using System;
using System.IO;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Data.Common;

namespace CsvApp
{
    public partial class MainForm : Form
    {
        private DataTable dataTable;
        private string trennenzeichnen;

        public MainForm()
        {
            InitializeComponent();
            InitializeDataTable();

            this.StartPosition = FormStartPosition.CenterScreen;
            trennenzeichnen = ";";
        }
        private void InitializeDataTable()
        {

            // Erstelle eine DataTable und binden an die DataGridView
            dataTable = new DataTable();
            //dataTable.Columns.Add();
            //
            dataGridView1.DataSource = dataTable;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataTable.Reset();
            // Tauschen/ersetzen
            using (Trennenzeichnen dlgTrennenZeichnen = new Trennenzeichnen())
            {

                dlgTrennenZeichnen.StartPosition = FormStartPosition.CenterParent;
                dlgTrennenZeichnen.ShowDialog();
                if (dlgTrennenZeichnen.DialogResult == DialogResult.OK)
                {
                    //MessageBox.Show(dlgTrennenZeichnen.trennenzeichnen);
                    trennenzeichnen = dlgTrennenZeichnen.trennenzeichnen;
                    //öffnen eine csv-Datei und lese eine Datei
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.Filter = "CSV Files (*.csv) |*.csv";
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            ReadCSV(openFileDialog.FileName);
                        }
                    }
                }
                else
                {
                    trennenzeichnen = ";";
                }
            }
            

        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataTable.Rows.Count > 0)
            {
                // 
                using (Trennenzeichnen dlgTrennenZeichnen = new Trennenzeichnen())
                {

                    dlgTrennenZeichnen.StartPosition = FormStartPosition.CenterParent;
                    dlgTrennenZeichnen.ShowDialog();
                    if (dlgTrennenZeichnen.DialogResult == DialogResult.OK)
                    {
                        //MessageBox.Show(dlgTrennenZeichnen.trennenzeichnen);
                        trennenzeichnen = dlgTrennenZeichnen.trennenzeichnen;

                        // Speichere die Daten in einer CSV-Datei ausser dem Abbrechen und bleiben  
                        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                        {
                            saveFileDialog.Filter = "CSV Files (*.csv) |*.csv";
                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                WriteCSV(saveFileDialog.FileName);
                            }
                        }
                    }
                    else
                    {
                        trennenzeichnen = ";";                       
                    }
                }               
            }

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //am Anfang gibts kein (Nix geöffnet habe ) Spalte dirkt
            if (dataTable.Rows.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                // ?? wenn man irgendwas was geändert hat, dann kommt das alles 
                DialogResult result = MessageBox.Show("Do you want Save your changes? ", "Save Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                    Application.Exit();
                }
                else if (result == DialogResult.No)
                {
                    Application.Exit();
                    // no  braucht keine MessageBox / Cancel muss bleiben 
                }
                // Cancel 
                else
                {

                }
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ReadCSV(string filePath)
        {
            // martin 
            /* var lines = File.ReadLines(filePath);
             // 
             var words = lines.First().Split(';');

             //
             DataTable dataTable = new DataTable();
             // 
             foreach (string line in words)
             {
                 dataTable.Columns.Add(line);
             }

             int x = 0;
             foreach (string line in lines)
             {
                 if (x > 0)
                 {
                     string[] data = line.Split(';');
                     dataTable.Rows.Add(data);// x 1234// line Vorname, Nachname,Geburtstag, Geschlecht//words ganz Spalten Vorname, Nachname,Geburtstag, Geschlecht 
                 }
                 x++;
             }
             dataGridView1.DataSource = dataTable;*/


            var reihe = File.ReadLines(filePath);
            // 
            var spalten = reihe.First().Split(trennenzeichnen).Length;
            MessageBox.Show($"Die CSV-Datei hat {spalten} Spalten.", "Spaltenanzahl", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // dataGridView1.DataSource = dataTable;
            dataTable = new DataTable();

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length > 0)
                {
                    string[] headers = lines[0].Split(trennenzeichnen);
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header);
                    }
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] data = lines[i].Split(trennenzeichnen);
                        dataTable.Rows.Add(data);
                    }
                }
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading CSV file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView1.DataSource = dataTable;
        }
        private void WriteCSV(string filePath)
        {
            try
            {
                // 
                List<string> lines = new List<string>();
                string header = "";

                //Add headers (überschriften )
                foreach(DataColumn column in dataTable.Columns)
                {
                    header += column.ColumnName + trennenzeichnen;
                }

                header.PadRight(0);
                lines.Add(header);
                

                //Add data 
                foreach (DataRow row in dataTable.Rows)
                {
                    string line = string.Join(trennenzeichnen, row.ItemArray);
                    lines.Add(line);
                }
                File.WriteAllLines(filePath, lines);//.toArray()
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing CSV file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ShowInputDialog();
            string columnName = Microsoft.VisualBasic.Interaction.InputBox("Enter column name: ", "Add Column", "");
            if (!string.IsNullOrEmpty(columnName))
            {
                dataTable.Columns.Add(columnName);
            }

        }
        private void AddColumnsToTable(int numberOfColumns)

        {

            for (int i = 0; i < numberOfColumns; i++)

            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();
                column.HeaderText = "Column " + (dataGridView1.Columns.Count + 1);
                dataGridView1.Columns.Add(column);
            }

        }

        private void ShowInputDialog(object sender, EventArgs e)
        {
            /*using (InputDialogForm dialog = new InputDialogForm())
            {
                dialog.StartPosition = FormStartPosition.CenterParent;
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    int numberOfColumns = (int)dialog.numericUpDown1.Value;
                    AddColumnsToTable(numberOfColumns);
                }
            }*/
        }

        private void deleteColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int columnIndex = dataGridView1.SelectedCells[0].ColumnIndex;
                dataTable.Columns.RemoveAt(columnIndex);
            }
        }

        private void addRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Add a new row with monetary values to the DataTable
            /*List<object> rowdata = new List<object>();
            foreach (DataColumn column in dataGridView1.Columns)
            {
                string inputValue = Microsoft.VisualBasic.Interaction.InputBox($"Enter value for {column.ColumnName}", "Add Row", "O");

                // validate and Convert input to decimal
                if(decimal.TryParse(inputValue,out decimal value))
                {
                    rowdata.Add(column);
                }
                else
                {
                    MessageBox.Show("Invalid monetary value. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            dataTable.Rows.Add(rowdata.ToArray());*/
            dataTable.Rows.Add();

        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Delete the selected row from the DataTable
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int roIndex = dataGridView1.SelectedCells[0].RowIndex;
                dataTable.Rows.RemoveAt(roIndex);

            }
        }

        private void sumColumnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SumSelectedColumns(4);
        }

        private void SumSelectedColumns(int numberOfColumns)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                // Prüfe, ob die ausgewählte Zeile existiert
                if (rowIndex >= 0 && rowIndex < dataTable.Rows.Count)
                {
                    // Wähle diie ersten 'numberOfColumns ' Zellen in der ausgewählten Zeile aus 
                    var selectedCells = dataGridView1.Rows[rowIndex].Cells.Cast<DataGridViewCell>().ToList();
                    decimal sum = 0;
                    foreach (var cell in selectedCells)
                    {
                        if (decimal.TryParse(cell.Value.ToString(), out decimal cellValue))
                        {
                            sum += cellValue;
                        }
                    }
                    //zeige das Ergebnis an 
                    MessageBox.Show($"Sum of selected {numberOfColumns} columns: {sum}", "Sum Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBox.ObjectCollection eintraege;
            int spalten = 0;
            int zeilen = 0;
            
            dataTable.Clear();
            using (Tabellengoß dlgTabellengoß = new Tabellengoß())
            {

                dlgTabellengoß.StartPosition = FormStartPosition.CenterParent;
                dlgTabellengoß.ShowDialog();
                if (dlgTabellengoß.DialogResult == DialogResult.OK)
                {
                    // MessageBox.Show(dlgTabellengoß.columns.ToString());
                    // MessageBox.Show(dlgTabellengoß.rows.ToString());
                    zeilen = dlgTabellengoß.rows;
                    spalten = dlgTabellengoß.columns;


                    // Add Column 
                    using (SpaltenNamen dlgSpaltenNamen = new SpaltenNamen(spalten))
                    {
                        dlgSpaltenNamen.StartPosition = FormStartPosition.CenterParent;
                        dlgSpaltenNamen.ShowDialog();
                        if (dlgSpaltenNamen.DialogResult == DialogResult.OK)
                        {
                            //MessageBox.Show(dlgSpaltenNamen.trennenzeichnen);

                            eintraege = dlgSpaltenNamen.entries;
                            if (eintraege.Count > 0)
                            {
                                for (int i = 0; i < eintraege.Count; i++)
                                {
                                    DataColumn column = new DataColumn();
                                    column.ColumnName = eintraege[i].ToString();
                                    //Add the column to the table.
                                    dataTable.Columns.Add(column);

                                }
                            }
                        }

                    }
                    // Add 
                    DataRow row;
                    for (int i = 1;i <= zeilen; i++)
                    {
                         row = dataTable.NewRow();
                        dataTable.Rows.Add(row);
                    }
                    
                }


             
            }

        }

        private void tabellenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBox.ObjectCollection eintraege;
            int zeilen;
            int spalten;
             using (Tabellengoß dlgTabellengoß = new Tabellengoß())
             {
                 dlgTabellengoß.StartPosition = FormStartPosition.CenterParent;
                 dlgTabellengoß.ShowDialog();
                 if (dlgTabellengoß.DialogResult == DialogResult.OK)
                 {
                     //MessageBox.Show(dlgTabellengoß.columns.ToString());
                     //MessageBox.Show(dlgTabellengoß.rows.ToString());
                     zeilen = dlgTabellengoß.rows;
                     spalten = dlgTabellengoß.columns;
                    //
                    using (SpaltenNamen dlgSpaltenNamen = new SpaltenNamen(spalten))
                    {
                        dlgSpaltenNamen.StartPosition = FormStartPosition.CenterParent;
                        dlgSpaltenNamen.ShowDialog();
                        if (dlgSpaltenNamen.DialogResult == DialogResult.OK)
                        {
                            //MessageBox.Show(dlgSpaltenNamen.trennenzeichnen);

                            eintraege = dlgSpaltenNamen.entries;
                            if(eintraege.Count > 0)
                            {
                                for (int i = 0; i < eintraege.Count; i++)
                                {
                                    DataColumn column = new DataColumn();
                                    column.ColumnName = eintraege[i].ToString();
                                    //Add the column to the table.
                                    dataTable.Columns.Add(column);

                                }
                            }
                        }

                    }
                }
                

            }


            /* string[,] zahlenfeld = new string[zeilen, spalten]; // Erstellen eines benutzerdefinierten Zeilen x Spalten-Zahlenfelds

             StreamWriter sw = new StreamWriter("Zahlenfeld.csv"); // Erstellen einer StreamWriter-Instanz zum Schreiben in eine CSV-Datei

             // Initialisieren des Zahlenfelds

             for (int i = 0; i < zeilen; i++)
             {
                 for (int j = 0; j < spalten; j++)
                 {
                     zahlenfeld[i, j] = (i + 1).ToString() + "," + (j + 1).ToString();
                 }
             }
             // Schreiben des Zahlenfelds in die CSV-Datei
             for (int i = 0; i < zeilen; i++)
             {
                 for (int j = 0; j < spalten; j++)
                 {
                     sw.Write(zahlenfeld[i, j]);
                 }
                 sw.WriteLine(); // Schreiben einer neuen Zeile
             }
             sw.Close(); // Schließen der StreamWriter-Instanz
             MessageBox.Show("Zahlenfeld.csv wurde erfolgreich erstellt.");*/
           
        }
        public void CalculateAge()

        {

            /*ateTime today = DateTime.Today;
             int age = today.Year - this.Geburtsjahr;
             if (today.Month < this.Geburtsmonat || (today.Month == this.Geburtsmonat && today.Day < this.Geburtstag))
             {
                 age--;
             }
             this.Alter.Text = age.ToString();*/
        }
        //
        private void trennenzeichnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Trennenzeichnen dlgTrennenZeichnen = new Trennenzeichnen())
            {
                dlgTrennenZeichnen.StartPosition = FormStartPosition.CenterParent;
                dlgTrennenZeichnen.ShowDialog();
                if (dlgTrennenZeichnen.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show(dlgTrennenZeichnen.trennenzeichnen);
                }

            }


            //dataGridView1.DataSource = ReadCSV(filePath);
        }
    }
}
