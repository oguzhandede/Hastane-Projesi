
namespace Proje_Hastane
{
    partial class frmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHastaGiris));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGirisyap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(101, 158);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 25);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Üye Ol";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(297, 110);
            this.txtsifre.Margin = new System.Windows.Forms.Padding(24, 23, 24, 23);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(141, 31);
            this.txtsifre.TabIndex = 25;
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(297, 74);
            this.msktc.Margin = new System.Windows.Forms.Padding(24, 23, 24, 23);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(141, 31);
            this.msktc.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(122, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Sifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(47, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "TC Kimik No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 55);
            this.label1.TabIndex = 21;
            this.label1.Text = "Doktor Giriş Paneli";
            // 
            // btnGirisyap
            // 
            this.btnGirisyap.BackColor = System.Drawing.Color.Black;
            this.btnGirisyap.ForeColor = System.Drawing.Color.White;
            this.btnGirisyap.Location = new System.Drawing.Point(297, 150);
            this.btnGirisyap.Name = "btnGirisyap";
            this.btnGirisyap.Size = new System.Drawing.Size(141, 41);
            this.btnGirisyap.TabIndex = 27;
            this.btnGirisyap.Text = "Giriş Yap";
            this.btnGirisyap.UseVisualStyleBackColor = false;
            this.btnGirisyap.Click += new System.EventHandler(this.btnGirisyap_Click);
            // 
            // frmHastaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(499, 233);
            this.Controls.Add(this.btnGirisyap);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeBox = false;
            this.Name = "frmHastaGiris";
            this.Text = "frmHastaGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGirisyap;
    }
}