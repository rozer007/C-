using System;
using System.Text;
using System.Linq;
namespace Arraryss
{
    class Arrys
    {
        static void Main(String[]args)
        {
            int[]arr1={11,12,13,14,15};
            Console.WriteLine(Array.IndexOf(arr1,14));
            String[]joins ={"spiderman","captain america","ant man","wasp girl"};
            
            String str=String.Join(" : ",joins);
            Console.WriteLine(str);

            String[]splt=str.Split(":");
            foreach(String s in splt)
            {
                Console.Write(s + " -> ");
            }

            //2d Array
            Console.WriteLine("Enter the rows and column : ");
            int r=int.Parse(Console.ReadLine());
            int c=int.Parse(Console.ReadLine());
            int[,]arr=new int[r,c];

            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(arr.Length); //give the number of element
            Console.WriteLine(arr.GetLength(1)); //give size of first index

            // foreach(int i in arr)//work for 2d also
            // {
            //     Console.WriteLine(i);
            // }

            // System.Array.ForEach(splt,n =>Console.WriteLine(n)); // work only in 1d array
        }
    }
}