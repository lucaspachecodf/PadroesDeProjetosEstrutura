using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosEstrutura.PadraoDecorator
{
    public class MoldeArmadura
    {
        private string _descricao = "Armadura	do	Personagem	Abstrata";

        public virtual string Descricao
        {
            get { return _descricao; }
        }
    }
}
