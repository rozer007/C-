using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace spirl
{
    class spiral
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            int m=int.Parse(Console.ReadLine());
            int[,] arr=new int[n,m];
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    arr[i,j]=int.Parse(Console.ReadLine());
                }
            }

            int minc=0;
            int minr=0;
            int maxc=arr.GetLength(1)-1;
            int maxr=arr.GetLength(0)-1;

            int total=arr.Length; //get the total number of elements
            int count=0;

            while(count<total)
            {
                //left
                int l=minr;
                while(count<total&&l<=maxr)
                {
                    Console.WriteLine(arr[l,minc]);
                    l++;
                    count++;
                }
                minc++;

                //down
                int d=minc;
                while(count<total&&d<=maxc)
                {
                    Console.WriteLine(arr[maxr,d]);
                    d++;
                    count++;
                }
                maxr--;

                //right
                int r=maxr;
                while(count<total&&r>=minr)
                {
                    Console.WriteLine(arr[r,maxc]);
                    r--;
                    count++;
                }
                maxc--;

                //up
                int u=maxc;
                while(count<total&&u>=minc)
                {
                    Console.WriteLine(arr[minr,u]);
                    u--;
                    count++;
                }
                minc++;
            }

        }
    }
}