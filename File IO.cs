using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace File
{
    class file
    {
        static void Main(string[]args)
        {

            // string[] custs = new string[] { "Tom", "Paul", "Greg" };

            // using (StreamWriter sw = new StreamWriter("custs.txt"))
            // {
            //     foreach(string cust in custs)
            //     {
            //         sw.WriteLine(cust);
            //     }
            // }
 
            string custName = "";
            using (StreamReader sr = new StreamReader("custs.txt"))
            {
                while ((custName = sr.ReadLine()) != null)
                {
                    Console.WriteLine(custName);
                }
            }
 
            Console.Write("Hit Enter to Exit");
            string exitApp = Console.ReadLine();
        }
    }
}