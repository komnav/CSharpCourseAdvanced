// See https://aka.ms/new-console-template for more information

/*
 * Задача №1.1: Создайте систему очереди для банка

Очередь идентифицируется номером
У каждого сотрудника банка своя максимальная длина очереди
Сотрудники банка могут поставить клиентов в очередь
Сотрудник банка имеет возможность обслуживать клиента. Он обслуживает клиента по очереди.
Кто был обслужен, снимается с очереди

 * 
 */

using Generics;

MyQueue<BankClient> myQueue = new MyQueue<BankClient>(7);
myQueue.AddToQueue(new BankClient() { Price = 200 });
myQueue.AddToQueue(new BankClient() { Price = 300 });
myQueue.AddToQueue(new BankClient() { Price = 3300 });

Console.WriteLine(myQueue.GetCurrent().Number);

var currentInQueue = myQueue.GetCurrent();
Console.WriteLine($"Price for serve is {currentInQueue.Price}");
myQueue.RemoveFromQueue(currentInQueue);

Console.WriteLine(myQueue.GetCurrent().Number);

Console.ReadLine();


MyQueue<PatientClient> queueInPatient = new MyQueue<PatientClient>(7);

queueInPatient.AddToQueue(new PatientClient());