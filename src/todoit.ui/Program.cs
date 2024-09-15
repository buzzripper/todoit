using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;
using System.Net.Http;
using System.Windows.Forms;
using Todoit.UI.Config;
using Todoit.UI.Data;

namespace Todoit.UI
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			var configuration = BuildConfiguration();
			var logger = CreateLogger(configuration);
			var appConfig = GetAppConfig(configuration);
			var host = CreateHostBuilder(configuration, appConfig, logger).Build();

			ApplicationConfiguration.Initialize();

			Application.Run(host.Services.GetRequiredService<Form1>());
			//Application.Run(host.Services.GetRequiredService<Form2>());
		}

		private static IConfiguration BuildConfiguration()
		{
			// Configuration
			return new ConfigurationBuilder()
				.AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
				.Build();
		}

		private static AppConfig GetAppConfig(IConfiguration configuration)
		{
			var appConfig = configuration.GetSection("AppConfig").Get<AppConfig>();
			if (appConfig == null)
				throw new ApplicationException("Unable to retrieve ApplicationConfig section from appsettings.json file.");

			return appConfig;
		}

		private static ILogger CreateLogger(IConfiguration configuration)
		{
			var loggerConfig = new LoggerConfiguration()
				.ReadFrom.Configuration(configuration)
				.Enrich.FromLogContext();

			return loggerConfig.CreateLogger();
		}

		private static IHostBuilder CreateHostBuilder(IConfiguration configuration, AppConfig appConfig, ILogger logger)
		{
			return Host.CreateDefaultBuilder()
				.ConfigureServices(services =>
				{
					services.AddSingleton<ILogger>(provider =>
					{
						return logger;
					});

					services.AddSingleton(serviceProvider =>
					{
						return new Form1(serviceProvider.GetRequiredService<Db>(), logger);
					});

					//services.AddSingleton(serviceProvider =>
					//{
					//	return new Form2(appConfig, serviceProvider.GetRequiredService<IHttpClientFactory>());
					//});

					services.AddSingleton(appConfig);
					services.AddHttpClient();

					services.AddDbContext<Db>(options => options.UseSqlite($"Data Source={appConfig.DbFilepath}"));
				});
		}
	}
}
