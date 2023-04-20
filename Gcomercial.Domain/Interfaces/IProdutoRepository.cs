using Gcomercial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gcomercial.Domain.Interfaces
{
	public interface IProdutoRepository
	{
		IEnumerable<Produto> GetProdutos();
	}
}
