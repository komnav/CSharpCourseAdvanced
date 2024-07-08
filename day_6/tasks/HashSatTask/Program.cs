HashSet<string> nameOfPlayer = new HashSet<string>
{
    "Ter Stegen","Pique", "Alves","Arauhjo","Jordi Alba", "De Jong", "Busquets","Gavi"
};

string[] name = new string[]
{
    "De Jong","Busquets","Gavi", "Dembele","Aubemiyang","Ferran","Adama "
};

var playerIntersect = nameOfPlayer.Intersect(name);

foreach (var item in playerIntersect)
{
    Console.WriteLine(item);
}
