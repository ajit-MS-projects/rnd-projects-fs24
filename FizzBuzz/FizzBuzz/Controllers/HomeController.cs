using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace FizzBuzz.Controllers
{
    public class HomeController : Controller
    {
        //"Write a program that prints the numbers from 1 to 100. 
        //But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”. 
        //For numbers which are multiples of both three and five print “FizzBuzz”."
        public MvcHtmlString Index()
        {
            var retVal = new StringBuilder();
            for (int i = 1; i <= 100; i++)
            {
                var value = i%3 == 0 ? "Fizz" : (i%5 == 0 ? "Buzz" : (i%3 == 0 && i%5 == 0 ? "FizzBuzz" : i.ToString()));
                retVal.Append(AppendValue(value));
            }
            return new MvcHtmlString(retVal.ToString());
        }

        private static string AppendValue<T>(T strValue)
        {
            return string.Format("{0}</br>", strValue);
        }
    }
}
