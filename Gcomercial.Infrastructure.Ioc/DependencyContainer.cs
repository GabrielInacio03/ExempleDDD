using Gcomercial.Application.Interfaces;
using Gcomercial.Application.Services;
using Gcomercial.Domain.Interfaces;
using Gcomercial.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gcomercial.Infrastructure.Ioc
{
	public class DependencyContainer
	{
		public static void RegisterServices(IServiceCollection services)
		{
			//Application
			services.AddScoped<IProdutoService, ProdutoService>();

			//Domain.Interface e Infra.Data.Repositories
			services.AddScoped<IProdutoRepository, ProdutoRepository>();
		}
	}
}
