using Microsoft.EntityFrameworkCore;
using warehousebe.model;

namespace warehousebe.Models
{
    public class VehicleContext:DbContext
    {
        public VehicleContext(DbContextOptions options) : base(options) { }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            ////One-to-one Warehouse-Car
            //modelBuilder.Entity<Warehouse>()
            //    .HasOne<Cars>(s => s.Cars)
            //    .WithOne(ad => ad.Warehouse)
            //    .HasForeignKey<Cars>(ad => ad.WarehouseId );


            ////One-to-one Warehouse-Location
            //modelBuilder.Entity<Warehouse>()
            //    .HasOne<Location>(s => s.Location)
            //    .WithOne(ad => ad.Warehouse)
            //    .HasForeignKey<Location>(ad =>  ad.WarehouseId );

            
            ////One-to-Many Car-Vehicle
            //modelBuilder.Entity<Vehicle>()
            //.HasOne<Cars>(s => s.Car)
            //.WithMany(g => g.Vehicles)
            //.HasForeignKey(s => s.WarehouseCarId);
        }

        public DbSet<Cars> Car { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Warehouse> Warehouse { get; set; }
    }
}
