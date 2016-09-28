using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;
using E.Data.Model;
using NhibernatePersistenceHelper;

namespace Services
{

	public class EmpService
	{
		public IEmp GetEmp(int id)
		{
			using (var pc = PersistenceHelper.CreatePersistenceContext())
			{
				return Emp.Queryable.Where(x => x.Id == id).FirstOrDefault();
			}
		}

		public IEmp SaveEmp(IEmp emp)
		{
			using (var pc = PersistenceHelper.CreatePersistenceContext())
			{
				((Emp) emp).SaveOrUpdate();
			}

			return emp;
		}
	}
	public class MyEmpService:BaseEntityService
	{
		public IMyEmp GetMyEmp(int id)
		{
			return db.MyEmp.AsQueryable().FirstOrDefault(x => x.Id == id);
		}

	public IMyEmp SaveMyEmp(IMyEmp emp)
	{
		if (emp.Id == 0)
		{
			emp = db.MyEmp.Add((MyEmp) emp);
		}
		else
		{
			db.MyEmp.Attach((MyEmp) emp);
			db.Entry((MyEmp)emp).State=EntityState.Modified;
		}

		db.SaveChanges();
		return emp;
	}
    }

	public class BaseEntityService
	{
		public DataDbContext db = new DataDbContext();
	}
}
