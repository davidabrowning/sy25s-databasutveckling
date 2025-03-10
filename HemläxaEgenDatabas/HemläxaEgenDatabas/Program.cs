namespace HemläxaEgenDatabas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DemoDatabas;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
            DavidStudentDBContext dbContext = new DavidStudentDBContext();
            Student fredrik = dbContext.Students.Where(s => s.Name.Contains("Fredrik")).First<Student>();
            Console.WriteLine(fredrik.Name);
        }
    }
}
