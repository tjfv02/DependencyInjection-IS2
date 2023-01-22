using InyeccionDependencia_IS2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencia_IS2.Clases
{
    public class DepartamentoBomberos: IDepartamento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public DepartamentoBomberos(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public void ContratarPersonal()
        {
            Console.WriteLine("Contratanto un Nuevo Policía...");
        }
        public void AsignarTarea()
        {
            Console.WriteLine("Asignando Tarea...");
        }

    }
}
