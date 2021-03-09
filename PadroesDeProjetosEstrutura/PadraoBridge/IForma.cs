using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosEstrutura.PadraoBridge
{
    public interface IForma
    {
        string Descer();
        ICor ICor { get; set; }
    }
}
