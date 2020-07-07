using System;
namespace Shapes
{
    public abstract class Shape
    {
        private double area;
        public Shape()
        {
        }
        public virtual double GetArea()
        {
            return this.area;
        }

    }
    public class Circle : Shape
    {
        double a;
        double b;

        public Circle(double a, double b) 
        {
            this.a = a;
            this.b = b;
        }
        public override double GetArea()
        {
            return 3.14 * this.a * this.b;
        }
    }

    public class Square : Shape
    {
        private int[] node = { 0, 0 };
        private double width;
        private double higth;
        public Square(int[] node,double width,double higth) 
        {
            this.node = node;
            this.width = width;
            this.higth = higth;
        }
        public override double GetArea()
        {
            return this.higth * this.width;
        }
    }
}