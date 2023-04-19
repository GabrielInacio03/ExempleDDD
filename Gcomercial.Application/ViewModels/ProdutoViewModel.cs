using Gcomercial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gcomercial.Application.ViewModels
{
	public class ProdutoViewModel
	{
		public IEnumerable<Produto> Produtos { get; set; }
	}
}
