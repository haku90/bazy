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
    public partial class FormMain : Form
    {
        public FormLog form;

        public string conString;
        public MySqlConnection conn;
        public MySqlDataReader dr;
        public MySqlCommand cmd;
        public string sql;

        public FormMain(FormLog form,string conString,MySqlConnection conn)
        {
            this.form = form;
            this.conString = conString;
            this.conn = conn;
            cmd = new MySqlCommand("", conn);
            
            
            InitializeComponent();
          

            connAndRead();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {

          
            Close();
            form.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void polaczToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
           form.Show();
        }

        private void btDodaj_Click(object sender, EventArgs e)
        {
            if (tBnazwa.Text != "")
            {
                if (tBkubatura.Text != "")
                {
                    if (tBilosc.Text != "")
                    {
                        if (cbEdit.Checked == false)
                        {
                            sql = "insert into artykuly Values (" + tBlp.Text + ",'" + tBnazwa.Text + "'," + tBilosc.Text + ",'" + tBkubatura.Text + "');";
                        }
                        else
                        {
                            sql = "";
                            //UPDATE ksiazka_adresowa SET adres = 'ul. Krakowska 16' WHERE id = 2;
                        }
                        connAndExecute(sql);
                        connAndRead();
                    }
                }
            }
            else 
            {
                MessageBox.Show("Nalezy wypelnic nazwa,ilosc,kubatura");
            }
        }
        public void connAndRead()
        {
            sql = sql = "SELECT * FROM artykuly";
            listBox1.Items.Clear();
            try
            {
                conn.Open();
                cmd.CommandText = sql;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string thisrow = "";
                    for (int i = 0; i < dr.FieldCount; i++)
                        thisrow += dr.GetValue(i).ToString() + " ";
                    listBox1.Items.Add(thisrow);
                }
                conn.Close();
                MessageBox.Show("odswiezono lokalna baze danych");
            }
            catch (MySqlException exp)
            {
                conn.Close();
                MessageBox.Show(exp.Message);
            }

        }
        public void connAndExecute(string ans) 
        {
            conn.Open();
            cmd.CommandText = ans;
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Rekord zmieniony/dodany");
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = listBox1.SelectedItem.ToString();
            string[] aray = select.Split();
            tBlp.Text = aray[0];
            tBnazwa.Text = aray[1];
            tBilosc.Text = aray[2];
            tBkubatura.Text = aray[3];
            cbEdit.Checked = true;

        }
    }
}
