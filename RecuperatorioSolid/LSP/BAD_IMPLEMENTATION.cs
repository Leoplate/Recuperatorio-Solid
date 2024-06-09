using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RecuperatorioSolid.OCP;
using Single_Responsability;

namespace LSP
{
    public class Animal 
    {

        private string tipo;
        
        

        public void Comer()
        {
            Console.WriteLine("Soy un "+this.tipo + "y estoy comiendo");
        }

        public virtual void Saltar()
        {
            Console.WriteLine("Soy un " + this.tipo + "y estoy saltando");
        }

        public void Dormir()
        {
            Console.WriteLine("Soy un " + this.tipo + "y estoy durmiendo");
        }

        
        
    }




      


       

       


       





   }



