using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpInDepth
{
	class Program
	{
		static void Main(string[] args)
		{
			var e = new Emp<Program, double>();
			e.Id = 11;
			Console.WriteLine(e.Id);
			Console.Read();
		}
	}
	public class Emp<T,TU> where TU:IComparable where T:class , new() 
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
}
