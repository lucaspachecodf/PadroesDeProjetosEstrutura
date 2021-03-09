using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosEstrutura.PadraoAdapter
{
    public interface IAcao
    {
        void Andar(string personagem);
        void Atirar();
    }
}
