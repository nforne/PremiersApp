namespace Week11_Lab01_PremierApp
{
    partial class PremierApp
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
            this.lbx_Premiers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_PnameAndLife = new System.Windows.Forms.Label();
            this.lbl_PremierAndInfo = new System.Windows.Forms.Label();
            this.pbx_Primier = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Primier)).BeginInit();
            this.SuspendLayout();
            // 
            // lbx_Premiers
            // 
            this.lbx_Premiers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbx_Premiers.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbx_Premiers.FormattingEnabled = true;
            this.lbx_Premiers.ItemHeight = 16;
            this.lbx_Premiers.Location = new System.Drawing.Point(616, 117);
            this.lbx_Premiers.Name = "lbx_Premiers";
            this.lbx_Premiers.Size = new System.Drawing.Size(263, 356);
            this.lbx_Premiers.Sorted = true;
            this.lbx_Premiers.TabIndex = 0;
            this.lbx_Premiers.SelectedIndexChanged += new System.EventHandler(this.lbx_Premiers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(718, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Premiers";
            // 
            // lbl_PnameAndLife
            // 
            this.lbl_PnameAndLife.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_PnameAndLife.AutoSize = true;
            this.lbl_PnameAndLife.Location = new System.Drawing.Point(164, 80);
            this.lbl_PnameAndLife.Name = "lbl_PnameAndLife";
            this.lbl_PnameAndLife.Size = new System.Drawing.Size(0, 16);
            this.lbl_PnameAndLife.TabIndex = 2;
            // 
            // lbl_PremierAndInfo
            // 
            this.lbl_PremierAndInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_PremierAndInfo.AutoSize = true;
            this.lbl_PremierAndInfo.Location = new System.Drawing.Point(164, 475);
            this.lbl_PremierAndInfo.Name = "lbl_PremierAndInfo";
            this.lbl_PremierAndInfo.Size = new System.Drawing.Size(0, 16);
            this.lbl_PremierAndInfo.TabIndex = 3;
            // 
            // pbx_Primier
            // 
            this.pbx_Primier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbx_Primier.Location = new System.Drawing.Point(167, 117);
            this.pbx_Primier.Name = "pbx_Primier";
            this.pbx_Primier.Size = new System.Drawing.Size(315, 356);
            this.pbx_Primier.TabIndex = 4;
            this.pbx_Primier.TabStop = false;
            // 
            // PremierApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 585);
            this.Controls.Add(this.pbx_Primier);
            this.Controls.Add(this.lbl_PremierAndInfo);
            this.Controls.Add(this.lbl_PnameAndLife);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbx_Premiers);
            this.Name = "PremierApp";
            this.Text = "PremierApp";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Primier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_Premiers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_PnameAndLife;
        private System.Windows.Forms.Label lbl_PremierAndInfo;
        private System.Windows.Forms.PictureBox pbx_Primier;
    }
}

