using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVAProdavnica.Data
{
    [Table("cars")]
    public class Car : Base
    {
        [Column("manufacturer")]
        public string Manufacturer { get; set; }
        
        [Column("modelName")]
        public string ModelName { get; set; }
        
        public enum CarType {Coupe, Limousine , SUV}

        [Column("countrOfOrigin")]
        public string CountryOfOrigin { get; set; }

        [Column("yearProduction")]
        public int YearOfProduction { get; set; }
        
        [Column("price")]
        public double Price { get; set; }

    }
}
