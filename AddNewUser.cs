using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace BestKADR
{
    public partial class AddNewUser : Form
    {
        public AddNewUser()
        {
            InitializeComponent();
        }

        //Кнопка добавить Окно добавить нового пользователя//
        private void AddNewUserButton_Click(object sender, EventArgs e)
        {
            if (newlogBox.Text == "" || newpassBox.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены");
            }
            else
            {
                String query = "insert into UsersDB (Login,Password) values ('" + newlogBox.Text + "','" + newpassBox.Text + "');";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                MySqlDataReader rd;
                try
                {
                    conn.Open();
                    rd = cmDB.ExecuteReader();
                    MessageBox.Show("Запись успешно добавлена");
                    MainMenu win = new MainMenu();
                    win.Show();
                    this.Hide();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка ввода");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Кнопка возвращения в главное меню Окно Добавить нового пользователя//
        private void ToMainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu win = new MainMenu();
            win.Show();
            this.Close();
        }
    }
}
