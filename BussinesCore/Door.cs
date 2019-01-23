using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesCore
{
    public class Door
    {
        private int numDoor;
        
        public Door()
        {
            this.numDoor = 0;
        }
        public Door(int numDoor)
        {
            this.numDoor = numDoor;
            if (numDoor == 0)
            {
                System.Console.WriteLine("El vehiculo no tiene puertas");
            }
            if (numDoor == 2)
            {
                System.Console.WriteLine("El vehiculo tiene dos puertas");
            }
            if (numDoor == 4)
            {
                System.Console.WriteLine("El vehiculo tiene cuatro puertas");
            }
        }

        public int NumDoor { get => numDoor; }
    }
}
