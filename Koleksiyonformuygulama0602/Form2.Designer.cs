
namespace Koleksiyonformuygulama0602
{
    partial class Form2
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
            this.girişEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapListelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitaplarıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girişEkranıToolStripMenuItem,
            this.kitapListelemeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // girişEkranıToolStripMenuItem
            // 
            this.girişEkranıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıGirişiToolStripMenuItem});
            this.girişEkranıToolStripMenuItem.Name = "girişEkranıToolStripMenuItem";
            this.girişEkranıToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.girişEkranıToolStripMenuItem.Text = "Kitap Ekleme";
            // 
            // kullanıcıGirişiToolStripMenuItem
            // 
            this.kullanıcıGirişiToolStripMenuItem.Name = "kullanıcıGirişiToolStripMenuItem";
            this.kullanıcıGirişiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kullanıcıGirişiToolStripMenuItem.Text = "Yeni Kitap";
            this.kullanıcıGirişiToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıGirişiToolStripMenuItem_Click);
            // 
            // kitapListelemeToolStripMenuItem
            // 
            this.kitapListelemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitaplarıListeleToolStripMenuItem});
            this.kitapListelemeToolStripMenuItem.Name = "kitapListelemeToolStripMenuItem";
            this.kitapListelemeToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.kitapListelemeToolStripMenuItem.Text = "Listeleme";
            this.kitapListelemeToolStripMenuItem.Click += new System.EventHandler(this.kitapListelemeToolStripMenuItem_Click);
            // 
            // kitaplarıListeleToolStripMenuItem
            // 
            this.kitaplarıListeleToolStripMenuItem.Name = "kitaplarıListeleToolStripMenuItem";
            this.kitaplarıListeleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kitaplarıListeleToolStripMenuItem.Text = "Kitapları Listele";
            this.kitaplarıListeleToolStripMenuItem.Click += new System.EventHandler(this.kitaplarıListeleToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem girişEkranıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıGirişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapListelemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitaplarıListeleToolStripMenuItem;
    }
}