using RecuperatorioSolid.ISP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperatorioSolid.ISP
{
    public class Abeja : InsectoBAD
    {
        

        public void Comer()
        {
            Console.WriteLine("Soy una abeja y puedo comer");
        }

        public void Saltar()
        {
            throw new NotImplementedException("Soy una abeja y no puedo saltar");
        }

        public void Volar()
        {
            Console.WriteLine("Soy una abeja y puedo volar");
        }
    }
}


public class Grillo : InsectoBAD
{
    

    public void Comer()
    {
        Console.WriteLine("Soy un grillo y puedo comer");
    }

    public void Saltar()
    {
        Console.WriteLine("Soy un grillo y puedo saltar");
    }

    public void Volar()
    {
        throw new NotImplementedException("Soy un grillo y no puedo volar");
    }
}
