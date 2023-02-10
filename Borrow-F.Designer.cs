/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 3/15/2022
 * Time: 10:31 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Final_6213841
{
	partial class Borrow_F
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
			this.label1 = new System.Windows.Forms.Label();
			this.lblmemId = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblFullname = new System.Windows.Forms.Label();
			this.dtBorrow = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.btnConfirm = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtIsbn = new System.Windows.Forms.TextBox();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.txtGenres = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(88, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID";
			// 
			// lblmemId
			// 
			this.lblmemId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblmemId.Location = new System.Drawing.Point(221, 24);
			this.lblmemId.Name = "lblmemId";
			this.lblmemId.Size = new System.Drawing.Size(388, 23);
			this.lblmemId.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(88, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Name";
			// 
			// lblFullname
			// 
			this.lblFullname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblFullname.Location = new System.Drawing.Point(221, 63);
			this.lblFullname.Name = "lblFullname";
			this.lblFullname.Size = new System.Drawing.Size(388, 23);
			this.lblFullname.TabIndex = 3;
			// 
			// dtBorrow
			// 
			this.dtBorrow.Location = new System.Drawing.Point(221, 100);
			this.dtBorrow.Name = "dtBorrow";
			this.dtBorrow.Size = new System.Drawing.Size(388, 27);
			this.dtBorrow.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(88, 105);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Date";
			// 
			// btnConfirm
			// 
			this.btnConfirm.BackColor = System.Drawing.Color.Green;
			this.btnConfirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConfirm.ForeColor = System.Drawing.Color.White;
			this.btnConfirm.Location = new System.Drawing.Point(175, 269);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(185, 69);
			this.btnConfirm.TabIndex = 6;
			this.btnConfirm.Text = "confirm";
			this.btnConfirm.UseVisualStyleBackColor = false;
			this.btnConfirm.Click += new System.EventHandler(this.BtnConfirmClick);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Red;
			this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Location = new System.Drawing.Point(372, 269);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(185, 69);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(88, 184);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(107, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Title of Book";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(88, 145);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 8;
			this.label7.Text = "ISBN";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(88, 219);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 12;
			this.label11.Text = "Genres";
			// 
			// txtIsbn
			// 
			this.txtIsbn.Location = new System.Drawing.Point(221, 147);
			this.txtIsbn.Name = "txtIsbn";
			this.txtIsbn.Size = new System.Drawing.Size(388, 27);
			this.txtIsbn.TabIndex = 14;
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(221, 184);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(388, 27);
			this.txtTitle.TabIndex = 15;
			// 
			// txtGenres
			// 
			this.txtGenres.Location = new System.Drawing.Point(221, 219);
			this.txtGenres.Name = "txtGenres";
			this.txtGenres.Size = new System.Drawing.Size(388, 27);
			this.txtGenres.TabIndex = 16;
			// 
			// Borrow_F
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(707, 359);
			this.Controls.Add(this.txtGenres);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.txtIsbn);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnConfirm);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dtBorrow);
			this.Controls.Add(this.lblFullname);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblmemId);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "Borrow_F";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Borrow_F";
			this.Load += new System.EventHandler(this.Borrow_FLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtGenres;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.TextBox txtIsbn;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblmemId;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnConfirm;
		private System.Windows.Forms.DateTimePicker dtBorrow;
		private System.Windows.Forms.Label lblFullname;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
