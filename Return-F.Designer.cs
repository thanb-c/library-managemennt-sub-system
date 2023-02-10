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
	partial class Return_F
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
			this.txtStudentName = new System.Windows.Forms.TextBox();
			this.btnReturn = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtBookTitle = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dtReturnDate = new System.Windows.Forms.DateTimePicker();
			this.grid1 = new System.Windows.Forms.DataGridView();
			this.txtDateBorrow = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtStudentName
			// 
			this.txtStudentName.Enabled = false;
			this.txtStudentName.Location = new System.Drawing.Point(333, 191);
			this.txtStudentName.Name = "txtStudentName";
			this.txtStudentName.Size = new System.Drawing.Size(187, 27);
			this.txtStudentName.TabIndex = 0;
			// 
			// btnReturn
			// 
			this.btnReturn.BackColor = System.Drawing.Color.Green;
			this.btnReturn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReturn.ForeColor = System.Drawing.Color.White;
			this.btnReturn.Location = new System.Drawing.Point(201, 374);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(123, 49);
			this.btnReturn.TabIndex = 2;
			this.btnReturn.Text = "Return";
			this.btnReturn.UseVisualStyleBackColor = false;
			this.btnReturn.Click += new System.EventHandler(this.BtnReturnClick);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Red;
			this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Location = new System.Drawing.Point(484, 374);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(134, 49);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(175, 195);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Student name";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(175, 277);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "Borrow Date";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(175, 235);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "Book\'s Title";
			// 
			// txtBookTitle
			// 
			this.txtBookTitle.Enabled = false;
			this.txtBookTitle.Location = new System.Drawing.Point(333, 231);
			this.txtBookTitle.Name = "txtBookTitle";
			this.txtBookTitle.Size = new System.Drawing.Size(312, 27);
			this.txtBookTitle.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(175, 323);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(136, 23);
			this.label5.TabIndex = 12;
			this.label5.Text = "Return Date";
			// 
			// dtReturnDate
			// 
			this.dtReturnDate.Location = new System.Drawing.Point(333, 323);
			this.dtReturnDate.Name = "dtReturnDate";
			this.dtReturnDate.Size = new System.Drawing.Size(312, 27);
			this.dtReturnDate.TabIndex = 11;
			// 
			// grid1
			// 
			this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid1.Location = new System.Drawing.Point(34, 6);
			this.grid1.MultiSelect = false;
			this.grid1.Name = "grid1";
			this.grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grid1.Size = new System.Drawing.Size(724, 171);
			this.grid1.TabIndex = 13;
			this.grid1.SelectionChanged += new System.EventHandler(this.Grid1SelectionChanged);
			// 
			// txtDateBorrow
			// 
			this.txtDateBorrow.Enabled = false;
			this.txtDateBorrow.Location = new System.Drawing.Point(333, 277);
			this.txtDateBorrow.Name = "txtDateBorrow";
			this.txtDateBorrow.Size = new System.Drawing.Size(312, 27);
			this.txtDateBorrow.TabIndex = 14;
			// 
			// Return_F
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(787, 435);
			this.Controls.Add(this.txtDateBorrow);
			this.Controls.Add(this.grid1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dtReturnDate);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtBookTitle);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.txtStudentName);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "Return_F";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CheckOut_F";
			this.Load += new System.EventHandler(this.Return_FLoad);
			((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtStudentName;
		private System.Windows.Forms.Button btnReturn;
		private System.Windows.Forms.TextBox txtDateBorrow;
		private System.Windows.Forms.DataGridView grid1;
		private System.Windows.Forms.TextBox txtBookTitle;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.DateTimePicker dtReturnDate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
	}
}
