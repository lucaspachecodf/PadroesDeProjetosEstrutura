using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosEstrutura.PadraoBridge
{
    public class Forma2 : IForma
    {
        public ICor ICor { get; set; }

        public string Descer()
        {
            return "U - " + ICor.Cor();
        }
    }
}
