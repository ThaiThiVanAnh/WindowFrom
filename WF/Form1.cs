using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(txtLN.Text);
            lvi.SubItems.Add(txtFN.Text);
            lvi.SubItems.Add(txtP.Text);
            lv1.Items.Add(lvi);
        }

        private void lv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv1.SelectedItems.Count>0)
            {
                txtLN.Text = lv1.SelectedItems[0].SubItems[0].Text;
                txtFN.Text = lv1.SelectedItems[0].SubItems[1].Text;
                txtP.Text = lv1.SelectedItems[0].SubItems[2].Text; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lv1.Items.Remove(lv1.SelectedItems[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lv1.SelectedItems[0].SubItems[0].Text = txtLN.Text;
            lv1.SelectedItems[0].SubItems[1].Text = txtFN.Text;
            lv1.SelectedItems[0].SubItems[2].Text = txtP.Text;

        }
    }
}
