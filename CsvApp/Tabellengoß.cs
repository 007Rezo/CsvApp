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
    public partial class Tabellengoß : Form
    {

        public int columns = 0;
        public int rows = 0;

        public Tabellengoß()
        {
            InitializeComponent();
        }

        private void numeric_Spalten_ValueChanged(object sender, EventArgs e)
        {
            columns = ((int)numeric_Spalten.Value);
            //numeric_Spalten.Select(0, numeric_Spalten.Value.ToString().Length);
        }

        private void numeric_Zeilen_ValueChanged(object sender, EventArgs e)
        {
            rows = ((int)numeric_Zeilen.Value);
            //numeric_Zeilen.Select(0, numeric_Zeilen.Value.ToString().Length);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void oK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tabellengoß_Load(object sender, EventArgs e)
        {

        }

    }
}
