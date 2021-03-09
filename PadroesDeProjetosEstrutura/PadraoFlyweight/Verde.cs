using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosEstrutura.PadraoFlyweight
{
    public class Verde : Tartaruga
    {
        public Verde()
        {
            this.condicao = " tartaruga dentro do casco, ";
            this.acao = "rodando no chão - ";
        }
        public override void Mostra(string qualcor)
        {
            this.cor = qualcor;
            Console.WriteLine(condicao + acao + cor.ToUpper());
        }
    }
}
