using System;

namespace enu
{
    public enum Temperature
    {
        freeze,
        low,
        warm=10,
        boil   
    }
    class enumm
    {
        static void Main(string[] args)
        {
            Temperature tem= Temperature.low;

            Console.ReadLine();
 
            switch (tem)
            {
                case Temperature.freeze:
                    Console.WriteLine("Temp on Freezing");
                    break;
 
                case Temperature.low:
                    Console.WriteLine("Temp on Low");
                    break;
 
                case Temperature.warm:
                    Console.WriteLine("Temp on Warm");
                    break;
 
                case Temperature.boil:
                    Console.WriteLine("Temp on Boil");
                    break;
            }
        }
    }
}