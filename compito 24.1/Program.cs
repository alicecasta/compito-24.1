using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compito_24._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            quadro l = new quadro();
            Console.WriteLine("inserire il lato");
            l.Lato = float.Parse(Console.ReadLine());
            Console.WriteLine( "l'area è {0}", (l.Lato)*(l.Lato));
            Console.ReadLine();
        }
    
    }
}
