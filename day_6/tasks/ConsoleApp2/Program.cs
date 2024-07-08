Stack<string> stack = new Stack<string>();
stack.Push("Apple");
stack.Push("Banana");
stack.Push("Cherries");
stack.Push("Orange");
stack.Push("Pear");
foreach (var queues in stack)
{
    Console.WriteLine(queues);
}
Console.WriteLine();

Console.WriteLine(stack.Peek());

stack.Pop();
stack.Pop();
Console.WriteLine();

foreach (var queues in stack)
{
    Console.WriteLine(queues);
}
Console.WriteLine();
Console.WriteLine(stack.Peek());
