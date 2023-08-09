namespace MantisLog
{
	partial class FrmInquiryLog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInquiryLog));
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.dtStart = new System.Windows.Forms.DateTimePicker();
			this.dtEnd = new System.Windows.Forms.DateTimePicker();
			this.btnBrowse = new MaterialSkin.Controls.MaterialButton();
			this.txtMessage = new MaterialSkin.Controls.MaterialTextBox();
			this.btnSearch = new MaterialSkin.Controls.MaterialButton();
			this.cmboxInfo = new MaterialSkin.Controls.MaterialComboBox();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
			this.btnPrev = new MaterialSkin.Controls.MaterialButton();
			this.btnNext = new MaterialSkin.Controls.MaterialButton();
			this.lblTotalPage = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
			this.txtCurrentPage = new System.Windows.Forms.TextBox();
			this.of = new MaterialSkin.Controls.MaterialLabel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AllowUserToOrderColumns = true;
			this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(31, 343);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowHeadersWidth = 51;
			this.dataGridView.RowTemplate.Height = 24;
			this.dataGridView.Size = new System.Drawing.Size(1668, 534);
			this.dataGridView.TabIndex = 1;
			// 
			// dtStart
			// 
			this.dtStart.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dtStart.CustomFormat = "dd/MM/yyyy";
			this.dtStart.Font = new System.Drawing.Font("Roboto Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtStart.Location = new System.Drawing.Point(175, 157);
			this.dtStart.Name = "dtStart";
			this.dtStart.Size = new System.Drawing.Size(200, 28);
			this.dtStart.TabIndex = 7;
			this.dtStart.Value = new System.DateTime(2023, 8, 8, 11, 49, 54, 0);
			// 
			// dtEnd
			// 
			this.dtEnd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dtEnd.CustomFormat = "dd/MM/yyyy";
			this.dtEnd.Font = new System.Drawing.Font("Roboto Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtEnd.Location = new System.Drawing.Point(429, 157);
			this.dtEnd.Name = "dtEnd";
			this.dtEnd.Size = new System.Drawing.Size(200, 28);
			this.dtEnd.TabIndex = 9;
			// 
			// btnBrowse
			// 
			this.btnBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnBrowse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.btnBrowse.Depth = 0;
			this.btnBrowse.HighEmphasis = true;
			this.btnBrowse.Icon = null;
			this.btnBrowse.Location = new System.Drawing.Point(40, 100);
			this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btnBrowse.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.NoAccentTextColor = System.Drawing.Color.Empty;
			this.btnBrowse.Size = new System.Drawing.Size(80, 36);
			this.btnBrowse.TabIndex = 15;
			this.btnBrowse.Text = "Browse";
			this.btnBrowse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.btnBrowse.UseAccentColor = false;
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// txtMessage
			// 
			this.txtMessage.AnimateReadOnly = false;
			this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtMessage.Depth = 0;
			this.txtMessage.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.txtMessage.LeadingIcon = null;
			this.txtMessage.Location = new System.Drawing.Point(175, 269);
			this.txtMessage.MaxLength = 50;
			this.txtMessage.MouseState = MaterialSkin.MouseState.OUT;
			this.txtMessage.Multiline = false;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(455, 50);
			this.txtMessage.TabIndex = 16;
			this.txtMessage.Text = "";
			this.txtMessage.TrailingIcon = null;
			// 
			// btnSearch
			// 
			this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.btnSearch.Depth = 0;
			this.btnSearch.HighEmphasis = true;
			this.btnSearch.Icon = null;
			this.btnSearch.Location = new System.Drawing.Point(645, 276);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.NoAccentTextColor = System.Drawing.Color.Empty;
			this.btnSearch.Size = new System.Drawing.Size(78, 36);
			this.btnSearch.TabIndex = 17;
			this.btnSearch.Text = "Search";
			this.btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.btnSearch.UseAccentColor = false;
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// cmboxInfo
			// 
			this.cmboxInfo.AutoResize = false;
			this.cmboxInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.cmboxInfo.Depth = 0;
			this.cmboxInfo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.cmboxInfo.DropDownHeight = 174;
			this.cmboxInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmboxInfo.DropDownWidth = 121;
			this.cmboxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.cmboxInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.cmboxInfo.FormattingEnabled = true;
			this.cmboxInfo.IntegralHeight = false;
			this.cmboxInfo.ItemHeight = 43;
			this.cmboxInfo.Location = new System.Drawing.Point(175, 202);
			this.cmboxInfo.MaxDropDownItems = 4;
			this.cmboxInfo.MouseState = MaterialSkin.MouseState.OUT;
			this.cmboxInfo.Name = "cmboxInfo";
			this.cmboxInfo.Size = new System.Drawing.Size(200, 49);
			this.cmboxInfo.StartIndex = 0;
			this.cmboxInfo.TabIndex = 18;
			// 
			// materialLabel1
			// 
			this.materialLabel1.AutoSize = true;
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel1.Location = new System.Drawing.Point(40, 162);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(46, 19);
			this.materialLabel1.TabIndex = 19;
			this.materialLabel1.Text = "Period";
			// 
			// materialLabel2
			// 
			this.materialLabel2.AutoSize = true;
			this.materialLabel2.Depth = 0;
			this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel2.Location = new System.Drawing.Point(40, 217);
			this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new System.Drawing.Size(29, 19);
			this.materialLabel2.TabIndex = 20;
			this.materialLabel2.Text = "Info";
			// 
			// materialLabel3
			// 
			this.materialLabel3.AutoSize = true;
			this.materialLabel3.Depth = 0;
			this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel3.Location = new System.Drawing.Point(40, 285);
			this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel3.Name = "materialLabel3";
			this.materialLabel3.Size = new System.Drawing.Size(65, 19);
			this.materialLabel3.TabIndex = 21;
			this.materialLabel3.Text = "Message";
			// 
			// btnPrev
			// 
			this.btnPrev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnPrev.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.btnPrev.Depth = 0;
			this.btnPrev.HighEmphasis = true;
			this.btnPrev.Icon = null;
			this.btnPrev.Location = new System.Drawing.Point(1349, 896);
			this.btnPrev.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btnPrev.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnPrev.Name = "btnPrev";
			this.btnPrev.NoAccentTextColor = System.Drawing.Color.Empty;
			this.btnPrev.Size = new System.Drawing.Size(64, 36);
			this.btnPrev.TabIndex = 22;
			this.btnPrev.Text = "<<";
			this.btnPrev.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.btnPrev.UseAccentColor = false;
			this.btnPrev.UseVisualStyleBackColor = true;
			this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
			// 
			// btnNext
			// 
			this.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnNext.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.btnNext.Depth = 0;
			this.btnNext.HighEmphasis = true;
			this.btnNext.Icon = null;
			this.btnNext.Location = new System.Drawing.Point(1612, 896);
			this.btnNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btnNext.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnNext.Name = "btnNext";
			this.btnNext.NoAccentTextColor = System.Drawing.Color.Empty;
			this.btnNext.Size = new System.Drawing.Size(64, 36);
			this.btnNext.TabIndex = 23;
			this.btnNext.Text = ">>";
			this.btnNext.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.btnNext.UseAccentColor = false;
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// lblTotalPage
			// 
			this.lblTotalPage.AutoSize = true;
			this.lblTotalPage.Depth = 0;
			this.lblTotalPage.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.lblTotalPage.Location = new System.Drawing.Point(1558, 905);
			this.lblTotalPage.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblTotalPage.Name = "lblTotalPage";
			this.lblTotalPage.Size = new System.Drawing.Size(10, 19);
			this.lblTotalPage.TabIndex = 24;
			this.lblTotalPage.Text = "1";
			// 
			// materialLabel4
			// 
			this.materialLabel4.AutoSize = true;
			this.materialLabel4.Depth = 0;
			this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel4.Location = new System.Drawing.Point(394, 162);
			this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel4.Name = "materialLabel4";
			this.materialLabel4.Size = new System.Drawing.Size(15, 19);
			this.materialLabel4.TabIndex = 25;
			this.materialLabel4.Text = "to";
			// 
			// txtCurrentPage
			// 
			this.txtCurrentPage.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCurrentPage.Location = new System.Drawing.Point(1448, 902);
			this.txtCurrentPage.MaxLength = 4;
			this.txtCurrentPage.Name = "txtCurrentPage";
			this.txtCurrentPage.Size = new System.Drawing.Size(62, 35);
			this.txtCurrentPage.TabIndex = 26;
			this.txtCurrentPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtCurrentPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrentPage_KeyPress);
			// 
			// of
			// 
			this.of.AutoSize = true;
			this.of.Depth = 0;
			this.of.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.of.Location = new System.Drawing.Point(1523, 905);
			this.of.MouseState = MaterialSkin.MouseState.HOVER;
			this.of.Name = "of";
			this.of.Size = new System.Drawing.Size(16, 19);
			this.of.TabIndex = 27;
			this.of.Text = "of";
			// 
			// FrmInquiryLog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1725, 971);
			this.Controls.Add(this.of);
			this.Controls.Add(this.txtCurrentPage);
			this.Controls.Add(this.materialLabel4);
			this.Controls.Add(this.lblTotalPage);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnPrev);
			this.Controls.Add(this.materialLabel3);
			this.Controls.Add(this.materialLabel2);
			this.Controls.Add(this.materialLabel1);
			this.Controls.Add(this.cmboxInfo);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtMessage);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.dtEnd);
			this.Controls.Add(this.dtStart);
			this.Controls.Add(this.dataGridView);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmInquiryLog";
			this.Sizable = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mantis Log";
			this.Load += new System.EventHandler(this.FrmInquiryLog_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.DateTimePicker dtStart;
		private System.Windows.Forms.DateTimePicker dtEnd;
		private MaterialSkin.Controls.MaterialButton btnBrowse;
		private MaterialSkin.Controls.MaterialTextBox txtMessage;
		private MaterialSkin.Controls.MaterialButton btnSearch;
		private MaterialSkin.Controls.MaterialComboBox cmboxInfo;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private MaterialSkin.Controls.MaterialLabel materialLabel3;
		private MaterialSkin.Controls.MaterialButton btnPrev;
		private MaterialSkin.Controls.MaterialButton btnNext;
		private MaterialSkin.Controls.MaterialLabel lblTotalPage;
		private MaterialSkin.Controls.MaterialLabel materialLabel4;
		private System.Windows.Forms.TextBox txtCurrentPage;
		private MaterialSkin.Controls.MaterialLabel of;
	}
}

