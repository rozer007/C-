using System;
using System.Collections.Generic;
using System.Linq;
namespace List
{
    class List
    {
        static void Main(String[]args)
        {
            List<int> num=new List<int>();
            num.Add(4);
            num.Add(90);
            int[]arr={1,2,3,4,5};
            num.AddRange(arr);
            num.Insert(2,56);
            num.InsertRange(2,new int[3]{12,13,14});    
            for(int i=0;i<num.Count;i++)
            {
                Console.WriteLine(num[i]);
            }
            num.Sort();
            for(int i=0;i<num.Count;i++)
            {
                Console.Write(num[i]+" ");
            }
          

            List<String> str=new List<string>(new String[]{"TOM","kollo"});
            Console.WriteLine(str.Contains("tom"));
            Console.WriteLine(str.Contains("tom",StringComparer.OrdinalIgnoreCase));
            Console.WriteLine(str.BinarySearch("tom"));

            str.Sort();
            for(int i=0;i<str.Count;i++)
            {
                Console.Write(str[i]+" ");
            }
        }
    }
}