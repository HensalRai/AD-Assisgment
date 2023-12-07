namespace Exercise8
{
    internal struct Point2D
    {
        internal float x; 
        internal float y;

         static float CalculateDistance(Point2D p1, Point2D p2)
        {
            float distance= (float)Math.Sqrt(Math.Pow((p1.x - p2.x),2)+Math.Pow(p1.y-p2.y,2));
            return distance;
        }
        static void Main(string[] args)
        {
            Point2D pointA = new Point2D { x = 3, y = 4 };
        Point2D pointB = new Point2D { x = 6, y = 8 };


            float distance=CalculateDistance(pointA, pointB);
            Console.WriteLine("Distance between pointA and pointB: "+distance);
        }
    }
}