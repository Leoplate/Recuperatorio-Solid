using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Single_Responsability
{




    public class BaseAutoBad
    {

        private List<Car> Base;

        public BaseAutoBad(List<Car> BaseAuto)
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

        public void Mostrar()
        {

            foreach (Car auto in this.Base)
            {
                Console.WriteLine(auto.VerMarca() + " " +auto.VerModelo() );
              
            }

        }

    }










    


       





   }



