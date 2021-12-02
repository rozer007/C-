using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace  bar
{
    class barchart
    {
        static void Main(string[]args)
        {
            int n=int.Parse(Console.ReadLine());
            int[] arr=new int[n];
            for(int i =0;i<n;i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            int max=arr.Max();
            for(int r=0;r<max;r++)
            {
                foreach(int val in arr)
                {
                    if(val>=max-r)
                    Console.Write("*\t");
                    else
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
        }
    }
}