//List<int> numbers = new List<int>();

//numbers.Add(5);

//var first = numbers[0];

var person = new Person { UserName = "Jonh", Age = 20 };

List<Person> perons = new List<Person>();
perons.Add(person);

if (perons.Any(s => s.UserName == "admin"))
{

}

Dictionary<string, Person> dictionary = new Dictionary<string, Person>();

if (!dictionary.ContainsKey(person.UserName))
{
    //Query to db 
    dictionary.Add(person.UserName, person);
}



class Person
{
    public string UserName { get; set; }

    public int Age { get; set; }
}