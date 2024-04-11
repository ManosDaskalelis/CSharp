using HelloOOPApp;

namespace HelloOOApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student alice = new Student();
            //Student Bob = new();            // C# 9.0 και μετά
            var costas = new Student();     // C# 3.0 και μετά

            alice.Id = 1;
            alice.Firstname = "ALice";
            alice.Lastname = "W.";

            Console.WriteLine($"{alice.Id}");
            Console.WriteLine($"{alice.Firstname}");
            Console.WriteLine($"{alice.Lastname}");

            Student bob = new()
            {
                Id = 2,
                Firstname = "Bob",
                Lastname = "D."
            };

            Student dylan = new Student(2, "Dylan", "S.");

            Course course = new Course(1, "Java", "Java Programming");
            Course course1 = new()
            {
                Id = 4,
                ShortTitle = "SQL",
                Title = "Structured Query Language"
            };

            //course.Title = " ";

            School school1 = new(1, "ΙΕΚ Αγ. Αναργύρων", SchoolType.IEK);
            School school2 = new(1, "ΙΕΚ Αγ. Αναργύρων", SchoolType.IEK);

            if (school1 == school2)
            {
                Console.WriteLine("EQUALS");
            }
            else
            {
                Console.WriteLine("NOT EQUALS");
            }
        }
    }
}