using AutoMapper;
using Gcomercial.Application.Interfaces;
using Gcomercial.Application.ViewModels;
using Gcomercial.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
			var model = _produtoService.GetProdutos();
			return View(model);
		}
		public IActionResult Create(ProdutoViewModel model)
		{
            return View();
        }
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(Produto produto)
		{
			try
			{
				if(ModelState.IsValid) 
				{
					
					_produtoService.AddProduto(produto);
                    //return View("Create");
                }
            }
			catch (DbUpdateException ex)
			{
                Console.WriteLine("ProdutosController.Erro.Message"+ ex.Message);
				ModelState.AddModelError("", "Não foi possível inserir os dados do produto.");
            }
            return View(produto);
        }
	}
}
