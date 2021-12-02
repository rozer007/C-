using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Intro
{
    class math
    {
        static void Main(string[] args)
        {
            double d=12.5;
            double c=89.2;
            int f=89;

            Console.WriteLine(Math.Abs(d));
            Console.WriteLine(Math.Ceiling(d));
            Console.WriteLine(Math.Floor(d));
            Console.WriteLine(Math.Max(d,c));
            Console.WriteLine(Math.Min(d,f));
            Console.WriteLine(Math.Pow(d,2));
            Console.WriteLine(Math.Round(d));
            Console.WriteLine(Math.Sqrt(d));

            Random rn = new Random();
            Console.WriteLine(rn.Next(1,5));
            
        }
    }
}