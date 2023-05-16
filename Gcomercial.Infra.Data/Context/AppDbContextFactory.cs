using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gcomercial.Infra.Data.Context
{
	public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
	{
		public AppDbContext CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
			optionsBuilder.UseSqlServer("Data Source=BAZINGA\\SQLEXPRESS;Initial Catalog=DBGcomercial;Integrated Security=True"); //BAZINGA\\SQLEXPRESS
			//BAZINGA\\Inacio
            //private const string CONNECTIONSTRING = "Password=123@cetec;Persist Security Info=True;User ID=usr_heitor;Initial Catalog=TreinamentoH;Data Source=bd.ceteclins.com.br";

            return new AppDbContext(optionsBuilder.Options);
		}
	}
}
