using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dailytasks
{
   public interface IShape
    {
        public double GetArea();
    }

    public class Circle : IShape
    {
        public  double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Rectangle : IShape
    {
        public  double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double width,double length)
        {
            Width = width;
            Length = length;
        }

        public double GetArea()
        {
            return Length * Width;
        }

    }

    public class Square : IShape
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public double GetArea()
        {
            return Side * Side;
        }

    }
}
