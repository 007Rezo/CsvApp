namespace CsvApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            addColumnToolStripMenuItem = new ToolStripMenuItem();
            deleteColumnToolStripMenuItem = new ToolStripMenuItem();
            addRowsToolStripMenuItem = new ToolStripMenuItem();
            deleteRowToolStripMenuItem = new ToolStripMenuItem();
            sumColumnsToolStripMenuItem = new ToolStripMenuItem();
            tabellenToolStripMenuItem = new ToolStripMenuItem();
            trennenzeichnenToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(589, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, closeToolStripMenuItem, newToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(180, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(180, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addColumnToolStripMenuItem, deleteColumnToolStripMenuItem, addRowsToolStripMenuItem, deleteRowToolStripMenuItem, sumColumnsToolStripMenuItem, tabellenToolStripMenuItem, trennenzeichnenToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // addColumnToolStripMenuItem
            // 
            addColumnToolStripMenuItem.Name = "addColumnToolStripMenuItem";
            addColumnToolStripMenuItem.Size = new Size(163, 22);
            addColumnToolStripMenuItem.Text = "Add Column";
            addColumnToolStripMenuItem.Click += addColumnToolStripMenuItem_Click;
            // 
            // deleteColumnToolStripMenuItem
            // 
            deleteColumnToolStripMenuItem.Name = "deleteColumnToolStripMenuItem";
            deleteColumnToolStripMenuItem.Size = new Size(163, 22);
            deleteColumnToolStripMenuItem.Text = "Delete Column";
            deleteColumnToolStripMenuItem.Click += deleteColumnToolStripMenuItem_Click;
            // 
            // addRowsToolStripMenuItem
            // 
            addRowsToolStripMenuItem.Name = "addRowsToolStripMenuItem";
            addRowsToolStripMenuItem.Size = new Size(163, 22);
            addRowsToolStripMenuItem.Text = "Add Row";
            addRowsToolStripMenuItem.Click += addRowToolStripMenuItem_Click;
            // 
            // deleteRowToolStripMenuItem
            // 
            deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            deleteRowToolStripMenuItem.Size = new Size(163, 22);
            deleteRowToolStripMenuItem.Text = "Delete Row";
            deleteRowToolStripMenuItem.Click += deleteRowToolStripMenuItem_Click;
            // 
            // sumColumnsToolStripMenuItem
            // 
            sumColumnsToolStripMenuItem.Name = "sumColumnsToolStripMenuItem";
            sumColumnsToolStripMenuItem.Size = new Size(163, 22);
            sumColumnsToolStripMenuItem.Text = "Sum Columns";
            sumColumnsToolStripMenuItem.Click += sumColumnsToolStripMenuItem_Click;
            // 
            // tabellenToolStripMenuItem
            // 
            tabellenToolStripMenuItem.Name = "tabellenToolStripMenuItem";
            tabellenToolStripMenuItem.Size = new Size(163, 22);
            tabellenToolStripMenuItem.Text = "Tabellen";
            tabellenToolStripMenuItem.Click += tabellenToolStripMenuItem_Click;
            // 
            // trennenzeichnenToolStripMenuItem
            // 
            trennenzeichnenToolStripMenuItem.Name = "trennenzeichnenToolStripMenuItem";
            trennenzeichnenToolStripMenuItem.Size = new Size(163, 22);
            trennenzeichnenToolStripMenuItem.Text = "Trennenzeichnen";
            trennenzeichnenToolStripMenuItem.Click += trennenzeichnenToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(589, 426);
            dataGridView1.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(589, 450);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "CSV APP";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //throw new NotImplementedException();
        //}

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem addColumnToolStripMenuItem;
        private ToolStripMenuItem deleteColumnToolStripMenuItem;
        private DataGridView dataGridView1;
        private ToolStripMenuItem addRowsToolStripMenuItem;
        private ToolStripMenuItem deleteRowToolStripMenuItem;
        private ToolStripMenuItem sumColumnsToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem tabellenToolStripMenuItem;
        private ToolStripMenuItem trennenzeichnenToolStripMenuItem;
    }
}