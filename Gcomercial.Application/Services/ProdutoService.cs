using Gcomercial.Application.Interfaces;
using Gcomercial.Application.ViewModels;
using Gcomercial.Domain.Entities;
using Gcomercial.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gcomercial.Application.Services
{
	public class ProdutoService : IProdutoService
	{
		public IProdutoRepository _produtoRepository;
		public ProdutoService(IProdutoRepository produtoRepository)
		{
			_produtoRepository = produtoRepository;
		}
		public ProdutoViewModel GetProdutos()
		{
			return new ProdutoViewModel() 
			{
				Produtos = _produtoRepository.GetProdutos()
			};
		}

        public void AddProduto(Produto produto)
        {
			_produtoRepository.AddProduto(produto);
        }
    }
}
