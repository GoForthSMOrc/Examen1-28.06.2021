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
    //Окно добавить новую запись//
    public partial class AddNewRecord : Form
    {
        public AddNewRecord()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Кнопка добавить новую запись Окно добавить новую запись//
        private void AddNewRecordButton_Click(object sender, EventArgs e)
        {
            if (newfioBox.Text == "" || newphoneBox.Text == "" || newemailBox.Text == "" || neweducationBox.Text == "" || newbioBox.Text == "" || newsexBox.Text == "" || newpositionBox.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены");
            }
            else
            {
                String query = "insert into Personnel(Name,Tel,email,bio,id_Sex,id_Education,id_PositionPer) values ('" + newfioBox.Text + "','" + newphoneBox.Text + "','" + newemailBox.Text + "','" + newbioBox.Text + "','" + newsexBox.Text + "','" + neweducationBox.Text + "','" + newpositionBox.Text + "');";
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

        //Кнопка возвращения в главное меню Окно добавить новую запись//
        private void ToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu win = new MainMenu();
            win.Show();
            this.Hide();
        }
    }
}
