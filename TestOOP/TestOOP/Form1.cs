using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Vedouci clovek = new Vedouci(textBox1.Text, textBox2.Text, dateTimePicker1.Value, (int)numericUpDown1.Value);
                clovek.DatumNarozeni = dateTimePicker1.Value;
                label1.Text = clovek.ToString();
                clovek.bohaty();
                Vedouci clovek2 = new Vedouci(textBox3.Text, textBox4.Text, dateTimePicker2.Value, (int)numericUpDown2.Value);
                clovek2.DatumNarozeni = dateTimePicker2.Value;
                label10.Text = clovek2.ToString();
                Sponzor sponzor = new Sponzor(textBox6.Text, (int)numericUpDown3.Value);
                label13.Text = sponzor.ToString();
                Sponzor sponzor2 = new Sponzor(textBox5.Text, (int)numericUpDown4.Value);
                label14.Text = sponzor2.ToString();

            }
            catch
            {
                MessageBox.Show("Něco se nepovedlo");
            }
        }
    }
}
