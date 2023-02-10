/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 3/12/2022
 * Time: 1:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Final_6213841
{
	partial class Login_Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
			this.btnLogin = new System.Windows.Forms.Button();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbShowPass = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.close = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(218, 290);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(5);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(172, 37);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLoginClick);
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(189, 177);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(294, 27);
			this.txtUsername.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(83, 177);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "User name :";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(189, 219);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(294, 27);
			this.txtPassword.TabIndex = 3;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(83, 222);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password : ";
			// 
			// cbShowPass
			// 
			this.cbShowPass.Location = new System.Drawing.Point(218, 258);
			this.cbShowPass.Name = "cbShowPass";
			this.cbShowPass.Size = new System.Drawing.Size(158, 24);
			this.cbShowPass.TabIndex = 5;
			this.cbShowPass.Text = "show password";
			this.cbShowPass.UseVisualStyleBackColor = true;
			this.cbShowPass.CheckedChanged += new System.EventHandler(this.cbShowPassCheckedChanged);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(71, 121);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(432, 50);
			this.label4.TabIndex = 8;
			this.label4.Text = "Please login to access to the system.\r\nInput user name and password, then click l" +
			"ogin button.\r\n";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// close
			// 
			this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
			this.close.Location = new System.Drawing.Point(538, 1);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(39, 35);
			this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.close.TabIndex = 9;
			this.close.TabStop = false;
			this.close.Click += new System.EventHandler(this.closeClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(201, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(175, 111);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// Login_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(576, 369);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.close);
			this.Controls.Add(this.cbShowPass);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.label4);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "Login_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox close;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.CheckBox cbShowPass;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUsername;
	}
}
