namespace Everything4Rent.Modules.Product
{
    partial class PetsProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBread = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.aaaa = new System.Windows.Forms.Label();
            this.sadsa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBread
            // 
            this.lblBread.AutoSize = true;
            this.lblBread.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBread.Location = new System.Drawing.Point(174, 36);
            this.lblBread.Name = "lblBread";
            this.lblBread.Size = new System.Drawing.Size(87, 24);
            this.lblBread.TabIndex = 15;
            this.lblBread.Text = "lblBread";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(158, 93);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(64, 24);
            this.lblAge.TabIndex = 14;
            this.lblAge.Text = "Office";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(154, 140);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(176, 24);
            this.lblSex.TabIndex = 13;
            this.lblSex.Text = "Tel Aviv, Irmiyahu";
            // 
            // aaaa
            // 
            this.aaaa.AutoSize = true;
            this.aaaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aaaa.Location = new System.Drawing.Point(23, 88);
            this.aaaa.Name = "aaaa";
            this.aaaa.Size = new System.Drawing.Size(54, 24);
            this.aaaa.TabIndex = 12;
            this.aaaa.Text = "Age:";
            // 
            // sadsa
            // 
            this.sadsa.AutoSize = true;
            this.sadsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sadsa.Location = new System.Drawing.Point(23, 140);
            this.sadsa.Name = "sadsa";
            this.sadsa.Size = new System.Drawing.Size(52, 24);
            this.sadsa.TabIndex = 11;
            this.sadsa.Text = "Sex:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Breed:";
            // 
            // PetsProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblBread);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.aaaa);
            this.Controls.Add(this.sadsa);
            this.Controls.Add(this.label1);
            this.Name = "PetsProducts";
            this.Size = new System.Drawing.Size(346, 197);
            this.Load += new System.EventHandler(this.PetsProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblBread;
        public System.Windows.Forms.Label lblAge;
        public System.Windows.Forms.Label lblSex;
        public System.Windows.Forms.Label aaaa;
        public System.Windows.Forms.Label sadsa;
        public System.Windows.Forms.Label label1;
    }
}
