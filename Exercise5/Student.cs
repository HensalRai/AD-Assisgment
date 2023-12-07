namespace Exercise5
{
    internal class Student
    {
        private string name;
        private int age;
        private string major;

        internal Student(string name, int age, string major)
        {
            this.name = name;
            this.age = age;
            this.major = major;
        }

        internal void Introduce()
        {
            Console.WriteLine("Name:"+this.name+"\nAge:"+this.age+"\nMajor:"+this.major);
        }

        static void Main(string[] args)
        {
            Student st = new("John Doe", 20, "Computer Science");
            st.Introduce();
        }
    }
}