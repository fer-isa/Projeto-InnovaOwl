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
    public partial class listaProfessores : UserControl
    {
        public listaProfessores()
        {
            InitializeComponent();
            dgv_ListaDeProfessores.DataSource = consultaProfessores.ListarProfessores();

        }

        private void dgv_Lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_AdicionarCurso_Click(object sender, EventArgs e)
        {
            frm_professores adicionarProfessor = new frm_professores();
            adicionarProfessor.ShowDialog();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            dgv_ListaDeProfessores.DataSource = consultaProfessores.BuscarProfessores(txt_pesquisar.Text);
        }

        private void btn_RemoverProfessor_Click(object sender, EventArgs e)
        {
            if (dgv_ListaDeProfessores.SelectedCells.Count > 0 && dgv_ListaDeProfessores.SelectedCells.Count <= 1)
            {
                // Seleciona o ID da linha selecionada no DataGridView
                int professorQueSeraDeletado = Convert.ToInt32(dgv_ListaDeProfessores.CurrentRow.Cells["id_professor"].Value);

                // Exibi mensagem de confirmação de exclusão
                DialogResult escolhaDoUsuario = MessageBox.Show(
                    $"Gostaria de apagar esse professor do id_professor: {professorQueSeraDeletado}? \nEsta ação é irreversível.",
                    "Delete Professor",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning

                );

                if (escolhaDoUsuario == DialogResult.Yes)
                {
                    consultaProfessores.RemoverProfessores(professorQueSeraDeletado);
                    dgv_ListaDeProfessores.DataSource = consultaProfessores.ListarProfessores();
                }

            }

        }

        private void btn_editarProfessor_Click(object sender, EventArgs e)
        {
            // Verificando se há algum item selecionado na DataGridView
            if (dgv_ListaDeProfessores.SelectedCells.Count > 0 && dgv_ListaDeProfessores.SelectedCells.Count <= 1)
            {
                // Seleciona o ID da linha selecionada no DataGridView
                int professorQueSeraEditado = Convert.ToInt32(dgv_ListaDeProfessores.CurrentRow.Cells["id_professor"].Value);

                frm_professores editarProfessor = new frm_professores(professorQueSeraEditado);
                editarProfessor.ShowDialog();
                dgv_ListaDeProfessores.DataSource = consultaProfessores.ListarProfessores();
            }
        }
    }
}
