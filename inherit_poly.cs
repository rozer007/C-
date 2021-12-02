using System;

namespace inheri
{
    class animal
    {
        public string name;
        public string Names
        {
            get{return name;}
            set{this.name=value;}
        }
        public double height{get;set;}
        public string sound{get;set;}

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

        static void Main(string[]args)
        {
            // animal a= new animal("dog","woof",12);
            // animal b= new animal();
            // b.name="cat";
            // b.height=23;
            // b.sound="meau";
            // a.getalll();
            // b.getalll();
            // Console.WriteLine(animal.ob());
            // animal obj=new animal{
            //     name="ppp",
            //     sound="prr",
            //     height=12
            // };
            dog d=new dog("meat");
            d.name="tommy";
            d.height=12;
            d.sound="woof";
            d.getalll();        
        }
    }

    class dog:animal
    {
        public string food{get;set;}
        public dog():base()
        {
            this.food="NO food";
        } 

        public dog(string fod)
        {
            this.food=fod;
        }

        //overriding the funciton in base class.
         new public void getalll()
        {
            Console.WriteLine("The animal is "+name+" it make sound like "+sound+" and it is "+height+" height love to eat "+this.food);
        }

    }

}