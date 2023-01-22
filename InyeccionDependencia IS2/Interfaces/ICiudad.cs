using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencia_IS2.Interfaces
{
    public interface ICiudad
    {
        string Nombre { get; set; }
        List<IDepartamento> ListaDepartamentos { get; set; }
        void CrearDepartamentoPolicias();
        void CrearDepartamentoBomberos();
    }
}
