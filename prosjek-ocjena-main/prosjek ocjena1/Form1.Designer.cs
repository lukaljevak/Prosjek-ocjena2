namespace prosjek_ocjena1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbOcjena = new System.Windows.Forms.ComboBox();
            this.txtOcjena = new System.Windows.Forms.TextBox();
            this.listaOcjena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUčitaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(516, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Unesi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(516, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "Spremi";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(516, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ispiši";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmbOcjena
            // 
            this.cmbOcjena.FormattingEnabled = true;
            this.cmbOcjena.Items.AddRange(new object[] {
            "Hrvatski jezik",
            "Matematika"});
            this.cmbOcjena.Location = new System.Drawing.Point(37, 39);
            this.cmbOcjena.Name = "cmbOcjena";
            this.cmbOcjena.Size = new System.Drawing.Size(121, 28);
            this.cmbOcjena.TabIndex = 3;
            // 
            // txtOcjena
            // 
            this.txtOcjena.Location = new System.Drawing.Point(99, 119);
            this.txtOcjena.Name = "txtOcjena";
            this.txtOcjena.Size = new System.Drawing.Size(100, 26);
            this.txtOcjena.TabIndex = 4;
            this.txtOcjena.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // listaOcjena
            // 
            this.listaOcjena.Location = new System.Drawing.Point(48, 185);
            this.listaOcjena.Multiline = true;
            this.listaOcjena.Name = "listaOcjena";
            this.listaOcjena.Size = new System.Drawing.Size(242, 224);
            this.listaOcjena.TabIndex = 5;
            this.listaOcjena.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ocjena";
            // 
            // btnUčitaj
            // 
            this.btnUčitaj.Location = new System.Drawing.Point(516, 329);
            this.btnUčitaj.Name = "btnUčitaj";
            this.btnUčitaj.Size = new System.Drawing.Size(99, 52);
            this.btnUčitaj.TabIndex = 7;
            this.btnUčitaj.Text = "Učitaj";
            this.btnUčitaj.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(744, 431);
            this.Controls.Add(this.btnUčitaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaOcjena);
            this.Controls.Add(this.txtOcjena);
            this.Controls.Add(this.cmbOcjena);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmbOcjena;
        private System.Windows.Forms.TextBox txtOcjena;
        private System.Windows.Forms.TextBox listaOcjena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUčitaj;
    }
}

