using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace clss
{    

    delegate double Getsum(double num1,double num2);
    class animal
    {

        static void Main(string[]args)
        {
            List<int> lt=new List<int>{1,2,3,4,5,6};
          List<int> even =lt.Where(n=>n%2==0).ToList();
          foreach(int i in even)
            {
                Console.Write(i);
            }
        
        }
    }
}