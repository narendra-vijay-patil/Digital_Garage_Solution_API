using Digital_Garage_Solutions_API.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace Digital_Garage_Solutions_API.DBCONTEXT
{
    public class DataBase : DbContext
    {
        public DataBase(DbContextOptions<DataBase> option) : base(option) {}


        public DbSet<login_model> login { get; set; }
        public DbSet<CarServiceBooking> CarServiceBookings { get; set; }
        public DbSet<HomeMechanicBooking> HomeMechanicBookings { get; set; }
        public DbSet<DiagnosticsBooking> DiagnosticsBookings { get; set; }
    }
}
