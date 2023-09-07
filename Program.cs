using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Book b1 = new Book();
            //b1.DisplayDetails();

            //Book b2 = new Book(2,"Hello World","Samatha","Xyz Inc",500f);
            //b2.DisplayDetails();

            Book1 b1 = new Book1();
            b1.Id = 10;
            b1.Title = "sdfsdf";
            b1.Author = "author1";
            b1.Publisher = "publisher";
            b1.Price = 324.3f;
            

            Console.WriteLine($"Id : {b1.Id} Title: {b1.Title} Author : {b1.Author} Publisher : {b1.Publisher} Price : {b1.Price}");

            Console.ReadLine();
        }
    }
}
