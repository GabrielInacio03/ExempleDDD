using Gcomercial.Application.ViewModels;
using Gcomercial.Domain.Entities;
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
		void AddProduto(Produto produto);
	}
}
