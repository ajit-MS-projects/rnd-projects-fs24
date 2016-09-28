using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace MvcDisplayTemplates.Models
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
		public Category Cats { get; set; }
		public IList<long> SelectedCats1 { get; set; }

    	public MultiSelectList CategoriesList
    	{
    		get
    		{
				var objItems = (from Category c in Enum.GetValues(typeof(Category)) select new SelectListItem { Value = ((int)c).ToString(), Text = c.ToString() }).ToList();

				return new MultiSelectList(objItems, "Value", "Text");
    		}
    		
    	}


		
    }
	
	public enum Category
	{
		Kitchen,
		Bad,
		Electronics,
		Sports,
		Outdoor,
		Computer	
	}
	
}