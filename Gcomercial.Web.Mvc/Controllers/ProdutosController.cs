using Gcomercial.Application.Interfaces;
using Gcomercial.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Gcomercial.Web.Mvc.Controllers
{
	public class ProdutosController : Controller
	{
		private IProdutoService _produtoService;

		public ProdutosController(IProdutoService produtoService)
		{
			_produtoService = produtoService;
		}
		public IActionResult Index()
		{
			ProdutoViewModel model = _produtoService.GetProdutos();

			foreach (var item in model.Produtos)
			{
                Console.WriteLine("item -> "+ item.Nome);
            }
			return View(model);
		}
	}
}
