using RecuperatorioSolid.ISP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperatorioSolid.ISP
{
    public class AbejaII : Insecto, InsectoVolador
    {
        

        public void Comer()
        {
            Console.WriteLine("Soy una abeja y puedo comer");
        }

        

        public void Volar()
        {
            Console.WriteLine("Soy una abeja y puedo volar");
        }
    }
}


public class GrilloII : Insecto, InsectoSaltador
{
    

    public void Comer()
    {
        Console.WriteLine("Soy un grillo y puedo comer");
    }

    public void Saltar()
    {
        Console.WriteLine("Soy un grillo y puedo saltar");
    }

    
}
