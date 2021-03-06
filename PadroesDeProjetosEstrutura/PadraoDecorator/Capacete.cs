using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosEstrutura.PadraoDecorator
{
    public class Capacete : DecoratorArmadura
    {
		string _descricao = "Capacte, ";

		MoldeArmadura _moldeArmadura;
		public Capacete(MoldeArmadura moldeArmadura)
		{
			_moldeArmadura = moldeArmadura;
		}
		public override string Descricao
		{
			get
			{
				return _moldeArmadura.Descricao + _descricao;
			}
		}
	}
}
