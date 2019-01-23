using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesCore
{
    public class Chassis
    {
        private String material;
        private float peso;
        private float ancho;
        private float largo;
        private float volumen;
        private float superficie;

        public Chassis()
        {
            this.Material = "";
            this.Peso = 0;
            this.Ancho = 0;
            this.Largo = 0;
            this.Alto = 0;
            this.volumen = 0;
            this.superficie = 0;

        }

        public Chassis(String material)
        {
            System.Console.WriteLine("El material del chasis es: " + material + ". No se saben las dimensiones del chasis");
         
        }
        public Chassis(String material,float peso,float ancho,float largo,float alto)
        {
            
            float volumen = getVolumen(largo, alto, ancho);
            float supeficie = getSuperficie(largo, ancho);
            System.Console.WriteLine("El material del chasis es: " + material);
            System.Console.WriteLine("El peso del chasis es: " + peso + "m");
            System.Console.WriteLine("El largo del chasis es: " + largo + "m");
            System.Console.WriteLine("El ancho del chasis es: " + ancho + "m");
            System.Console.WriteLine("La superficie del chasis es: " + superficie + "m^2");
            System.Console.WriteLine("El volumen del chasis es: " + volumen + "m^3");
      

        }

        private float getVolumen(float largo,float alto,float ancho)
        {
            //Metodo que devuelve el volumen del chassis.
            float volumen;
            volumen = largo * ancho * alto;
            return volumen;
        }
        private float getSuperficie(float largo, float ancho)
        {
            //Metodo que devuelve la superficie del chassis.
            float superficie;
            superficie = largo * ancho ;
            return superficie;
        }

        public string Material { get => material; set => material = value; }
        public float Peso { get => peso; set => peso = value; }
        public float Ancho { get => ancho; set => ancho = value; }
        public float Largo { get => largo; set => largo = value; }
        public float Alto { get; set; }






    }
}
