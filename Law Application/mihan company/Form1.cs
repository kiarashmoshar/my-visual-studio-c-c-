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

namespace mihan_company
{
    public partial class Form1 : Form
    {
        SqlConnection conn= new SqlConnection("Data Source=KIARASH; initial catalog=MihanCo;Integrated Security=SSPI");
        SqlCommand command;
        string imgLoc = "";
        string imgLoc2 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            try
            { OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "jpg files (*.jpg) | *.jpg |GIF files (*.gif)| *.gif| all files (*.*)|*.*";
                dlg.Title = "Select customer picture";
                if(dlg.ShowDialog()==DialogResult.OK)
                { imgLoc = dlg.FileName.ToString();
                    picCustomer.ImageLocation = imgLoc;
                }

            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;
                byte[] img2 = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open , FileAccess.Read);
                FileStream fs2 = new FileStream(imgLoc2, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                BinaryReader br2 = new BinaryReader(fs2);
                img = br.ReadBytes((int)fs.Length);
                img2 = br2.ReadBytes((int)fs2.Length);
                
                string sql = " INSERT INTO PermanentCustomer(Name,[Last Name],[Father Name],[Passport Number],Sh_ID ,I_ID,Email,[Phone Number], [Address], [Attorney In Iran], [Application Text] ,[Application Title Code],[Customer picture],[Date of recieving the power of attorney in Iran],[Samane Tak Date of sending Power Of Attorney to embassy] ,[Total Payment] ,[Total Paid],[Iran Case Status],[USA Case Status],deed,[birth certificate],[Iranian Passport],[American Passport],[picture],[Mariage Certificate],[Divorce Certificate],[Any judgment],Balance,AplicationImage)Values('" + textBoxFN.Text + "', '" + textBoxLN.Text + "','" + textBoxFatherN.Text + "','" + textBoxPN.Text + "','" + textBoxBCN.Text + "' ,'" + textBoxIDN.Text + "','" + textBoxEmail.Text + "','" + textBoxPhoneN.Text + "', '" + textBoxAddress.Text + "',  '" + textBoxAI.Text + "', '"+richTextBoxAT.Text+"', '"+textBoxATC.Text+"',@img, '" + dateTimePickerDRPAI.Text + "','" + dateTimePickerSTDSPAE.Text + "','" + textBoxTPayments.Text + "','" + textBoxTPaid.Text + "','" + textBoxICS.Text + "','" + textBoxUCS.Text + "','" + checkBoxD.Checked + "','" + checkboxBC.Checked + "','" + checkBoxIP.Checked + "','" + checkBoxAP.Checked + "','" + checkBoxP.Checked + "','" + checkBoxMC.Checked + "','" + checkBoxDC.Checked + "','" + checkBoxAnyJ.Checked + "','"+ textBoxbalance.Text+ "',@img2)";
                if (conn.State != ConnectionState.Open)
                    conn.Open();
               
                command = new SqlCommand(sql, conn);
              
                command.Parameters.Add(new SqlParameter("@img",img));
                command.Parameters.Add(new SqlParameter("@img2", img2));
// MessageBox.Show(sql);
                int x = command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(x.ToString() + "Records saved!");
                textBoxFN.Text = "";
                textBoxLN.Text = "";
                textBoxFatherN.Text = "";
                textBoxPN.Text = "";
                textBoxBCN.Text = "";
                textBoxIDN.Text = "";
                textBoxEmail.Text = "";
                textBoxPhoneN.Text = "";
                textBoxAddress.Text = "";
                textBoxAI.Text = "";
                richTextBoxAT.Text = "";
                textBoxATC.Text = "";
                picCustomer.Image = null;
                textBoxTPayments.Text = "";
                textBoxTPaid.Text = "";
                textBoxbalance.Text = "";
                textBoxICS.Text = "";
                textBoxUCS.Text = "";
                checkBoxAnyJ.Checked = false;
                checkBoxAP.Checked = false;
                checkboxBC.Checked = false;
                checkBoxD.Checked = false;
                checkBoxDC.Checked = false;
                checkBoxIP.Checked = false;
                checkBoxMC.Checked = false;
                checkBoxP.Checked = false;
                AplicationText.Image = null;





            }
            catch(Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string sql = "SELECT Name,[Last Name],[Father Name],[Passport Number],Sh_ID ,I_ID,Email,[Phone Number], [Address], [Attorney In Iran], [Application Text] ,[Application Title Code],[Customer picture],[Date of recieving the power of attorney in Iran],[Samane Tak Date of sending Power Of Attorney to embassy] ,[Total Payment] ,[Total Paid],[Iran Case Status],[USA Case Status],deed,[birth certificate],[Iranian Passport],[American Passport],[picture],[Mariage Certificate],[Divorce Certificate],[Any judgment],Balance FROM permanentCustomer where I_ID=" + textBoxIDN.Text + "";
            //    if (conn.State != ConnectionState.Open)
            //        conn.Open();
            //    command = new SqlCommand(sql, conn);
            //    SqlDataReader reader = command.ExecuteReader();
            //    reader.Read();
            //    if (reader.HasRows)
            //    {
            //        textBoxFN.Text = reader[0].ToString();
            //        textBoxLN.Text = reader[1].ToString();
            //        textBoxFatherN = reader[2].ToString();
            //        textBoxPN.Text = reader[3].ToString();
            //        textBoxBCN.Text = reader[4].ToString();
            //        textBoxIDN.Text = reader[5].ToString();
            //        textBoxEmail.Text = reader[6].ToString();
            //        textBoxPhoneN.Text = reader[7].ToString();
            //        textBoxAddress.Text = reader[8].ToString();
            //        textBoxAI.Text = reader[9].ToString();
            //        richTextBoxAT.Text = reader[10].ToString();
            //        textBoxATC.Text = reader[11].ToString();
            //        byte[] img = (byte[])(reader(12));
            //        if (img == null)
            //        { picCustomer.Image = null; }
            //        else
            //        {
            //            MemoryStream ms = new MemoryStream(img);
            //            picCustomer.Image = Image.FromStream(ms);
            //        }


            //    }
            //    else
            //    {
            //        MessageBox.Show("This Record does not exist");
            //    }
            //    conn.Close();
            //}
            //catch(Exception ex)
            //{
            //    conn.Close();
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void picCustomer_Click(object sender, EventArgs e)
        {

        }

        private void buttonBrowse2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "jpg files (*.jpg) | *.jpg |GIF files (*.gif)| *.gif| all files (*.*)|*.*";
                dlg.Title = "Select Application Text Image ";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc2 = dlg.FileName.ToString();
                    AplicationText.ImageLocation = imgLoc2;
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void AplicationText_Click(object sender, EventArgs e)
        {

        }

        private void textBoxATC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIDN_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT Name,[Last Name],[Father Name],[Passport Number],Sh_ID ,I_ID,Email,[Phone Number], [Address], [Attorney In Iran], [Application Text] ,[Application Title Code] ,[Total Payment] ,[Total Paid],[Iran Case Status],[USA Case Status],Balance,[Customer picture] from permanentCustomer where (I_ID='"+textBoxIDN.Text+"' and [Last Name]='"+textBoxLN.Text+"') or (Sh_ID='"+textBoxBCN.Text+"' and [Last Name]='"+textBoxLN.Text+"') or Sh_ID='"+textBoxBCN.Text+"' or I_ID='"+textBoxIDN.Text+"' ";
                if (conn.State != ConnectionState.Open)
                    conn.Open();
               // MessageBox.Show("1");
                command = new SqlCommand(sql, conn);
               // MessageBox.Show("2");
                SqlDataReader reader = command.ExecuteReader();
                //MessageBox.Show("3");
                reader.Read();
               // MessageBox.Show("4");
                if (reader.HasRows)
                {
                    textBoxFN.Text = reader[0].ToString();
                    textBoxLN.Text = reader[1].ToString();
                    textBoxFatherN.Text = reader[2].ToString();
                    textBoxPN.Text = reader[3].ToString();
                    textBoxBCN.Text = reader[4].ToString();
                    textBoxIDN.Text = reader[5].ToString();
                    textBoxEmail.Text = reader[6].ToString();
                    textBoxPhoneN.Text = reader[7].ToString();
                    textBoxAddress.Text = reader[8].ToString();
                    textBoxAI.Text = reader[9].ToString();
                    richTextBoxAT.Text = reader[10].ToString();

                    textBoxTPayments.Text = reader[11].ToString();
                    textBoxTPaid.Text = reader[12].ToString();
                    textBoxICS.Text = reader[13].ToString();
                    textBoxUCS.Text = reader[14].ToString();
                    textBoxbalance.Text = reader[15].ToString();
                    byte[] img = (byte[])(reader[16]);
                    if (img == null) { picCustomer.Image = null; }
                    else { MemoryStream ms = new MemoryStream(img); }


                }
                else { MessageBox.Show("This Record is not exist!"); }
                conn.Close();
            }
            catch(Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxFN.Text = "";
            textBoxLN.Text = "";
            textBoxFatherN.Text = "";
            textBoxPN.Text = "";
            textBoxBCN.Text = "";
            textBoxIDN.Text = "";
            textBoxEmail.Text = "";
            textBoxPhoneN.Text = "";
            textBoxAddress.Text = "";
            textBoxAI.Text = "";
            richTextBoxAT.Text = "";
            textBoxATC.Text = "";
            picCustomer.Image = null;
            textBoxTPayments.Text = "";
            textBoxTPaid.Text = "";
            textBoxbalance.Text = "";
            textBoxICS.Text = "";
            textBoxUCS.Text = "";
            checkBoxAnyJ.Checked = false;
            checkBoxAP.Checked = false;
            checkboxBC.Checked = false;
            checkBoxD.Checked = false;
            checkBoxDC.Checked = false;
            checkBoxIP.Checked = false;
            checkBoxMC.Checked = false;
            checkBoxP.Checked = false;
            AplicationText.Image = null;
        }
    }
}
