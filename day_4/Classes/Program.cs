// See https://aka.ms/new-console-template for more information

using System.Drawing;
Student Student = new Student();
Student.ShowMyType();
Console.ReadLine();
//User user = new User();
//user.UserName = "komdil";

//var users = new User[] { user };
//AuthorizationService authorizationService = new AuthorizationService(users);



//Domain
public class User
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }

    public bool IsActive { get; set; }
}

public class Car
{
    public string Color { get; set; }

    public string Mark { get; set; }

    public string Model { get; set; }
}

//Services

public interface IUserRepository
{
    User[] GetUsers();
}

public class MyClass(string Name);

public class AuthorizationService
{
    private User[] _users;

    public AuthorizationService(IUserRepository userRepository) : this(userRepository.GetUsers())
    {
    }

    public AuthorizationService(User[] users)
    {
        _users = users.Where(s => s.IsActive).ToArray();
    }

    public bool AuthorizeUser(string userName, string password)
    {
        return _users.Any(s => s.UserName == userName && s.Password == password);
    }
}

class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
    public Person()
    {

    }

    public virtual void ShowMyType()
    {
        Console.Write("I am person");
    }
}
class Student : Person
{
    public string LastName { get; set; }

    public Student(string name, string lastName) : base(name)
    {
        LastName = lastName;
    }

    public Student()
    {

    }

    public override void ShowMyType()
    {
        Console.WriteLine("I am student");
    }

    public override string ToString()
    {
        return Name;
    }
}