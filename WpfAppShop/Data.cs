using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using System.Data;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfAppShop
{
    public class Data : INotifyPropertyChanged
    {
        public static string connectionString { get; set; } = @"Data Source = (LocalDb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True";
        public Table<Product> TProd
        {
            get => tProd; set
            {
                tProd = value;
                OnPropertyChanged("TProd");
            }

        }

        private void OnPropertyChanged([CallerMemberName]string v = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(v));
        }

        public Table<Order> TOrder
        {
            get => tOrder; set
            {
                tOrder = value;
                OnPropertyChanged("TOrder");
            }
        }

        public Table<OrderDetail> TOD { get => tOD; set => tOD = value; }
        public Table<Customer> TCust { get => tCust; set => tCust = value; }
        public Table<Suplier> TSup { get => tSup; set => tSup = value; }

        Table<Product> tProd;
        Table<Order> tOrder;
        Table<OrderDetail> tOD;
        Table<Customer> tCust;
        Table<Suplier> tSup;

        public event PropertyChangedEventHandler PropertyChanged;

        public Data()
        {

            DataContext dk = new DataContext(connectionString);

            TOrder = dk.GetTable<Order>();
            TProd = dk.GetTable<Product>();
            TOD = dk.GetTable<OrderDetail>();
            TCust = dk.GetTable<Customer>();
            TSup = dk.GetTable<Suplier>();
        }

    }
    #region Product
    [Table(Name = "Products")]
    public class Product
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true, Name = "ProductID")]
        public int Id { get; set; }
        [Column(Name = "ProductName")]
        public string Name { get; set; }
        [Column(Name = "SupplierID")]
        public int SuplierID { get; set; }
        [Column]
        public int CategoryID { get; set; }
        [Column]
        public string QuantityPerUnit { get; set; }
        [Column]
        public decimal UnitPrice { get; set; }
        [Column]
        public short UnitsInStock { get; set; }
        [Column]
        public short UnitsOnOrder { get; set; }
        [Column]
        public short ReorderLevel { get; set; }
        [Column]
        public bool Discontinued { get; set; }


    }
    #endregion
    #region Order
    [Table(Name = "Orders")]
    public class Order
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int OrderID { get; set; }
        [Column]
        public string CustomerID { get; set; }
        [Column]
        public int EmployeeID { get; set; }
        [Column(CanBeNull = false)]
        public DateTime OrderDate { get; set; }
        [Column(CanBeNull = false)]
        public DateTime RequiredDate { get; set; }
        //[Column]
        public DateTime ShippedDate { get; set; }
        [Column]
        public int ShipVia { get; set; }
        [Column]
        public decimal Freight { get; set; }
        [Column]
        public string ShipName { get; set; }
        [Column]
        public string ShipAddress { get; set; }
        [Column]
        public string ShipCity { get; set; }

        [Column]
        public string ShipRegion { get; set; }
        [Column]
        public string ShipPostalCode { get; set; }
        [Column]
        public string ShipCountry { get; set; }


    }
    #endregion
    #region OrderDetail
    [Table(Name = "Order Details")]
    public class OrderDetail
    {
        [Column]
        public int OrderID { get; set; }
        [Column]
        public int ProductID { get; set; }
        [Column]
        public decimal UnitPrice { get; set; }
        [Column]
        public short Quantity { get; set; }
        [Column]
        public float Discount { get; set; }
    }
    #endregion
    #region Customers
    [Table(Name = "Customers")]
    public class Customer
    {
        [Column]
        public string CustomerID { get; set; }
        [Column]
        public string CompanyName { get; set; }
        [Column]
        public string ContactName { get; set; }
        [Column]
        public string ContactTitle { get; set; }
        [Column]
        public string Address { get; set; }
        [Column]
        public string City { get; set; }
        [Column]
        public string Region { get; set; }
        [Column]
        public string PostalCode { get; set; }
        [Column]
        public string Country { get; set; }
        [Column]
        public string Phone { get; set; }
        [Column]
        public string Fax { get; set; }
    }
    #endregion
    #region Suplier
    [Table(Name ="Suppliers")]
    public class Suplier
    {
        [Column]
        public int SupplierID { get; set; }
        [Column]
        public string CompanyName { get; set; }
        [Column]
        public string ContactName { get; set; }
        [Column]
        public string ContactTitle { get; set; }
        [Column]
        public string Address { get; set; }
        [Column]
        public string City { get; set; }
        [Column]
        public string Region { get; set; }
        [Column]
        public string PostalCode { get; set; }
        [Column]
        public string Country { get; set; }
        [Column]
        public string Phone { get; set; }
        [Column]
        public string Fax { get; set; }
        [Column]
        public string HomePage { get; set; }
    }
#endregion
}
 
