using Microsoft.EntityFrameworkCore;

namespace HemläxaEgenDatabas3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbContext dbContext = new Homework3DBContext();

            // Add new car
            Car car = new Car()
            {
                Make = "Ferrari",
                Model = "F355",
                Year = 2000,
                Color = "Red"
            };
            dbContext.Add(car);

            // Add new boat
            Boat boat = new Boat()
            {
                Model = "Driftwood8",
                LengthInMeters = 4,
                Year = 2002,
                Color = "White"
            };
            dbContext.Add(boat);

            // Save changes
            dbContext.SaveChanges();
        }
    }
}
