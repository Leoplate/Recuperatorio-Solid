using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RecuperatorioSolid.OCP;
using Single_Responsability;

namespace Single_Responsability
{
    public class Car 
    {
        private string modelo;
        private string marca;
        private int precio;
        private int descuento;

        public Car(string modelo, string marca,int precio, int descuento)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.precio = precio;
            this.descuento = descuento;
        }

        public string VerModelo()
        {
            return this.modelo;
        }

        public string VerMarca()
        {
            return this.marca;
        }

        public int VerPrecio()
        {
            return this.precio;
        }

        public int VerDescuento()
        {
            return this.descuento;
        }

        
    }


    


       

       


       





   }



