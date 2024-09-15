using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;
using Todoit.UI.Entitites;

namespace Todoit.UI.Data
{
	public class Db : DbContext
	{
		public DbSet<TodoItem> TodoItem { get; set; }

		public string DbPath { get; }

		public Db(DbContextOptions<Db> options)
			: base(options)
		{
			Console.WriteLine(options.ToString());
		}

		//public Db()
		//{
		//	var folder = Environment.SpecialFolder.LocalApplicationData;
		//	var path = Environment.GetFolderPath(folder);
		//	DbPath = System.IO.Path.Join(path, "Todoit.db");
		//}

		// The following configures EF to create a Sqlite database file in the
		// special "local" folder for your platform.
		//protected override void OnConfiguring(DbContextOptionsBuilder options)
		//	=> options.UseSqlite($"Data Source={DbPath}");
	}
}
