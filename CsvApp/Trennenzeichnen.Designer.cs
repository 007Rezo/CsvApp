namespace CsvApp
{
    partial class Trennenzeichnen
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox1 = new GroupBox();
            radioButton5 = new RadioButton();
            label1 = new Label();
            btn_Ok = new Button();
            btn_Cancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(15, 20);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(44, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "\"\\t\"";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(15, 44);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(41, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = " \";\"";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(15, 68);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(34, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "' '";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(15, 92);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(40, 19);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "' : '";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Location = new Point(6, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(159, 140);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Trennenzeichnen";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(15, 116);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(40, 19);
            radioButton5.TabIndex = 4;
            radioButton5.TabStop = true;
            radioButton5.Text = "' , '";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 154);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // btn_Ok
            // 
            btn_Ok.DialogResult = DialogResult.OK;
            btn_Ok.Location = new Point(138, 150);
            btn_Ok.Name = "btn_Ok";
            btn_Ok.Size = new Size(65, 23);
            btn_Ok.TabIndex = 6;
            btn_Ok.Text = "OK";
            btn_Ok.UseVisualStyleBackColor = true;
            btn_Ok.Click += ok_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.DialogResult = DialogResult.Cancel;
            btn_Cancel.Location = new Point(59, 150);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(79, 23);
            btn_Cancel.TabIndex = 7;
            btn_Cancel.Text = "Abbrechen";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // Trennenzeichnen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(210, 178);
            ControlBox = false;
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Ok);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "Trennenzeichnen";
            Text = "TrennenZeichnen";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private GroupBox groupBox1;
        private RadioButton radioButton5;
        private Label label1;
        private Button btn_Ok;
        private Button btn_Cancel;
    }
}