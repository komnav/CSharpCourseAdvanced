using TasksDay_5;





SimpleMenu napitki = new SimpleMenu();
napitki.MenuName = "Napitki";


SimpleMenu chay = new SimpleMenu();
chay.MenuName = "Chay";
napitki.Childs.Add(chay);

SimpleMenu sok = new SimpleMenu();
sok.MenuName = "Sok";
napitki.Childs.Add(sok);
MenuGenerator.GenerateMenuToFile(napitki, "napitli.html");

ComplexMenu sayti = new ComplexMenu();

sayti.MenuName = "Sayti";
sayti.Url = "#";


ComplexMenu google = new ComplexMenu();

google.MenuName = "Google";
google.Url = "https://www.google.com/";
google.Icon = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/77/Google_Images_2015_logo.svg/640px-Google_Images_2015_logo.svg.png";

sayti.Childs.Add(google);

ComplexMenu yandex = new ComplexMenu();
yandex.MenuName = "Yandex";

yandex.Url = "https://ya.ru";
yandex.Icon = "https://ichef.bbci.co.uk/news/480/cpsprodpb/15F27/production/_132559898_gettyimages-1243579431.jpg.webp";

sayti.Childs.Add(yandex);

MenuGenerator.GenerateMenuToFile(sayti, "sayti.html");

