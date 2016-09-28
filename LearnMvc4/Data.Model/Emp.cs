using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NhibernatePersistenceHelper;

namespace Data.Model
{
	public interface IEmp
	{
		string Name { get; set; }
	}
	 
	public class Emp : BaseObject<Emp>, IEmp
	{
	    public virtual string Name{ get; set; }
    }
}
