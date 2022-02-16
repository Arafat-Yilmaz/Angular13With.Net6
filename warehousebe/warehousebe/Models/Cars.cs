using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace warehousebe.model
{
     public class Cars
    {


        [Key,ForeignKey("WarehouseId")]
        public int CarId { get; set; }
        public int WarehouseId { get; set; }
        [Column("location")]
        public string Location { get; set; }

        //navigation Properties

        [Column("vehicles")]
        public virtual ICollection<Vehicle> Vehicles { get; set; }
        public virtual Warehouse? Warehouse { get; set; }
    }
}
