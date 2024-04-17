// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;

Console.WriteLine("Hello, World!");

CategoryManager categoryManager = new CategoryManager();
InsructorManager insructorManager = new();

if (categoryManager.Add(new Category { Name = "Programlama", Id = 1 }))
    Console.WriteLine("kategori eklendi");

List<Category> categories = categoryManager.GetAll();
Console.WriteLine("");
Console.WriteLine("Kategoriler:");
Console.WriteLine("----------------------");
foreach (Category category in categories)
{
    Console.WriteLine(category.Name);
}


insructorManager.Add(new Insructor{ Id = 1, Name = "Engin", LastName = "Demiroğ"});
insructorManager.Add(new Insructor{ Id = 2, Name = "Halit Enes", LastName = "Kalaycı" });

List<Insructor> insructors = insructorManager.GetAll();

Console.WriteLine("");
Console.WriteLine("Eğitmenler:");
Console.WriteLine("----------------------");


foreach (Insructor insructor in insructors)
{
    Console.WriteLine($"{insructor.Name} {insructor.LastName}");
}

CourseManager courseManager = new CourseManager();
courseManager.Add(new Course
{
    Id = 1,
    Name = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)",
    CategoryId = 1,
    InstructorId = 1,
    ImageUrl = "",
    Progress=100,
});
Console.WriteLine("");
Console.WriteLine("Kurs Eklendi");