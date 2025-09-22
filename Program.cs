namespace CircleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle();
            Circle circle2 = new Circle();

            circle1.Radius = 5;
            circle2.Radius = 6;

            Console.WriteLine($"The area for circle 1 is: {circle1.GetArea(circle1.Radius)}");
            Console.WriteLine($"The area for circle 2 is: {circle2.GetArea(circle2.Radius)}");
        }
    }

    public class Circle
    {
        public int Radius {get; set;}

        public double GetArea(int radius)
        {
            double area = radius * radius * Math.PI;
            return Math.Round(area, 3);
        }
    }
}
