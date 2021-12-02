using System;

namespace excep
{
    class exp
    {
        static void Main(string[]args)
        {
            try{
                int c=10/2;
                Console.WriteLine(c/0);
            }
            catch(DivideByZeroException ex) //if this catch then next catch block will not execute.
            {
                Console.WriteLine("NO zerosss");
                // throw new DivideByZeroException("Operatio on zero error");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Don't give zero");
            }
        }
    }
}