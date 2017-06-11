namespace KlijentForme
{
    partial class PocetnaForma
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosClanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledIIzmenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledIIzmenaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zaduzenjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosZaduzenjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledZaduzenjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clanToolStripMenuItem,
            this.filmToolStripMenuItem,
            this.zaduzenjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(860, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clanToolStripMenuItem
            // 
            this.clanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosClanaToolStripMenuItem,
            this.pregledIIzmenaToolStripMenuItem});
            this.clanToolStripMenuItem.Name = "clanToolStripMenuItem";
            this.clanToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.clanToolStripMenuItem.Text = "Clan";
            // 
            // unosClanaToolStripMenuItem
            // 
            this.unosClanaToolStripMenuItem.Name = "unosClanaToolStripMenuItem";
            this.unosClanaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.unosClanaToolStripMenuItem.Text = "Unos clana";
            this.unosClanaToolStripMenuItem.Click += new System.EventHandler(this.unosClanaToolStripMenuItem_Click);
            // 
            // pregledIIzmenaToolStripMenuItem
            // 
            this.pregledIIzmenaToolStripMenuItem.Name = "pregledIIzmenaToolStripMenuItem";
            this.pregledIIzmenaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.pregledIIzmenaToolStripMenuItem.Text = "Pregled i izmena";
            this.pregledIIzmenaToolStripMenuItem.Click += new System.EventHandler(this.pregledIIzmenaToolStripMenuItem_Click);
            // 
            // filmToolStripMenuItem
            // 
            this.filmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.pregledIIzmenaToolStripMenuItem1});
            this.filmToolStripMenuItem.Name = "filmToolStripMenuItem";
            this.filmToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filmToolStripMenuItem.Text = "Film";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.unosToolStripMenuItem.Text = "Unos";
            this.unosToolStripMenuItem.Click += new System.EventHandler(this.unosToolStripMenuItem_Click);
            // 
            // pregledIIzmenaToolStripMenuItem1
            // 
            this.pregledIIzmenaToolStripMenuItem1.Name = "pregledIIzmenaToolStripMenuItem1";
            this.pregledIIzmenaToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.pregledIIzmenaToolStripMenuItem1.Text = "Pregled i izmena";
            this.pregledIIzmenaToolStripMenuItem1.Click += new System.EventHandler(this.pregledIIzmenaToolStripMenuItem1_Click);
            // 
            // zaduzenjeToolStripMenuItem
            // 
            this.zaduzenjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosZaduzenjaToolStripMenuItem,
            this.pregledZaduzenjaToolStripMenuItem});
            this.zaduzenjeToolStripMenuItem.Name = "zaduzenjeToolStripMenuItem";
            this.zaduzenjeToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.zaduzenjeToolStripMenuItem.Text = "Zaduzenje";
            // 
            // unosZaduzenjaToolStripMenuItem
            // 
            this.unosZaduzenjaToolStripMenuItem.Name = "unosZaduzenjaToolStripMenuItem";
            this.unosZaduzenjaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.unosZaduzenjaToolStripMenuItem.Text = "Unos zaduzenja";
            this.unosZaduzenjaToolStripMenuItem.Click += new System.EventHandler(this.unosZaduzenjaToolStripMenuItem_Click);
            // 
            // pregledZaduzenjaToolStripMenuItem
            // 
            this.pregledZaduzenjaToolStripMenuItem.Name = "pregledZaduzenjaToolStripMenuItem";
            this.pregledZaduzenjaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.pregledZaduzenjaToolStripMenuItem.Text = "Pregled zaduzenja";
            this.pregledZaduzenjaToolStripMenuItem.Click += new System.EventHandler(this.pregledZaduzenjaToolStripMenuItem_Click);
            // 
            // PocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 403);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "PocetnaForma";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PocetnaForma_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosClanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledIIzmenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledIIzmenaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zaduzenjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosZaduzenjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledZaduzenjaToolStripMenuItem;
    }
}

