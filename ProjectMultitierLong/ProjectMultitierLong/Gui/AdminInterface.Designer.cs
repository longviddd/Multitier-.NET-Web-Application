namespace ProjectMultitierLong.Gui
{
    partial class AdminInterface
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
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNumberRoom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNumberBathroom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxGarage = new System.Windows.Forms.ComboBox();
            this.comboBoxPool = new System.Windows.Forms.ComboBox();
            this.comboBoxFireplace = new System.Windows.Forms.ComboBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxSearchOption = new System.Windows.Forms.ComboBox();
            this.textBoxCitySearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxPriceMin = new System.Windows.Forms.TextBox();
            this.textBoxPriceMax = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonList = new System.Windows.Forms.Button();
            this.HouseId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Region = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumberOfRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumberOfBathroom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Garage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pool = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fireplace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxHouseId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(167, 156);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCity.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Region";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "City";
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Location = new System.Drawing.Point(167, 114);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRegion.TabIndex = 3;
            this.comboBoxRegion.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegion_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(167, 199);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(121, 20);
            this.textBoxPrice.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of Rooms";
            // 
            // textBoxNumberRoom
            // 
            this.textBoxNumberRoom.Location = new System.Drawing.Point(167, 239);
            this.textBoxNumberRoom.Name = "textBoxNumberRoom";
            this.textBoxNumberRoom.Size = new System.Drawing.Size(121, 20);
            this.textBoxNumberRoom.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Number of Bathrooms";
            // 
            // textBoxNumberBathroom
            // 
            this.textBoxNumberBathroom.Location = new System.Drawing.Point(167, 277);
            this.textBoxNumberBathroom.Name = "textBoxNumberBathroom";
            this.textBoxNumberBathroom.Size = new System.Drawing.Size(121, 20);
            this.textBoxNumberBathroom.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Garage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Pool";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Fireplace";
            // 
            // comboBoxGarage
            // 
            this.comboBoxGarage.FormattingEnabled = true;
            this.comboBoxGarage.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxGarage.Location = new System.Drawing.Point(498, 75);
            this.comboBoxGarage.Name = "comboBoxGarage";
            this.comboBoxGarage.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGarage.TabIndex = 13;
            // 
            // comboBoxPool
            // 
            this.comboBoxPool.FormattingEnabled = true;
            this.comboBoxPool.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxPool.Location = new System.Drawing.Point(498, 117);
            this.comboBoxPool.Name = "comboBoxPool";
            this.comboBoxPool.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPool.TabIndex = 14;
            // 
            // comboBoxFireplace
            // 
            this.comboBoxFireplace.FormattingEnabled = true;
            this.comboBoxFireplace.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxFireplace.Location = new System.Drawing.Point(498, 160);
            this.comboBoxFireplace.Name = "comboBoxFireplace";
            this.comboBoxFireplace.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFireplace.TabIndex = 15;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(77, 339);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 16;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(323, 339);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 17;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(440, 339);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(545, 339);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 19;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(417, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Search by";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(417, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "City";
            // 
            // comboBoxSearchOption
            // 
            this.comboBoxSearchOption.FormattingEnabled = true;
            this.comboBoxSearchOption.Items.AddRange(new object[] {
            "City",
            "Price Range"});
            this.comboBoxSearchOption.Location = new System.Drawing.Point(498, 200);
            this.comboBoxSearchOption.Name = "comboBoxSearchOption";
            this.comboBoxSearchOption.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearchOption.TabIndex = 22;
            this.comboBoxSearchOption.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchOption_SelectedIndexChanged);
            // 
            // textBoxCitySearch
            // 
            this.textBoxCitySearch.Location = new System.Drawing.Point(498, 242);
            this.textBoxCitySearch.Name = "textBoxCitySearch";
            this.textBoxCitySearch.Size = new System.Drawing.Size(121, 20);
            this.textBoxCitySearch.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(417, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Price Range";
            // 
            // textBoxPriceMin
            // 
            this.textBoxPriceMin.Location = new System.Drawing.Point(498, 282);
            this.textBoxPriceMin.Name = "textBoxPriceMin";
            this.textBoxPriceMin.Size = new System.Drawing.Size(55, 20);
            this.textBoxPriceMin.TabIndex = 25;
            // 
            // textBoxPriceMax
            // 
            this.textBoxPriceMax.Location = new System.Drawing.Point(564, 282);
            this.textBoxPriceMax.Name = "textBoxPriceMax";
            this.textBoxPriceMax.Size = new System.Drawing.Size(55, 20);
            this.textBoxPriceMax.TabIndex = 26;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HouseId,
            this.Region,
            this.City,
            this.Price,
            this.NumberOfRoom,
            this.NumberOfBathroom,
            this.Garage,
            this.Pool,
            this.Fireplace});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(45, 380);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(715, 105);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(195, 339);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(75, 23);
            this.buttonList.TabIndex = 28;
            this.buttonList.Text = "List";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // HouseId
            // 
            this.HouseId.Text = "HouseId";
            this.HouseId.Width = 66;
            // 
            // Region
            // 
            this.Region.Text = "Region";
            this.Region.Width = 88;
            // 
            // City
            // 
            this.City.Text = "City";
            this.City.Width = 100;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 79;
            // 
            // NumberOfRoom
            // 
            this.NumberOfRoom.Text = "NumberOfRoom";
            this.NumberOfRoom.Width = 92;
            // 
            // NumberOfBathroom
            // 
            this.NumberOfBathroom.Text = "NumberOfBathroom";
            this.NumberOfBathroom.Width = 108;
            // 
            // Garage
            // 
            this.Garage.Text = "Garage";
            // 
            // Pool
            // 
            this.Pool.Text = "Pool";
            // 
            // Fireplace
            // 
            this.Fireplace.Text = "Fireplace";
            this.Fireplace.Width = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "HouseId";
            // 
            // textBoxHouseId
            // 
            this.textBoxHouseId.Location = new System.Drawing.Point(167, 72);
            this.textBoxHouseId.Name = "textBoxHouseId";
            this.textBoxHouseId.Size = new System.Drawing.Size(121, 20);
            this.textBoxHouseId.TabIndex = 30;
            // 
            // AdminInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.textBoxHouseId);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBoxPriceMax);
            this.Controls.Add(this.textBoxPriceMin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxCitySearch);
            this.Controls.Add(this.comboBoxSearchOption);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.comboBoxFireplace);
            this.Controls.Add(this.comboBoxPool);
            this.Controls.Add(this.comboBoxGarage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxNumberBathroom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNumberRoom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxRegion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCity);
            this.Name = "AdminInterface";
            this.Text = "AdminInterface";
            this.Load += new System.EventHandler(this.AdminInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNumberRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNumberBathroom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxGarage;
        private System.Windows.Forms.ComboBox comboBoxPool;
        private System.Windows.Forms.ComboBox comboBoxFireplace;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxSearchOption;
        private System.Windows.Forms.TextBox textBoxCitySearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxPriceMin;
        private System.Windows.Forms.TextBox textBoxPriceMax;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.ColumnHeader HouseId;
        private System.Windows.Forms.ColumnHeader Region;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader NumberOfRoom;
        private System.Windows.Forms.ColumnHeader NumberOfBathroom;
        private System.Windows.Forms.ColumnHeader Garage;
        private System.Windows.Forms.ColumnHeader Pool;
        private System.Windows.Forms.ColumnHeader Fireplace;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxHouseId;
    }
}