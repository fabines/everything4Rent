using Everything4Rent.Modules.RentListings;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Everything4Rent.Modules.DashBoard
{
    partial class AdsPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel flpListingPanel;
        private List<ProductListingModel> productsToDisplay;
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
            this.flpListingPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpListingPanel
            // 
            this.flpListingPanel.AutoScroll = true;
            this.flpListingPanel.BackColor = System.Drawing.SystemColors.Control;
            this.flpListingPanel.Location = new System.Drawing.Point(5, 9);
            this.flpListingPanel.Name = "flpListingPanel";
            this.flpListingPanel.Size = new System.Drawing.Size(752, 357);
            this.flpListingPanel.TabIndex = 0;
            this.flpListingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flpListingPanel_Paint);
            // 
            // AdsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.flpListingPanel);
            this.Name = "AdsPage";
            this.Size = new System.Drawing.Size(771, 373);
            this.Load += new System.EventHandler(this.ListingView_Load);
            this.ResumeLayout(false);

        }

        

        #endregion

    }
}
