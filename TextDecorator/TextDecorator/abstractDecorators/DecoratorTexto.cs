using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDecorator.abstractDecorators
{
	public abstract class DecoratorTexto : ITexto
	{
		protected ITexto texto;

		public DecoratorTexto(ITexto texto)
		{
			this.texto = texto;
		}

		public virtual string Render()
		{
			return texto.Render();
		}

		public virtual string Text()
		{
			return texto.Text();
		}
	}

}
