namespace PicBox
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.imagen1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagen2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagen3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagen4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagen1ToolStripMenuItem,
            this.imagen2ToolStripMenuItem,
            this.imagen3ToolStripMenuItem,
            this.imagen4ToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // imagen1ToolStripMenuItem
            // 
            this.imagen1ToolStripMenuItem.Name = "imagen1ToolStripMenuItem";
            this.imagen1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imagen1ToolStripMenuItem.Text = "Imagen 1";
            this.imagen1ToolStripMenuItem.Click += new System.EventHandler(this.imagen1ToolStripMenuItem_Click);
            // 
            // imagen2ToolStripMenuItem
            // 
            this.imagen2ToolStripMenuItem.Name = "imagen2ToolStripMenuItem";
            this.imagen2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imagen2ToolStripMenuItem.Text = "Imagen 2";
            this.imagen2ToolStripMenuItem.Click += new System.EventHandler(this.imagen2ToolStripMenuItem_Click);
            // 
            // imagen3ToolStripMenuItem
            // 
            this.imagen3ToolStripMenuItem.Name = "imagen3ToolStripMenuItem";
            this.imagen3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imagen3ToolStripMenuItem.Text = "Imagen 3";
            this.imagen3ToolStripMenuItem.Click += new System.EventHandler(this.imagen3ToolStripMenuItem_Click);
            // 
            // imagen4ToolStripMenuItem
            // 
            this.imagen4ToolStripMenuItem.Name = "imagen4ToolStripMenuItem";
            this.imagen4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imagen4ToolStripMenuItem.Text = "Imagen 4";
            this.imagen4ToolStripMenuItem.Click += new System.EventHandler(this.imagen4ToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PicBox.Properties.Resources.austris_augusts_52p1K0d0euM_unsplash;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 427);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem imagen1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagen2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagen3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagen4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

