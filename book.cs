/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 3/15/2022
 * Time: 10:36 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Final_6213841
{
	/// <summary>
	/// Description of book.
	/// </summary>
	public class book
	{
		public string isbn;
		public string title;
		public string genres;
		public book(string isbn, string title, string genres)
		{
			this.isbn = isbn;
			this.title = title;
			this.genres = genres;
		}
		public book()
		{
		}
	}//ec
}//en
