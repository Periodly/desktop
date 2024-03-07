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
using System.Windows.Shapes;
//using MySql.Data.MySqlClient;

namespace Periodly
{
    /// <summary>
    /// Logika interakcji dla klasy AddUserPanel.xaml
    /// </summary>
    public partial class AddUserPanel : Window
    {
        public AddUserPanel()
        {
            InitializeComponent();
        }

        string name;
        string surname;

        private void addUserBtn_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "Server=localhost;Database=your_database_name;Uid=your_username;Pwd=your_password;";

            /*using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                name = nameTB.Text;
                surname = surnameTB.Text;

                try
                {
                    connection.Open();
                    string query = "INSERT INTO users (name, surname) VALUES (@Name, @Surname)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", name);
                    command.Parameters.AddWithValue("@Email", surname);
                    command.ExecuteNonQuery();

                    MessageBox.Show("User added successfully!");

                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }*/
        }

        private void Back_To_Users_Button_Click(object sender, RoutedEventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Close();
        }
    }
}
