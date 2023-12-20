using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsvApp
{
    public partial class Trennenzeichnen : Form
    {
        public string trennenzeichnen;
        public Trennenzeichnen()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // ( / nicht Tab )
            trennenzeichnen = "\\t";
            label1.Text = trennenzeichnen;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            trennenzeichnen = ";";
            label1.Text = trennenzeichnen;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            trennenzeichnen = "' '";
            label1.Text = trennenzeichnen;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            trennenzeichnen = ":";
            label1.Text = trennenzeichnen;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            trennenzeichnen = ",";
            label1.Text = trennenzeichnen;
        }

        private void ok_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
