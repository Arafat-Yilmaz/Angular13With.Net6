using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace warehousebe.model
{
    public class Location
    {
        [Key,ForeignKey("Warehouse")]
        public int LocationId { get; set; }
        public int WarehouseId { get; set; }
        [Column("lat")]
        public string Lat { get; set; }
        [Column("long")]
        public string? LocationLong { get; set; }

        // Navigation Properties
        public virtual Warehouse?  Warehouse { get; set; }
    }
}
