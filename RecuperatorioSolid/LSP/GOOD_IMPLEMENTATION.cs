using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RecuperatorioSolid.OCP;
using Single_Responsability;

namespace LSP
{
    public class AnimalGood
    {
        private string tipo;

        public void Comer()
        {
            Console.WriteLine("Soy un " + this.tipo + "y estoy comiendo");
        }

        public void Dormir()
        {
            Console.WriteLine("Soy un " + this.tipo + "y estoy durmiendo");
        }

    } 


    public interface AnimalSaltador
    {
        public void Saltar();
    }
        
        
    




      


       

       


       





   }



