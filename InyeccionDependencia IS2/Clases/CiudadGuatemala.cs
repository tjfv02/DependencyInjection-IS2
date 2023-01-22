using InyeccionDependencia_IS2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencia_IS2.Clases
{
    public class CiudadGuatemala: ICiudad
    {
        public string Nombre { get; set; }

        public CiudadGuatemala()
        {
            Nombre = "Ciudad de Guatemala";
        }

        public void CobrarImpuestos()
        {
            Console.WriteLine("Cobrando Impuestos"); ;
        }

        public void CrearDepartamento()
        {
            Console.WriteLine("Creando departamento de: ");
        }
    }
}
