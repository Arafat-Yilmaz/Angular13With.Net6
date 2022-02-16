using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using warehousebe.model;
using warehousebe.Models;
using warehousebe.Service.Abstract;

namespace warehousebe.Service.Concrete
{
    public class WarehouseService : IWarehouseService
    {

        protected VehicleContext _context;
        public WarehouseService(VehicleContext context)
        {
            _context = context;
        }


        public List<Vehicle> GetVehicleList()
        {
            List<Vehicle> listOfVehicle = new List<Vehicle>();
            var warehouses = _context.Warehouse
        .Join(
            _context.Car,
            warehouse => warehouse.WarehouseId,
            car => car.Warehouse.WarehouseId,
            (warehouse, car) => new
            {
                carId = car.CarId,
                listOfVehicle = car.Vehicles,
                warehouseName = warehouse.Name,
            }
        );
            foreach (var car in warehouses)
            {
                foreach (var vehicle in car.listOfVehicle)
                {
                    listOfVehicle.Add(vehicle);

                }
            
            }
            listOfVehicle.Sort((Vehicle x, Vehicle y) => x.date_added.CompareTo(y.date_added));
            return listOfVehicle;

        }

        public Vehicle GetVehicle(int id)
        {
            return _context.Vehicle.Find(id);
        }

        public void AddWarehouseList(List<Warehouse> warehouseList)
        {
           
            _context.Warehouse.AddRange(warehouseList);
            _context.SaveChanges();
        }
    }
}
