using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp50
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            string secim = "10B";
            if (radioButton1.Checked)
            {
                secim = "9";
            }
            if (radioButton2.Checked)
            {
                secim = "10";
            }
            if (radioButton3.Checked)
            {
                secim = "11";
            }
            if (radioButton4.Checked)
            {
                secim = "12";
            }
            if (radioButton5.Checked)
            {
                secim = secim+"A";
            }
            if (radioButton6.Checked)
            {
                secim = secim+ "B";
            }
            if (radioButton7.Checked)
            {
                secim = secim + "C";
            }
            if (radioButton8.Checked)
            {
                secim = secim+ "D";
            }
            if (radioButton9.Checked)
            {
                secim = secim + "E";
            }
            if(secim == "10B")
            {
                int sirano = rastgele.Next(29);
                label1.Text = B10.Items[sirano].ToString();
            }
            if (secim == "9B")
            {
                int sirano = rastgele.Next(32);
                label1.Text = B9.Items[sirano].ToString();
            }
            if (secim == "11B")
            {
                int sirano = rastgele.Next(24);
                label1.Text = B11.Items[sirano].ToString();
            }
            if(secim == "12B")
            {
                int sirano = rastgele.Next(20);
                label1.Text= B12.Items[sirano].ToString();
            }
            if(secim == "9A")
            {
                int sirano =rastgele.Next(32);
                label1.Text = A9.Items[sirano].ToString();
            }
            if (secim == "10A")
            {
                int sirano = rastgele.Next(30);
                label1.Text = A10.Items[sirano].ToString();
            }
            if(secim == "11A")
            {
                int sirano = rastgele.Next(30);
                label1.Text= A11.Items[sirano].ToString();
            }
            if (secim == "12A")
            {
                int sirano = rastgele.Next(26);
                label1.Text = (A12.Items[sirano].ToString());
            }
            if (secim == "9C")
            {
                int sirano =rastgele.Next(27);
                label1.Text = (C9.Items[sirano].ToString());
            }
            if (secim == "10C")
            {
                int sirano=rastgele.Next(34);
                label1.Text = ((C10.Items[sirano]).ToString());
            }
            if ((secim == "11C"))
            {
                int sirano = rastgele.Next(24);
                label1.Text = (C11.Items[sirano]).ToString();
            }
            if (secim == "12C")
            {
                int sirano = rastgele.Next(24);
                label1.Text = (C12.Items[sirano]).ToString();
            }
            if (secim == "9D")
            {
                int sirano = rastgele.Next(31);
                label1.Text = (D9.Items[sirano]).ToString();
            }
            if (secim == "10D")
            {
                int sirano = rastgele.Next(22);
                label1.Text = (D10.Items[sirano]).ToString();
            }
            if (secim == "11D")
            {
                int sirano = rastgele.Next(22);
                label1.Text = (D11.Items[sirano]).ToString();
            }
            if ( secim == "12D")
            {
                int sirano = rastgele.Next(15);
                label1.Text = (D12.Items[sirano]).ToString();
            }
            if (secim == "9E")
            {
                int sirano = rastgele.Next(29);
                label1.Text = (E9.Items[sirano]).ToString();
            }
            if(secim == "10E")
            {
                int sirano = rastgele.Next(23);
                label1.Text = (E10.Items[sirano]).ToString();
            }
            if (secim == "11E")
            {
                int sirano = rastgele.Next(18);
                label1.Text = (E11.Items[sirano]).ToString();
            }
            if (secim == "12E")
            {
                int sirano = rastgele.Next(15);
                label1.Text = (E12.Items[sirano]).ToString();
            }
        }

        private void B11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void B10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
