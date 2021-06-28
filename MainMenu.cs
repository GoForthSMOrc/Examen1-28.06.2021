using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
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
    //Окно главное меню//
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            getInfo(listView1);
        }
        //Функция вывода информации Окно главное меню//
        void getInfo(ListView List)
        {
            String query = "Select Personnel.Id_Personnel,Personnel.Name, Personnel.Tel, Personnel.email, Personnel.bio, Sex.Name,Education.Name,PositionPer.Name from Personnel join Sex on Personnel.id_Sex = Sex.Id_Sex join Education on Personnel.id_Education = Education.Id_Education join PositionPer on Personnel.id_PositionPer = PositionPer.Id_PositionPer;";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query,conn);
            MySqlDataReader rd;
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                if(rd.HasRows)
                {
                    while(rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetString(5), rd.GetString(6), rd.GetString(7) };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка");
                MessageBox.Show(ex.Message);
            }
        }

        //Кнопка поиск Окно Главное меню//
        private void FindButton_Click(object sender, EventArgs e)
        {
            if (fioBox.Text == "")
            {
                MessageBox.Show("Поле поиска должно быть заполнено");
            }
            else
            {
                listView1.Items.Clear();
                String query = "Select Personnel.Id_Personnel,Personnel.Name, Personnel.Tel, Personnel.email, Personnel.bio, Sex.Name,Education.Name,PositionPer.Name from Personnel join Sex on Personnel.id_Sex = Sex.Id_Sex join Education on Personnel.id_Education = Education.Id_Education join PositionPer on Personnel.id_PositionPer = PositionPer.Id_PositionPer where Personnel.name = '" + fioBox.Text + "';";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                MySqlDataReader rd;
                cmDB.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    rd = cmDB.ExecuteReader();
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetString(5), rd.GetString(6), rd.GetString(7) };
                            var listViewItem = new ListViewItem(row);
                            listView1.Items.Add(listViewItem);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Кнопка обновить список Окно главное меню//
        private void UpdateListButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            getInfo(listView1);
        }

        //Кнопка удалить запись Окно главное меню//
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (deleteBox.Text == "")
            {
                MessageBox.Show("Поле удаления должно быть заполнено");
            }
            else
            {
                String query = "Delete from Personnel where Id_Personnel = '" + deleteBox.Text + "';";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                MySqlDataReader rd;
                cmDB.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    rd = cmDB.ExecuteReader();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        
       
        //Кнопка добавить новую запись Окно главное меню//
        private void AddNewRecordWinButton_Click(object sender, EventArgs e)
        {
            AddNewRecord win = new AddNewRecord();
            win.Show();
            this.Hide();
        }

        //Кнопка выйти Окно главное меню//
        private void OutButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Кнопка добавить нового пользователя Окно главное меню//
        private void NewUserWinButton_Click(object sender, EventArgs e)
        {
            AddNewUser win = new AddNewUser();
            win.Show();
            this.Hide();
        }
    }
}
