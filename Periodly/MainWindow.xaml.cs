using System;
using System.Collections.Generic;
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

using System.Data;
// using MySql.Data.MySqlClient;

namespace Periodly
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string login;
        string password;

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            login = loginTB.Text;
            password = passwordPB.Password.ToString();


            if (login != "" && password != "")
            {
                // getting data from database
                string connectionString = "Server=localhost;Database=your_database_name;Uid=your_username;Pwd=your_password;";

                /*using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "SELECT login, password FROM users WHERE login='" + login + "' AND password='" + password + "'";
                        MySqlCommand command = new MySqlCommand(query, connection);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);

                            dataGrid.ItemsSource = dataTable.DefaultView;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }*/

                // redirecting into adminpanel window
                AdminPanel ap = new AdminPanel();
                ap.Show();
                this.Close();
            } else
            {
                MessageBox.Show("Uzupelnij wszystkie pola!");
            }
            
        }
    }
}
