using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    /*
     * Задача №1.1: Создайте систему очереди для банка

Очередь идентифицируется номером
У каждого сотрудника банка своя максимальная длина очереди
Сотрудники банка могут поставить клиентов в очередь
Сотрудник банка имеет возможность обслуживать клиента. Он обслуживает клиента по очереди.
Кто был обслужен, снимается с очереди
     */
    public class MyQueue<T> where T : class, IQueuable
    {
        public MyQueue(int maxLenght)
        {
            MaxLenght = maxLenght;
            Items = new List<T>();
        }

        List<T> Items { get; set; }//11001, 2222, 333, 4123, 51231

        int MaxLenght { get; set; }

        public void AddToQueue(T item)
        {
            if (Items.Count == MaxLenght)
            {
                throw new Exception("Queue is full");
            }

            Random random = new Random();
            var randomNumber = random.Next(1000, 9999);
            item.Number = randomNumber;
            Items.Add(item);
        }

        public void RemoveFromQueue(T item)
        {
            Items.Remove(item);
        }

        public T GetCurrent()
        {
            return Items.First();
        }
    }
}
