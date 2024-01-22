using System;
using System.Windows.Forms;
namespace joojin
{
	public class TiroVilao : Tiro
	{
		public TiroVilao()
		{
			Load("GargoyleEsq.gif");
			Width = 50;
			Height = 50;
			this.Parent = MainForm.fundo;
			Left = MainForm.fundo.Left + 700;
			atirar();
		}
	

		public void atirar(){
		Timer tempo1 = new Timer();
		tempo1.Tick += tEMPOHAHAHA;
		tempo1.Enabled = true;
		
		if (this.Disposing == true) {
			tempo1.Dispose();
		}
		
		}
		public void moviTiro(){
		
			Left -= shotSpd;

		}
		
		void tEMPOHAHAHA(object sender, EventArgs e){
			
			moviTiro();
			
			if (Bounds.IntersectsWith(MainForm.heroi.Bounds))Dispose();	
			if (Left < MainForm.fundo.Left - 60)Dispose();
				}	
	}
}
