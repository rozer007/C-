using System;

namespace Intro
{
    class Helloworld
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name : ");
            // string name=Console.ReadLine();
            String name="popeye";
            Console.WriteLine("Hello "+name);

            // Data Types

            // int a=int.MaxValue;
            // long l=long.MaxValue;
            // float f=float.MaxValue;
            // double d=double.MaxValue;
            // decimal dec=decimal.MaxValue;
            // Console.WriteLine(a);
            // Console.WriteLine(l);
            // Console.WriteLine(f);
            // Console.WriteLine(d);
            // Console.WriteLine(dec);

            var auto= "Hello world";
            Console.WriteLine(auto.GetTypeCode());
            // auto=2;//will give an error since it is of string type

            //NAth function

            Random rand=new Random();
            Console.WriteLine("Random : "+rand.Next(1,11));
        }    
    }
}