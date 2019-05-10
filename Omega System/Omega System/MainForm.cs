using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Omega_System.Class.View;
using Omega_System.Class.Controller;

namespace Omega_System
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Btn_logarClick(object sender, EventArgs e)
		{
			//bool logado = false;
			Usuarios u = new Usuarios();
			
			u.setLogin(txt_login.Text);
			u.setSenha(txt_senha.Text);
			//u.Entrar();
			
			if(u.Entrar() == true){
				frmMain f1 = new frmMain();
				this.Hide();
				f1.ShowDialog();
			}
		}
		
		void Btn_cancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
