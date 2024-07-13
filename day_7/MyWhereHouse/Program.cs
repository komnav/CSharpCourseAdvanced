using Microsoft.Extensions.DependencyInjection;
using MyWarehouse;
using MyWarehouse.Repositories;
using MyWarehouse.Repository.Abstractions;
using MyWarehouse.Strategies;
using MyWhereHouse.Strategies;
using MyWhereHouse.Strategies.Abstractions;


var serviceCollection = new ServiceCollection();

serviceCollection.AddSingleton<IProductRepository, ProductRepository>();
serviceCollection.AddSingleton<ICommandLineStrategyResolver, CommandLineStrategyResolver>();

serviceCollection.AddSingleton<ICommandLineStrategy, GetProductsStrategy>();
serviceCollection.AddSingleton<ICommandLineStrategy, AddProductStrategy>();
serviceCollection.AddSingleton<ICommandLineStrategy, SellProductStrategy>();
serviceCollection.AddSingleton<ICommandLineStrategy, DeleteProductStrategy>();
serviceCollection.AddSingleton<ICommandLineStrategy, CloseApplicationStrategy>();

serviceCollection.AddSingleton<Application>();

var provider = serviceCollection.BuildServiceProvider();

var application = provider.GetRequiredService<Application>();
application.Start();