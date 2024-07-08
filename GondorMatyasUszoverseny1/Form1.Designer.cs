namespace GondorMatyasUsz
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstVersenyzok = new System.Windows.Forms.ListBox();
            this.txtRajtszam = new System.Windows.Forms.TextBox();
            this.txtOrszag = new System.Windows.Forms.TextBox();
            this.txtIdoEredmeny = new System.Windows.Forms.TextBox();
            this.txtEletKor = new System.Windows.Forms.TextBox();
            this.rchTxtGyoztes = new System.Windows.Forms.RichTextBox();
            this.btnGyoztes = new System.Windows.Forms.Button();
            this.btnAdatBe = new System.Windows.Forms.Button();
            this.btnBezar = new System.Windows.Forms.Button();
            this.txtGyoztesIdo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(111, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "200m-es pillangó úszás";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(52, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Résztvevők:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rajtszám:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ország:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Időeredmény:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Életkor:";
            // 
            // lstVersenyzok
            // 
            this.lstVersenyzok.FormattingEnabled = true;
            this.lstVersenyzok.Location = new System.Drawing.Point(55, 112);
            this.lstVersenyzok.Name = "lstVersenyzok";
            this.lstVersenyzok.Size = new System.Drawing.Size(159, 290);
            this.lstVersenyzok.Sorted = true;
            this.lstVersenyzok.TabIndex = 6;
            this.lstVersenyzok.SelectedIndexChanged += new System.EventHandler(this.lstVersenyzok_SelectedIndexChanged);
            // 
            // txtRajtszam
            // 
            this.txtRajtszam.Location = new System.Drawing.Point(343, 104);
            this.txtRajtszam.Name = "txtRajtszam";
            this.txtRajtszam.Size = new System.Drawing.Size(100, 20);
            this.txtRajtszam.TabIndex = 7;
            // 
            // txtOrszag
            // 
            this.txtOrszag.Location = new System.Drawing.Point(343, 151);
            this.txtOrszag.Name = "txtOrszag";
            this.txtOrszag.Size = new System.Drawing.Size(100, 20);
            this.txtOrszag.TabIndex = 8;
            // 
            // txtIdoEredmeny
            // 
            this.txtIdoEredmeny.Location = new System.Drawing.Point(343, 199);
            this.txtIdoEredmeny.Name = "txtIdoEredmeny";
            this.txtIdoEredmeny.Size = new System.Drawing.Size(100, 20);
            this.txtIdoEredmeny.TabIndex = 9;
            // 
            // txtEletKor
            // 
            this.txtEletKor.Location = new System.Drawing.Point(343, 245);
            this.txtEletKor.Name = "txtEletKor";
            this.txtEletKor.Size = new System.Drawing.Size(100, 20);
            this.txtEletKor.TabIndex = 10;
            // 
            // rchTxtGyoztes
            // 
            this.rchTxtGyoztes.Location = new System.Drawing.Point(235, 304);
            this.rchTxtGyoztes.Name = "rchTxtGyoztes";
            this.rchTxtGyoztes.Size = new System.Drawing.Size(208, 97);
            this.rchTxtGyoztes.TabIndex = 11;
            this.rchTxtGyoztes.Text = "";
            // 
            // btnGyoztes
            // 
            this.btnGyoztes.Enabled = false;
            this.btnGyoztes.Location = new System.Drawing.Point(235, 275);
            this.btnGyoztes.Name = "btnGyoztes";
            this.btnGyoztes.Size = new System.Drawing.Size(97, 20);
            this.btnGyoztes.TabIndex = 12;
            this.btnGyoztes.Text = "Győztes";
            this.btnGyoztes.UseVisualStyleBackColor = true;
            this.btnGyoztes.Click += new System.EventHandler(this.btnGyoztes_Click);
            // 
            // btnAdatBe
            // 
            this.btnAdatBe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdatBe.Location = new System.Drawing.Point(83, 407);
            this.btnAdatBe.Name = "btnAdatBe";
            this.btnAdatBe.Size = new System.Drawing.Size(108, 23);
            this.btnAdatBe.TabIndex = 14;
            this.btnAdatBe.Text = "Adatok beolvasása";
            this.btnAdatBe.UseVisualStyleBackColor = true;
            this.btnAdatBe.Click += new System.EventHandler(this.btnAdatBe_Click);
            // 
            // btnBezar
            // 
            this.btnBezar.Location = new System.Drawing.Point(291, 407);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(105, 23);
            this.btnBezar.TabIndex = 15;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = true;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // txtGyoztesIdo
            // 
            this.txtGyoztesIdo.Location = new System.Drawing.Point(343, 275);
            this.txtGyoztesIdo.Name = "txtGyoztesIdo";
            this.txtGyoztesIdo.Size = new System.Drawing.Size(100, 20);
            this.txtGyoztesIdo.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.txtGyoztesIdo);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.btnAdatBe);
            this.Controls.Add(this.btnGyoztes);
            this.Controls.Add(this.rchTxtGyoztes);
            this.Controls.Add(this.txtEletKor);
            this.Controls.Add(this.txtIdoEredmeny);
            this.Controls.Add(this.txtOrszag);
            this.Controls.Add(this.txtRajtszam);
            this.Controls.Add(this.lstVersenyzok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstVersenyzok;
        private System.Windows.Forms.TextBox txtRajtszam;
        private System.Windows.Forms.TextBox txtOrszag;
        private System.Windows.Forms.TextBox txtIdoEredmeny;
        private System.Windows.Forms.TextBox txtEletKor;
        private System.Windows.Forms.RichTextBox rchTxtGyoztes;
        private System.Windows.Forms.Button btnGyoztes;
        private System.Windows.Forms.Button btnAdatBe;
        private System.Windows.Forms.Button btnBezar;
        private System.Windows.Forms.TextBox txtGyoztesIdo;
    }
}

