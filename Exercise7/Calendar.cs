namespace Exercise7
{
    internal class Calendar
    {
        enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        internal void PrintDaysOfWeek()
        {
            foreach (DaysOfWeek days in Enum.GetValues(typeof(DaysOfWeek)))
            {
                if (days>=DaysOfWeek.Monday && days<= DaysOfWeek.Friday){
                    Console.WriteLine(days);
                }
            }
        }
        static void Main(string[] args)
        {
            Calendar cal = new();
            cal.PrintDaysOfWeek();
        }
    }
}