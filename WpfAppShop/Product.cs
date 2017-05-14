using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace WpfAppShop
{
    [Table(Name = "Products")]
    public class Product
    {
        [Column(Name ="ProductID")]
        public string ProductID { get; set; }
        [Column]
        public string ProductName { get; set; }
        [Column]
        public string Color { get; set; }
        [Column]
        public string Size { get; set; }
        [Column]
        public string Price { get; set; }
        [Column]
        public string Class { get; set; }
        [Column]
        public string SuplierID { get; set; }
    }
}
