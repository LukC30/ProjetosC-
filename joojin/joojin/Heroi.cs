using System;

namespace joojin
{

	public class Heroi : Personagem
	{
		public Heroi() //Metodo constutor, carrega os atributos e metodos basicos
		{
			Load("Gargoyle.gif");
			Height = 100;
			Width  = 100;
			spd = 20;
			
			
		}
		//a partir daqui, podemos definir os metodos, enfim.
		
		//variaveis publicas
		public sbyte direcao = 1;
		
		//variaveis locais/privadas
		
		int cenario = 0;
		
		//Metodos auxiliares
		
		public void esq(){
			direcao = -1;
			if(direcao == -1)Load("GargoyleEsq.gif");
		Left -= spd;
		
		if (Left < 0) {
			
			
			cenario--;	//cenario tem seu valor diminuido em 1
			
			Left = MainForm.fundo.Width - Width;
			
			if (cenario < 0) {
				cenario = 2;
				
			}
				
			MainForm.fundo.Load("cenario" + cenario + ".gif");
			
		}
		
		}
		public void dir(){
		
			direcao = 1;
			if(direcao == 1)Load("Gargoyle.gif");
			Left += spd;
			
			if(Left > MainForm.fundo.Width){
				
				
				cenario++; 
				if (cenario > 2) cenario = 0;
				MainForm.fundo.Load("cenario" + cenario + ".gif");
				Left = 0;
				
			}
		}
		
		public void cima(){
		
			Top -= spd;
			
			if (Top < 0) Top = 0;
		}
		
		public void baixo(){
		
			Top += spd;
			if(Top > 220) Top = 220;
		}
			
	}
}
