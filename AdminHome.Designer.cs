namespace The_Mosholla_Wala__Version_3_
{
	partial class AdminHome
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.labelThemoshollawal = new System.Windows.Forms.Label();
			this.buttonBack = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonAddSpice = new System.Windows.Forms.Button();
			this.buttonCustomerInfo = new System.Windows.Forms.Button();
			this.buttonDeleteSpice = new System.Windows.Forms.Button();
			this.buttonOrderedSpices = new System.Windows.Forms.Button();
			this.buttonDeliveredSpices = new System.Windows.Forms.Button();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.dataGridViewAdminHome = new System.Windows.Forms.DataGridView();
			this.spiceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.spiceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.spiceInfoTableUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.theMoshollaWalaDataSet2 = new The_Mosholla_Wala__Version_3_.TheMoshollaWalaDataSet2();
			this.spiceInfoTable_UserTableAdapter = new The_Mosholla_Wala__Version_3_.TheMoshollaWalaDataSet2TableAdapters.SpiceInfoTable_UserTableAdapter();
			this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
			this.buttonUpdateSpices = new System.Windows.Forms.Button();
			this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
			this.labelUserName = new System.Windows.Forms.Label();
			this.labelSignOut = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminHome)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spiceInfoTableUserBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.theMoshollaWalaDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
			this.SuspendLayout();
			// 
			// labelThemoshollawal
			// 
			this.labelThemoshollawal.AutoSize = true;
			this.labelThemoshollawal.BackColor = System.Drawing.Color.Transparent;
			this.labelThemoshollawal.Font = new System.Drawing.Font("Edwardian Script ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelThemoshollawal.ForeColor = System.Drawing.Color.PeachPuff;
			this.labelThemoshollawal.Location = new System.Drawing.Point(963, 18);
			this.labelThemoshollawal.Name = "labelThemoshollawal";
			this.labelThemoshollawal.Size = new System.Drawing.Size(393, 71);
			this.labelThemoshollawal.TabIndex = 11;
			this.labelThemoshollawal.Text = "The Mosholla Wala";
			this.labelThemoshollawal.Click += new System.EventHandler(this.labelThemoshollawal_Click);
			// 
			// buttonBack
			// 
			this.buttonBack.BackColor = System.Drawing.Color.LemonChiffon;
			this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBack.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBack.ForeColor = System.Drawing.Color.Olive;
			this.buttonBack.Location = new System.Drawing.Point(26, 677);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(81, 29);
			this.buttonBack.TabIndex = 34;
			this.buttonBack.Text = "BACK";
			this.buttonBack.UseVisualStyleBackColor = false;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.BackColor = System.Drawing.Color.LemonChiffon;
			this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonExit.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonExit.ForeColor = System.Drawing.Color.Olive;
			this.buttonExit.Location = new System.Drawing.Point(1266, 677);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(81, 29);
			this.buttonExit.TabIndex = 35;
			this.buttonExit.Text = "EXIT";
			this.buttonExit.UseVisualStyleBackColor = false;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonAddSpice
			// 
			this.buttonAddSpice.BackColor = System.Drawing.Color.Wheat;
			this.buttonAddSpice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddSpice.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAddSpice.ForeColor = System.Drawing.Color.Peru;
			this.buttonAddSpice.Location = new System.Drawing.Point(0, 130);
			this.buttonAddSpice.Name = "buttonAddSpice";
			this.buttonAddSpice.Size = new System.Drawing.Size(227, 45);
			this.buttonAddSpice.TabIndex = 36;
			this.buttonAddSpice.Text = "Add Spice";
			this.buttonAddSpice.UseVisualStyleBackColor = false;
			this.buttonAddSpice.Click += new System.EventHandler(this.buttonAddSpice_Click);
			this.buttonAddSpice.MouseLeave += new System.EventHandler(this.buttonAddSpice_MouseLeave);
			this.buttonAddSpice.MouseHover += new System.EventHandler(this.buttonAddSpice_MouseHover);
			// 
			// buttonCustomerInfo
			// 
			this.buttonCustomerInfo.BackColor = System.Drawing.Color.Wheat;
			this.buttonCustomerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCustomerInfo.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCustomerInfo.ForeColor = System.Drawing.Color.Peru;
			this.buttonCustomerInfo.Location = new System.Drawing.Point(681, 130);
			this.buttonCustomerInfo.Name = "buttonCustomerInfo";
			this.buttonCustomerInfo.Size = new System.Drawing.Size(227, 45);
			this.buttonCustomerInfo.TabIndex = 37;
			this.buttonCustomerInfo.Text = "Customer Info";
			this.buttonCustomerInfo.UseVisualStyleBackColor = false;
			this.buttonCustomerInfo.Click += new System.EventHandler(this.buttonCustomerInfo_Click);
			this.buttonCustomerInfo.MouseLeave += new System.EventHandler(this.buttonCustomerInfo_MouseLeave);
			this.buttonCustomerInfo.MouseHover += new System.EventHandler(this.buttonCustomerInfo_MouseHover);
			// 
			// buttonDeleteSpice
			// 
			this.buttonDeleteSpice.BackColor = System.Drawing.Color.Wheat;
			this.buttonDeleteSpice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDeleteSpice.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDeleteSpice.ForeColor = System.Drawing.Color.Peru;
			this.buttonDeleteSpice.Location = new System.Drawing.Point(227, 130);
			this.buttonDeleteSpice.Name = "buttonDeleteSpice";
			this.buttonDeleteSpice.Size = new System.Drawing.Size(227, 45);
			this.buttonDeleteSpice.TabIndex = 38;
			this.buttonDeleteSpice.Text = "Delete Spice";
			this.buttonDeleteSpice.UseVisualStyleBackColor = false;
			this.buttonDeleteSpice.Click += new System.EventHandler(this.buttonDeleteSpice_Click);
			this.buttonDeleteSpice.MouseLeave += new System.EventHandler(this.buttonDeleteSpice_MouseLeave);
			this.buttonDeleteSpice.MouseHover += new System.EventHandler(this.buttonDeleteSpice_MouseHover);
			// 
			// buttonOrderedSpices
			// 
			this.buttonOrderedSpices.BackColor = System.Drawing.Color.Wheat;
			this.buttonOrderedSpices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOrderedSpices.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonOrderedSpices.ForeColor = System.Drawing.Color.Peru;
			this.buttonOrderedSpices.Location = new System.Drawing.Point(908, 130);
			this.buttonOrderedSpices.Name = "buttonOrderedSpices";
			this.buttonOrderedSpices.Size = new System.Drawing.Size(227, 45);
			this.buttonOrderedSpices.TabIndex = 39;
			this.buttonOrderedSpices.Text = "Ordered Spices";
			this.buttonOrderedSpices.UseVisualStyleBackColor = false;
			this.buttonOrderedSpices.Click += new System.EventHandler(this.buttonOrderedSpices_Click);
			this.buttonOrderedSpices.MouseLeave += new System.EventHandler(this.buttonOrderedSpices_MouseLeave);
			this.buttonOrderedSpices.MouseHover += new System.EventHandler(this.buttonOrderedSpices_MouseHover);
			// 
			// buttonDeliveredSpices
			// 
			this.buttonDeliveredSpices.BackColor = System.Drawing.Color.Wheat;
			this.buttonDeliveredSpices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDeliveredSpices.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDeliveredSpices.ForeColor = System.Drawing.Color.Peru;
			this.buttonDeliveredSpices.Location = new System.Drawing.Point(1135, 130);
			this.buttonDeliveredSpices.Name = "buttonDeliveredSpices";
			this.buttonDeliveredSpices.Size = new System.Drawing.Size(227, 45);
			this.buttonDeliveredSpices.TabIndex = 40;
			this.buttonDeliveredSpices.Text = "Delivered Spices";
			this.buttonDeliveredSpices.UseVisualStyleBackColor = false;
			this.buttonDeliveredSpices.Click += new System.EventHandler(this.buttonDeliveredSpices_Click);
			this.buttonDeliveredSpices.MouseLeave += new System.EventHandler(this.buttonDeliveredSpices_MouseLeave);
			this.buttonDeliveredSpices.MouseHover += new System.EventHandler(this.buttonDeliveredSpices_MouseHover);
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxSearch.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSearch.Location = new System.Drawing.Point(1063, 94);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(230, 30);
			this.textBoxSearch.TabIndex = 41;
			this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
			// 
			// dataGridViewAdminHome
			// 
			this.dataGridViewAdminHome.AutoGenerateColumns = false;
			this.dataGridViewAdminHome.BackgroundColor = System.Drawing.Color.Wheat;
			this.dataGridViewAdminHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAdminHome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.spiceIdDataGridViewTextBoxColumn,
            this.spiceNameDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
			this.dataGridViewAdminHome.DataSource = this.spiceInfoTableUserBindingSource;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Wheat;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Peru;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewAdminHome.DefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewAdminHome.GridColor = System.Drawing.Color.Peru;
			this.dataGridViewAdminHome.Location = new System.Drawing.Point(219, 200);
			this.dataGridViewAdminHome.Name = "dataGridViewAdminHome";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.BurlyWood;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SaddleBrown;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewAdminHome.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewAdminHome.RowTemplate.Height = 24;
			this.dataGridViewAdminHome.Size = new System.Drawing.Size(946, 449);
			this.dataGridViewAdminHome.TabIndex = 55;
			// 
			// spiceIdDataGridViewTextBoxColumn
			// 
			this.spiceIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.spiceIdDataGridViewTextBoxColumn.DataPropertyName = "SpiceId";
			this.spiceIdDataGridViewTextBoxColumn.HeaderText = "SpiceId";
			this.spiceIdDataGridViewTextBoxColumn.Name = "spiceIdDataGridViewTextBoxColumn";
			// 
			// spiceNameDataGridViewTextBoxColumn
			// 
			this.spiceNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.spiceNameDataGridViewTextBoxColumn.DataPropertyName = "SpiceName";
			this.spiceNameDataGridViewTextBoxColumn.HeaderText = "SpiceName";
			this.spiceNameDataGridViewTextBoxColumn.Name = "spiceNameDataGridViewTextBoxColumn";
			// 
			// brandDataGridViewTextBoxColumn
			// 
			this.brandDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
			this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
			this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			// 
			// spiceInfoTableUserBindingSource
			// 
			this.spiceInfoTableUserBindingSource.DataMember = "SpiceInfoTable_User";
			this.spiceInfoTableUserBindingSource.DataSource = this.theMoshollaWalaDataSet2;
			// 
			// theMoshollaWalaDataSet2
			// 
			this.theMoshollaWalaDataSet2.DataSetName = "TheMoshollaWalaDataSet2";
			this.theMoshollaWalaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// spiceInfoTable_UserTableAdapter
			// 
			this.spiceInfoTable_UserTableAdapter.ClearBeforeFill = true;
			// 
			// pictureBoxSearch
			// 
			this.pictureBoxSearch.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxSearch.BackgroundImage = global::The_Mosholla_Wala__Version_3_.Properties.Resources.musica_searcher;
			this.pictureBoxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBoxSearch.Location = new System.Drawing.Point(1299, 94);
			this.pictureBoxSearch.Name = "pictureBoxSearch";
			this.pictureBoxSearch.Size = new System.Drawing.Size(44, 30);
			this.pictureBoxSearch.TabIndex = 62;
			this.pictureBoxSearch.TabStop = false;
			this.pictureBoxSearch.Click += new System.EventHandler(this.pictureBoxSearch_Click);
			// 
			// buttonUpdateSpices
			// 
			this.buttonUpdateSpices.BackColor = System.Drawing.Color.Wheat;
			this.buttonUpdateSpices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonUpdateSpices.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonUpdateSpices.ForeColor = System.Drawing.Color.Peru;
			this.buttonUpdateSpices.Location = new System.Drawing.Point(454, 130);
			this.buttonUpdateSpices.Name = "buttonUpdateSpices";
			this.buttonUpdateSpices.Size = new System.Drawing.Size(227, 45);
			this.buttonUpdateSpices.TabIndex = 63;
			this.buttonUpdateSpices.Text = "Update Spice";
			this.buttonUpdateSpices.UseVisualStyleBackColor = false;
			this.buttonUpdateSpices.Click += new System.EventHandler(this.buttonUpdateSpices_Click);
			this.buttonUpdateSpices.MouseLeave += new System.EventHandler(this.buttonUpdateSpices_MouseLeave);
			this.buttonUpdateSpices.MouseHover += new System.EventHandler(this.buttonUpdateSpices_MouseHover);
			// 
			// pictureBoxProfile
			// 
			this.pictureBoxProfile.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxProfile.BackgroundImage = global::The_Mosholla_Wala__Version_3_.Properties.Resources.girl;
			this.pictureBoxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBoxProfile.Location = new System.Drawing.Point(0, 1);
			this.pictureBoxProfile.Name = "pictureBoxProfile";
			this.pictureBoxProfile.Size = new System.Drawing.Size(100, 78);
			this.pictureBoxProfile.TabIndex = 75;
			this.pictureBoxProfile.TabStop = false;
			// 
			// labelUserName
			// 
			this.labelUserName.AutoSize = true;
			this.labelUserName.BackColor = System.Drawing.Color.Transparent;
			this.labelUserName.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelUserName.Location = new System.Drawing.Point(96, 30);
			this.labelUserName.Name = "labelUserName";
			this.labelUserName.Size = new System.Drawing.Size(63, 28);
			this.labelUserName.TabIndex = 74;
			this.labelUserName.Text = "label1";
			// 
			// labelSignOut
			// 
			this.labelSignOut.AutoSize = true;
			this.labelSignOut.BackColor = System.Drawing.Color.Transparent;
			this.labelSignOut.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSignOut.Location = new System.Drawing.Point(12, 82);
			this.labelSignOut.Name = "labelSignOut";
			this.labelSignOut.Size = new System.Drawing.Size(88, 28);
			this.labelSignOut.TabIndex = 77;
			this.labelSignOut.Text = "Sign Out";
			this.labelSignOut.Click += new System.EventHandler(this.labelSignOut_Click);
			// 
			// AdminHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::The_Mosholla_Wala__Version_3_.Properties.Resources.wp2689347_spices_wallpapers;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1368, 729);
			this.Controls.Add(this.labelSignOut);
			this.Controls.Add(this.pictureBoxProfile);
			this.Controls.Add(this.labelUserName);
			this.Controls.Add(this.buttonUpdateSpices);
			this.Controls.Add(this.pictureBoxSearch);
			this.Controls.Add(this.dataGridViewAdminHome);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.buttonDeliveredSpices);
			this.Controls.Add(this.buttonOrderedSpices);
			this.Controls.Add(this.buttonDeleteSpice);
			this.Controls.Add(this.buttonCustomerInfo);
			this.Controls.Add(this.buttonAddSpice);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.labelThemoshollawal);
			this.Name = "AdminHome";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdminHome";
			this.Load += new System.EventHandler(this.AdminHome_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminHome)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spiceInfoTableUserBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.theMoshollaWalaDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelThemoshollawal;
		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonAddSpice;
		private System.Windows.Forms.Button buttonCustomerInfo;
		private System.Windows.Forms.Button buttonDeleteSpice;
		private System.Windows.Forms.Button buttonOrderedSpices;
		private System.Windows.Forms.Button buttonDeliveredSpices;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.DataGridView dataGridViewAdminHome;
		private TheMoshollaWalaDataSet2 theMoshollaWalaDataSet2;
		private System.Windows.Forms.BindingSource spiceInfoTableUserBindingSource;
		private TheMoshollaWalaDataSet2TableAdapters.SpiceInfoTable_UserTableAdapter spiceInfoTable_UserTableAdapter;
		private System.Windows.Forms.PictureBox pictureBoxSearch;
		private System.Windows.Forms.DataGridViewTextBoxColumn spiceIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn spiceNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button buttonUpdateSpices;
		private System.Windows.Forms.PictureBox pictureBoxProfile;
		private System.Windows.Forms.Label labelUserName;
		private System.Windows.Forms.Label labelSignOut;
	}
}