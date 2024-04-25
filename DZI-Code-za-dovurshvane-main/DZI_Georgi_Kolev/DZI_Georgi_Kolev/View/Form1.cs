using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DZI_Georgi_Kolev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bezalkoholno1.Hide();
            ceni1.Hide();
            kontakti1.Hide();
            produktiStoki1.Hide();
            registraciq1.Hide();
            reservacii1.Hide();
            uchastiq1.Hide();
            uslugi1.Hide();
            uslugi21.Hide();
            vhod1.Show();
            za_nas1.Hide();
           vhod1.BringToFront();

        }

        private void заНасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bezalkoholno1.Hide();
            ceni1.Hide();
            kontakti1.Hide();
            produktiStoki1.Hide();
            registraciq1.Hide();
            reservacii1.Hide();
            uchastiq1.Hide();
            uslugi1.Hide();
            uslugi21.Hide();
            vhod1.Hide();
            za_nas1.Show();
            za_nas1.BringToFront(); 
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            bezalkoholno1.Hide();
            ceni1.Hide();
            kontakti1.Hide(); 
            produktiStoki1.Hide();
            registraciq1.Hide();
            reservacii1.Hide();
            uchastiq1.Hide();
            uslugi1.Hide();
            uslugi21.Hide();
            vhod1.Hide();
            za_nas1.Hide();

        }

        private void kontakti1_Load(object sender, EventArgs e)
        {

        }

        private void рожденДенToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bezalkoholno1.Hide();
            ceni1.Hide();
            kontakti1.Hide();
            produktiStoki1.Hide();
            registraciq1.Hide();
            reservacii1.Hide();
            uchastiq1.Hide();
            uslugi1.Show();
            uslugi1.BringToFront();
            uslugi21.Hide();
            vhod1.Hide();
            za_nas1.Hide();
        }

        private void частноПартиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bezalkoholno1.Hide();
            ceni1.Hide();
            kontakti1.Hide();
            produktiStoki1.Hide();
            registraciq1.Hide();
            reservacii1.Hide();
            uchastiq1.Hide();
            uslugi1.Hide();
            uslugi21.Show();
            uslugi21.BringToFront();    
            vhod1.Hide();
            za_nas1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bezalkoholno1.Hide();
            ceni1.Hide();
            kontakti1.Hide();
            produktiStoki1.Hide();
            registraciq1.Show();
            reservacii1.Hide();
            uchastiq1.Hide();
            uslugi1.Hide();
            uslugi21.Hide();
            vhod1.Hide();
            za_nas1.Hide();
            registraciq1.BringToFront();
        }

        private void цениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bezalkoholno1.Hide();
            registraciq1.Hide();
            kontakti1.Hide();
            produktiStoki1.Hide();
            ceni1.Show();
            reservacii1.Hide();
            uchastiq1.Hide();
            uslugi1.Hide();
            uslugi21.Hide();
            vhod1.Hide();
            za_nas1.Hide();
            ceni1.BringToFront();
        }

        private void продуктиСтокиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void контактиИРезервацииToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void контактиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bezalkoholno1.Hide();
            ceni1.Hide();
            kontakti1.Show();
            produktiStoki1.Hide();
            registraciq1.Hide();
            reservacii1.Hide();
            uchastiq1.Hide();
            uslugi1.Hide();
            uslugi21.Hide();
            vhod1.Hide();
            za_nas1.Hide();
            kontakti1.BringToFront();
        }

        private void резервацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bezalkoholno1.Hide();
            ceni1.Hide();
            kontakti1.Hide();
            produktiStoki1.Hide();
            registraciq1.Hide();
            reservacii1.Show();
            uchastiq1.Hide();
            uslugi1.Hide();
            uslugi21.Hide();
            vhod1.Hide();
            za_nas1.Hide();
            reservacii1.BringToFront();
        }

        private void алкохолToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bezalkoholno1.Hide();
            ceni1.Hide();
            kontakti1.Hide();
            registraciq1.Hide();
            produktiStoki1.Show();
            reservacii1.Hide();
            uchastiq1.Hide();
            uslugi1.Hide();
            uslugi21.Hide();
            vhod1.Hide();
            za_nas1.Hide();
            produktiStoki1.BringToFront();
        }

        private void безалкохолноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bezalkoholno1.Show();
            ceni1.Hide();
            kontakti1.Hide();
            registraciq1.Hide();
            produktiStoki1.Hide();
            reservacii1.Hide();
            uchastiq1.Hide();
            uslugi1.Hide();
            uslugi21.Hide();
            vhod1.Hide();
            za_nas1.Hide();
            bezalkoholno1.BringToFront();
        }
    }
}
