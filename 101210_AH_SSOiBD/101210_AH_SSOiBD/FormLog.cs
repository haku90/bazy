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
namespace _101210_AH_SSOiBD
{

    public partial class FormLog : Form
    {
        public string connectionString;
        public MySqlConnection conn;
        public MySqlCommand cmd;
        public MySqlDataReader dr;

        public FormLog()
        {
            InitializeComponent();
            connectionString = "Server=" + tBip.Text + ";Database=101210_artykuly_spozywcze;Uid=" + tBuser.Text + ";Pwd=" + tBpass.Text + ";";


        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btConn_Click(object sender, EventArgs e)
        {
            
            //connectionString = String.Format("Server={0};Databases=SOB_test;Uid={1};Pwd={2}", tBip.Text, tBuser.Text, tBpass.Text);
           // connectionString = "Server=192.168.1.13;Database=SOB_test;Uid=sob;Pwd=kulka12;";
           
            try
            {
                conn = new MySqlConnection(connectionString);
                
                conn.Open();
                MessageBox.Show("udalo sie polaczyc z baza danych", "Info", MessageBoxButtons.OK);
                conn.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return;
            }
            
            FormMain fMain = new FormMain(this,connectionString,conn);
            this.Hide();
            fMain.Show();
            
        }
    }
}
