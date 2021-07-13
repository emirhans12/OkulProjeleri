using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vucut_Kitle_İndeksi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy, kilo, indeks = 0;
            
            boy = Convert.ToDouble(txtBoy.Text);
            
            kilo = Convert.ToDouble(txtKilo.Text);
            indeks = kilo / (boy * boy);

            lblİndeks.Text = ("Vücut Kitle İndeksiniz = "+Convert.ToString(indeks)); //indeks);
            lblİndeks.Visible = true;
            if (indeks < 18)
            {
                lblSon.Text=("Zayıf");
                lblSon.Visible = true;

            }
            else if (indeks >= 18.1 && indeks < 23.9)
            {
                lblSon.Text = ("Normal");
                lblSon.Visible = true;
            }
            else if (indeks >= 24 && indeks < 29)
            {
                lblSon.Text = ("Kilolu");
                lblSon.Visible = true;
            }
            else if (indeks >= 30)
            {
                lblSon.Text = ("Obez");
                lblSon.Visible = true;
            }
        }
    }
}
