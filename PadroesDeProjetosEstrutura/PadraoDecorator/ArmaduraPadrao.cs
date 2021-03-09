using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosEstrutura.PadraoDecorator
{
    public class ArmaduraPadrao : MoldeArmadura
    {
        string _descricao = "Proteção Simples, ";
        public override string Descricao
        {
            get
            {
                return _descricao;
            }
        }
    }
}
