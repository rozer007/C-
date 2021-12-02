using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Name
{
    class isprime
    {
        static void Main(string[]args)
        {
            int n=int.Parse(Console.ReadLine());
            // int count=0;
            // for(int i=1;i<=n;i++)
            // {
            //     if(n%i==0)
            //     count+=1;
            // }
            // if(count==2)
            // Console.WriteLine("Prime");
            // else 
            // Console.WriteLine("Not Prime");
            bool flag=true;
            for(int i=2;i*i<n;i++)
            {
                if(n%i==0)
                {
                    flag=false;
                    break;
                }
            }
            if(flag==true)
            Console.WriteLine("Prime");
            else
            Console.WriteLine("Not Prime");
        }
    }
}