using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Web;
using NHibernate;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Mapping.ByCode;
using NHibernate.Tool.hbm2ddl;
using NhibernatePersistenceHelper.CollectionTypeFactory;
using Configuration = NHibernate.Cfg.Configuration;

namespace NhibernatePersistenceHelper
{
	public static class PersistenceHelper
	{
		public static ISessionFactory SessionFactory { get; private set; }
		public static Configuration NhibernateConfiguration { get; private set; }
		[ThreadStatic] 
		private static Stack<PersistenceContext> persistenceContextStack;

		private static string persistenceContextStackKey = "PersistenceContextStack";

		static PersistenceHelper()
		{
			Initialize();
		}

		public static void Initialize()
		{
			NhibernateConfiguration = new Configuration();
			NhibernateConfiguration.Properties[NHibernate.Cfg.Environment.CollectionTypeFactoryClass] = typeof(Net4CollectionTypeFactory).AssemblyQualifiedName;
			NhibernateConfiguration.Configure();

			// Mapping by Mapping XML-Files
			foreach (var xmlMappingAssembly in GetXmlMappingAssemblies())
			{
				NhibernateConfiguration.AddAssembly(xmlMappingAssembly);
			}
			
			// Mapping by Code
			var modelMapper = new ModelMapper();
			
			foreach (var modelAssembly in GetModelAssemblies())
			{
				modelMapper.AddMappings(modelAssembly.GetExportedTypes());
				NhibernateConfiguration.AddAssembly(modelAssembly);
			}
			if (GetModelAssemblies().Any())
			{
				HbmMapping domainMapping = modelMapper.CompileMappingForAllExplicitlyAddedEntities();
				NhibernateConfiguration.AddMapping(domainMapping);
			}
			
			SessionFactory = NhibernateConfiguration.BuildSessionFactory();
		}

		public static void CreateDatabaseSchema()
		{
			new SchemaExport(NhibernateConfiguration).Execute(false, true, false);
		}

		//public static void CreateDatabaseSchemaScript()
		//{
		//	NhibernateConfiguration.GenerateSchemaCreationScript( NhibernateConfiguration.GetProperty("dialect"))
		//}

		private static IEnumerable<Assembly> GetModelAssemblies()
		{
			NameValueCollection valueCollection = (NameValueCollection)ConfigurationManager.GetSection("DatabaseModelAssemblies");

			if (valueCollection != null)
			{
				var assembliesKeys = valueCollection.AllKeys;

				foreach (var assembliesKey in assembliesKeys)
				{
					yield return Assembly.Load(valueCollection[assembliesKey]);
				}
			}
		}
		
		private static IEnumerable<Assembly> GetXmlMappingAssemblies()
		{
			NameValueCollection valueCollection = (NameValueCollection)ConfigurationManager.GetSection("DatabaseXmlMappingAssemblies");
			if (valueCollection != null)
			{
				var assembliesKeys = valueCollection.AllKeys;

				foreach (var assembliesKey in assembliesKeys)
				{
					yield return Assembly.Load(valueCollection[assembliesKey]);
				}
			}
		}

		public static PersistenceContext CreatePersistenceContext()
		{
			return CreatePersistenceContext(false);
		}

		/// <summary>
		/// Creates the persistence context.
		/// </summary>
		/// <param name="newPersistenceContext">if set to <c>true</c> [new persistence context].</param>
		/// <returns></returns>
		public static PersistenceContext CreatePersistenceContext(bool newPersistenceContext)
		{
			if (newPersistenceContext || !PersistenceContextStack.Any())
			{
				PersistenceContextStack.Push(new PersistenceContext(newPersistenceContext, false));
			}
			PersistenceContextStack.Peek().Register();
			return PersistenceContextStack.Peek();
		}

		public static PersistenceContext CreatePersistenceContextWithTransaction()
		{
			return CreatePersistenceContextWithTransaction(false);
		}

		public static PersistenceContext CreatePersistenceContextWithTransaction(bool newPersistenceContext)
		{
			if (newPersistenceContext || !PersistenceContextStack.Any())
			{
				PersistenceContextStack.Push(new PersistenceContext(newPersistenceContext, true));
			}
			PersistenceContextStack.Peek().Register();
			return PersistenceContextStack.Peek();
		}

		private static Stack<PersistenceContext> PersistenceContextStack
		{
			get
			{
				var httpContext = HttpContext.Current;

				if (httpContext != null)
				{
					if (!httpContext.Items.Contains(persistenceContextStackKey))
					{
						httpContext.Items.Add(persistenceContextStackKey, new Stack<PersistenceContext>());
					}
					return httpContext.Items[persistenceContextStackKey] as Stack<PersistenceContext>;

				}
				if (persistenceContextStack == null)
				{
					persistenceContextStack = new Stack<PersistenceContext>();
				}
				return persistenceContextStack;
			}
		}
		
		internal static void RemoveFromStack(PersistenceContext persistenceContext)
		{
			if (persistenceContext == PersistenceContextStack.Peek())
			{
				PersistenceContextStack.Pop();
			}
			
		}

	}
}
