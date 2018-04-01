using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsAndDestructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Cow c = new Cow("Barney");
            Console.ReadLine();
        }
    }

    class Cow
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Constructor
        //Shoul be the same name as the Class
        //A constructor that writes the name of the cow
        public Cow (string cowName)
        {
            Name = cowName;
            Console.WriteLine(Name);
        }

        //Destructor
        //Same as the Class but should have the tilde sign before it
        //Runs when the class is not reachable - https://www.dotnetperls.com/destructor
        ~Cow()
        {
            Console.WriteLine("Running Destructor");
        }
    }
}
