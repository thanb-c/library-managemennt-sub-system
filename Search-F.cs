/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 3/12/2022
 * Time: 1:50 PM
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
	/// Description of Search_F.
	/// </summary>
	public partial class Search_F : Form
	{
		DataManager m1 = new DataManager("localhost", "final", "root","1234");
		
		public Search_F()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}
		
		void Search_FLoad(object sender, EventArgs e)
		{
			displayBookDetail();
		}//ef
		
		private void displayBookDetail(){
			string sql = "SELECT book.isbn, book.type, book.title, book.author, book.genres, book.shelfNo, booktype.loanable FROM book LEFT JOIN booktype ON book.type = booktype.typename";
			DataTable table = m1.GetDataTable(sql);
			foreach(DataRow row in table.Rows){
				string isbn 		= row[0].ToString();
				string type			= row[1].ToString();
				string title		= row[2].ToString();
				string author	 	= row[3].ToString();
				string genres	 	= row[4].ToString();
				string shelfNo	 	= row[5].ToString();
				string loanable 	= row[6].ToString();
				ListViewItem newrow = new ListViewItem(isbn);
				newrow.SubItems.Add(title); newrow.SubItems.Add(author); 
				newrow.SubItems.Add(type); newrow.SubItems.Add(genres); 
				newrow.SubItems.Add(shelfNo); newrow.SubItems.Add(loanable);
				listView1.Items.Add(newrow);
			}//eloop
			
		}//ef
		
		void ListView1SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0){
				txtIsbn.Text 	= listView1.SelectedItems[0].SubItems[0].Text;
				txtTitle.Text 	= listView1.SelectedItems[0].SubItems[1].Text;
				txtAuthor.Text 	= listView1.SelectedItems[0].SubItems[2].Text;
				cmbType.Text 	= listView1.SelectedItems[0].SubItems[3].Text;
				cmbGenres.Text 	= listView1.SelectedItems[0].SubItems[4].Text;
				txtShelfNo.Text = listView1.SelectedItems[0].SubItems[5].Text;
				cmbLoanable.Text= listView1.SelectedItems[0].SubItems[6].Text;
			}//eif
		}//ef

	
		void BtnBorrowClick(object sender, EventArgs e)
		{	
			Borrow_F borrow = new Borrow_F();
			
			string isbn 	= listView1.SelectedItems[0].SubItems[0].Text;
			string title 	= listView1.SelectedItems[0].SubItems[1].Text;
			string genres 	= listView1.SelectedItems[0].SubItems[4].Text;	
			book borrowbook = new book(isbn,title,genres);
			Global.book = borrowbook;
			
			//if it is allow to borrow there will pop up the message box 
			if (cmbLoanable.SelectedItem.Equals("No")){
				borrow.Enabled = false;
			MessageBox.Show("This Book not allow to borrow");	
			}//eif
			else{
				borrow.ShowDialog();
				}//eif
		}//ef

		
		void TxtSearchTextChanged(object sender, EventArgs e)
		{
			listView1.Items.Clear();
			string search = txtSearch.Text;
			string sql = "SELECT book.isbn, book.type, book.title, book.author, book.genres, book.shelfNo, booktype.loanable FROM book" 
				+ " LEFT JOIN booktype ON book.type = booktype.typename where title like '%b1%';";
			sql = sql.Replace("b1", search);
			
			DataTable result = m1.GetDataTable(sql);
			foreach(DataRow row in result.Rows){
				string isbn 		= row[0].ToString();
				string type			= row[1].ToString();
				string title		= row[2].ToString();
				string author	 	= row[3].ToString();
				string genres	 	= row[4].ToString();
				string shelfNo	 	= row[5].ToString();
				string loanable 	= row[6].ToString();
				ListViewItem newrow = new ListViewItem(isbn);
				newrow.SubItems.Add(title); newrow.SubItems.Add(author); 
				newrow.SubItems.Add(type); newrow.SubItems.Add(genres); 
				newrow.SubItems.Add(shelfNo); newrow.SubItems.Add(loanable);
				listView1.Items.Add(newrow);
			}//eloop
		}//ef
		
	}//ec
}//en
