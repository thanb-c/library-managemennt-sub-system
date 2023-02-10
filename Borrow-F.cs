/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 3/15/2022
 * Time: 10:31 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Final_6213841
{
	/// <summary>
	/// Description of Borrow_F.
	/// </summary>
	public partial class Borrow_F : Form
	{
		DataManager m1 = new DataManager("localhost", "final", "root","1234");
	
		public Borrow_F()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void Borrow_FLoad(object sender, EventArgs e)
		{
			lblmemId.Text = Global.member.no.ToString();
			lblFullname.Text = Global.member.firstname + " " + Global.member.lastname;
			txtIsbn.Text = Global.book.isbn;
			txtTitle.Text = Global.book.title;
			txtGenres.Text = Global.book.genres;
		}//ef
	
		void BtnConfirmClick(object sender, EventArgs e)
		{
			string sql = "insert into borrowed (no,memberId,ISBN,title,borrowDate,returnDate)";
			sql += "values(null,'p1','p2','p3','p4',null);";
			sql = sql.Replace("p1", lblmemId.Text);
			sql = sql.Replace("p2", txtIsbn.Text);
			sql = sql.Replace("p3", txtTitle.Text);
			sql = sql.Replace("p4", dtBorrow.Value.ToString("yyyy-MM-dd HH:mm:ss"));
			m1.ExecuteNonQuery(sql);
			MessageBox.Show("Borrow Success!!");
		}//ef
		
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.Close();
		}//ef
		
		
	}//ec
}//en
