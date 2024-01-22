
using System;
using System.Windows.Forms;

namespace joojin
{

	public class Vilao : Personagem
	{

		
		
		public Vilao()
		{
			Load("GargoyleEsq.gif");
			Height = 100;
			Width  = 100;
			spd = 20;
			
			
		}
		
		public TiroHeroi boundsTiro;
		
		public void moviCima(){
			Top+=spd;
										
		}
		public void moviBaixo(){
			Top-=spd;
		}
		



	}
}
