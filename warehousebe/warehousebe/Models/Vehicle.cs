using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace warehousebe.model
{
    public class Vehicle
    {
        [Key,ForeignKey("CarId")]
        [Column("_id")]
        public int VehicleId { get; set; }
        public int CarId { get; set; }
        [Column("make")]
        public string Make { get; set; }
        [Column("model")]
        public string Model { get; set; }
        [Column("year_model")]
        public int YearModel { get; set; }
        [Column("price")]
        public double Price { get; set; }
        [Column("licensed")]
        public bool Licensed { get; set; }
        [Column(TypeName ="Date")]
        public DateTime date_added { get; set; }
        
        public virtual Cars? Car { get; set; }
    }
}
