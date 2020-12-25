using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        OleDbConnection connection = new OleDbConnection("Provider=MSOLEDBSQL;Server=DESKTOP-63SM79K;Database=ParaniYonet;Trusted_Connection=Yes;");

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadUsers();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            AddUser();
        }

        private void b_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchByName();
        }

        private void SearchByName()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter =
                new OleDbDataAdapter("SELECT * FROM Users WHERE FirstName LIKE '%" + tbx6.Text + "%'", connection);
            adapter.Fill(dt);
            dgw1.DataContext = dt;
            adapter.Dispose();
        }

        private void LoadUsers()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Users", connection);
            adapter.Fill(dt);
            dgw1.DataContext = dt;
            adapter.Dispose();
        }


        private void AddUser()
        {
            OleDbCommand addUser = new OleDbCommand("INSERT INTO Users (FirstName,LastName,Email,Password,GSM) VALUES(?,?,?,?,?)", connection);
            addUser.Parameters.AddWithValue("@FirstName", tbx1.Text);
            addUser.Parameters.AddWithValue("@LastName", tbx2.Text);
            addUser.Parameters.AddWithValue("@Email", tbx3.Text);
            addUser.Parameters.AddWithValue("@Password", tbx4.Text);
            addUser.Parameters.AddWithValue("@GSM", Convert.ToInt64(tbx5.Text));

            connection.Open();
            addUser.ExecuteNonQuery();
            addUser.Dispose();
            LoadUsers();
            connection.Close();
        }

        
    }

    
}
