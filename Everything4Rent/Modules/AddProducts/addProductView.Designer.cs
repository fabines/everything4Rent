namespace Everything4Rent.Modules.AddProducts
{
    partial class addProductView
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.ddlCondition = new System.Windows.Forms.ComboBox();
            this.ddlComposition = new System.Windows.Forms.ComboBox();
            this.ddlPurpose = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ddlDescription = new System.Windows.Forms.ComboBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.ddlCity = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.ddlStreet = new System.Windows.Forms.TextBox();
            this.lblMaxCapacity = new System.Windows.Forms.Label();
            this.ddlMaxCapacity = new System.Windows.Forms.TextBox();
            this.lblBreed = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.ddlBreed = new System.Windows.Forms.TextBox();
            this.ddlAge = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.ddlSex = new System.Windows.Forms.TextBox();
            this.lblSubCategory = new System.Windows.Forms.Label();
            this.ddlSubCategory = new System.Windows.Forms.TextBox();
            this.lblEngine = new System.Windows.Forms.Label();
            this.ddlEngine = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.ddlColor = new System.Windows.Forms.TextBox();
            this.lblProdYear = new System.Windows.Forms.Label();
            this.ddlProdYear = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.ddlPrice = new System.Windows.Forms.TextBox();
            this.lblDeposite = new System.Windows.Forms.Label();
            this.ddlDeposite = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.lblBundle = new System.Windows.Forms.Label();
            this.ddlBundle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ddlAddons = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(254, 319);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(248, 41);
            this.btnSubmit.TabIndex = 24;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(147, 251);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(200, 20);
            this.dateTo.TabIndex = 23;
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(147, 204);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(200, 20);
            this.dateFrom.TabIndex = 22;
            // 
            // ddlCondition
            // 
            this.ddlCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCondition.FormattingEnabled = true;
            this.ddlCondition.Items.AddRange(new object[] {
            " ",
            "New",
            "Like new",
            "Used",
            "Need Fixing"});
            this.ddlCondition.Location = new System.Drawing.Point(147, 154);
            this.ddlCondition.Name = "ddlCondition";
            this.ddlCondition.Size = new System.Drawing.Size(200, 21);
            this.ddlCondition.TabIndex = 21;
            this.ddlCondition.SelectedIndexChanged += new System.EventHandler(this.ddlCondition_SelectedIndexChanged);
            // 
            // ddlComposition
            // 
            this.ddlComposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlComposition.FormattingEnabled = true;
            this.ddlComposition.Items.AddRange(new object[] {
            " ",
            "Bundle",
            "Single Item"});
            this.ddlComposition.Location = new System.Drawing.Point(147, 110);
            this.ddlComposition.Name = "ddlComposition";
            this.ddlComposition.Size = new System.Drawing.Size(200, 21);
            this.ddlComposition.TabIndex = 20;
            this.ddlComposition.SelectedIndexChanged += new System.EventHandler(this.ddlComposition_SelectedIndexChanged);
            // 
            // ddlPurpose
            // 
            this.ddlPurpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPurpose.FormattingEnabled = true;
            this.ddlPurpose.Items.AddRange(new object[] {
            " ",
            "Trade",
            "Loan",
            "Rent"});
            this.ddlPurpose.Location = new System.Drawing.Point(147, 67);
            this.ddlPurpose.Name = "ddlPurpose";
            this.ddlPurpose.Size = new System.Drawing.Size(200, 21);
            this.ddlPurpose.TabIndex = 19;
            this.ddlPurpose.SelectedIndexChanged += new System.EventHandler(this.ddlType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Condition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Composition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Purpose";
            // 
            // ddlCategory
            // 
            this.ddlCategory.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ddlCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCategory.FormattingEnabled = true;
            this.ddlCategory.Items.AddRange(new object[] {
            " ",
            "Real Estate",
            "Vehicles",
            "2nd Hand",
            "Pets"});
            this.ddlCategory.Location = new System.Drawing.Point(147, 19);
            this.ddlCategory.Name = "ddlCategory";
            this.ddlCategory.Size = new System.Drawing.Size(200, 21);
            this.ddlCategory.TabIndex = 13;
            this.ddlCategory.SelectedIndexChanged += new System.EventHandler(this.ddlCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Category";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(367, 24);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(39, 16);
            this.lblPrice.TabIndex = 26;
            this.lblPrice.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(367, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Description";
            // 
            // ddlDescription
            // 
            this.ddlDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlDescription.FormattingEnabled = true;
            this.ddlDescription.Location = new System.Drawing.Point(493, 62);
            this.ddlDescription.Name = "ddlDescription";
            this.ddlDescription.Size = new System.Drawing.Size(200, 21);
            this.ddlDescription.TabIndex = 29;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(367, 111);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(30, 16);
            this.lblCity.TabIndex = 30;
            this.lblCity.Text = "City";
            this.lblCity.Visible = false;
            // 
            // ddlCity
            // 
            this.ddlCity.BackColor = System.Drawing.SystemColors.Window;
            this.ddlCity.Location = new System.Drawing.Point(493, 106);
            this.ddlCity.Name = "ddlCity";
            this.ddlCity.Size = new System.Drawing.Size(197, 20);
            this.ddlCity.TabIndex = 31;
            this.ddlCity.Visible = false;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(367, 155);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(43, 16);
            this.lblStreet.TabIndex = 32;
            this.lblStreet.Text = "Street";
            this.lblStreet.Visible = false;
            // 
            // ddlStreet
            // 
            this.ddlStreet.BackColor = System.Drawing.SystemColors.Window;
            this.ddlStreet.Location = new System.Drawing.Point(493, 150);
            this.ddlStreet.Name = "ddlStreet";
            this.ddlStreet.Size = new System.Drawing.Size(197, 20);
            this.ddlStreet.TabIndex = 33;
            this.ddlStreet.Visible = false;
            // 
            // lblMaxCapacity
            // 
            this.lblMaxCapacity.AutoSize = true;
            this.lblMaxCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxCapacity.Location = new System.Drawing.Point(367, 204);
            this.lblMaxCapacity.Name = "lblMaxCapacity";
            this.lblMaxCapacity.Size = new System.Drawing.Size(87, 16);
            this.lblMaxCapacity.TabIndex = 34;
            this.lblMaxCapacity.Text = "Max capacity";
            this.lblMaxCapacity.Visible = false;
            // 
            // ddlMaxCapacity
            // 
            this.ddlMaxCapacity.BackColor = System.Drawing.SystemColors.Window;
            this.ddlMaxCapacity.Location = new System.Drawing.Point(493, 203);
            this.ddlMaxCapacity.Name = "ddlMaxCapacity";
            this.ddlMaxCapacity.Size = new System.Drawing.Size(197, 20);
            this.ddlMaxCapacity.TabIndex = 35;
            this.ddlMaxCapacity.Visible = false;
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreed.Location = new System.Drawing.Point(367, 111);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(44, 16);
            this.lblBreed.TabIndex = 36;
            this.lblBreed.Text = "breed";
            this.lblBreed.Visible = false;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(367, 155);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(33, 16);
            this.lblAge.TabIndex = 37;
            this.lblAge.Text = "Age";
            this.lblAge.Visible = false;
            // 
            // ddlBreed
            // 
            this.ddlBreed.BackColor = System.Drawing.SystemColors.Window;
            this.ddlBreed.Location = new System.Drawing.Point(493, 106);
            this.ddlBreed.Name = "ddlBreed";
            this.ddlBreed.Size = new System.Drawing.Size(197, 20);
            this.ddlBreed.TabIndex = 38;
            this.ddlBreed.Visible = false;
            // 
            // ddlAge
            // 
            this.ddlAge.BackColor = System.Drawing.SystemColors.Window;
            this.ddlAge.Location = new System.Drawing.Point(493, 150);
            this.ddlAge.Name = "ddlAge";
            this.ddlAge.Size = new System.Drawing.Size(197, 20);
            this.ddlAge.TabIndex = 39;
            this.ddlAge.Visible = false;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(367, 203);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(31, 16);
            this.lblSex.TabIndex = 40;
            this.lblSex.Text = "Sex";
            this.lblSex.Visible = false;
            // 
            // ddlSex
            // 
            this.ddlSex.BackColor = System.Drawing.SystemColors.Window;
            this.ddlSex.Location = new System.Drawing.Point(493, 202);
            this.ddlSex.Name = "ddlSex";
            this.ddlSex.Size = new System.Drawing.Size(197, 20);
            this.ddlSex.TabIndex = 41;
            this.ddlSex.Visible = false;
            // 
            // lblSubCategory
            // 
            this.lblSubCategory.AutoSize = true;
            this.lblSubCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubCategory.Location = new System.Drawing.Point(367, 111);
            this.lblSubCategory.Name = "lblSubCategory";
            this.lblSubCategory.Size = new System.Drawing.Size(88, 16);
            this.lblSubCategory.TabIndex = 42;
            this.lblSubCategory.Text = "Sub category";
            this.lblSubCategory.Visible = false;
            // 
            // ddlSubCategory
            // 
            this.ddlSubCategory.BackColor = System.Drawing.SystemColors.Window;
            this.ddlSubCategory.Location = new System.Drawing.Point(493, 107);
            this.ddlSubCategory.Name = "ddlSubCategory";
            this.ddlSubCategory.Size = new System.Drawing.Size(197, 20);
            this.ddlSubCategory.TabIndex = 43;
            this.ddlSubCategory.Visible = false;
            // 
            // lblEngine
            // 
            this.lblEngine.AutoSize = true;
            this.lblEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngine.Location = new System.Drawing.Point(367, 111);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(50, 16);
            this.lblEngine.TabIndex = 44;
            this.lblEngine.Text = "Engine";
            this.lblEngine.Visible = false;
            this.lblEngine.Click += new System.EventHandler(this.lblEngine_Click);
            // 
            // ddlEngine
            // 
            this.ddlEngine.BackColor = System.Drawing.SystemColors.Window;
            this.ddlEngine.Location = new System.Drawing.Point(493, 106);
            this.ddlEngine.Name = "ddlEngine";
            this.ddlEngine.Size = new System.Drawing.Size(197, 20);
            this.ddlEngine.TabIndex = 45;
            this.ddlEngine.Visible = false;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(367, 159);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(40, 16);
            this.lblColor.TabIndex = 46;
            this.lblColor.Text = "Color";
            this.lblColor.Visible = false;
            // 
            // ddlColor
            // 
            this.ddlColor.BackColor = System.Drawing.SystemColors.Window;
            this.ddlColor.Location = new System.Drawing.Point(493, 151);
            this.ddlColor.Name = "ddlColor";
            this.ddlColor.Size = new System.Drawing.Size(197, 20);
            this.ddlColor.TabIndex = 47;
            this.ddlColor.Visible = false;
            // 
            // lblProdYear
            // 
            this.lblProdYear.AutoSize = true;
            this.lblProdYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdYear.Location = new System.Drawing.Point(366, 203);
            this.lblProdYear.Name = "lblProdYear";
            this.lblProdYear.Size = new System.Drawing.Size(104, 16);
            this.lblProdYear.TabIndex = 48;
            this.lblProdYear.Text = "Production Year";
            this.lblProdYear.Visible = false;
            // 
            // ddlProdYear
            // 
            this.ddlProdYear.BackColor = System.Drawing.SystemColors.Window;
            this.ddlProdYear.Location = new System.Drawing.Point(493, 203);
            this.ddlProdYear.Name = "ddlProdYear";
            this.ddlProdYear.Size = new System.Drawing.Size(197, 20);
            this.ddlProdYear.TabIndex = 49;
            this.ddlProdYear.Visible = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(508, 319);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(248, 41);
            this.btnAddProduct.TabIndex = 50;
            this.btnAddProduct.Text = "Add another product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Visible = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // ddlPrice
            // 
            this.ddlPrice.BackColor = System.Drawing.SystemColors.Window;
            this.ddlPrice.Location = new System.Drawing.Point(493, 20);
            this.ddlPrice.Name = "ddlPrice";
            this.ddlPrice.Size = new System.Drawing.Size(197, 20);
            this.ddlPrice.TabIndex = 51;
            // 
            // lblDeposite
            // 
            this.lblDeposite.AutoSize = true;
            this.lblDeposite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposite.Location = new System.Drawing.Point(367, 24);
            this.lblDeposite.Name = "lblDeposite";
            this.lblDeposite.Size = new System.Drawing.Size(63, 16);
            this.lblDeposite.TabIndex = 53;
            this.lblDeposite.Text = "Deposite";
            this.lblDeposite.Visible = false;
            this.lblDeposite.Click += new System.EventHandler(this.label9_Click);
            // 
            // ddlDeposite
            // 
            this.ddlDeposite.BackColor = System.Drawing.SystemColors.Window;
            this.ddlDeposite.Location = new System.Drawing.Point(493, 20);
            this.ddlDeposite.Name = "ddlDeposite";
            this.ddlDeposite.Size = new System.Drawing.Size(197, 20);
            this.ddlDeposite.TabIndex = 54;
            this.ddlDeposite.Visible = false;
            this.ddlDeposite.TextChanged += new System.EventHandler(this.ddlDeposite_TextChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(3, 319);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(248, 41);
            this.buttonClear.TabIndex = 55;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // lblBundle
            // 
            this.lblBundle.AutoSize = true;
            this.lblBundle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBundle.Location = new System.Drawing.Point(366, 251);
            this.lblBundle.Name = "lblBundle";
            this.lblBundle.Size = new System.Drawing.Size(100, 16);
            this.lblBundle.TabIndex = 56;
            this.lblBundle.Text = "name of bundle";
            this.lblBundle.Visible = false;
            // 
            // ddlBundle
            // 
            this.ddlBundle.BackColor = System.Drawing.SystemColors.Window;
            this.ddlBundle.Location = new System.Drawing.Point(493, 249);
            this.ddlBundle.Name = "ddlBundle";
            this.ddlBundle.Size = new System.Drawing.Size(197, 20);
            this.ddlBundle.TabIndex = 57;
            this.ddlBundle.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 58;
            this.label7.Text = "addons";
            // 
            // ddlAddons
            // 
            this.ddlAddons.BackColor = System.Drawing.SystemColors.Window;
            this.ddlAddons.Location = new System.Drawing.Point(147, 288);
            this.ddlAddons.Name = "ddlAddons";
            this.ddlAddons.Size = new System.Drawing.Size(197, 20);
            this.ddlAddons.TabIndex = 59;
            // 
            // addProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.ddlAddons);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ddlBundle);
            this.Controls.Add(this.lblBundle);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.ddlDeposite);
            this.Controls.Add(this.lblDeposite);
            this.Controls.Add(this.ddlPrice);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.ddlProdYear);
            this.Controls.Add(this.lblProdYear);
            this.Controls.Add(this.ddlColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.ddlEngine);
            this.Controls.Add(this.lblEngine);
            this.Controls.Add(this.ddlSubCategory);
            this.Controls.Add(this.lblSubCategory);
            this.Controls.Add(this.ddlSex);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.ddlAge);
            this.Controls.Add(this.ddlBreed);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblBreed);
            this.Controls.Add(this.ddlMaxCapacity);
            this.Controls.Add(this.lblMaxCapacity);
            this.Controls.Add(this.ddlStreet);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.ddlCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.ddlDescription);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.ddlCondition);
            this.Controls.Add(this.ddlComposition);
            this.Controls.Add(this.ddlPurpose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ddlCategory);
            this.Name = "addProductView";
            this.Size = new System.Drawing.Size(771, 373);
            this.Load += new System.EventHandler(this.addProductView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.ComboBox ddlCondition;
        private System.Windows.Forms.ComboBox ddlComposition;
        private System.Windows.Forms.ComboBox ddlPurpose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox ddlCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox ddlDescription;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox ddlCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox ddlStreet;
        private System.Windows.Forms.Label lblMaxCapacity;
        private System.Windows.Forms.TextBox ddlMaxCapacity;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox ddlBreed;
        private System.Windows.Forms.TextBox ddlAge;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.TextBox ddlSex;
        private System.Windows.Forms.Label lblSubCategory;
        private System.Windows.Forms.TextBox ddlSubCategory;
        private System.Windows.Forms.Label lblEngine;
        private System.Windows.Forms.TextBox ddlEngine;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox ddlColor;
        private System.Windows.Forms.Label lblProdYear;
        private System.Windows.Forms.TextBox ddlProdYear;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox ddlPrice;
        private System.Windows.Forms.Label lblDeposite;
        private System.Windows.Forms.TextBox ddlDeposite;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label lblBundle;
        private System.Windows.Forms.TextBox ddlBundle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ddlAddons;
    }
}
