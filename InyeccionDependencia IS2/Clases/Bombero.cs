using InyeccionDependencia_IS2.Interfaces;
using InyeccionDependencia_IS2.Interfaces.InterfacesDI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencia_IS2
{
    public class Bombero: IPersona, IExampleScopedService, IExampleSingletonService, IExampleTransientService
    {
        public string Name { get; }
        public int CUI { get; }
        public void Trabajar()
        {
            Console.WriteLine("Trabajando Felizmente :)");
        }
    }
}
