namespace Everything4Rent.Modules.Product
{
    partial class VehicleProducts
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
            this.lblEngine = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblProdYear = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.sddd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEngine
            // 
            this.lblEngine.AutoSize = true;
            this.lblEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngine.Location = new System.Drawing.Point(181, 32);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(87, 24);
            this.lblEngine.TabIndex = 21;
            this.lblEngine.Text = "lblBread";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(165, 89);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(64, 24);
            this.lblColor.TabIndex = 20;
            this.lblColor.Text = "Office";
            // 
            // lblProdYear
            // 
            this.lblProdYear.AutoSize = true;
            this.lblProdYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdYear.Location = new System.Drawing.Point(161, 136);
            this.lblProdYear.Name = "lblProdYear";
            this.lblProdYear.Size = new System.Drawing.Size(176, 24);
            this.lblProdYear.TabIndex = 19;
            this.lblProdYear.Text = "Tel Aviv, Irmiyahu";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(30, 84);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(66, 24);
            this.lbl.TabIndex = 18;
            this.lbl.Text = "Color:";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(26, 136);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(74, 24);
            this.lblSex.TabIndex = 17;
            this.lblSex.Text = "Model:";
            // 
            // sddd
            // 
            this.sddd.AutoSize = true;
            this.sddd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sddd.Location = new System.Drawing.Point(24, 29);
            this.sddd.Name = "sddd";
            this.sddd.Size = new System.Drawing.Size(83, 24);
            this.sddd.TabIndex = 16;
            this.sddd.Text = "Engine:";
            // 
            // VehicleProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEngine);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblProdYear);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.sddd);
            this.Name = "VehicleProducts";
            this.Size = new System.Drawing.Size(362, 188);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblEngine;
        public System.Windows.Forms.Label lblColor;
        public System.Windows.Forms.Label lblProdYear;
        public System.Windows.Forms.Label lbl;
        public System.Windows.Forms.Label lblSex;
        public System.Windows.Forms.Label sddd;
    }
}
