namespace KlijentForme.Zaduzenje
{
    partial class ZaduzenjePrikaz
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
            this.cmbClan = new System.Windows.Forms.ComboBox();
            this.dgPrikaz = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrikaz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Clan:";
            // 
            // cmbClan
            // 
            this.cmbClan.FormattingEnabled = true;
            this.cmbClan.Location = new System.Drawing.Point(74, 4);
            this.cmbClan.Name = "cmbClan";
            this.cmbClan.Size = new System.Drawing.Size(121, 21);
            this.cmbClan.TabIndex = 13;
            this.cmbClan.SelectedIndexChanged += new System.EventHandler(this.cmbClan_SelectedIndexChanged);
            // 
            // dgPrikaz
            // 
            this.dgPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPrikaz.Location = new System.Drawing.Point(12, 55);
            this.dgPrikaz.Name = "dgPrikaz";
            this.dgPrikaz.Size = new System.Drawing.Size(532, 207);
            this.dgPrikaz.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Razduzi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ZaduzenjePrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 315);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgPrikaz);
            this.Controls.Add(this.cmbClan);
            this.Controls.Add(this.label1);
            this.Name = "ZaduzenjePrikaz";
            this.Text = "ZaduzenjePrikaz";
            this.Load += new System.EventHandler(this.ZaduzenjePrikaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPrikaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClan;
        private System.Windows.Forms.DataGridView dgPrikaz;
        private System.Windows.Forms.Button button1;
    }
}