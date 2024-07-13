using DI;
using Microsoft.Extensions.DependencyInjection;

IServiceCollection services = new ServiceCollection();


services.AddTransient<NotificationService>();
services.AddTransient<IMessageService, EmailService>();
services.AddTransient<ILogger, ConsoleLogger>();
services.AddTransient<IDataBase, PostgresdataBase>();


var serviceProvider = services.BuildServiceProvider();
var notificationService = serviceProvider.GetRequiredService<NotificationService>();

notificationService.Notify();


Console.ReadLine();
