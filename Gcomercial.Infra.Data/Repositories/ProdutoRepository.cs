using Gcomercial.Domain.Entities;
using Gcomercial.Domain.Interfaces;
using Gcomercial.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gcomercial.Infra.Data.Repositories
{
	public class ProdutoRepository : IProdutoRepository
	{
		public AppDbContext _context;
		public ProdutoRepository(AppDbContext context) 
		{
			_context = context;
		}
		public IEnumerable<Produto> GetProdutos()
		{
			return _context.Produtos;
		}
        public void AddProduto(Produto produto)
        {
            _context.Set<Produto>().Add(produto);
			_context.SaveChanges();
        }
    }
}
