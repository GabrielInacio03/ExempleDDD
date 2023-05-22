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
			return View(model);
		}
		public IActionResult Create(ProdutoViewModel model)
		{
            //ProdutoViewModel model = _produtoService.GetProdutos();
            return View();
        }
	}
}
