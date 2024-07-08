Queue<string> queue = new Queue<string>();

queue.Enqueue("Apple");
queue.Enqueue("Banana");
queue.Enqueue("Cherries");
queue.Enqueue("Orange");
queue.Enqueue("Pear");
foreach (var queues in queue)
{
    Console.WriteLine(queues);
}
Console.WriteLine();
Console.WriteLine(queue.Peek());
queue.Dequeue();
queue.Dequeue();

Console.WriteLine();
foreach (var queues in queue)
{
    Console.WriteLine(queues);
}
Console.WriteLine();
Console.WriteLine(queue.Peek());