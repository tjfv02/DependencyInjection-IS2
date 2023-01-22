using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencia_IS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bombero bombero = new Bombero();
            bombero.ApagarFuego();
            Console.ReadLine();
        }
    }
}
