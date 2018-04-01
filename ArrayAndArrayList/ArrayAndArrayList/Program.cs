using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array
            //Has a fixed length and only int data type can be added 
            int[] array1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(array1[0]);
            Console.WriteLine(array1[1]);
            Console.WriteLine(array1[2]);

            //ArrayList
            //Does not need the size to be indicated and it grows dynamically as a value added in the array list
            //Any datatype can be added
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(1);
            arrayList1.Add(1.23);
            arrayList1.Add("String");

            Console.WriteLine(arrayList1[0]);
            Console.WriteLine(arrayList1[1]);
            Console.WriteLine(arrayList1[2]);
            Console.ReadLine();
        }
    }
}
