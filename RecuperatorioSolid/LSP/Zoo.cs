using LSP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperatorioSolid.LSP
{
    public class Zoo
    {

       List<Animal> Jaula = new List<Animal>();

        public void Guardar(Animal a)
        {
            Jaula.Add(a);
        }


        public void Interactuar () { 
        
           foreach(Animal a in Jaula)
            {
                a.Comer();
                a.Dormir();
                a.Saltar();

            }
            
               
        }




    }
}
