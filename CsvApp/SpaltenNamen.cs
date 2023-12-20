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
    public partial class SpaltenNamen : Form
    {
        private int columns;
        private int count = 0;
        public ListBox.ObjectCollection entries;
        public SpaltenNamen(int columns)
        {
            InitializeComponent();
            this.columns = columns;
        }

        private void SpaltenNamen_Load(object sender, EventArgs e)
        {

        }

        private void oK_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                entries = listBox1.Items;
            }
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Abbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Add 
        private void AddHeaderName_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Length > 0 && count < columns )
            {

                // Set the RTF content back to the listBox1 control
                listBox1.Items.Add(textBox1.Text);
                // Clear the TextBox control
                textBox1.Clear();
                count++;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Delete_btn(object sender, EventArgs e)
        {
            // Delete One word 
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                count--;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
