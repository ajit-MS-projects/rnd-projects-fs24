using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	internal class Program
	{
		private static Random rnd = new Random();

		public static IEnumerable<int> GetRandomNumbers()
		{
			while (true)
			{
				int num = rnd.Next();
				if (num % 100 == 0)
					break;
				yield return num;
			}
		}
		public static IEnumerable<int> GetRandomNumbers2()
		{
			while (true)
			{
				yield return rnd.Next();
			}
		}

		private static void Main(string[] args)
		{
			foreach (var s in GetRandomNumbers())
			{//conditioncontrolled by client
				if(s%100==0)
					break;
				Console.WriteLine(s);
			}
			Console.ReadLine();
			foreach (var s in GetRandomNumbers())
			{//conditioncontrolled by client in iterator method
				Console.WriteLine(s);
			}
			Console.ReadLine();
		}


		private static void Main1(string[] args)
		{
			Func<int, bool> myDelegate = i => i > 5;
			Expression<Func<int, bool>> exp = i => i > 5;
			var randy = new Random();
			int[] n = new int[] {1, 2, 3, 4, 5, 6, 74, 58, 44, 9, 3};
			IEnumerable<int> xx = n.Where(x => x > 8);

			n.Where(x => x > 8);
			var cx = from nn in n where nn < 5 select n;

		}
	}

	public class MyQuery : IQueryable
	{
		public IEnumerator GetEnumerator()
		{
			throw new NotImplementedException();
		}

		public Expression Expression { get; private set; }
		public Type ElementType { get; private set; }
		public IQueryProvider Provider { get; private set; }
	}
}
