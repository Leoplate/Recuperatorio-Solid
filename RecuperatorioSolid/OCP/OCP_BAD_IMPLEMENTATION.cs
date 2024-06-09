using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Single_Responsability;
using RecuperatorioSolid.OCP;




namespace Open_Close
{


    





    public class MostrarAutoOCBAD
    {


        public void Mostrar(BaseAutoGood Base2)
        {
            
            
            foreach (Car auto in Base2.Devolver())
            {
                
                if (auto.VerMarca() == "Peugeot")
                {
                    
                    Console.WriteLine("Precio " + auto.VerMarca() + " " + auto.VerModelo() +" "+ auto.VerDescuento() + " % descuento " + auto.VerPrecio() * (100 - auto.VerDescuento())/100);
                }

                if (auto.VerMarca() == "Ford")
                {
                    Console.WriteLine("Precio " + auto.VerMarca() + " " + auto.VerModelo() +" " + auto.VerDescuento() + " % descuento " + auto.VerPrecio() *  (100-auto.VerDescuento())/100);

                }
            }
        }
    }
}