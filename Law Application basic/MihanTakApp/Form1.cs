using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace MihanTakApp
{
    public partial class Main : Form
    {
        
        SqlConnection conn = new SqlConnection("Data Source=KIARASH; initial catalog=MihanTak;Integrated Security=SSPI");
        SqlCommand command;
        public Main()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mihanTakDataSet.info' table. You can move, or remove it, as needed.
            this.infoTableAdapter.Fill(this.mihanTakDataSet.info);

        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into info(PersianName,EnglishName,PersianLName,EnglishLName,UserCode,PassCode,EmailAddress,EmailPass) values('" + textBoxPN.Text + "','" + textBoxEN.Text + "','" + textBoxPLN.Text + "', '" + textBoxELN.Text + "','" + textBoxUC.Text + "','" + textBoxP.Text + "','" + textBoxE.Text + "','" + textBoxEP.Text + "')";
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                command = new SqlCommand(sql, conn);
                int x = command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(x.ToString() + "Records saved!");
                textBoxE.Text = "";
                textBoxELN.Text = "";
                textBoxEN.Text = "";
                textBoxEP.Text = "";
                textBoxP.Text = "";
                textBoxPLN.Text = "";
                textBoxPN.Text = "";
                textBoxUC.Text = "";

            }
            catch(Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message); }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                
                    string sql = "select PersianName,EnglishName,PersianLName,EnglishLName,UserCode,PassCode,EmailAddress,EmailPass from info where UserCode='" + textBoxUC.Text + "' or EnglishName = '" + textBoxEN.Text + "' or EnglishLName ='" + textBoxELN.Text + "'";
                
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    command = new SqlCommand(sql, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        textBoxPN.Text = reader[0].ToString();
                        textBoxEN.Text = reader[1].ToString();
                        textBoxPLN.Text = reader[2].ToString();
                        textBoxELN.Text = reader[3].ToString();
                        textBoxUC.Text = reader[4].ToString();
                        textBoxP.Text = reader[5].ToString();
                        textBoxE.Text = reader[6].ToString();
                        textBoxEP.Text = reader[7].ToString();


                    }
                    else
                    { MessageBox.Show("This Record Does not Exsit"); }
                    conn.Close();
                
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBoxE.Text = "";
            textBoxELN.Text = "";
            textBoxEN.Text = "";
            textBoxEP.Text = "";
            textBoxP.Text = "";
            textBoxPLN.Text = "";
            textBoxPN.Text = "";
            textBoxUC.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
        }

        private void searchNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.infoTableAdapter.SearchName(this.mihanTakDataSet.info, englishNameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.infoTableAdapter.FillBy(this.mihanTakDataSet.info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
