using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RestaurantReservation.Db;


static IHostBuilder CreateHostBuilder(string[] args)
{
    return Host.CreateDefaultBuilder()
        .ConfigureServices(services =>
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                {
                    var configuration = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json", false, true)
                        .Build();

                    options
                        .UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
                });
        });
}

await CreateHostBuilder(args).Build().RunAsync();

// Set up configuration sources
// IConfiguration configuration = new ConfigurationBuilder()
//     .SetBasePath(Directory.GetCurrentDirectory())
//     .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
//     .Build();

// Retrieve the connection string from the configuration file
// var connectionString = configuration.GetConnectionString("DefaultConnection");

// if (string.IsNullOrEmpty(connectionString))
// {
//     throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
// }

// Configure the service collection and add DbContext
// var serviceProvider = new ServiceCollection()
//     .AddDbContext<ApplicationDbContext>(options =>
//         options.UseSqlServer(connectionString))
//     .BuildServiceProvider();