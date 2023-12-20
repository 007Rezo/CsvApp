namespace CsvApp
{
    partial class SpaltenNamen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            Abbrechen = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            button3 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(230, 368);
            button1.Name = "button1";
            button1.Size = new Size(72, 23);
            button1.TabIndex = 2;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += oK_Click;
            // 
            // Abbrechen
            // 
            Abbrechen.DialogResult = DialogResult.Cancel;
            Abbrechen.Location = new Point(149, 368);
            Abbrechen.Name = "Abbrechen";
            Abbrechen.Size = new Size(75, 23);
            Abbrechen.TabIndex = 3;
            Abbrechen.Text = "Abbrechen\r\n";
            Abbrechen.UseVisualStyleBackColor = true;
            Abbrechen.Click += Abbrechen_Click;
            // 
            // button2
            // 
            button2.Location = new Point(227, 50);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += AddHeaderName_Click;
            // 
            // listBox1
            // 
            listBox1.AllowDrop = true;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 80);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(290, 274);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(149, 50);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Delete_btn;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 23);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // SpaltenNamen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 399);
            ControlBox = false;
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(Abbrechen);
            Controls.Add(button1);
            Name = "SpaltenNamen";
            Text = "SpaltenNamen";
            Load += SpaltenNamen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button Abbrechen;
        private Button button2;
        private ListBox listBox1;
        private Button button3;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox1;
    }
}