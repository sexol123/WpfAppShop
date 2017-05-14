using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppShop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //SqlDataAdapter adapter ;
        //Data data;
        string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True";
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Data();
            //string sql = "SELECT * FROM Products";
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    Создаем объект DataAdapter
            //   SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            //    Создаем объект Dataset
            //   DataSet ds = new DataSet();
            //    Заполняем Dataset
            //    adapter.Fill(ds);
            //    Отображаем данные
            //    dataGridView1.ItemsSource = ds.Tables[0].DefaultView;
            //}

        }

        private void ButtonTest_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connektion = new SqlConnection(connectionString);
            try
            {
                connektion.Open();
                MessageBox.Show($"Connection: {connektion.State.ToString()}");
                connektion.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("ERORR " + ex.Message);
            }
            
        }

        private void ButtonB_Click(object sender, RoutedEventArgs e)
        {
            //Data d = new Data();
           // dataGridView1.ItemsSource = Data.Getti();
            
        }
    }
}
