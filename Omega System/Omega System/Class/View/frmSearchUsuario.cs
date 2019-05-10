using System;
using System.Drawing;
using System.Windows.Forms;
using Omega_System.Class.Controller;
using System.Collections.Generic;
using System.Data;

namespace Omega_System.Class.View
{
	public partial class frmSearchUsuario : Form
	{
		public frmSearchUsuario()
		{
			InitializeComponent();
		}
		
		void Btn_pesquisarClick(object sender, EventArgs e)
		{
			Usuarios u = new Usuarios();
			this.dgv_usuarios.DataSource = u.Buscar();	
			//this.dgv_usuarios.Update();
		}
			
		void FrmSearchUsuarioLoad(object sender, EventArgs e)
		{
		
		}
		
		void Btn_incluirClick(object sender, EventArgs e)
		{
			frmUsu f2 = new frmUsu();
			this.Hide();
			f2.ShowDialog();
		}
		
		void Dgv_usuariosCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Usuarios u = new Usuarios();
			u.setId(Convert.ToInt32(dgv_usuarios.Rows[e.RowIndex].Cells[0].Value));
			u.setNome(Convert.ToString(dgv_usuarios.Rows[e.RowIndex].Cells[1].Value));
			u.setLogin(Convert.ToString(dgv_usuarios.Rows[e.RowIndex].Cells[2].Value));
			
			frmUpdUsu f3 = new frmUpdUsu(u);
			this.Hide();
			f3.ShowDialog();
		}
	}
}
