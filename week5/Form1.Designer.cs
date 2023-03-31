namespace week5
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_all = new System.Windows.Forms.Button();
            this.button_filter = new System.Windows.Forms.Button();
            this.combobox_filter = new System.Windows.Forms.ComboBox();
            this.label_category = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label_name = new System.Windows.Forms.Label();
            this.txtbox_namedetail = new System.Windows.Forms.TextBox();
            this.label_category2 = new System.Windows.Forms.Label();
            this.label_detail = new System.Windows.Forms.Label();
            this.combobox_categorydetail = new System.Windows.Forms.ComboBox();
            this.label_price = new System.Windows.Forms.Label();
            this.txtbox_price = new System.Windows.Forms.TextBox();
            this.label_stock = new System.Windows.Forms.Label();
            this.txtbox_stock = new System.Windows.Forms.TextBox();
            this.label_name2 = new System.Windows.Forms.Label();
            this.txtbox_namecategory = new System.Windows.Forms.TextBox();
            this.button_addcategory = new System.Windows.Forms.Button();
            this.button_removecategory = new System.Windows.Forms.Button();
            this.button_addproduct = new System.Windows.Forms.Button();
            this.button_editproduct = new System.Windows.Forms.Button();
            this.button_removeproduct = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_welkom = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(382, 194);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button_all
            // 
            this.button_all.Location = new System.Drawing.Point(432, 59);
            this.button_all.Name = "button_all";
            this.button_all.Size = new System.Drawing.Size(75, 23);
            this.button_all.TabIndex = 2;
            this.button_all.Text = "ALL";
            this.button_all.UseVisualStyleBackColor = true;
            this.button_all.Click += new System.EventHandler(this.button_all_Click);
            // 
            // button_filter
            // 
            this.button_filter.Location = new System.Drawing.Point(432, 103);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(75, 23);
            this.button_filter.TabIndex = 3;
            this.button_filter.Text = "FILTER";
            this.button_filter.UseVisualStyleBackColor = true;
            this.button_filter.Click += new System.EventHandler(this.button_filter_Click);
            // 
            // combobox_filter
            // 
            this.combobox_filter.Enabled = false;
            this.combobox_filter.FormattingEnabled = true;
            this.combobox_filter.Location = new System.Drawing.Point(432, 151);
            this.combobox_filter.Name = "combobox_filter";
            this.combobox_filter.Size = new System.Drawing.Size(75, 21);
            this.combobox_filter.TabIndex = 4;
            this.combobox_filter.SelectionChangeCommitted += new System.EventHandler(this.combobox_filter_SelectionChangeCommitted);
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_category.Location = new System.Drawing.Point(622, 19);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(84, 26);
            this.label_category.TabIndex = 5;
            this.label_category.Text = "CATEGORY";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(577, 59);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(185, 113);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(25, 312);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(38, 13);
            this.label_name.TabIndex = 7;
            this.label_name.Text = "NAME";
            // 
            // txtbox_namedetail
            // 
            this.txtbox_namedetail.Location = new System.Drawing.Point(111, 309);
            this.txtbox_namedetail.Name = "txtbox_namedetail";
            this.txtbox_namedetail.Size = new System.Drawing.Size(180, 20);
            this.txtbox_namedetail.TabIndex = 8;
            // 
            // label_category2
            // 
            this.label_category2.AutoSize = true;
            this.label_category2.Location = new System.Drawing.Point(25, 343);
            this.label_category2.Name = "label_category2";
            this.label_category2.Size = new System.Drawing.Size(66, 13);
            this.label_category2.TabIndex = 9;
            this.label_category2.Text = "CATEGORY";
            // 
            // label_detail
            // 
            this.label_detail.AutoSize = true;
            this.label_detail.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_detail.Location = new System.Drawing.Point(176, 265);
            this.label_detail.Name = "label_detail";
            this.label_detail.Size = new System.Drawing.Size(59, 26);
            this.label_detail.TabIndex = 10;
            this.label_detail.Text = "DETAIL";
            // 
            // combobox_categorydetail
            // 
            this.combobox_categorydetail.FormattingEnabled = true;
            this.combobox_categorydetail.Location = new System.Drawing.Point(111, 340);
            this.combobox_categorydetail.Name = "combobox_categorydetail";
            this.combobox_categorydetail.Size = new System.Drawing.Size(121, 21);
            this.combobox_categorydetail.TabIndex = 11;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(25, 376);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(39, 13);
            this.label_price.TabIndex = 12;
            this.label_price.Text = "PRICE";
            // 
            // txtbox_price
            // 
            this.txtbox_price.Location = new System.Drawing.Point(111, 373);
            this.txtbox_price.Name = "txtbox_price";
            this.txtbox_price.Size = new System.Drawing.Size(100, 20);
            this.txtbox_price.TabIndex = 13;
            this.txtbox_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_price_KeyPress);
            // 
            // label_stock
            // 
            this.label_stock.AutoSize = true;
            this.label_stock.Location = new System.Drawing.Point(25, 411);
            this.label_stock.Name = "label_stock";
            this.label_stock.Size = new System.Drawing.Size(43, 13);
            this.label_stock.TabIndex = 14;
            this.label_stock.Text = "STOCK";
            // 
            // txtbox_stock
            // 
            this.txtbox_stock.Location = new System.Drawing.Point(111, 404);
            this.txtbox_stock.Name = "txtbox_stock";
            this.txtbox_stock.Size = new System.Drawing.Size(100, 20);
            this.txtbox_stock.TabIndex = 15;
            this.txtbox_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_stock_KeyPress);
            // 
            // label_name2
            // 
            this.label_name2.AutoSize = true;
            this.label_name2.Location = new System.Drawing.Point(574, 191);
            this.label_name2.Name = "label_name2";
            this.label_name2.Size = new System.Drawing.Size(38, 13);
            this.label_name2.TabIndex = 16;
            this.label_name2.Text = "NAME";
            // 
            // txtbox_namecategory
            // 
            this.txtbox_namecategory.Location = new System.Drawing.Point(627, 188);
            this.txtbox_namecategory.Name = "txtbox_namecategory";
            this.txtbox_namecategory.Size = new System.Drawing.Size(100, 20);
            this.txtbox_namecategory.TabIndex = 17;
            // 
            // button_addcategory
            // 
            this.button_addcategory.BackColor = System.Drawing.Color.LimeGreen;
            this.button_addcategory.Location = new System.Drawing.Point(577, 215);
            this.button_addcategory.Name = "button_addcategory";
            this.button_addcategory.Size = new System.Drawing.Size(75, 38);
            this.button_addcategory.TabIndex = 18;
            this.button_addcategory.Text = "ADD CATEGORY";
            this.button_addcategory.UseVisualStyleBackColor = false;
            this.button_addcategory.Click += new System.EventHandler(this.button_addcategory_Click);
            // 
            // button_removecategory
            // 
            this.button_removecategory.BackColor = System.Drawing.Color.Red;
            this.button_removecategory.Location = new System.Drawing.Point(671, 215);
            this.button_removecategory.Name = "button_removecategory";
            this.button_removecategory.Size = new System.Drawing.Size(80, 38);
            this.button_removecategory.TabIndex = 19;
            this.button_removecategory.Text = "REMOVE CATEGORY";
            this.button_removecategory.UseVisualStyleBackColor = false;
            this.button_removecategory.Click += new System.EventHandler(this.button_removecategory_Click);
            // 
            // button_addproduct
            // 
            this.button_addproduct.BackColor = System.Drawing.Color.LimeGreen;
            this.button_addproduct.Location = new System.Drawing.Point(335, 312);
            this.button_addproduct.Name = "button_addproduct";
            this.button_addproduct.Size = new System.Drawing.Size(102, 32);
            this.button_addproduct.TabIndex = 20;
            this.button_addproduct.Text = "ADD PRODUCT";
            this.button_addproduct.UseVisualStyleBackColor = false;
            this.button_addproduct.Click += new System.EventHandler(this.button_addproduct_Click);
            // 
            // button_editproduct
            // 
            this.button_editproduct.BackColor = System.Drawing.Color.Yellow;
            this.button_editproduct.Location = new System.Drawing.Point(335, 350);
            this.button_editproduct.Name = "button_editproduct";
            this.button_editproduct.Size = new System.Drawing.Size(102, 35);
            this.button_editproduct.TabIndex = 21;
            this.button_editproduct.Text = "EDIT PRODUCT";
            this.button_editproduct.UseVisualStyleBackColor = false;
            this.button_editproduct.Click += new System.EventHandler(this.button_editproduct_Click);
            // 
            // button_removeproduct
            // 
            this.button_removeproduct.BackColor = System.Drawing.Color.Red;
            this.button_removeproduct.Location = new System.Drawing.Point(335, 391);
            this.button_removeproduct.Name = "button_removeproduct";
            this.button_removeproduct.Size = new System.Drawing.Size(102, 47);
            this.button_removeproduct.TabIndex = 22;
            this.button_removeproduct.Text = "REMOVE PRODUCT";
            this.button_removeproduct.UseVisualStyleBackColor = false;
            this.button_removeproduct.Click += new System.EventHandler(this.button_removeproduct_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::week5.Properties.Resources.gambardora3;
            this.pictureBox1.Location = new System.Drawing.Point(491, 293);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label_welkom
            // 
            this.label_welkom.AutoSize = true;
            this.label_welkom.BackColor = System.Drawing.Color.White;
            this.label_welkom.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welkom.Location = new System.Drawing.Point(644, 277);
            this.label_welkom.Name = "label_welkom";
            this.label_welkom.Size = new System.Drawing.Size(158, 31);
            this.label_welkom.TabIndex = 24;
            this.label_welkom.Text = "WELKOM BROHH";
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 250;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_welkom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_removeproduct);
            this.Controls.Add(this.button_editproduct);
            this.Controls.Add(this.button_addproduct);
            this.Controls.Add(this.button_removecategory);
            this.Controls.Add(this.button_addcategory);
            this.Controls.Add(this.txtbox_namecategory);
            this.Controls.Add(this.label_name2);
            this.Controls.Add(this.txtbox_stock);
            this.Controls.Add(this.label_stock);
            this.Controls.Add(this.txtbox_price);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.combobox_categorydetail);
            this.Controls.Add(this.label_detail);
            this.Controls.Add(this.label_category2);
            this.Controls.Add(this.txtbox_namedetail);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label_category);
            this.Controls.Add(this.combobox_filter);
            this.Controls.Add(this.button_filter);
            this.Controls.Add(this.button_all);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_all;
        private System.Windows.Forms.Button button_filter;
        private System.Windows.Forms.ComboBox combobox_filter;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox txtbox_namedetail;
        private System.Windows.Forms.Label label_category2;
        private System.Windows.Forms.Label label_detail;
        private System.Windows.Forms.ComboBox combobox_categorydetail;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.TextBox txtbox_price;
        private System.Windows.Forms.Label label_stock;
        private System.Windows.Forms.TextBox txtbox_stock;
        private System.Windows.Forms.Label label_name2;
        private System.Windows.Forms.TextBox txtbox_namecategory;
        private System.Windows.Forms.Button button_addcategory;
        private System.Windows.Forms.Button button_removecategory;
        private System.Windows.Forms.Button button_addproduct;
        private System.Windows.Forms.Button button_editproduct;
        private System.Windows.Forms.Button button_removeproduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_welkom;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

