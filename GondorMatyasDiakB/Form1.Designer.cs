namespace GondorMatyasDiak
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdatBe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstEredmeny = new System.Windows.Forms.ListBox();
            this.lblKivalasztott = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lstDiakok = new System.Windows.Forms.ListBox();
            this.pnlEvek = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diakok";
            // 
            // btnAdatBe
            // 
            this.btnAdatBe.Location = new System.Drawing.Point(84, 328);
            this.btnAdatBe.Name = "btnAdatBe";
            this.btnAdatBe.Size = new System.Drawing.Size(75, 23);
            this.btnAdatBe.TabIndex = 2;
            this.btnAdatBe.Text = "Adatbevitel";
            this.btnAdatBe.UseVisualStyleBackColor = true;
            this.btnAdatBe.Click += new System.EventHandler(this.btnAdatBe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Születési év";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "A keresés eredménye:";
            // 
            // lstEredmeny
            // 
            this.lstEredmeny.FormattingEnabled = true;
            this.lstEredmeny.Location = new System.Drawing.Point(306, 253);
            this.lstEredmeny.Name = "lstEredmeny";
            this.lstEredmeny.Size = new System.Drawing.Size(239, 69);
            this.lstEredmeny.TabIndex = 7;
            // 
            // lblKivalasztott
            // 
            this.lblKivalasztott.AutoSize = true;
            this.lblKivalasztott.Location = new System.Drawing.Point(303, 362);
            this.lblKivalasztott.Name = "lblKivalasztott";
            this.lblKivalasztott.Size = new System.Drawing.Size(0, 13);
            this.lblKivalasztott.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lstDiakok
            // 
            this.lstDiakok.FormattingEnabled = true;
            this.lstDiakok.Location = new System.Drawing.Point(35, 84);
            this.lstDiakok.Name = "lstDiakok";
            this.lstDiakok.Size = new System.Drawing.Size(176, 238);
            this.lstDiakok.TabIndex = 9;
            // 
            // pnlEvek
            // 
            this.pnlEvek.Location = new System.Drawing.Point(306, 84);
            this.pnlEvek.Name = "pnlEvek";
            this.pnlEvek.Size = new System.Drawing.Size(239, 57);
            this.pnlEvek.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.pnlEvek);
            this.Controls.Add(this.lstDiakok);
            this.Controls.Add(this.lblKivalasztott);
            this.Controls.Add(this.lstEredmeny);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdatBe);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Diakok adatai";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdatBe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstEredmeny;
        private System.Windows.Forms.Label lblKivalasztott;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lstDiakok;
        private System.Windows.Forms.Panel pnlEvek;
    }
}

