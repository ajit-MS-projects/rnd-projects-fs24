using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcutePsAndCopyToIso8859Exe
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            if (args.Length <= 0)
            {
                args = new[] {"source.txt", "output.txt"};
            }

            var encoding = Encoding.GetEncoding("iso-8859-1");

            using (StreamReader sr = new StreamReader(args[0], Encoding.Unicode))
            {
                using (StreamWriter sw = new StreamWriter(args[1], false, encoding))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        sw.WriteLine(line);
                    }
                }
            }
        }
    }
}
