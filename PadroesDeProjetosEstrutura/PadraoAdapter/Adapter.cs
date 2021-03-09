using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosEstrutura.PadraoAdapter
{
    public class Adapter : IAcao
    {
        Aviao aviao;
        public Adapter(Aviao novo_aviao)
        {
            this.aviao = novo_aviao;
        }
        public void Andar(string jogador)
        {
            this.aviao.Voar("Rodrigo");
        }

        public void Atirar()
        {
            this.aviao.SoltarMissil();
        }
    }
}
