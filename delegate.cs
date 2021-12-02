using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

delegate double Getsum(double num1,double num2);

namespace dele
{
    class dligte
    {
        static void Main(string[]args)
        {
            Getsum sum=delegate(double num1,double num2)
            {
                return num1+num2;
            };
            Console.WriteLine("5 + 10 = "+sum(12,13));


            //lambda functions

            Func<int,int,int,int> sum3=(x,y,z)=>x+y+z;
            Console.WriteLine(sum3.Invoke(1,2,3));

            List<int> lt=new List<int>{1,2,3,4,5,6};

            List<int> even =lt.Where(n=>n%2==0).ToList();

            foreach(int i in even)
            {
                Console.WriteLine(i);
            }

        }
    }
}