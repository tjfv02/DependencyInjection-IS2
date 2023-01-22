using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencia_IS2.Interfaces
{
    public interface IDepartamento
    {
        int Id { get; set; }
        string Nombre { get; set;}
        List<IPersona> ListaPersonal { get; set; }
        void ContratarPersonal();
    }
}
