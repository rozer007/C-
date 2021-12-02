using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace delegte
{
    public delegate void sum(int a,int b);

    class delegte
    {
        static void add(int a,int b )
        {
            Console.WriteLine(a+b);
        }

        public void addition(int a , int b)
        {
            Console.WriteLine(a+b);
        }

        public static void invokedelegate(sum del)
        {
            del(10,19);
        }
        public static void Main(string[]args)
        {
            delegte del=new delegte();
            sum ad=del.addition;  // sunm ad=new sum(del.addition) setting target to class method
            sum s=new sum(add); //setting a traget for static method

            // ad(3,4);// calling or invoking
            // ad.Invoke(3,4);
            // s(2,3);

            //lambda expression in delegate

            sum lam=(int a,int b) => Console.WriteLine(a+b);

            // lam(2,4);


            //passing delgate as paramter
            s=del.addition;
            // invokedelegate(s);

            // multicast delegate - that point to many function

            sum dele=ad+s; //multicast
            dele(1,2);
        }
    }
} 