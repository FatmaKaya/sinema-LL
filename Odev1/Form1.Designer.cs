namespace Odev1
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
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtKoltukNo = new System.Windows.Forms.TextBox();
            this.lblKoltukNo = new System.Windows.Forms.Label();
            this.lblKoltukAl = new System.Windows.Forms.Button();
            this.btnKoltukDegistir = new System.Windows.Forms.Button();
            this.btnKoltukDurumları = new System.Windows.Forms.Button();
            this.btnKoltukOgren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(12, 32);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(56, 13);
            this.lblAdSoyad.TabIndex = 0;
            this.lblAdSoyad.Text = "Ad Soyad:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(86, 29);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(129, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // txtKoltukNo
            // 
            this.txtKoltukNo.Location = new System.Drawing.Point(86, 69);
            this.txtKoltukNo.Name = "txtKoltukNo";
            this.txtKoltukNo.Size = new System.Drawing.Size(129, 20);
            this.txtKoltukNo.TabIndex = 3;
            // 
            // lblKoltukNo
            // 
            this.lblKoltukNo.AutoSize = true;
            this.lblKoltukNo.Location = new System.Drawing.Point(12, 72);
            this.lblKoltukNo.Name = "lblKoltukNo";
            this.lblKoltukNo.Size = new System.Drawing.Size(57, 13);
            this.lblKoltukNo.TabIndex = 2;
            this.lblKoltukNo.Text = "Koltuk No:";
            // 
            // lblKoltukAl
            // 
            this.lblKoltukAl.Location = new System.Drawing.Point(15, 123);
            this.lblKoltukAl.Name = "lblKoltukAl";
            this.lblKoltukAl.Size = new System.Drawing.Size(90, 23);
            this.lblKoltukAl.TabIndex = 4;
            this.lblKoltukAl.Text = "Koltuk Al";
            this.lblKoltukAl.UseVisualStyleBackColor = true;
            this.lblKoltukAl.Click += new System.EventHandler(this.lblKoltukAl_Click);
            // 
            // btnKoltukDegistir
            // 
            this.btnKoltukDegistir.Location = new System.Drawing.Point(123, 123);
            this.btnKoltukDegistir.Name = "btnKoltukDegistir";
            this.btnKoltukDegistir.Size = new System.Drawing.Size(92, 23);
            this.btnKoltukDegistir.TabIndex = 5;
            this.btnKoltukDegistir.Text = "Koltuk İptal Et";
            this.btnKoltukDegistir.UseVisualStyleBackColor = true;
            this.btnKoltukDegistir.Click += new System.EventHandler(this.btnKoltukDegistir_Click);
            // 
            // btnKoltukDurumları
            // 
            this.btnKoltukDurumları.Location = new System.Drawing.Point(50, 203);
            this.btnKoltukDurumları.Name = "btnKoltukDurumları";
            this.btnKoltukDurumları.Size = new System.Drawing.Size(116, 23);
            this.btnKoltukDurumları.TabIndex = 6;
            this.btnKoltukDurumları.Text = "Koltuk Durumları";
            this.btnKoltukDurumları.UseVisualStyleBackColor = true;
            this.btnKoltukDurumları.Click += new System.EventHandler(this.btnKoltukDurumları_Click);
            // 
            // btnKoltukOgren
            // 
            this.btnKoltukOgren.Location = new System.Drawing.Point(15, 161);
            this.btnKoltukOgren.Name = "btnKoltukOgren";
            this.btnKoltukOgren.Size = new System.Drawing.Size(200, 23);
            this.btnKoltukOgren.TabIndex = 7;
            this.btnKoltukOgren.Text = "Koltuk Numarası Öğren";
            this.btnKoltukOgren.UseVisualStyleBackColor = true;
            this.btnKoltukOgren.Click += new System.EventHandler(this.btnKoltukOgren_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 261);
            this.Controls.Add(this.btnKoltukOgren);
            this.Controls.Add(this.btnKoltukDurumları);
            this.Controls.Add(this.btnKoltukDegistir);
            this.Controls.Add(this.lblKoltukAl);
            this.Controls.Add(this.txtKoltukNo);
            this.Controls.Add(this.lblKoltukNo);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.lblAdSoyad);
            this.Name = "Form1";
            this.Text = "Bollywood Sineması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtKoltukNo;
        private System.Windows.Forms.Label lblKoltukNo;
        private System.Windows.Forms.Button lblKoltukAl;
        private System.Windows.Forms.Button btnKoltukDegistir;
        private System.Windows.Forms.Button btnKoltukDurumları;
        private System.Windows.Forms.Button btnKoltukOgren;
    }
}

