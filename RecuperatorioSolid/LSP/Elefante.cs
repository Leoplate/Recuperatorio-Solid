using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RecuperatorioSolid.OCP;
using Single_Responsability;

namespace LSP
{
    


      public class Elefante : Animal
      {

        private string tipo;

        public Elefante(string tipo)
        {
            this.tipo = tipo;   
        }

        override
        public void Saltar()
        {
            throw new NotImplementedException("Soy un" + this.tipo +" y no puedo saltar");
        }

        



    }



    public class ElefanteGood : AnimalGood
    {

        private string tipo;

        public ElefanteGood(string tipo)
        {
            this.tipo = tipo;
        }

        
     

    }











}



