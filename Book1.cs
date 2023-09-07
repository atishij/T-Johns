using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Book1
    {
        string name;
        //auto implemented properties
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public float Price { get; set; }


        public string BName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
