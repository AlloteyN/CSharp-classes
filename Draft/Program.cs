using Draft;

namespace CoolBeans
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new("The Great Gatsby", "F. Scott Fitzgerald", 215);
            Student student1 = new ("Greg", 3.5);
            Student student2 = new ("Sam", 2.5);
            Console.WriteLine(book1.Title + " by " + book1.Author + " is " + 
                book1.Pages + " pages long.");
            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
            Console.WriteLine(Student.studentCount);

        }

       


    }
}
