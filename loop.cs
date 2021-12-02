using System;
namespace loop
{
    class alloop
    {
        static void Main(String[]args)
        {
            int i=0;
            while(i<3)
            {
                Console.Write(i);
                i++;
            }

            Console.WriteLine();

            i=0;
            do
            {
                Console.Write(i);
                i++;
            }while(i<3);

            Console.WriteLine();

            for(i=0;i<3;i++)
            {
                Console.Write(i);
            }

            Console.WriteLine();
            
            String str="Hello world";

            foreach(char c in str)
            {
                Console.Write(c+" < ");
            }
        }
    }
}