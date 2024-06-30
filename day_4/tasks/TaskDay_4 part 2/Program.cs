using TaskDay_4_part_2;

Paper paper = new Paper();
paper.Name = "oila";
paper.Date = DateTime.Now;
paper.Publisher = "Oila TV";

Console.WriteLine(paper.ToString());


Book book = new Book();
book.Title = 15;
Console.WriteLine(book.ToString());
Console.ReadLine();