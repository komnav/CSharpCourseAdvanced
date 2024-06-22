using System;

class Program
{
    static void Main(string[] args)
    {
        // Method1();
        ParentNode parentnode = new ParentNode();
        Method2(parentnode);
    }

    static void Method1()
    {
        int a = 100;
        int b = 200;
        decimal t = 100;
        DateTime dateTime = DateTime.Now;
    }

    static void Method2(ParentNode parent)
    {
        Node node = new Node()
        {
            Value = 100
        };// 1 MB
          //RAM: 4 GB
          //SUMM: 5 GB
        parent.Node = node;
    }
}

public class Node
{
    public int Value { get; set; }
}

public class ParentNode
{
    public Node Node { get; set; }
}