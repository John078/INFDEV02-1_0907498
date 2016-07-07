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
using MySql.Data.MySqlClient;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string connString = "Server=localhost;Port = 3306;Database = project;Uid = root;password = Sita4ever;";
        MySqlConnection conn = new MySqlConnection(connString);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MySqlCommand command = new MySqlCommand("Select Perioden from project3 where ID = 2");
            MySqlDataReader reader;
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read());
                {
                    MessageBox.Show(reader["Perioden"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
