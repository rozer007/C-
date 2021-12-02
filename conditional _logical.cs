using System;
namespace conditional
{
    class Logical
    {
        static void Main(String[]args)
        {
            Console.Write("Enter your age : ");
            // String a =Console.ReadLine();
            // int val =Convert.ToInt32(a);
            int val=int.Parse(Console.ReadLine());
            Console.WriteLine("The age is :"+val);
            // String str=@"hello";
            // Console.WriteLine(str);
            if(val>10)
            {
                Console.WriteLine("Greater");
            }
            else
            goto clue;
            clue:
            Console.WriteLine("GOTO");
        }

    }
}