using Single_Responsability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;


namespace DIP
{

    public interface BDGenerica
    {
        public void Guardar(Car car);
    }
    
    
    
    public class BDSQLServerGood : BDGenerica
    {

        List<Car> cars = new List<Car>();

        public void Guardar(Car auto)
        {
            cars.Add(auto);
        }


        
    }


    public class BDMySQLServerGood : BDGenerica
    {

        List<Car> cars = new List<Car>();

        public void Guardar(Car auto)
        {
            cars.Add(auto);
        }



    }



    public class PersistenciaGood
    {

        BDGenerica BD;
        
        
        
        public PersistenciaGood(BDGenerica BD)
        {
            this.BD = BD;
        }
        
        public void Persistir(Car auto) {
            
            
            BD.Guardar(auto);
        }

        
    }










    


       





   }



