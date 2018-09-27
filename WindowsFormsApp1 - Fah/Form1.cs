using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1___Fah
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonHitung_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtnilaiA.Text);
            var b = Convert.ToInt32(txtnilaiB.Text);

            Double Hasil;
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    Hasil = a + b;
                    lstHasil.Text = Convert.ToString(Hasil);
                    break;

                case 1:
                    Hasil = a - b;
                    lstHasil.Text = Convert.ToString(Hasil);
                    break;

                case 2:
                    Hasil = a * b;
                    lstHasil.Text = Convert.ToString(Hasil);
                    break;

                case 3:
                    Hasil = a / b;
                    lstHasil.Text = Convert.ToString(Hasil);
                    break;

            }
        }
    }
}
