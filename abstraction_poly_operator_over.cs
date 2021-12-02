using System;

namespace clsss
{
    abstract class shape
    {
        public abstract double area();
        public void sayhi()
        {
            Console.WriteLine("Hello world");
        }
    }

    public interface shapeitem
    {
        double area();// this is also a abstract class
    }

    class rectangle:shapeitem //shape
    {
        public double length;
        public double width;
        public rectangle(double num1,double num2)
        {
            this.length=num1;
            this.width=num2;
        }
        public  double area()
        {
            return length*width;
        }
        // public override double area()
        // {
        //     return length*width;
        // }
        public static rectangle operator+(rectangle r1,rectangle r2) //operator overriding
        {
            double rlength=r1.length+r2.length;
            double rwidth=r1.width+r2.width;
            return new rectangle(rlength,rwidth);
        }
    }

    class traingle:shapeitem
    {
        public double bb;
        public double height;
        public traingle(double num1,double num2)
        {
            this.bb=num1;
            this.height=num2;
        }
        public double area()
        {
            return .5*height*bb;
        }
        // public override double area()
        // {
        //     return .5*height*bb;
        // }
    }

    class poly_abs_inter_ope
    {
        static void Main(string[] args)
        {
            rectangle rec=new rectangle(12,8);
            traingle tri=new traingle(12,8);
            Console.WriteLine(rec.area());
            Console.WriteLine(tri.area());

            rectangle com=new rectangle(1,2)+new rectangle(2,2);
            Console.WriteLine(com.area());
        }   
    }
}