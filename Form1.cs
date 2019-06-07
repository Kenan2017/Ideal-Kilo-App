using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace IdealKiloHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var boy = double.Parse(txtBoy.Text);
            var kilo = double.Parse(txtKilo.Text);
            double index = (kilo / (boy*boy));

            if (index < 20 )
            {
                MessageBox.Show("Vucut Kitle Indeksin " + index + ". " + "Zayifsin");
            }

            else if (index >= 20 && index <25)
            {
                MessageBox.Show("Vucut Kitle Indeksin " + index + ". " + "Normalsin");
            }
            else
            {
                MessageBox.Show("Vucut Kitle Indeksin " + index + ". " + "Sismansin");
            }

        }
    }
}
