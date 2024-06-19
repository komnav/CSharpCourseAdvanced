using System;
using System.Collections.Generic;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        //int number = 10;//stack
        //Plus(ref number);

        //Console.WriteLine(number);
        //Console.ReadLine();

        //Student student = new Student { Name = "Dilshod" };//Dilshod will go to heap, ref1 will go to stack
        //ChangeName(ref student);

        //Console.WriteLine(student.Name);

        //Dictionary<string, string> d = new Dictionary<string, string>();

        //d.TryGetValue("", out string newVar);

        if (int.TryParse("abc", out int number))
        {

        }
        Console.WriteLine(number);
        //var student = new Student() { Name = "Dilshod" };

        //if (TryGetName(student, out string name))
        //{
        //    Console.WriteLine(name);
        //}

        Console.ReadLine();
    }

    static bool TryGetName(Student student, out string name)
    {
        if (!string.IsNullOrEmpty(student.Name))
        {
            name = student.Name;
            return true;
        }
        else
        {
            name = null;
        }
        return false;
    }

    static void Plus(ref int x)
    {
        x++;
    }

    static void ChangeName(ref Student student)//ref1 
    {
        student = new Student { Name = "Navruz" };//Navruz will go to heap
    }
}

class Student
{
    public string Name { get; set; }
}