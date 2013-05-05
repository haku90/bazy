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

            sql = "select *from artykuly";
            connAndRead(sql);
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
                            sql = "update artykuly SET nazwa='"+tBnazwa.Text+"',ilosc="+tBilosc.Text+",kubatura='"+tBkubatura.Text+"'where lp="+tBlp.Text+";";
                            
                        }
                        connAndExecute(sql);
                        sql = "Select *from artykuly";
                        connAndRead(sql);
                        clearTb();
                        cbEdit.Checked = false;
                    }
                }
            }
            else 
            {
                MessageBox.Show("Nalezy wypelnic nazwa,ilosc,kubatura");
            }
        }
        public void connAndRead(string sql)
        {
            string ans = sql;
            listBox1.Items.Clear();
            try
            {
                conn.Open();
                cmd.CommandText = ans;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string thisrow = "";
                    for (int i = 0; i < dr.FieldCount; i++)
                        thisrow += dr.GetValue(i).ToString() + " ";
                    listBox1.Items.Add(thisrow);
                }
                conn.Close();
             
            }
            catch (MySqlException exp)
            {
                conn.Close();
                MessageBox.Show(exp.Message);
            }

        }
        public void connAndExecute(string ans) 
        {
            try
            {
                conn.Open();
                cmd.CommandText = ans;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btDelete_Click(object sender, EventArgs e)
        {
            sql = "delete from artykuly where lp=" + tBlp.Text + ";";
            connAndExecute(sql);
            sql = "select *from artykuly";
            connAndRead(sql);
            clearTb();
            cbEdit.Checked = false;

        }
        public void clearTb()
        {
            tBilosc.Text = "";
            tBkubatura.Text = "";
            tBlp.Text = "";
            tBnazwa.Text = "";
        }

        private void cbEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEdit.Checked==true)
                tBlp.ReadOnly = true;
            else
                tBlp.ReadOnly = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cbIlosc.Checked == true)
            {
                if (cbNazwa.Checked == true)
                {
                    sql = "select *from artykuly order by ilosc,nazwa;";
                }
                else
                    sql = "select *from artykuly order by ilosc;";
               
            }
            else 
            {
                if (cbNazwa.Checked == true)
                    sql = "select *from artykuly order by nazwa;";
                else
                {
                    MessageBox.Show("Wybierz po jakim atrybucie chcesz sortowac");
                    return;
                }
            }
            connAndRead(sql);
        }
    }
}
