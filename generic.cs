using System;

namespace gen
{
    class genrc
    {
        static void Main(string[]args)
        {
            machine <string,string> obj=new machine<string, string>();
            obj.display();

            machine <string,string> obj1=new machine<string, string>("120","78");
            obj1.display();
        }

    }
    class machine<Tkey,Tvalue>
    {
        public Tkey key;
        public Tvalue value;
        public machine( )
        {
        }
        public machine(Tkey k,Tvalue v)
        {
            key=k;
            value=v;
        }
        public void display()
        {
            Console.WriteLine("key : "+this.key+" -> value : "+this.value);
        }
    }
}