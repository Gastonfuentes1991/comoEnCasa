using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Interfaces
{
    public interface IDB
    {
        string Error { get; }
        bool Comando(string command);
        object Consulta(string consulta);
    }
}
