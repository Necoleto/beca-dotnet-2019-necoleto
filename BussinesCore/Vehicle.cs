using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesCore
{
    public class Vehicle
    {
        private String tipo;
        private String color;
        private Wheel[] wheels;
        private Door[] doors;
        private Chassis chassis;

        public Vehicle()
        {
            this.tipo = "";
            this.color = "";
        }
        public Vehicle(String tipo,String color)
        {
            this.tipo = tipo;
            this.color = color;
            System.Console.WriteLine("El vehiculo es un " + tipo + ".");
            System.Console.WriteLine("El vehiculo es de color " + color + ".");
        }

        public string Tipo { get => tipo; set => tipo = value; }
        public string Color { get => color; set => color = value; }
    }
}
