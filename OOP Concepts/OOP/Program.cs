using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine myMachine = new VendingMachine();
            myMachine.BasePrice = 10;
            Console.WriteLine("[Encapsulation] Price: " + myMachine.BasePrice);
            myMachine.GetSelectedDrink();

            NewVendingMachine myNewMachine = new NewVendingMachine();
            myNewMachine.BasePrice = 20;
            Console.WriteLine("[Inheritance] Price: " + myNewMachine.BasePrice);
            myNewMachine.GetSelectedDrink();

            Console.ReadLine();
        }
    }

    //Encapsulation
    public class VendingMachine
    {
        private decimal basePrice;

        public decimal BasePrice
        {
            get { return basePrice; }
            set { basePrice = value; }
        }

        
        public virtual void GetSelectedDrink() //add VIRTUAL modifier so that it can be overridden
        {
            Console.WriteLine("[Base Class] Getting the drink.");
        }
    }

    //Inheritance
    public class NewVendingMachine : VendingMachine
    {
        //Polymorphism
        public override void GetSelectedDrink() //overide the method
        {
            Console.WriteLine("[Polymorphed] Getting the NEW drink.");
        }
    }


}
