using Aula_15_04.conexao;
using Aula_15_04.DAL;
using Aula_15_04.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_15_04.Controles
{
    public partial class listaDeCursos : UserControl
    {
        public listaDeCursos()
        {
            InitializeComponent();
            dgv_Lista.DataSource = ConsultaCursos.ListarCursos();
        }



        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            dgv_Lista.DataSource = ConsultaCursos.BuscarCursos(txt_pesquisar.Text);
        }

        private void btn_AdicionarCurso_Click(object sender, EventArgs e)
        {
            frm_cursos adicionarCursos = new frm_cursos();
            adicionarCursos.ShowDialog();
            dgv_Lista.DataSource = ConsultaCursos.ListarCursos();

        }

        private void listaDeCursos_Load(object sender, EventArgs e)
        {

        }

        private void dgv_Lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_RemoverCurso_Click(object sender, EventArgs e)
        {
            // Verificando se há algum item selecionado na DataGridView
            if (dgv_Lista.SelectedCells.Count > 0 && dgv_Lista.SelectedCells.Count <= 1)
            {
                // Seleciona o ID da linha selecionada no DataGridView
                int cursoQueSeraDeletado = Convert.ToInt32(dgv_Lista.CurrentRow.Cells["id_curso"].Value);

                // Exibi mensagem de confirmação de exclusão
                DialogResult escolhaDoUsuario = MessageBox.Show(
                    $"Gostaria de apagar esse Curso do id_curso: {cursoQueSeraDeletado}? \nEsta ação é irreversível.",
                    "Delete Curso",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning

                );

                if (escolhaDoUsuario == DialogResult.Yes)
                {
                    ConsultaCursos.RemoverCursos(cursoQueSeraDeletado);
                    dgv_Lista.DataSource = ConsultaCursos.ListarCursos();
                }

            }

        }

        private void btn_EditarCurso_Click(object sender, EventArgs e)
        {
            // Verificando se há algum item selecionado na DataGridView
            if (dgv_Lista.SelectedCells.Count > 0 && dgv_Lista.SelectedCells.Count <= 1)
            {
                // Seleciona o ID da linha selecionada no DataGridView
                int cursoQueSeraEditado = Convert.ToInt32(dgv_Lista.CurrentRow.Cells["id_curso"].Value);

                frm_cursos adicionarCursos = new frm_cursos(cursoQueSeraEditado);
                adicionarCursos.ShowDialog();
                dgv_Lista.DataSource = ConsultaCursos.ListarCursos();
            }


        }
    }
}
