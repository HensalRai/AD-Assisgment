namespace Exercise4
{
    internal class Shape
    {
        internal virtual double CalculateArea()
        {
            return 0;
        }
    }

    internal class Circle : Shape
    {
        private float radius;

        internal Circle(float radius)
        {
            this.radius = radius;
        }

        internal override double CalculateArea()
        {
            double area = 3.14 * (this.radius)*(this.radius);
            return area;
        }


        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            double area=circle.CalculateArea();
            Console.WriteLine("The area of circle is: "+area);

        }
    }

    
}