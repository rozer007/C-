using System;

namespace str
{
    struct direction
    {
        private string N;
        private string S;
        private string E;
        private string W;

        // public direction()
        // {
        //     this.N="0";
        //     this.S="0";
        //     this.E="0";
        //     this.W="0";
        // }
        public void set(String n,String s,String e,String w)
        {
            N=n;
            S=s;
            E=e;
            W=w;
        }
         public void display()
        {
            Console.WriteLine("North : "+N);
            Console.WriteLine("South : "+S);
            Console.WriteLine("East : "+E);
            Console.WriteLine("West : "+W);
        }
    }
    class sitt
    {
        static void Main(string[]args)
        {
            direction dir=new direction();
            dir.set("12","45","23","78");
            dir.display();
        }   
    }
}
