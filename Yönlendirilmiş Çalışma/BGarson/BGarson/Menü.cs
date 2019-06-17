using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Data.OleDb;

namespace BGarson
{

    public partial class Menü : Form
    {


        
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=PersonelTakip.accdb");
        OleDbCommand kmt = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds;
        void griddoldur()
        {

            adtr = new OleDbDataAdapter("Select *from Siparis", bag);
            ds = new DataSet();
            bag.Open();
            adtr.Fill(ds, "Siparis");
            dataGridView1.DataSource = ds.Tables["Siparis"];
            bag.Close();
        }
        public void pide1()
        {
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select Pide from Urunler";
            OleDbDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                comboBox_pide.Items.Add(oku[0].ToString());


            }
            bag.Close();
            oku.Dispose();
            comboBox_kebap.Sorted = true;
        }
        public void kebap1()
        {
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select Kebap from Urunler";
            OleDbDataReader oku;
            oku = kmt.ExecuteReader();

            while (oku.Read())
            {
                comboBox_kebap.Items.Add(oku[0].ToString());

            }
            bag.Close();
            oku.Dispose();
            comboBox_tatlı.Sorted = true;
        }
        public void corba1()
        {
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select corba from Urunler";
            OleDbDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                comboBox_Corba.Items.Add(oku[0].ToString());
            }
            bag.Close();
            oku.Dispose();
            comboBox_Corba.Sorted = true;
        }
        public void tatlı1()
        {
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select Tatlı from Urunler";
            OleDbDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                comboBox_tatlı.Items.Add(oku[0].ToString());
            }
            bag.Close();
            oku.Dispose();
            comboBox_Corba.Sorted = true;
        }
        public void icecek1()
        {
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select İcecek from Urunler";
            OleDbDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                comboBox_icecek.Items.Add(oku[0].ToString());
            }
            bag.Close();
            oku.Dispose();
            comboBox_Corba.Sorted = true;
        }
        public Menü()
        {
            InitializeComponent();
        }

        void islem(Object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            button2.BackColor = System.Drawing.Color.Green;//butonun arkaplan renginin yeşil olmasını sağlıyoruz
            button3.BackColor = System.Drawing.Color.Green;
            button4.BackColor = System.Drawing.Color.Green;
            button5.BackColor = System.Drawing.Color.Green;
            button6.BackColor = System.Drawing.Color.Green;
            button7.BackColor = System.Drawing.Color.Green;
            button8.BackColor = System.Drawing.Color.Green;
            button9.BackColor = System.Drawing.Color.Green;
            button10.BackColor = System.Drawing.Color.Green;
            button11.BackColor = System.Drawing.Color.Green;
            griddoldur();
            corba1();
            kebap1();
            tatlı1();
            pide1();
            icecek1();
            
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            label_MasaNo.Text = "1";
            comboBox_Corba.Text = "";
            comboBox_icecek.Text = "";
            comboBox_kebap.Text = "";
            comboBox_pide.Text = "";
            comboBox_tatlı.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label_MasaNo.Text = "2";
            comboBox_Corba.Text = "";
            comboBox_icecek.Text = "";
            comboBox_kebap.Text = "";
            comboBox_pide.Text = "";
            comboBox_tatlı.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label_MasaNo.Text = "3";
            comboBox_Corba.Text = "";
            comboBox_icecek.Text = "";
            comboBox_kebap.Text = "";
            comboBox_pide.Text = "";
            comboBox_tatlı.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label_MasaNo.Text = "4";
            comboBox_Corba.Text = "";
            comboBox_icecek.Text = "";
            comboBox_kebap.Text = "";
            comboBox_pide.Text = "";
            comboBox_tatlı.Text = "";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label_MasaNo.Text = "5";
            comboBox_Corba.Text = "";
            comboBox_icecek.Text = "";
            comboBox_kebap.Text = "";
            comboBox_pide.Text = "";
            comboBox_tatlı.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label_MasaNo.Text = "6";
            comboBox_Corba.Text = "";
            comboBox_icecek.Text = "";
            comboBox_kebap.Text = "";
            comboBox_pide.Text = "";
            comboBox_tatlı.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label_MasaNo.Text = "7";
            comboBox_Corba.Text = "";
            comboBox_icecek.Text = "";
            comboBox_kebap.Text = "";
            comboBox_pide.Text = "";
            comboBox_tatlı.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label_MasaNo.Text = "8";
            comboBox_Corba.Text = "";
            comboBox_icecek.Text = "";
            comboBox_kebap.Text = "";
            comboBox_pide.Text = "";
            comboBox_tatlı.Text = "";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            label_MasaNo.Text = "9";
            comboBox_Corba.Text = "";
            comboBox_icecek.Text = "";
            comboBox_kebap.Text = "";
            comboBox_pide.Text = "";
            comboBox_tatlı.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label_MasaNo.Text = "10";
            comboBox_Corba.Text = "";
            comboBox_icecek.Text = "";
            comboBox_kebap.Text = "";
            comboBox_pide.Text = "";
            comboBox_tatlı.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void groupBox_menu_Enter(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            int sıra = listView1.Items.Count;
            listView1.Items.Add(label_MasaNo.Text);
            listView1.Items[sıra].SubItems.Add(comboBox_Corba.Text);
            listView1.Items[sıra].SubItems.Add(comboBox_pide.Text);
            listView1.Items[sıra].SubItems.Add(comboBox_kebap.Text);
            listView1.Items[sıra].SubItems.Add(comboBox_tatlı.Text);
            listView1.Items[sıra].SubItems.Add(comboBox_icecek.Text);

            if (label_MasaNo.Text=="1")
            {
                button2.BackColor = System.Drawing.Color.Red;
            }
            if (label_MasaNo.Text == "2")
            {
                button3.BackColor = System.Drawing.Color.Red;
            }
            if (label_MasaNo.Text == "3")
            {
                button4.BackColor = System.Drawing.Color.Red;
            }
            if (label_MasaNo.Text == "4")
            {
                button5.BackColor = System.Drawing.Color.Red;
            }
            if (label_MasaNo.Text == "5")
            {
                button6.BackColor = System.Drawing.Color.Red;
            }
            if (label_MasaNo.Text == "6")
            {
                button7.BackColor = System.Drawing.Color.Red;
            }
            if (label_MasaNo.Text == "7")
            {
                button8.BackColor = System.Drawing.Color.Red;
            }
            if (label_MasaNo.Text == "8")
            {
                button9.BackColor = System.Drawing.Color.Red;
            }
            if (label_MasaNo.Text == "9")
            {
                button10.BackColor = System.Drawing.Color.Red;
            }
            if (label_MasaNo.Text == "10")
            {
                button11.BackColor = System.Drawing.Color.Red;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            groupBox_odeme.Visible = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].Remove();


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                label7.Text = listView1.SelectedItems[0].SubItems[0].Text;
                label12.Text = listView1.SelectedItems[0].SubItems[1].Text;
                label11.Text = listView1.SelectedItems[0].SubItems[2].Text;
                label10.Text = listView1.SelectedItems[0].SubItems[3].Text;
                label17.Text = listView1.SelectedItems[0].SubItems[4].Text;

                label15.Text = listView1.SelectedItems[0].SubItems[5].Text;

                if (label12.Text == "")
                {
                    textBox2.Enabled = false;
                    comboBox1.Enabled = false;
                    textBox2.Text = 0.ToString();
                    comboBox1.Text = 1.ToString();
                }
                else
                {
                    textBox2.Enabled = true;
                    comboBox2.Enabled = true;
                }        
                
            
                if (label11.Text == "")
                {
                    textBox3.Enabled = false;
                    comboBox2.Enabled = false;
                    comboBox2.Text = 1.ToString();
                    textBox3.Text = 0.ToString();
                }
                else
                {
                    textBox3.Enabled = true;
                    comboBox2.Enabled = true;
                }
                    
                if (label10.Text == "")
                {
                    textBox4.Enabled = false;
                    comboBox3.Enabled = false;
                    comboBox3.Text = 1.ToString();
                    textBox4.Text = 0.ToString();
                }
                else
                {
                    textBox4.Enabled = true;
                    comboBox3.Enabled = true;
                }
                    
                if (label17.Text == "")
                {
                    textBox5.Enabled = false;
                    comboBox4.Enabled = false;
                    comboBox4.Text = 1.ToString();
                    textBox5.Text = 0.ToString();
                }
                else
                {
                    textBox5.Enabled = true;
                    comboBox4.Enabled = true;
                }
                    
                if (label15.Text == "")
                {
                    textBox1.Enabled = false;
                    comboBox5.Enabled = false;
                    comboBox5.Text = 1.ToString();
                    textBox1.Text = 0.ToString();
                }
                else
                {
                    textBox1.Enabled = true;
                    comboBox4.Enabled = true;
                }


            }
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            groupBox_odeme.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (label_MasaNo.Text == "1")
            {
                button2.BackColor = System.Drawing.Color.Green;
            }
            if (label_MasaNo.Text == "2")
            {
                button3.BackColor = System.Drawing.Color.Green;
            }
            if (label_MasaNo.Text == "3")
            {
                button4.BackColor = System.Drawing.Color.Green;
            }
            if (label_MasaNo.Text == "4")
            {
                button5.BackColor = System.Drawing.Color.Green;
            }
            if (label_MasaNo.Text == "5")
            {
                button6.BackColor = System.Drawing.Color.Green;
            }
            if (label_MasaNo.Text == "6")
            {
                button7.BackColor = System.Drawing.Color.Green;
            }
            if (label_MasaNo.Text == "7")
            {
                button8.BackColor = System.Drawing.Color.Green;
            }
            if (label_MasaNo.Text == "8")
            {
                button9.BackColor = System.Drawing.Color.Green;
            }
            if (label_MasaNo.Text == "9")
            {
                button10.BackColor = System.Drawing.Color.Green;
            }
            if (label_MasaNo.Text == "10")
            {
                button11.BackColor = System.Drawing.Color.Green;
            }
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double corba, pide, kebap, tatlı, icecek, tutar;
            corba = double.Parse(textBox2.Text)*double.Parse(comboBox1.Text);
            pide = double.Parse(textBox3.Text) * double.Parse(comboBox2.Text);
            kebap = double.Parse(textBox4.Text) * double.Parse(comboBox3.Text);
            tatlı = double.Parse(textBox5.Text) * double.Parse(comboBox4.Text);
            icecek = double.Parse(textBox1.Text) * double.Parse(comboBox5.Text);

            tutar = corba + pide + kebap + tatlı + icecek;
            label9.Text = (tutar.ToString()+"TL");
            label14.Text = "Bekliyor...";

        }

        private void groupBox_odeme_Enter(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            label14.Text = "Ödendi";
            kmt = new OleDbCommand();
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "insert into Siparis (MasaNo,Çorba,Pide,Kebap,Tatli,İçecek,Fiyat,Durum,Tarih) values ('" + label7.Text + "','" + label12.Text + "','" + label11.Text + "','" + label10.Text + "','" + label17.Text + "','" + label15.Text + "','" + label9.Text + "','" + label14.Text + "','" +dateTimePicker1.Value+ "')";
            kmt.ExecuteNonQuery();
            bag.Close();
            griddoldur();
            label7.Text = "___";
            label12.Text = "___";
            label11.Text = "___";
            label10.Text = "___";
            label17.Text = "___";
            label15.Text = "___";
            label9.Text = "___";
            
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Text = "___";
            label12.Text = "___";
            label11.Text = "___";
            label10.Text = "___";
            label17.Text = "___";
            label15.Text = "___";
            label9.Text = "___";
            label14.Text = "___";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";

        }

        private void button22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
