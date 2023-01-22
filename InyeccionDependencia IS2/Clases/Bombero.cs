using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencia_IS2
{
    public class Bombero
    {
        Edificio edificio;
        public Bombero() 
        {
            this.edificio = new Edificio();
        }
        public void ApagarFuego()
        {
            this.edificio.Incendiar();
            Console.WriteLine("Apagando Fuego...");
        }
    }
}
