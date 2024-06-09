using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Single_Responsability;
using RecuperatorioSolid.OCP;




namespace Open_Close
{

    


    public class Peugeot : Auto
    {
        private string modelo;
        private string marca;
        private int precio;
        private int descuento;

        public Peugeot(string modelo, string marca, int precio, int descuento)
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


    public class Ford : Auto
    {
        private string modelo;
        private string marca;
        private int precio;
        private int descuento;

        public Ford(string modelo, string marca, int precio, int descuento)
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



    public class MostrarAutoOCGOOD
    {


        public void Mostrar(List<Auto> Base2)
        {
            
            foreach (Auto auto in Base2)
            {
                                              
                    Console.WriteLine("Precio " + auto.VerMarca() + " " + auto.VerModelo() + " " + auto.VerDescuento() +" % descuento. Precio final " + (auto.VerPrecio() * (100-auto.VerDescuento())/100));
                
            }
        }
    }
}