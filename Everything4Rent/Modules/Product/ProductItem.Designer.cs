using System;

namespace Everything4Rent.Modules.Product
{
    partial class ProductItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductItem));
            this.lblPurpose = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nadlanProduct1 = new Everything4Rent.Modules.RentItem.NadlanProduct();
            this.secondHandProducts1 = new Everything4Rent.Modules.Product.SecondHandProducts();
            this.vehicleProducts1 = new Everything4Rent.Modules.Product.VehicleProducts();
            this.petsProducts1 = new Everything4Rent.Modules.Product.PetsProducts();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurpose.Location = new System.Drawing.Point(663, 32);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(79, 24);
            this.lblPurpose.TabIndex = 66;
            this.lblPurpose.Text = "TRADE";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(614, 324);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(135, 31);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit Request";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(468, 324);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 31);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // nadlanProduct1
            // 
            this.nadlanProduct1.Location = new System.Drawing.Point(268, 48);
            this.nadlanProduct1.Name = "nadlanProduct1";
            this.nadlanProduct1.Size = new System.Drawing.Size(377, 181);
            this.nadlanProduct1.TabIndex = 13;
            this.nadlanProduct1.Visible = false;
            // 
            // secondHandProducts1
            // 
            this.secondHandProducts1.Location = new System.Drawing.Point(268, 45);
            this.secondHandProducts1.Name = "secondHandProducts1";
            this.secondHandProducts1.Size = new System.Drawing.Size(403, 183);
            this.secondHandProducts1.TabIndex = 14;
            this.secondHandProducts1.Visible = false;
            // 
            // vehicleProducts1
            // 
            this.vehicleProducts1.Location = new System.Drawing.Point(253, 45);
            this.vehicleProducts1.Name = "vehicleProducts1";
            this.vehicleProducts1.Size = new System.Drawing.Size(436, 184);
            this.vehicleProducts1.TabIndex = 15;
            this.vehicleProducts1.Visible = false;
            // 
            // petsProducts1
            // 
            this.petsProducts1.Location = new System.Drawing.Point(268, 48);
            this.petsProducts1.Name = "petsProducts1";
            this.petsProducts1.Size = new System.Drawing.Size(418, 190);
            this.petsProducts1.TabIndex = 16;
            this.petsProducts1.Visible = false;
            // 
            // ProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPurpose);
            this.Controls.Add(this.petsProducts1);
            this.Controls.Add(this.vehicleProducts1);
            this.Controls.Add(this.secondHandProducts1);
            this.Controls.Add(this.nadlanProduct1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmit);
            this.Name = "ProductItem";
            this.Size = new System.Drawing.Size(771, 373);
            this.Load += new System.EventHandler(this.ItemView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        public System.Windows.Forms.Label lblPurpose;
        public System.Windows.Forms.Button btnSubmit;
        public System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        public RentItem.NadlanProduct nadlanProduct1;
        public SecondHandProducts secondHandProducts1;
        public VehicleProducts vehicleProducts1;
        public PetsProducts petsProducts1;
    }
}
