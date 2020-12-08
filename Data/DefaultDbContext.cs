using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjectResume.Data.Entities;

namespace ProjectResume.Data
{
	public class DefaultDbContext : DbContext
	{
		private readonly IConfiguration _config;

		public DefaultDbContext(DbContextOptions options, IConfiguration config) : base(options)
		{
			_config = config;
		}

		public DbSet<Project> Projects { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(DotNetEnv.Env.GetString("CONNECTION_STRING"));
		}
	}
}