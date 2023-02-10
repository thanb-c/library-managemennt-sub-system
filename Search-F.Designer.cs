/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 3/12/2022
 * Time: 1:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Final_6213841
{
	partial class Search_F
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbLoanable = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnBorrow = new System.Windows.Forms.Button();
			this.cmbGenres = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbType = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtShelfNo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAuthor = new System.Windows.Forms.TextBox();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtIsbn = new System.Windows.Forms.TextBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtSearch
			// 
			this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtSearch.Location = new System.Drawing.Point(288, 13);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(358, 27);
			this.txtSearch.TabIndex = 2;
			this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearchTextChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbLoanable);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.btnBorrow);
			this.groupBox1.Controls.Add(this.cmbGenres);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.cmbType);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtShelfNo);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtAuthor);
			this.groupBox1.Controls.Add(this.txtTitle);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtIsbn);
			this.groupBox1.Location = new System.Drawing.Point(48, 219);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(681, 244);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Book Information";
			// 
			// cmbLoanable
			// 
			this.cmbLoanable.FormattingEnabled = true;
			this.cmbLoanable.Items.AddRange(new object[] {
									"Yes",
									"No"});
			this.cmbLoanable.Location = new System.Drawing.Point(517, 152);
			this.cmbLoanable.Name = "cmbLoanable";
			this.cmbLoanable.Size = new System.Drawing.Size(140, 29);
			this.cmbLoanable.TabIndex = 45;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(439, 158);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 23);
			this.label5.TabIndex = 42;
			this.label5.Text = "Loanable";
			// 
			// btnBorrow
			// 
			this.btnBorrow.BackColor = System.Drawing.Color.Navy;
			this.btnBorrow.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBorrow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBorrow.Location = new System.Drawing.Point(443, 192);
			this.btnBorrow.Name = "btnBorrow";
			this.btnBorrow.Size = new System.Drawing.Size(220, 46);
			this.btnBorrow.TabIndex = 41;
			this.btnBorrow.Text = "Borrow";
			this.btnBorrow.UseVisualStyleBackColor = false;
			this.btnBorrow.Click += new System.EventHandler(this.BtnBorrowClick);
			// 
			// cmbGenres
			// 
			this.cmbGenres.FormattingEnabled = true;
			this.cmbGenres.Items.AddRange(new object[] {
									"Action/Aventure",
									"Business/economics",
									"Classic",
									"Comic book",
									"Dictionary",
									"Histrory",
									"Picture book",
									"Philosophy",
									"Romance",
									"Travel"});
			this.cmbGenres.Location = new System.Drawing.Point(517, 105);
			this.cmbGenres.Name = "cmbGenres";
			this.cmbGenres.Size = new System.Drawing.Size(140, 29);
			this.cmbGenres.TabIndex = 39;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(443, 111);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 23);
			this.label7.TabIndex = 38;
			this.label7.Text = "Genres";
			// 
			// cmbType
			// 
			this.cmbType.FormattingEnabled = true;
			this.cmbType.Items.AddRange(new object[] {
									"Fiction",
									"Nonfiction"});
			this.cmbType.Location = new System.Drawing.Point(517, 62);
			this.cmbType.Name = "cmbType";
			this.cmbType.Size = new System.Drawing.Size(140, 29);
			this.cmbType.TabIndex = 37;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(455, 68);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 23);
			this.label6.TabIndex = 34;
			this.label6.Text = "Type";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(20, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 23);
			this.label2.TabIndex = 33;
			this.label2.Text = "Title";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 161);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 23);
			this.label4.TabIndex = 30;
			this.label4.Text = "Shelf No.";
			// 
			// txtShelfNo
			// 
			this.txtShelfNo.Location = new System.Drawing.Point(94, 158);
			this.txtShelfNo.Name = "txtShelfNo";
			this.txtShelfNo.Size = new System.Drawing.Size(334, 27);
			this.txtShelfNo.TabIndex = 29;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(20, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 23);
			this.label3.TabIndex = 28;
			this.label3.Text = "Author";
			// 
			// txtAuthor
			// 
			this.txtAuthor.Location = new System.Drawing.Point(94, 111);
			this.txtAuthor.Name = "txtAuthor";
			this.txtAuthor.Size = new System.Drawing.Size(334, 27);
			this.txtAuthor.TabIndex = 27;
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(94, 66);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(334, 27);
			this.txtTitle.TabIndex = 26;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(20, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 23);
			this.label1.TabIndex = 25;
			this.label1.Text = "ISBN";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtIsbn
			// 
			this.txtIsbn.Location = new System.Drawing.Point(94, 26);
			this.txtIsbn.Name = "txtIsbn";
			this.txtIsbn.Size = new System.Drawing.Size(140, 27);
			this.txtIsbn.TabIndex = 24;
			// 
			// listView1
			// 
			this.listView1.AutoArrange = false;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4,
									this.columnHeader5,
									this.columnHeader6});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(13, 48);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(716, 165);
			this.listView1.TabIndex = 5;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "ISBN";
			this.columnHeader1.Width = 170;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Title";
			this.columnHeader2.Width = 224;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Author";
			this.columnHeader3.Width = 145;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Type";
			this.columnHeader4.Width = 105;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Genres";
			this.columnHeader5.Width = 101;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Shelf No.";
			this.columnHeader6.Width = 85;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(126, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(156, 23);
			this.label8.TabIndex = 6;
			this.label8.Text = "Search Book Title :";
			// 
			// Search_F
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(855, 435);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtSearch);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "Search_F";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Search_F";
			this.Load += new System.EventHandler(this.Search_FLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cmbLoanable;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnBorrow;
		private System.Windows.Forms.ComboBox cmbType;
		private System.Windows.Forms.ComboBox cmbGenres;
		private System.Windows.Forms.TextBox txtIsbn;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.TextBox txtAuthor;
		private System.Windows.Forms.TextBox txtShelfNo;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
	}
}
