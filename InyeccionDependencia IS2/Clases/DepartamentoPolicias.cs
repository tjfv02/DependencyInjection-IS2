using InyeccionDependencia_IS2.Interfaces;
using InyeccionDependencia_IS2.Interfaces.InterfacesDI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencia_IS2.Clases
{
    public class DepartamentoPolicias: IDepartamento, IExampleScopedService, IExampleSingletonService, IExampleTransientService
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<IPersona> ListaPersonal { get; set; }


        public DepartamentoPolicias(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public void ContratarPersonal()
        {
            Console.WriteLine("Contratanto un Nuevo Policía...");
        }
    }
}
