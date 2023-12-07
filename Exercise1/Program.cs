namespace Exercise1
{
    internal class Car
    {

        private string brand;
        private int year;
        private float price;


        public Car(string brand, int year, float price)
        {
            this.brand = brand;
            this.year = year;
            this.price = price;
        }


        public void PrintCarDetails()
        {
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine($"Price: ${price:F2}");
        }

        static void Main(string[] args)
        {

            Car myCar = new Car("Toyota", 2022, 25000.50f);

            //
            myCar.PrintCarDetails();
        }
    }
}


