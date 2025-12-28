using Digital_Garage_Solutions_API.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace Digital_Garage_Solutions_API.DBCONTEXT
{
    public class DataBase:DbContext
    {
        public DataBase(DbContextOptions<DataBase> option):base(option) { }

        public DbSet<GarageRegistratioinDbModel> GarageRegistration { get; set; }


    }

   
}
