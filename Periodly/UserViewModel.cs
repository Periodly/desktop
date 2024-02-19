//using MySql.Data.MySqlClient;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Periodly
{
    public class UserViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<User> _users;

        public ObservableCollection<User> Users
        {
            get { return _users; }
            set
            {
                _users = value;
                OnPropertyChanged("Users");
            }
        }

        public UserViewModel()
        {
            LoadUsers(); // Load users from database
        }

        private void LoadUsers()
        {
            string connectionString = "Server=yourServerAddress;Database=yourDatabase;Uid=yourUsername;Pwd=yourPassword;";

            /*using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT Id, Name, Surname, RoleId FROM Users";

                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        Users = new ObservableCollection<User>();
                        while (reader.Read())
                        {
                            Users.Add(new User
                            {
                                Id = reader.GetInt32("Id"),
                                Name = reader.GetString("Name"),
                                Surname = reader.GetString("Surname"),
                                RoleId = reader.GetInt32("RoleId")
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }*/
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
