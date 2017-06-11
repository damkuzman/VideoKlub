namespace KlijentForme.Zaduzenje
{
    partial class ZaduzenjeUnos
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
            this.txtUkIznos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgUnosStavke = new System.Windows.Forms.DataGridView();
            this.btnUnesiStavku = new System.Windows.Forms.Button();
            this.dtpZaduzenje = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpRazduzenje = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgUnosStavke)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clan:";
            // 
            // cmbClan
            // 
            this.cmbClan.FormattingEnabled = true;
            this.cmbClan.Location = new System.Drawing.Point(87, 47);
            this.cmbClan.Name = "cmbClan";
            this.cmbClan.Size = new System.Drawing.Size(121, 21);
            this.cmbClan.TabIndex = 1;
            // 
            // txtUkIznos
            // 
            this.txtUkIznos.Location = new System.Drawing.Point(87, 90);
            this.txtUkIznos.Name = "txtUkIznos";
            this.txtUkIznos.ReadOnly = true;
            this.txtUkIznos.Size = new System.Drawing.Size(121, 20);
            this.txtUkIznos.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "UkupanIznos:";
            // 
            // dgUnosStavke
            // 
            this.dgUnosStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUnosStavke.Location = new System.Drawing.Point(15, 158);
            this.dgUnosStavke.Name = "dgUnosStavke";
            this.dgUnosStavke.Size = new System.Drawing.Size(260, 150);
            this.dgUnosStavke.TabIndex = 4;
            this.dgUnosStavke.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ukupanIznos);
            this.dgUnosStavke.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUnosStavke_RowEnter);
            // 
            // btnUnesiStavku
            // 
            this.btnUnesiStavku.Location = new System.Drawing.Point(339, 222);
            this.btnUnesiStavku.Name = "btnUnesiStavku";
            this.btnUnesiStavku.Size = new System.Drawing.Size(125, 23);
            this.btnUnesiStavku.TabIndex = 5;
            this.btnUnesiStavku.Text = "Sacuvaj zaduzenje";
            this.btnUnesiStavku.UseVisualStyleBackColor = true;
            this.btnUnesiStavku.Click += new System.EventHandler(this.btnUnesiStavku_Click);
            // 
            // dtpZaduzenje
            // 
            this.dtpZaduzenje.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpZaduzenje.Location = new System.Drawing.Point(339, 44);
            this.dtpZaduzenje.Name = "dtpZaduzenje";
            this.dtpZaduzenje.Size = new System.Drawing.Size(125, 20);
            this.dtpZaduzenje.TabIndex = 6;
            this.dtpZaduzenje.Value = new System.DateTime(2012, 8, 26, 16, 27, 33, 0);
            this.dtpZaduzenje.ValueChanged += new System.EventHandler(this.dtpZaduzenje_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Datum zaduzenja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Datum razduzenja:";
            // 
            // dtpRazduzenje
            // 
            this.dtpRazduzenje.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRazduzenje.Location = new System.Drawing.Point(339, 86);
            this.dtpRazduzenje.Name = "dtpRazduzenje";
            this.dtpRazduzenje.Size = new System.Drawing.Size(125, 20);
            this.dtpRazduzenje.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sifra zaduzenja:";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(134, 12);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.ReadOnly = true;
            this.txtSifra.Size = new System.Drawing.Size(74, 20);
            this.txtSifra.TabIndex = 10;
            // 
            // ZaduzenjeUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 320);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.dtpRazduzenje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpZaduzenje);
            this.Controls.Add(this.btnUnesiStavku);
            this.Controls.Add(this.dgUnosStavke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUkIznos);
            this.Controls.Add(this.cmbClan);
            this.Controls.Add(this.label1);
            this.Name = "ZaduzenjeUnos";
            this.Text = "ZaduzenjeUnos";
            this.Load += new System.EventHandler(this.ZaduzenjeUnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUnosStavke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClan;
        private System.Windows.Forms.TextBox txtUkIznos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgUnosStavke;
        private System.Windows.Forms.Button btnUnesiStavku;
        private System.Windows.Forms.DateTimePicker dtpZaduzenje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpRazduzenje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSifra;
    }
}