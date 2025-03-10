namespace EFCoreInstall
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DemoDatabas;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False

            //Student s1 = new Student() { 
            //    Name = "John Doe", 
            //    City = "Hudiksvall" 
            //};

            List<Student> students = new List<Student>();
            // students.Add(s1);

            StudentDbContext dbCtx = new StudentDbContext();
            //dbCtx.Students.Add(s1);
            //dbCtx.SaveChanges();

            foreach (Student student in dbCtx.Students)
            {
                Console.WriteLine(student.Name);
            }

            // Hämta första student
            Console.WriteLine(dbCtx.Students.FirstOrDefault<Student>().Name);

            // Hämta student WHERE
            Console.WriteLine(dbCtx.Students.Where(s => s.Name.Contains("John")).First<Student>().Name);

            // Hämta och uppdatera student
            //Student john = dbCtx.Students.Where(s => s.Name.Contains("John")).First<Student>();
            //john.City = "Umeå";
            //dbCtx.SaveChanges();

            // Uppdatera Fredriks ålder
            //Student fredrik = dbCtx.Students.Where(s => s.StudentId == 1).First<Student>();
            //fredrik.Age = 50;
            //dbCtx.SaveChanges();

            // Uppdatera Fredrik och Johns telefonnummer
            Student fredrik = dbCtx.Students.Where(s => s.StudentId == 1).First<Student>();
            fredrik.PhoneNumber = 0735555555;
            Student john = dbCtx.Students.Where(s => s.StudentId == 2).First<Student>();
            john.PhoneNumber = 0738888888;
            dbCtx.SaveChanges();
        }
    }
}
