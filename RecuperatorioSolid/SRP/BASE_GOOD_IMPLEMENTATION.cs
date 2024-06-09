using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Single_Responsability;

namespace Single_Responsability
{
    


    public class MostrarAuto
    {
      
        
        public void Mostrar(BaseAutoGood Base2)
        {
            foreach (Car auto in Base2.Devolver())
            {
                Console.WriteLine(auto.VerMarca() + " " +auto.VerModelo());
                
                
            }
        }
    }


       


       public class BaseAutoGood
       {
         private List<Car> Base;

            public BaseAutoGood(List<Car> BaseAuto)
            {
                this.Base = BaseAuto;
            }

            public void Guardar(Car auto)
            {
                this.Base.Add(auto);
            }

            public List<Car> Devolver()
            {
                return this.Base;
            }

       }





   }



