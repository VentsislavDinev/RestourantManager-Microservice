using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Authentication;
using System.Threading.Tasks;
using App.Metrics.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using App.Metrics.AspNetCore.Health;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using App.Metrics.Health;
using System.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Debug;
using Serilog;
using Serilog.Events;

namespace Website.Product.Host.Startup
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
         .MinimumLevel.Debug()
         .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
         .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
         .Enrich.FromLogContext()
         .WriteTo.Console()
         .CreateLogger();

            try
            {
                Log.Information("Starting web host");

                var builder = CustomBuilder().Build();
                var logger = builder.Services.GetRequiredService<ILogger<Program>>();
                logger.LogInformation("Seeded the database.");

                builder.Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        private static IWebHostBuilder CustomBuilder()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())

                .Build();


            return new WebHostBuilder()

             // .UseUrls("http://wilsoft.site")
             //.UseSetting("http_port", "80")
             .UseUrls("http://*:12416")
                //.UseSetting("http_port", "80")
                .UseKestrel()
                .UseIISIntegration()
                 .UseSerilog()
                   .ConfigureLogging(logging =>
                   {
                       logging.ClearProviders();
                       logging.AddConsole();
                       logging.SetMinimumLevel(LogLevel.Warning);
                       logging.AddEventLog();

                       logging.AddEventSourceLogger();
                       logging.AddFilter("System", LogLevel.Debug)
                        .AddFilter<DebugLoggerProvider>("Microsoft", LogLevel.Trace);
                   })
                .UseConfiguration(config)
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()

                .UseHealthEndpoints(options =>
                {

                })
                .ConfigureHealth(
                builder =>
                {
                    builder.OutputHealth.AsPlainText();
                })
                .ConfigureHealthWithDefaults(
                        builder =>
                        {


                            builder.HealthChecks.AddCheck("DatabaseConnected", () => new ValueTask<HealthCheckResult>(HealthCheckResult.Healthy("Database Connection OK")));
                            builder.HealthChecks.AddPingCheck("google ping", "google.com", TimeSpan.FromSeconds(10));
                        })
                .ConfigureAppHealthHostingConfiguration(options =>
                {
                    //options.AllEndpointsPort = 1111;
                    //options.HealthEndpoint = "app-metrics-health";
                })
                 .UseMetricsEndpoints()
                 .UseHealth()
                .UseMetricsWebTracking()
                .UseMetrics()
                .ConfigureKestrel((context, options) =>
                {
                    //options.Listen(IPAddress.Any, 80);
                    //options.Listen(IPAddress.Any, 1994);
                    options.Limits.MaxConcurrentConnections = 100;
                    options.Limits.MaxConcurrentUpgradedConnections = 100;
                    //options.Limits.MaxRequestBodySize = 10 * 1024;
                    //options.Limits.MinRequestBodyDataRate =
                    //    new MinDataRate(bytesPerSecond: 100, gracePeriod: TimeSpan.FromSeconds(10));
                    //options.Limits.MinResponseDataRate =
                    //    new MinDataRate(bytesPerSecond: 100, gracePeriod: TimeSpan.FromSeconds(10));
                    //options.Listen(IPAddress.Loopback, 1994);
                    //options.Listen(IPAddress.Loopback, 5001, listenOptions =>
                    //{
                    //    listenOptions.UseHttps("testCert.pfx", "testPassword");
                    //});
                    //options.ConfigureHttpsDefaults(httpsOptions =>
                    //{
                    //    // certificate is an X509Certificate2
                    //    //httpsOptions.ServerCertificate = certificate;
                    //});
                    //options.Configure(context.Configuration.GetSection("Kestrel"))
                    // .Endpoint("HTTPS", opt =>
                    // {
                    //     opt.HttpsOptions.SslProtocols = SslProtocols.Tls12;
                    // });

                    //    options.ListenUnixSocket("/tmp/kestrel-test.sock");
                    //    options.ListenUnixSocket("/tmp/kestrel-test.sock", listenOptions =>
                    //    {
                    //        listenOptions.UseHttps("testCert.pfx", "testpassword");
                    //    });
                    //options.ListenAnyIP(5005, listenOptions =>
                    //{
                    //        listenOptions.Protocols = HttpProtocols.Http1AndHttp2;
                    //        //listenOptions.ConnectionAdapters.Add(new TlsFilterAdapter());
                    //        listenOptions.UseHttps(httpsOptions =>
                    //        {
                    //            //var localhostCert = CertificateLoader.LoadFromStoreCert(
                    //            //    "localhost", "My", StoreLocation.CurrentUser,
                    //            //    allowInvalid: true);
                    //            //var exampleCert = CertificateLoader.LoadFromStoreCert(
                    //            //    "example.com", "My", StoreLocation.CurrentUser,
                    //            //    allowInvalid: true);
                    //            //var subExampleCert = CertificateLoader.LoadFromStoreCert(
                    //            //    "sub.example.com", "My", StoreLocation.CurrentUser,
                    //            //    allowInvalid: true);
                    //            //var certs = new Dictionary<string, X509Certificate2>(
                    //            //    StringComparer.OrdinalIgnoreCase);
                    //            //certs["localhost"] = localhostCert;
                    //            //certs["example.com"] = exampleCert;
                    //            //certs["sub.example.com"] = subExampleCert;

                    //            //httpsOptions.ServerCertificateSelector = (connectionContext, name) =>
                    //            //{
                    //            //    if (name != null && certs.TryGetValue(name, out var cert))
                    //            //    {
                    //            //        return cert;
                    //            //    }

                    //            //    return exampleCert;
                    //            //};
                    //        });
                    //});
                    options.AllowSynchronousIO = true;
                    //    options.Limits.Http2.InitialStreamWindowSize = 98304;
                    //    options.Limits.Http2.InitialConnectionWindowSize = 131072;
                    //    options.Limits.Http2.MaxFrameSize = 16384;
                    //    options.Limits.Http2.MaxRequestHeaderFieldSize = 8192;
                    //    options.Limits.Http2.HeaderTableSize = 4096;
                    //    options.Limits.Http2.MaxStreamsPerConnection = 100;
                    //options.Limits.KeepAliveTimeout = TimeSpan.FromMinutes(15);
                    //options.Limits.RequestHeadersTimeout = TimeSpan.FromMinutes(2);
                });

        }
    }
}
