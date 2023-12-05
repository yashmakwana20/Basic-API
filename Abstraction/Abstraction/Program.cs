using System;

namespace aBSTRACTION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square s= new Square();
            s.draw();
            Circle c = new Circle();
            c.draw();
            c.print();
            
            Console.ReadLine();
        }
    }

    abstract class Shape
    {
        public abstract void draw();
        public virtual void print()
        {
            Console.WriteLine("Print method in shape class.");
        }
    }

    class Square : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Square.......");
        }
    }

    class Circle : Shape
    {
        public override void draw()
        {
            
            Console.WriteLine("Drawing Circle.......");
        }
        
        public override void print()
        {
            base.print();
            Console.WriteLine("Error Aavi Gy Chhe!");
        }
    }
}
