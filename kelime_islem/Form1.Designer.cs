namespace kelime_islem
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
            this.label4 = new System.Windows.Forms.Label();
            this.rtbMetin = new System.Windows.Forms.RichTextBox();
            this.lbHarf = new System.Windows.Forms.Label();
            this.lbKelime = new System.Windows.Forms.Label();
            this.lbCumle = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMetin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(403, 531);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kelime sayısı";
            // 
            // rtbMetin
            // 
            this.rtbMetin.Location = new System.Drawing.Point(76, 121);
            this.rtbMetin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rtbMetin.Name = "rtbMetin";
            this.rtbMetin.Size = new System.Drawing.Size(774, 360);
            this.rtbMetin.TabIndex = 4;
            this.rtbMetin.Text = "";
            this.rtbMetin.TextChanged += new System.EventHandler(this.rtbMetin_TextChanged);
            // 
            // lbHarf
            // 
            this.lbHarf.AutoSize = true;
            this.lbHarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lbHarf.Location = new System.Drawing.Point(104, 584);
            this.lbHarf.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHarf.Name = "lbHarf";
            this.lbHarf.Size = new System.Drawing.Size(30, 31);
            this.lbHarf.TabIndex = 5;
            this.lbHarf.Text = "0";
            // 
            // lbKelime
            // 
            this.lbKelime.AutoSize = true;
            this.lbKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lbKelime.Location = new System.Drawing.Point(446, 584);
            this.lbKelime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbKelime.Name = "lbKelime";
            this.lbKelime.Size = new System.Drawing.Size(30, 31);
            this.lbKelime.TabIndex = 7;
            this.lbKelime.Text = "0";
            // 
            // lbCumle
            // 
            this.lbCumle.AutoSize = true;
            this.lbCumle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lbCumle.Location = new System.Drawing.Point(773, 584);
            this.lbCumle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCumle.Name = "lbCumle";
            this.lbCumle.Size = new System.Drawing.Size(30, 31);
            this.lbCumle.TabIndex = 6;
            this.lbCumle.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(723, 531);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cümle Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(71, 531);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Harf Sayısı";
            // 
            // lbMetin
            // 
            this.lbMetin.AutoSize = true;
            this.lbMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbMetin.Location = new System.Drawing.Point(70, 84);
            this.lbMetin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbMetin.Name = "lbMetin";
            this.lbMetin.Size = new System.Drawing.Size(85, 31);
            this.lbMetin.TabIndex = 10;
            this.lbMetin.Text = "Metin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 718);
            this.Controls.Add(this.lbMetin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbKelime);
            this.Controls.Add(this.lbCumle);
            this.Controls.Add(this.lbHarf);
            this.Controls.Add(this.rtbMetin);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Kelime İşlem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbMetin;
        private System.Windows.Forms.Label lbHarf;
        private System.Windows.Forms.Label lbKelime;
        private System.Windows.Forms.Label lbCumle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMetin;
    }
}

