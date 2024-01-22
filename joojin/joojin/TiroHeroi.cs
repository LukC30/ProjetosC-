using System;
using System.Windows.Forms;


namespace joojin
{
	public class TiroHeroi : Tiro
	{
		sbyte direcao = MainForm.xd;
		
		public TiroHeroi()
		{
			
			if(direcao == 1)Load("gargoyle.gif");
			if(direcao == -1)Load("gargoyleesq.gif");
			Width = 50;
			Height = 50;	
			this.Parent = MainForm.fundo;
			VAMOSATIVE();
		
		}
		
		public Vilao boundsVilao;
		
		public void VAMOSATIVE(){
		
		Timer tristi = new Timer();
		tristi.Tick += tempo;
		tristi.Interval = 100;
		tristi.Enabled = true;
		
		if(this.Left < MainForm.fundo.Left - 60 || this.Left > MainForm.fundo.Left + 60){
			Dispose();
			tristi.Enabled = false;
		}
		
		}
			
			
		
		
		public void MoviTiror(){
			if(direcao == 1) Left += shotSpd;
			if(direcao == -1) Left -= shotSpd;
		  
		}
		public void tempo(object sender, EventArgs e){
			MoviTiror();

		}
	}
}
