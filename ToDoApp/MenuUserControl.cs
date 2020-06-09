using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzaApp;
using MySql.Data.MySqlClient;

namespace ToDoApp
{
    public partial class MenuUserControl : UserControl
    {
        DB database = new DB();
        public MenuUserControl()
        {
            InitializeComponent();
            database.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `orders`", database.ConnectToMysql());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            database.closeConnection();
        }

        private void MenuUserControl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form modalForm = new ModalFormAddToCart();
            modalForm.ShowDialog();
            //modalForm.ShowDialog();
        }
    }
}
