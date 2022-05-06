using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Zbozi zbozi = new Zbozi("Mleko", 35,DateTime.Parse("2/5/2022") , 30);
        private void button1_Click(object sender, EventArgs e)
        {
            zbozi.SplnujeMinTrvanlivost();
            MessageBox.Show(zbozi.ToString());
        }
        Produkt produkt = new Produkt("Mleko", 35, DateTime.Parse("2/5/2022"), 30);
        private void button2_Click(object sender, EventArgs e)
        {
            produkt.SplnujeMinTrvanlivost();
            MessageBox.Show(produkt.ToString());
        }
    }
}
