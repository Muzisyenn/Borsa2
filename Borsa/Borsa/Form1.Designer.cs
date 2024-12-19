namespace Borsa
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtApple = new System.Windows.Forms.TextBox();
            this.txtMicrosoft = new System.Windows.Forms.TextBox();
            this.txtAmazon = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVisa = new System.Windows.Forms.TextBox();
            this.txtTesla = new System.Windows.Forms.TextBox();
            this.txtFacebook = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtApple
            // 
            this.txtApple.Location = new System.Drawing.Point(68, 164);
            this.txtApple.Name = "txtApple";
            this.txtApple.ReadOnly = true;
            this.txtApple.Size = new System.Drawing.Size(100, 22);
            this.txtApple.TabIndex = 0;
            this.txtApple.TextChanged += new System.EventHandler(this.txtApple_TextChanged);
            // 
            // txtMicrosoft
            // 
            this.txtMicrosoft.Location = new System.Drawing.Point(211, 164);
            this.txtMicrosoft.Name = "txtMicrosoft";
            this.txtMicrosoft.ReadOnly = true;
            this.txtMicrosoft.Size = new System.Drawing.Size(100, 22);
            this.txtMicrosoft.TabIndex = 1;
            this.txtMicrosoft.TextChanged += new System.EventHandler(this.txtMicrosoft_TextChanged);
            // 
            // txtAmazon
            // 
            this.txtAmazon.Location = new System.Drawing.Point(366, 164);
            this.txtAmazon.Name = "txtAmazon";
            this.txtAmazon.ReadOnly = true;
            this.txtAmazon.Size = new System.Drawing.Size(100, 22);
            this.txtAmazon.TabIndex = 2;
            this.txtAmazon.TextChanged += new System.EventHandler(this.txtAmazon_TextChanged);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(389, 257);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(281, 89);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Apple(APPL)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Microsoft(MSFT)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amazon(AMZN)";
            // 
            // txtVisa
            // 
            this.txtVisa.Location = new System.Drawing.Point(924, 164);
            this.txtVisa.Name = "txtVisa";
            this.txtVisa.ReadOnly = true;
            this.txtVisa.Size = new System.Drawing.Size(100, 22);
            this.txtVisa.TabIndex = 7;
            this.txtVisa.TextChanged += new System.EventHandler(this.txtVisa_TextChanged);
            // 
            // txtTesla
            // 
            this.txtTesla.Location = new System.Drawing.Point(542, 164);
            this.txtTesla.Name = "txtTesla";
            this.txtTesla.ReadOnly = true;
            this.txtTesla.Size = new System.Drawing.Size(100, 22);
            this.txtTesla.TabIndex = 8;
            this.txtTesla.TextChanged += new System.EventHandler(this.txtTesla_TextChanged);
            // 
            // txtFacebook
            // 
            this.txtFacebook.Location = new System.Drawing.Point(733, 164);
            this.txtFacebook.Name = "txtFacebook";
            this.txtFacebook.ReadOnly = true;
            this.txtFacebook.Size = new System.Drawing.Size(100, 22);
            this.txtFacebook.TabIndex = 9;
            this.txtFacebook.TextChanged += new System.EventHandler(this.txtFacebook_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tesla(TSLA)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(730, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Facebook(FB)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(943, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Visa(V)";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1091, 517);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFacebook);
            this.Controls.Add(this.txtTesla);
            this.Controls.Add(this.txtVisa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtAmazon);
            this.Controls.Add(this.txtMicrosoft);
            this.Controls.Add(this.txtApple);
            this.Name = "Form1";
            this.Text = "Borsa Hisse Fiyatları";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtApple;
        private System.Windows.Forms.TextBox txtMicrosoft;
        private System.Windows.Forms.TextBox txtAmazon;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVisa;
        private System.Windows.Forms.TextBox txtTesla;
        private System.Windows.Forms.TextBox txtFacebook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
