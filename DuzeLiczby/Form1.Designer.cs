namespace DuzeLiczby
{
    partial class Form1
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Dodawanie = new System.Windows.Forms.RadioButton();
            this.Odejmowanie = new System.Windows.Forms.RadioButton();
            this.Mnozenie = new System.Windows.Forms.RadioButton();
            this.Dzielenie = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(17, 25);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(139, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ilość liczb w tablicy:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 76);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Dzielenie);
            this.panel2.Controls.Add(this.Mnozenie);
            this.panel2.Controls.Add(this.Odejmowanie);
            this.panel2.Controls.Add(this.Dodawanie);
            this.panel2.Location = new System.Drawing.Point(26, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 158);
            this.panel2.TabIndex = 3;
            // 
            // Dodawanie
            // 
            this.Dodawanie.AutoSize = true;
            this.Dodawanie.Checked = true;
            this.Dodawanie.Cursor = System.Windows.Forms.Cursors.No;
            this.Dodawanie.Location = new System.Drawing.Point(17, 12);
            this.Dodawanie.Name = "Dodawanie";
            this.Dodawanie.Size = new System.Drawing.Size(79, 17);
            this.Dodawanie.TabIndex = 0;
            this.Dodawanie.TabStop = true;
            this.Dodawanie.Text = "Dodawanie";
            this.Dodawanie.UseVisualStyleBackColor = true;
            // 
            // Odejmowanie
            // 
            this.Odejmowanie.AutoSize = true;
            this.Odejmowanie.Location = new System.Drawing.Point(16, 35);
            this.Odejmowanie.Name = "Odejmowanie";
            this.Odejmowanie.Size = new System.Drawing.Size(89, 17);
            this.Odejmowanie.TabIndex = 1;
            this.Odejmowanie.Text = "Odejmowanie";
            this.Odejmowanie.UseVisualStyleBackColor = true;
            // 
            // Mnozenie
            // 
            this.Mnozenie.AutoSize = true;
            this.Mnozenie.Location = new System.Drawing.Point(17, 58);
            this.Mnozenie.Name = "Mnozenie";
            this.Mnozenie.Size = new System.Drawing.Size(71, 17);
            this.Mnozenie.TabIndex = 2;
            this.Mnozenie.Text = "Mnożenie";
            this.Mnozenie.UseVisualStyleBackColor = true;
            // 
            // Dzielenie
            // 
            this.Dzielenie.AutoSize = true;
            this.Dzielenie.Location = new System.Drawing.Point(17, 81);
            this.Dzielenie.Name = "Dzielenie";
            this.Dzielenie.Size = new System.Drawing.Size(68, 17);
            this.Dzielenie.TabIndex = 3;
            this.Dzielenie.Text = "Dzielenie";
            this.Dzielenie.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(222, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(603, 238);
            this.listBox1.TabIndex = 6;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(29, 293);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(795, 108);
            this.listBox2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Logi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Wykonaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 413);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton Dzielenie;
        private System.Windows.Forms.RadioButton Mnozenie;
        private System.Windows.Forms.RadioButton Odejmowanie;
        private System.Windows.Forms.RadioButton Dodawanie;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}

