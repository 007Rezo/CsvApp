namespace CsvApp
{
    partial class Tabellengoß
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
            groupBox1 = new GroupBox();
            numeric_Zeilen = new NumericUpDown();
            label2 = new Label();
            numeric_Spalten = new NumericUpDown();
            label1 = new Label();
            btn_Ok = new Button();
            btn_Cancel = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numeric_Zeilen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numeric_Spalten).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numeric_Zeilen);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numeric_Spalten);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 87);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tabellengroß";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // numeric_Zeilen
            // 
            numeric_Zeilen.Location = new Point(87, 54);
            numeric_Zeilen.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numeric_Zeilen.Name = "numeric_Zeilen";
            numeric_Zeilen.Size = new Size(120, 23);
            numeric_Zeilen.TabIndex = 5;
            numeric_Zeilen.ValueChanged += numeric_Zeilen_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 54);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 6;
            label2.Text = "Zeilen";
            // 
            // numeric_Spalten
            // 
            numeric_Spalten.Location = new Point(86, 28);
            numeric_Spalten.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numeric_Spalten.Name = "numeric_Spalten";
            numeric_Spalten.Size = new Size(120, 23);
            numeric_Spalten.TabIndex = 4;
            numeric_Spalten.ValueChanged += numeric_Spalten_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 28);
            label1.Name = "label1";
            label1.Size = new Size(62, 21);
            label1.TabIndex = 3;
            label1.Text = "Spalten";
            // 
            // btn_Ok
            // 
            btn_Ok.DialogResult = DialogResult.OK;
            btn_Ok.Location = new Point(183, 98);
            btn_Ok.Margin = new Padding(3, 2, 3, 2);
            btn_Ok.Name = "btn_Ok";
            btn_Ok.Size = new Size(82, 22);
            btn_Ok.TabIndex = 7;
            btn_Ok.Text = "OK";
            btn_Ok.UseVisualStyleBackColor = true;
            btn_Ok.Click += oK_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.DialogResult = DialogResult.Cancel;
            btn_Cancel.Location = new Point(96, 98);
            btn_Cancel.Margin = new Padding(3, 2, 3, 2);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(82, 22);
            btn_Cancel.TabIndex = 8;
            btn_Cancel.Text = "Abbrechen";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // Tabellengoß
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 124);
            ControlBox = false;
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Ok);
            Controls.Add(groupBox1);
            Name = "Tabellengoß";
            Text = "Tabellengroß";
            Load += Tabellengoß_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numeric_Zeilen).EndInit();
            ((System.ComponentModel.ISupportInitialize)numeric_Spalten).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private NumericUpDown numeric_Zeilen;
        private Label label2;
        private NumericUpDown numeric_Spalten;
        private Button btn_Ok;
        private Button btn_Cancel;
    }
}