using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.Flyweight.Easy.Shapes
{
    internal interface IShape
    {
        void draw(CircleContext context);
    }

    internal class CircleColor : IShape
    {
        private string _color;
        public CircleColor(string color)
        {
            _color = color;
        }

        public void draw(CircleContext context)

        {
            Console.WriteLine($"Drawing {_color} circle at x: {context.GetCoords().x}, y: {context.GetCoords().y}");
        }
    }

    internal class CircleContext
    {
        private int _x;
        private int _y;

        public CircleContext(int x, int y) {
            _x= x;
            _y= y;
        }

        public (int x, int y)  GetCoords()
        {
            return (_x, _y);
        }
    }

    internal class CircleFactory
    {
        private static readonly Dictionary<string, IShape> circles = new Dictionary<string, IShape> ();

        public IShape GetCircle(string color)
        {
            if (circles.ContainsKey(color))
            {
                Console.WriteLine("Returning cached object");
                return circles[color];
            }
            else {
                Console.WriteLine("Object not found in cache, creating a new one");
                IShape newCircle = new CircleColor(color);
                circles.Add(color, newCircle);
                return newCircle;
            }
        }
    }
}
