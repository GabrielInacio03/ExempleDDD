using Gcomercial.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gcomercial.Application.Interfaces
{
	public interface IProdutoService
	{
		ProdutoViewModel GetProdutos();
	}
}
