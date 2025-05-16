using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula_15_04.Componentes.EmTestes;

namespace Aula_15_04.Componentes.EmTestes
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            //Arredonda.setRoundedController(btn_entrar, 10);
            //Arredonda.setRoundedController(btn_cadastrar, 10);


        }


        private void btn_entrar_Click(object sender, EventArgs e)
        {
            //DataTable acesso =




            if (txt_usuario.Text.Equals("USUARIOSENAC") && txt_senha.Text.Equals("CONHECIMENTO"))
            {
                //abrir proximo formulario 
                Form_principal form_Principal = new Form_principal();
                form_Principal.Show();
                this.Hide(); //fecha a tela de login
                form_Principal.FormClosing += delegate { this.Show(); };
            }

            else
            {
                MessageBox.Show(
                    "Usúario ou senha incorretas.",
                    "Entrar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
            }
        }


        private void btn_cadastrar_Click_1(object sender, EventArgs e)
        {
            Cadastrar telacadastro = new Cadastrar();
            telacadastro.ShowDialog();
        }

        private void lbl_login_Click(object sender, EventArgs e)
        {

        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
