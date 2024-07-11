using DI;
using Microsoft.Extensions.DependencyInjection;

IServiceCollection services = new ServiceCollection();

services.AddTransient<NotificationService>();
services.AddTransient<IMessageService, EmailService>();
services.AddTransient<ILogger, ConsoleLogger>();
services.AddTransient<IDataBase, PostgreDataBase>();

var serviceProvider = services.BuildServiceProvider();
var notificationservice = serviceProvider.GetRequiredService<NotificationService>();

notificationservice.Notify();

