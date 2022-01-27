using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace OOP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("1984", "Orwel", 1949);
            Book book2 = new Book("Test", "TestAuthor", 1999);
            Book book3 = new Book("TestTitle", "TestAuthor2", 2022);

            List<string> books = new() { book1.Author, book2.Author, book3.Author};
            FileWriteService service = new FileWriteService();
            
            //service.WriteAllText(books.ToArray());


            BooksRepository repository= new BooksRepository();
            repository.SaveBookTitle(book1);
            //repository.SaveBookAuthor(book1);
            //repository.SaveBookYear(book1);

            //service.AppendTexInSameLine(;


            // Getting data
            List<string> data = new();
            data = service.GetAllLines();

            //----------------------------------------------

            Student student1 = new Student(1985, "Tom", "NewYork");
            //student1.ShowDetails();

            Book book4 = new Book("Pavadinimas", "Autorius", 2020);
            //------------------------------------------------------------

            Page page1 = new Page("Content",1);
            Page page2 = new Page("Content",2);
            Page page3 = new Page("Content",3);

            var magazine = new Magazine(Guid.NewGuid(), "Book");

            magazine.Pages.Add(new Page("content", 1));
            magazine.Pages.Add(new Page("content", 2));
            magazine.Pages.Add(new Page("content", 3));

            //var pageToRemove = magazine.Pages.FirstOrDefault(x => x.Content == "content"); 


            //--------------------------------------------------
            //TV_Programme tV_Programme1 = new TV_Programme();

            TV_Show tV_Show1 = new TV_Show();
            tV_Show1.ID = Guid.NewGuid();
            tV_Show1.Duration = 10;
            tV_Show1.Description = "Description";
            tV_Show1.StartTime = DateTime.Now.Date;
            tV_Show1.Title = "Name";


            TV_Programme programme = new TV_Programme();
            programme.ListOfTVShows = new List<TV_Show>();
            programme.AddTVShow(tV_Show1);
            programme.RemoveTVShowByName("Name");
            programme.PrintProgram(programme.ListOfTVShows);

            Circle circle = new Circle(3.75);
            Console.WriteLine($"circle.radius=  {circle.Radius}");
            Console.WriteLine($"circle.area=  {circle.GetArea()}");
            Cylinder cylinder = new Cylinder(5.55, 7.25);
            Console.WriteLine($"cylinder.radius= {cylinder.Radius}");
            Console.WriteLine($"cylinder.height= {cylinder.Height}");
            Console.WriteLine($"cylinder.area= {cylinder.GetArea()}");
            Console.WriteLine($"cylinder.volume= {cylinder.GetVolume()}");

            Console.WriteLine("---------------------------------------");

            Rectangle rectangle = new Rectangle(5, 10);
            Console.WriteLine($"rectangle.width= {rectangle.Width}");
            Console.WriteLine($"rectangle.length= {rectangle.Length}");
            Console.WriteLine($"rectangle.area= {rectangle.GetArea()}");
            Cuboid cuboid = new Cuboid(5,10,5);
            Console.WriteLine($"cuboid.width= {cuboid.Width}");
            Console.WriteLine($"cuboid.lenght= {cuboid.Length}");
            Console.WriteLine($"cuboid.area= {cuboid.GetArea()}");
            Console.WriteLine($"cuboid.height= {cuboid.Height}");
            Console.WriteLine($"cuboid.volume= {cuboid.GetVolume()}");

            //--------------------------------------------------------------

            Hamburger hamburger = new Hamburger("Basic", "Sausage", 3.56, "White");
            hamburger.AddHamburgerAddition1("Tomato", 0.27);
            hamburger.AddHamburgerAddition2("Lettuce", 0.75);
            hamburger.AddHamburgerAddition3("Cheese", 1.13);


            Console.WriteLine($"{hamburger.Name}, {hamburger.Meat}, {hamburger.Price}, {hamburger.BreadRollType}");


        }
    }
}
