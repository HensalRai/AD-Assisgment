namespace Exercise3
{
    internal class Rectangle
    {
        private float length;
        private float width;

        internal Rectangle(float length, float width)
        {
            this.length = length;
            this.width = width;
        }

        internal float CalculateArea()
        {
            return this.length * this.width;
        }

        static void Main(string[] args)
        {
            Rectangle rectangle = new(4.5f, 3.2f);
            float result=rectangle.CalculateArea();
            Console.WriteLine("The area of rectangle is:"+result);
        }
    }

   
}