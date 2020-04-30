using AutoMapper;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Web;
using System;
using UserService.Models;

namespace UserService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Buyer, BuyerDTO>();
            });
            Buyer buy = new Buyer();
            IMapper mapper = config.CreateMapper();
            mapper.Map<Buyer, BuyerDTO>(buy);
            try
            {
                logger.Debug("init main function");
                CreateWebHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error in init");
                throw;
            }
            finally
            {
                NLog.LogManager.Shutdown();
            }

        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                    logging.SetMinimumLevel(LogLevel.Information);
                })
                .UseNLog();
    }


   //public static IHostBuilder CreateHostBuilder(string[] args) =>
   //         Host.CreateDefaultBuilder(args)
   //             .ConfigureWebHostDefaults(webBuilder =>
   //             {
   //                 webBuilder.UseStartup<Startup>();
   //             });
   // }
}
