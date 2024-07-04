using TasksDay_5;





var teaMenu = new Menu<GeneralMenu>(new GeneralMenu { MenuName = "Chay", Icon = "tea.png", Url = "komilov.html" });

var sokMenu = new Menu<GeneralMenu>(new GeneralMenu { MenuName = "Sok", Icon = "sok.png", Url = "Navruz.html" });


Menu<GeneralMenu> menu = new Menu<GeneralMenu>(new GeneralMenu { MenuName = "Napitki" })
{
    Childs = new List<Menu<GeneralMenu>> { teaMenu, sokMenu }
};

var icon = new GeneralMenu();
var url = new GeneralMenu();
MenuGenerator<GeneralMenu>.GenerateMenuToFile(menu, icon, url);

