using InyeccionDependencia_IS2.Interfaces;
using InyeccionDependencia_IS2.Interfaces.InterfacesDI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencia_IS2.Clases
{
    public class CiudadGuatemala: ICiudad, IExampleScopedService, IExampleSingletonService, IExampleTransientService
    {
        public string Nombre { get; set; }
        public string[] ListaDepartamentos { get; set; }


        public CiudadGuatemala()
        {
            Nombre = "Ciudad de Guatemala";
        }
        public void CrearDepartamentoPolicias()
        {
            Console.WriteLine("Creando departamento de Policias...");
        }
        public void CrearDepartamentoBomberos()
        {
            Console.WriteLine("Creando departamento de Bomberos...");
        }
    }
}
