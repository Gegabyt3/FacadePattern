// Ali Abu-Alizz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    // This facade class implements the IFacade interface
    // and creates new objects of the 7 classes that are going
    // to be used for the printable string
    public class FacadeClass : IFacade
    {
        // Creating the 7 new objects
        A a = new A();
        B b = new B();
        C c = new C();
        D d = new D();
        E e = new E();
        F f = new F();
        G g = new G();


        // This class implements this IFacade method
        // and uses the created classes' string methods
        // in a specific order and returns the new special string.
        // Other facade classes can have different orders.
        public string Order()
        {
            string message = "";
            message = message + this.g.Show();
            message = message + this.a.Show();
            message = message + this.b.Show();
            message = message + this.f.Show();
            message = message + this.e.Show();
            message = message + this.g.Show();
            message = message + this.a.Show();
            message = message + this.c.Show();
            message = message + this.c.Show();
            message = message + this.a.Show();
            message = message + this.d.Show();
            message = message + this.d.Show();
            message = message + this.a.Show();
            return message;
        }
    }
}
