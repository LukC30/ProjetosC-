/*
 * Created by SharpDevelop.
 * User: carva
 * Date: 11/09/2023
 * Time: 20:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Drawing;

namespace joojin
{
	/// <summary>
	/// Description of Tiro.
	/// </summary>
	public class Tiro : PictureBox
	{
		
		
		public Tiro()
		{
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			
		}
		public int shotSpd = 10;
		
	}
}
