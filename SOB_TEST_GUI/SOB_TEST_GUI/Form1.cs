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
namespace SOB_TEST_GUI
{
    public partial class Form1 : Form
    {
        public string ConnecitonString = "Server=192.168.1.15;Database=SOB_test;Uid=sob;Pwd=sob12;";
   
        public MySqlConnection conn;
        public MySqlCommand cmd;
        public MySqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection(ConnecitonString);
            cmd = new MySqlCommand("", conn);
            dataGridView1.Columns.Add("id","id");
            dataGridView1.Columns.Add("name","name");
            dataGridView1.Columns.Add("age", "age");

        }
        public  bool refresh() 
        {
            listBox1.Items.Clear();
           
                
                try
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM test";
                    

                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string thisrow = "";
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            thisrow += dr.GetValue(i).ToString() + " ";
                     
                        }
                            listBox1.Items.Add(thisrow);
                            
                    }
            
                    conn.Close();
                    return true;
                }
                catch (MySqlException expsql2)
                {
                    MessageBox.Show(String.Format("nie udalo sie pobrac danych, blad{0}", expsql2), "Pobieranie danych", MessageBoxButtons.OK);

                    return false;
                }
            
            
            
        }
        public bool dodaj() 
        {
            try
            {
                conn.Open();
                cmd.CommandText = "insert into test(id,name,age) value('" + tBid.Text + "','" + tBname.Text + "','" + tBage.Text + "')";
                cmd.ExecuteNonQuery();
                conn.Close();
                refresh();
                return true;
            }
            catch (MySqlException expsql3) 
            {
                MessageBox.Show(String.Format("Błąd {0}", expsql3),"Info", MessageBoxButtons.OK);
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            

               if( refresh())
               MessageBox.Show("polaczona z baza danych", "połaczenie", MessageBoxButtons.OK); 

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                if (tBage.Text == "" | tBname.Text == "" | tBid.Text == "")
                {
                    MessageBox.Show("wszystkie pola musza zostać wypełnione", "błąd", MessageBoxButtons.OK);
                    return;
                }
                
              if(dodaj())  
                MessageBox.Show("Rekord zostal dodanny");
        
        }

        private void ączToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
