using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RecuperatorioSolid.OCP;
using Single_Responsability;

namespace LSP
{
    


      public class Perro : Animal
    {
        private string tipo;

        public Perro(string tipo)
        {
            this.tipo = tipo;
        }

        override
        public void Saltar()
        {
            Console.WriteLine("Soy un " + this.tipo + " y estoy saltando");
        }

        



    }



    public class PerroGood : AnimalGood, AnimalSaltador
    {
        private string tipo;

        public PerroGood(string tipo)
        {
            this.tipo = tipo;
        }

        
        public void Saltar()
        {
            Console.WriteLine("Soy un " + this.tipo + " y estoy saltando");
        }





    }









}



