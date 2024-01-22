using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text;

namespace joojin
{
	public partial class MainForm : Form
	{
		
		public static PictureBox fundo = new PictureBox(); 
		public static Heroi heroi = new Heroi();
		Vilao vilao = new Vilao();
		Random rnd = new Random();
		Timer timer = new Timer();
		public static ListBox lista = new ListBox();

		
		int num;
		public int movimento = 1;
		public static sbyte xd;
		
		public MainForm()
			
		{

			InitializeComponent();
			

		}
		void MainFormLoad(object sender, EventArgs e)
		{
			//fundo
			fundo.Load("cenario0.gif");
			fundo.Parent = this;
			fundo.Width = this.Width;
			fundo.Height = this.Height - 120;
			fundo.SizeMode = PictureBoxSizeMode.StretchImage;
			
			//heroi
			heroi.Parent = fundo;
			heroi.Top = 180;
			
			//timer1
			timer2.Enabled = true;
			timer2.Interval = 1000;
			
			//timerxd
			timer.Enabled = true;
			
			//vilao
			vilao.Parent = fundo;
			vilao.Top = 1;
			vilao.Left = 750;
		
			
		}
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.W){	//Cima
				heroi.cima();
			}
			if (e.KeyCode == Keys.S) {	//Baixo
				heroi.baixo();
			}
			if (e.KeyCode == Keys.A) {	//Esquerda
				heroi.esq();
			
			}
			
			if (e.KeyCode == Keys.D) {	//Direita
				heroi.dir();
				
			}
			
			if(e.KeyCode == Keys.Space){	//tiro
				xd = heroi.direcao;
				TiroHeroi tiroHeroi = new TiroHeroi();
				tiroHeroi.boundsVilao = vilao;
				if (heroi.direcao == 1)tiroHeroi.Left = heroi.Left + 60;
				if (heroi.direcao == -1) tiroHeroi.Left = heroi.Left - 60;
				tiroHeroi.Top = heroi.Top;
				lista.Items.Add(tiroHeroi);
			}
		}

		void Timer2Tick(object sender, EventArgs e)
		{

			if(vilao.Top <= 0)movimento = 1;
			if(vilao.Top > MainForm.fundo.Height - 100) movimento = -1;
			
			if (movimento == 1)vilao.moviCima();
			if (movimento == -1)vilao.moviBaixo();

			num = rnd.Next(1,101);
				if (num > 80) {
				TiroVilao tiroVilokk = new TiroVilao();
				
				tiroVilokk.Parent = fundo;
				tiroVilokk.Top = vilao.Top;
				tiroVilokk.Left = vilao.Left - 100;
			}
			

			
		}
	}
}

//quero me matar