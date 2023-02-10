/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 3/12/2022
 * Time: 1:08 PM
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
	/// Description of Login_Form.
	/// </summary>
	public partial class Login_Form : Form
	{
		DataManager m1 = new DataManager("localhost", "final", "root","1234");
		public Login_Form()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void closeClick(object sender, EventArgs e)
		{
			this.Close();
		}//ef
		
		void btnLoginClick(object sender, EventArgs e)
		{
			string username = txtUsername.Text;
			string password = txtPassword.Text;

			string sql = "select * from member where username = 'p1' and password= 'p2' ";
			sql = sql.Replace("p1", username);
			sql = sql.Replace("p2", password);
			DataTable result=  m1.GetDataTable(sql);
			
			if (result.Rows.Count > 0) {
				int no				= int.Parse(result.Rows[0][0].ToString());
				string firstname 	= result.Rows[0][3].ToString();
				string lastname	 	= result.Rows[0][4].ToString();
				string type 		= result.Rows[0][5].ToString();
				member member = new member(no,firstname,lastname,type);
				Global.member = member;
				MainForm mainform = new MainForm();
				mainform.ShowDialog() ;
			}//eif
			else {
				MessageBox.Show("Something wrong, please try again");
			}//eif
		}//ef
		
		private void cbShowPassCheckedChanged(object sender, EventArgs e)
		{
			
			if (cbShowPass.Checked == true) {
				txtPassword.UseSystemPasswordChar = false;
			}//eif
			else {
				txtPassword.UseSystemPasswordChar = true;
			}//eif
		}//ef
		
		
	}//ec
}//en
