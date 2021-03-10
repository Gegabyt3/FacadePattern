// Ali Abu-Alizz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    // This class uses the facade class and uses its order
    // method that returns the special formatted string. 
    public class FacadeUser
    {

        IFacade user = new FacadeClass(); // This can be any different facade class
                                          // and it will still use that specific
                                          // string order the facade class has.
                                          // (Close to strategy pattern)

        public string Order()   // FacadeUser gets the ordered string from the
                                // created facade class
        {
            return this.user.Order();
        }


    }
}
