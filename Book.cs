using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Book
    {
        int Id;
        string Title;
        string Author;
        string Publisher;
        float Price;

        public Book()
        {
            Id = 1;
            Title = "If Tommorrow Comes";
            Author = "Sydney Sheldon";
            Publisher = "ABC Inc";
            Price = 455.50f;
        }

        public Book(int Id,string Title,string Author,string Publisher,float Price)
        {
            //this : current instance
            this.Id = Id; ;
            this.Title = Title;
            this.Author = Author;
            this.Publisher = Publisher;
            this.Price = Price;
        }

        public void DisplayDetails()
        {
            //code snippet cw tab tab
            Console.WriteLine("Id : {0} Title : {1} Author : {2} Publisher {3} Price {4}",this.Id,this.Title,this.Author,this.Publisher,this.Price);
            Console.WriteLine($"Id : {this.Id} Title: {this.Title} Author : {this.Author} Publisher : {this.Publisher} Price : {this.Price}");

        }


    }
}
