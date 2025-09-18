namespace CircleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle();
            Circle circle2 = new Circle();

            circle1.radius = 5;
            circle2.radius = 6;

            Console.WriteLine(circle1.GetArea(circle1.radius));
            Console.WriteLine(circle2.GetArea(circle2.radius));
        }
    }

    class Circle
    {
        public int radius;

        public double GetArea(int radius)
        {
            double area = radius * radius * Math.PI;
            return area;
        }
    }
}
