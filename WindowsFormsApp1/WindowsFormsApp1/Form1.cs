using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Listbox1 in seçilmiş indisi değişti
            // seçilmiş indis:
            int indis = listBox1.SelectedIndex;
            // seçilmiş öğe :
            object oge = listBox1.SelectedItem;
            if (oge!=null)
            label1.Text = "Seçilen öğenin: " + oge.ToString()
                + ", Seçilen öğenin indisi: " + indis.ToString()
                + " bu da seçilmiş öğe: "+listBox1.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //rb1 seçimi değişti eğer seçildiyse
            if(radioButton1.Checked)
                listBox1.SelectionMode = SelectionMode.One;
            else
                listBox1.SelectionMode = SelectionMode.MultiSimple;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lstbx1 in eleman sayısı
            int lbcount = listBox1.Items.Count;
            label1.Text = "lb1 eleman sayısı: "+lbcount.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string oge = textBox1.Text;
            if(!listBox1.Items.Contains(oge))
            listBox1.Items.Add(oge);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string oge = textBox1.Text;
            listBox1.Items.Remove(oge);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int indis = int.Parse(textBox1.Text);
            listBox1.Items.RemoveAt(indis);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //txtbx1 de yazılan lb1 de var mı?
            string oge = textBox1.Text;
            if (listBox1.Items.Contains(oge))
                label1.Text = oge + " var";
            else label1.Text = oge + " yok";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string oge = textBox1.Text;
            int indis = listBox1.Items.IndexOf(oge);
            if (indis > 0)
                label1.Text = oge + " var. " + indis.ToString() + ". öğe.";
            else label1.Text = oge + " yok";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
