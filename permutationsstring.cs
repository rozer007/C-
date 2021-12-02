using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace per
{
    class permutations
    {

        public static int fact(int n)
        {
            int fact=1;
            for(int i=2;i<=n;i++)
            {
                fact*=i;
            }
            return fact;
        }

        public static void solution(string str)
        {
            int len=str.Length;
            int total=fact(len);

            for(int n=0;n<total;n++)
            {
                StringBuilder sb= new StringBuilder(str);
                int temp=n;

                for(int div=len;div>=1;div--)
                {
                    int q=temp/div;
                    int r=temp%div;

                    Console.Write(sb[r]);
                    sb.Remove(r,1);
                    temp=q; 
                }
                Console.WriteLine();
            }
        }
        static void Main(string[]args)
        {
            string str=Console.ReadLine();
            solution(str);

        }
    }
}