using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees
{
    public class BinaryTree1
    {
		private SortedSet<int> binTree = new SortedSet<int>();
		List<int>  list = new List<int>();
		public delegate bool Convert(int tt);

	    private event Convert ccc ;

	    public BinaryTree1()
	    {
			Convert cc = IsEven;
			Func<int, bool> ff = IsEven;
		    //list.BinarySearch();
		    int i = list.Find(IsEven);
			List<int> ii = list.FindAll(IsEven);
			i = list.Find((int u) => { return u%2 == 0; });
		    binTree.RemoveWhere(ff.Invoke);
			binTree.RemoveWhere(cc.Invoke);
			list.Select((int p) => { return p*2; });
		    ccc += IsEven;
		    ccc(8);


	    }


		public void Insert(int no)
		{
			binTree.Add(no);
		}

		public void Print()
		{
			foreach (int i in binTree)
			{
				Debug.WriteLine("\t{0}", i);
			}
		}

		private static bool IsEven(int s)
		{
			return s%2 == 0;
		}
    }

	enum MyEnum
	{
		val1,
		val2,
		val3
	}

	class Test
	{
		delegate void TestDelegate(string s);
		static void M(string s)
		{
			Console.WriteLine(s);
		}

		static void Main(string[] args)
		{
			// Original delegate syntax required  
			// initialization with a named method.
			TestDelegate testDelA = new TestDelegate(M);
			

			// C# 2.0: A delegate can be initialized with 
			// inline code, called an "anonymous method." This
			// method takes a string as an input parameter.
			TestDelegate testDelB = delegate(string s) { Console.WriteLine(s); };

			// C# 3.0. A delegate can be initialized with 
			// a lambda expression. The lambda also takes a string 
			// as an input parameter (x). The type of x is inferred by the compiler.
			TestDelegate testDelC = (x) => { Console.WriteLine(x); };

			testDelC = (x) => { x=x+"dd"; };

			Action<string> f = M;
			f("dfdd");

			f = (String s) =>  s=s+"rr"; 

			Func<string,string> ff = (s) => { return s+"rr"; };

			// Invoke the delegates.
			testDelA("Hello. My name is M and I write lines.");
			testDelB("That's nothing. I'm anonymous and ");
			testDelC("I'm a famous author.");

			// Keep console window open in debug mode.
			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}
	}

    class Program
    {
		delegate int del(int i);
		static void Main11(string[] args)
        {
            Expression<del> myET = x => x * x;
        }
		
		static void Main111(string[] args)
		{
			del myDelegate = x => x * x;
			int j = myDelegate(5); //j = 25
		}

    }


}
