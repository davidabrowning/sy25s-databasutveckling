namespace HemläxaEgenDatabas2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DemoDatabas2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False

            TVShowDBContext dbContext = new TVShowDBContext();
            TVShow show = new TVShow("Hannibal", "Amazon");

            //dbContext.Add(show);
            //dbContext.SaveChanges();

            List<TVShow> shows = dbContext.TVShows.ToList<TVShow>();
            foreach (TVShow tvshow in shows)
                Console.WriteLine(tvshow);
        }
    }
}
