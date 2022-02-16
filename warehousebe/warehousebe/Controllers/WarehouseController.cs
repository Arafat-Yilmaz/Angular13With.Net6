using Microsoft.AspNetCore.Mvc;
using warehousebe.model;
using warehousebe.Models;
using warehousebe.Service.Abstract;
using warehousebe.Service.Concrete;

namespace warehousebe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WarehouseController : ControllerBase
    {
        private IWarehouseService _ws;
        public WarehouseController(IWarehouseService ws)
        {
            _ws = ws;

        }
        [HttpPost("warehouse")]
        public void AddWarehouseList([FromBody]List<Warehouse> warehouseList )
        {
            _ws.AddWarehouseList(warehouseList);

        }
        [HttpGet("warehouse/{id}")]
        public Vehicle GetLicensedVehicles(int id)
        {
            return _ws.GetVehicle(id);
        }
        [HttpGet("warehouse")]
         public List<Vehicle> GetAllVehicles()
        {
            List<Vehicle> listOfWarehouse = _ws.GetVehicleList();

            return listOfWarehouse;
        }
        
    }
}

