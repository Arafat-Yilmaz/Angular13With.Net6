using warehousebe.model;

namespace warehousebe.Service.Abstract
{
    public interface IWarehouseService
    {
        List<Vehicle> GetVehicleList();
        Vehicle GetVehicle(int id);
        void AddWarehouseList(List<Warehouse> warehouseList);

    }
}
