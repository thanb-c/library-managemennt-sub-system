/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 3/11/2022
 * Time: 11:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Final_6213841
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		DataManager m1 = new DataManager("localhost", "final", "root","1234");
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void openForm(Form selectedFrom,object btnSender)
		{
			selectedFrom.TopLevel = false;
			selectedFrom.FormBorderStyle = FormBorderStyle.None;
			selectedFrom.Dock = DockStyle.Fill;
			this.panel1.Controls.Add(selectedFrom);
			selectedFrom.BringToFront();
			selectedFrom.Show();
		}//ef
		
		void PictureBox2Click(object sender, EventArgs e)
		{
			this.Close();
		}//ef
		
		
		void btnSearchClick(object sender, EventArgs e)
		{
			Search_F find = new Search_F();
			openForm(find, sender);
			
		}//ef
		
		void BtnReturnClick(object sender, EventArgs e)
		{
			Return_F checkout = new Return_F();
			openForm(checkout, sender);
			
		}//ef
		
	}//ec
}//en
