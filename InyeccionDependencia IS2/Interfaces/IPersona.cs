﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencia_IS2.Interfaces
{
    public interface IPersona
    {
        string Name { get; }
        int Age { get; }
        int CUI { get; }

    }
}