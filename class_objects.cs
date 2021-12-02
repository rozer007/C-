using System;

namespace clsss
{
    class animal
    {
        public string name;
        public string Names
        {
            get{return name;}
            set{this.name=value;}
        }
        private double height{get;set;}
        private string sound{get;set;}

        public animal()
        {
            this.name="no name";
            this.height=0;
            this.sound="no sound";
            no++;
        }

        public animal(string name,string s,int h)
        {
            this.name=name;
            this.height=h;
            this.sound= s;
            no++;
        }

        public void getalll()
        {
            Console.WriteLine("The animal is "+this.name+" it make sound like "+this.sound+" and it is "+this.height);
        }

        static int no=0;
        public static int ob()
        {
            return no;
        }

        //function overloading
        public  int sum(int num1=1,int num2=1)
        {
            getalll();
            return num1+num2;
        }
        public  int sum(int num1=1,int num2=1,int num3=1)
        {
            return num1+num2+num3;
        }
        static void Main(string[]args)
        {
            animal a= new animal("dog","woof",12);
            animal b= new animal();
            b.name="cat";
            b.height=23;
            b.sound="meau";
            a.getalll();
            b.getalll();
            Console.WriteLine(animal.ob());
            animal obj=new animal{
                name="ppp",
                sound="prr",
                height=12
            };
            Console.WriteLine(obj.sum(1,2));
            Console.WriteLine(obj.sum(num1 :1,num3:2,num2:3));
        }
    }
}