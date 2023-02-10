/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 3/12/2022
 * Time: 1:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Final_6213841
{
	/// <summary>
	/// Description of CheckOut_F.
	/// </summary>
	public partial class Return_F : Form
	{
		DataManager m1 = new DataManager("localhost", "final", "root","1234");
		
		public Return_F()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Return_FLoad(object sender, EventArgs e)
		{
			loadData();
		}//ef
		
		private void loadData(){
		
			string sql = "SELECT borrowed.no, member.firstname, member.lastname, borrowed.title, borrowed.borrowDate, borrowed.returnDate FROM borrowed";
			sql += " LEFT JOIN member ON borrowed.memberId = member.no;";
			DataTable table = m1.GetDataTable(sql);
			grid1.DataSource = table;
				
		}//ef
		
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.Close();
		}//ef
		

		void Grid1SelectionChanged(object sender, EventArgs e)
		{
			txtStudentName.Text = grid1.CurrentRow.Cells[1].Value.ToString() + " " + grid1.CurrentRow.Cells[2].Value.ToString();
			txtBookTitle.Text 	= grid1.CurrentRow.Cells[3].Value.ToString();
			txtDateBorrow.Text	= grid1.CurrentRow.Cells[4].Value.ToString();
			
		}//ef
		
		void BtnReturnClick(object sender, EventArgs e)
		{
			string name = Global.member.firstname;
			
			string sql = "update borrowed set returnDate = 'd1'";
			sql += " where no = 'd0'";
			sql = sql.Replace("d0",grid1.CurrentRow.Cells[0].Value.ToString());
			sql = sql.Replace("d1",dtReturnDate.Value.ToString("yyyy-MM-dd HH:mm:ss"));
			
			//check wheter name and user login are match
			if (grid1.CurrentRow.Cells[1].Value.Equals(name)){
			m1.ExecuteNonQuery(sql);
			loadData();
			MessageBox.Show("You alredy return the book, Thank you!!");
			}//eif
			
			//if the name is not match with the user login	
			else{
				MessageBox.Show("Check your name again");
			}//eif
			
		}//ef
	}//ec
}//en
