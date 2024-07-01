using TasksDay_5;

Menu<string> menu = new Menu<string>("Napitki");
new Menu<string>($"{menu.MenuName = "Chay"}  {menu.MenuName = "Sok"}");
var test = MenuGenerator.GenerateMenu(menu);
Console.WriteLine(test);
Console.WriteLine(menu.Generate());