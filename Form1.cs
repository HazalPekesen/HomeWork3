using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        string[] araba = { "MERCEDES", "BMW", "TOYOTA" };

        //sadece tek bir checkbox tıklanır hale getirildi.
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked || checkBox3.Checked || checkBox4.Checked)
            {
                checkBox1.Checked = false;
            }

            label1.Text = string.Empty;
            label1.Text = araba[0];
            label2.Text = string.Empty;
            label2.Text = araba[1];
            label3.Text = string.Empty;
            label3.Text = araba[2];
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked || checkBox4.Checked)
            {
                checkBox2.Checked = false;
            }

            label1.Text = string.Empty;
            label1.Text = araba[1];
            label2.Text = string.Empty;
            label2.Text = araba[0];
            label3.Text = string.Empty;
            label3.Text = araba[2];
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox4.Checked)
            {
                checkBox3.Checked = false;
            }

            label1.Text = string.Empty;
            label1.Text = araba[2];
            label2.Text = string.Empty;
            label2.Text = araba[0];
            label3.Text = string.Empty;
            label3.Text = araba[1];
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                checkBox4.Checked = false;
            }

            label1.Text = string.Empty;
            label1.Text = araba[0];
            label2.Text = string.Empty;
            label2.Text = araba[1];
            label3.Text = string.Empty;
            label3.Text = araba[2];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("satır ekleniyor...");
            //tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("2020");
            comboBox1.Items.Add("2021");
            comboBox1.Items.Add("2022");
            comboBox2.Items.Add("2020");
            comboBox2.Items.Add("2021");
            comboBox2.Items.Add("2022");
            comboBox3.Items.Add("2020");
            comboBox3.Items.Add("2021");
            comboBox3.Items.Add("2022");
        }
    }
}
