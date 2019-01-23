using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesCore
{
    public class Wheel
    {
        private float diametro;

        public Wheel()
        {
   
            this.Diametro = 0;

        }
        public Wheel(float diametro)
        {
            this.diametro = diametro;
            System.Console.WriteLine("El diametro de las ruedas es de " + diametro + " cm");
        }

        public float Diametro { get => diametro; set => diametro = value; }
    }
}
