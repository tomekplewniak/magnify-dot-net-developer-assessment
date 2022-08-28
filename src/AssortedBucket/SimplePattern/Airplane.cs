using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePattern
{
    public class Airplane : IVehicle
    {
        public void Deliver()
        {
            Console.WriteLine("So you want to fly? Airplane is our only choice.");
        }
    }
}
