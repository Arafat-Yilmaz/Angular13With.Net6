using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace warehousebe.model
{
    public class Warehouse
    {
        [Key]
        [Column("_id")]
        public int WarehouseId { get; set; }
        [Column("name")]
        public string Name { get; set; }

        //navigation Properties

        [Column("location")]
        public virtual Location Location { get; set; }

        [Column("cars")]
        public virtual Cars Cars { get; set; }

    }
}
