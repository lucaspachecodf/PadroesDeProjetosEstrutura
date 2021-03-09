using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosEstrutura.PadraoDecorator
{
    public class DecoratorArmadura : MoldeArmadura
    {
        string _descricao = "Decorador Abstrato da Armadura do Persoangem";

        public override string Descricao
        {
            get { return _descricao; }
        }
    }
}
