using TasksDay_5;





var teaMenu = new Menu<string>("Chay") { Icon = "tea.png", Url = "komilov.html" };

var sokMenu = new Menu<string>("sok") { Icon = "sok.png", Url = "Navruz.html" };


Menu<string> menu = new Menu<string>("Napitki") { Childs = new List<Menu<string>> { teaMenu, sokMenu } };
MenuGenerator.GenerateMenuToFile(menu);

