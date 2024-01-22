
using System;
using System.Windows.Forms;
using System.Drawing;

namespace joojin
{

	public class Personagem : PictureBox
	{
		public Personagem()
		{
			SizeMode =	PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			
		}
		public int hp = 100;
		public int spd = 25;
		public int atk = 5;
		public int def = 5;
		
	}
}
