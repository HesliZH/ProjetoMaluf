using System;
using System.Drawing;
using System.Windows.Forms;

namespace Omega_System.Class.View
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}
		
		void Btn_usuClick(object sender, EventArgs e)
		{
			frmSearchUsuario f1 = new frmSearchUsuario();
			this.Hide();
			f1.ShowDialog();
		}
		
		void Btn_cadProdClick(object sender, EventArgs e)
		{
			frmPro f2 = new frmPro();
			this.Hide();
			f2.ShowDialog();
		}
	}
}
