using Aula_15_04.conexao;
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
    public partial class listaDeArtigos : UserControl
    {
        public listaDeArtigos()
        {
            // desenha controle na tela
            InitializeComponent();

            //preenche infrmações na tabela
            dgv_ListaArtigos.DataSource = consultaArtigos.listarArtigos();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            dgv_ListaArtigos.DataSource = consultaArtigos.buscarArtigos(txt_pesquisar.Text);
        }

        private void btn_RemoverCurso_Click(object sender, EventArgs e)
        {
            // Verificando se há algum item selecionado na DataGridView
            if (dgv_ListaArtigos.SelectedCells.Count > 0 && dgv_ListaArtigos.SelectedCells.Count <= 1)
            {
                // Seleciona o ID da linha selecionada no DataGridView
                int artigoQueSeraDeletado = Convert.ToInt32(dgv_ListaArtigos.CurrentRow.Cells["id_artigo"].Value);

                // Exibi mensagem de confirmação de exclusão
                DialogResult escolhaDoUsuario = MessageBox.Show(
                    $"Gostaria de apagar esse Artigo do id_artigo: {artigoQueSeraDeletado}",
                    "Delete Artigo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning

                );
                if (true)
                {
                    consultaArtigos.RemoverArtigos(artigoQueSeraDeletado);
                    dgv_ListaArtigos.DataSource = consultaArtigos.listarArtigos();
                }
            }
        }

        private void btn_AdicionarArtigos_Click(object sender, EventArgs e)
        {
            frm_artigos artigos = new frm_artigos();
            artigos.ShowDialog();
            dgv_ListaArtigos.DataSource = consultaArtigos.listarArtigos();
        }

        private void btn_EditarCurso_Click(object sender, EventArgs e)
        {
            if (dgv_ListaArtigos.SelectedCells.Count > 0 && dgv_ListaArtigos.SelectedCells.Count <= 1)
            {
                int idArtigoQueSeraEditado = Convert.ToInt32(dgv_ListaArtigos.CurrentRow.Cells["id_artigo"].Value);

                frm_artigos artigos = new frm_artigos(idArtigoQueSeraEditado);
                artigos.ShowDialog();
                dgv_ListaArtigos.DataSource = consultaArtigos.listarArtigos();
            }
        }
    }
}
