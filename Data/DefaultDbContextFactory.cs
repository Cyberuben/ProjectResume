using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ProjectResume.Data
{
	public class DefaultDbContextFactory : IDesignTimeDbContextFactory<DefaultDbContext>
	{
		public DefaultDbContext CreateDbContext(string[] args)
		{
			var config = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();

			DotNetEnv.Env.Load();

			return new DefaultDbContext(new DbContextOptionsBuilder<DefaultDbContext>().Options, config);
		}
	}
}