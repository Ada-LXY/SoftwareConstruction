using System;

using System;

namespace ShapeAreaCalculator
{
    // 定义形状接口
    public interface IShape
    {
        double CalculateArea();
        bool IsValid();
    }

    // 长方形类
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            if (!IsValid())
                throw new InvalidOperationException("Invalid rectangle dimensions.");
            return Width * Height;
        }

        public bool IsValid()
        {
            return Width > 0 && Height > 0;
        }
    }

    // 正方形类
    public class Square : IShape
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public double CalculateArea()
        {
            if (!IsValid())
                throw new InvalidOperationException("Invalid square dimensions.");
            return Side * Side;
        }

        public bool IsValid()
        {
            return Side > 0;
        }
    }

    // 三角形类
    public class Triangle : IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }

        public double CalculateArea()
        {
            if (!IsValid())
                throw new InvalidOperationException("Invalid triangle dimensions.");
            return 0.5 * Base * Height;
        }

        public bool IsValid()
        {
            return Base > 0 && Height > 0;
        }
    }

    // 简单工厂类
    public static class ShapeFactory
    {
        private static Random random = new Random();

        public static IShape CreateShape()
        {
            int shapeType = random.Next(0, 3); // 随机生成0-2的数字

            switch (shapeType)
            {
                case 0:
                    return new Rectangle(random.Next(1, 10), random.Next(1, 10));
                case 1:
                    return new Square(random.Next(1, 10));
                case 2:
                    return new Triangle(random.Next(1, 10), random.Next(1, 10));
                default:
                    throw new InvalidOperationException("Invalid shape type");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double totalArea = 0;

            for (int i = 0; i < 10; i++)
            {
                IShape shape = ShapeFactory.CreateShape();
                if (shape.IsValid())
                {
                    double area = shape.CalculateArea();
                    totalArea += area;
                    Console.WriteLine($"Created {shape.GetType().Name} with area: {area}");
                }
                else
                {
                    Console.WriteLine("Invalid shape created.");
                }
            }

            Console.WriteLine($"Total area of all shapes: {totalArea}");
        }
    }
}