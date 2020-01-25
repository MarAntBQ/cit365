namespace MegaDesk_Bustillos
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.ANQbtn = new System.Windows.Forms.Button();
            this.VQbtn = new System.Windows.Forms.Button();
            this.SQbtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ANQbtn
            // 
            this.ANQbtn.BackColor = System.Drawing.Color.Yellow;
            this.ANQbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ANQbtn.Location = new System.Drawing.Point(12, 12);
            this.ANQbtn.Name = "ANQbtn";
            this.ANQbtn.Size = new System.Drawing.Size(133, 42);
            this.ANQbtn.TabIndex = 0;
            this.ANQbtn.Text = "&Add a New Quote";
            this.ANQbtn.UseVisualStyleBackColor = false;
            this.ANQbtn.Click += new System.EventHandler(this.ANQbtn_Click);
            // 
            // VQbtn
            // 
            this.VQbtn.BackColor = System.Drawing.Color.Yellow;
            this.VQbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VQbtn.Location = new System.Drawing.Point(12, 69);
            this.VQbtn.Name = "VQbtn";
            this.VQbtn.Size = new System.Drawing.Size(133, 42);
            this.VQbtn.TabIndex = 1;
            this.VQbtn.Text = "&View Quotes";
            this.VQbtn.UseVisualStyleBackColor = false;
            this.VQbtn.Click += new System.EventHandler(this.VQbtn_Click);
            // 
            // SQbtn
            // 
            this.SQbtn.BackColor = System.Drawing.Color.Yellow;
            this.SQbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SQbtn.Location = new System.Drawing.Point(12, 126);
            this.SQbtn.Name = "SQbtn";
            this.SQbtn.Size = new System.Drawing.Size(133, 42);
            this.SQbtn.TabIndex = 2;
            this.SQbtn.Text = "&Search Quotes";
            this.SQbtn.UseVisualStyleBackColor = false;
            this.SQbtn.Click += new System.EventHandler(this.SQbtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.Color.Yellow;
            this.Exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exitbtn.Location = new System.Drawing.Point(12, 194);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(133, 42);
            this.Exitbtn.TabIndex = 3;
            this.Exitbtn.Text = "E&xit";
            this.Exitbtn.UseVisualStyleBackColor = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::MegaDesk_Bustillos.Properties.Resources.Desk;
            this.pictureBox1.Location = new System.Drawing.Point(151, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(427, 248);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.SQbtn);
            this.Controls.Add(this.VQbtn);
            this.Controls.Add(this.ANQbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk - Marco Antonio Bustillos®";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ANQbtn;
        private System.Windows.Forms.Button VQbtn;
        private System.Windows.Forms.Button SQbtn;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

