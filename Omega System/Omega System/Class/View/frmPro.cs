using System;
using System.Drawing;
using System.Windows.Forms;
using Omega_System.Class.Controller;

namespace Omega_System.Class.View
{
	public partial class frmPro : Form
	{
		public frmPro()
		{
			InitializeComponent();
		}
		
		void Btn_cadproClick(object sender, EventArgs e)
		{
			Produtos p = new Produtos();
			p.setDescricao(txt_descricao.Text);
			p.setMarca(txt_fabricante.Text);
			p.setVenda(Convert.ToDouble(txt_valor.Text));
			p.setQtd(Convert.ToDouble(txt_qtd.Text));
			
			p.Cadastrar();
		}
		
		void Btn_voltarClick(object sender, EventArgs e)
		{
			frmMain f1 = new frmMain();
			this.Hide();
			f1.ShowDialog();
		}
	}
}
