// Ali Abu-Alizz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    // This facade interface will be implemented by any class 
    // that wants to have a different order of the printable string
    public interface IFacade
    {
        string Order();
    }
}
