using Single_Responsability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;


namespace DIP
{


    public class BDSQLServer
    {

        List<Car> cars = new List<Car>();

        public void Guardar(Car auto)
        {
            cars.Add(auto);
        }


        
    }




    public class Persistencia
    {

        
        
        public void Persistir(Car auto) {
            
            BDSQLServer bd = new BDSQLServer();
            bd.Guardar(auto);
        }

        
    }










    


       





   }



