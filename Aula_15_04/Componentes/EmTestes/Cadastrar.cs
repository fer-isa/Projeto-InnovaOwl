using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_15_04.Componentes.EmTestes
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
            //Arredonda.setRoundedController(btn_cad, 10);
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }


        private void btn_cad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_principal telacadastro = new Form_principal();
            telacadastro.ShowDialog();
            this.Close();


           

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
