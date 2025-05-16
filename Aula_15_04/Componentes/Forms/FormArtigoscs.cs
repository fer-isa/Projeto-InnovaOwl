using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula_15_04.conexao;
using Aula_15_04.DAL;
using Aula_15_04.DTOs;

namespace Aula_15_04.Forms
{
    public partial class frm_artigos : Form
    {
        private IEnumerable<ArtigosDTOs> _artigoSelecionado;

        public frm_artigos()
        {
            InitializeComponent();
            cbx_categoria.DataSource = ConsultaCategoria.ListarCategoriaFormularios();
            cbx_categoria.DisplayMember = "nome";
            cbx_categoria.ValueMember = "id_categoria";

            btn_adicionar.Click += btn_adicionar_Click;
        }
        public frm_artigos(int ID)
        {
            InitializeComponent();

            _artigoSelecionado = consultaArtigos.ListarTodosOsArtigosDTO().Where(item => item.id == ID);
            // preechendo as comboboxes de categorias
            cbx_categoria.DataSource = ConsultaCategoria.ListarCategoriaFormularios();
            cbx_categoria.DisplayMember = "nome";
            cbx_categoria.ValueMember = "id_categoria";
            // recuperando infos preenchidas posteriormente
            txt_nomeArtigos.Text = _artigoSelecionado.First().titulo;
            txt_subtitulo.Text = _artigoSelecionado.First().subtitulo;
            txt_descricao.Text = _artigoSelecionado.First().descricao;
            txt_linkArtigo.Text = _artigoSelecionado.First().link_artigos;
            dtp_dataPublicaçao.Value = _artigoSelecionado.First().data_publicacao;

            cbx_categoria.SelectedValue = _artigoSelecionado.First().id_categoria;

            lbl_adicionarArtigos.Text = "Editar Artigo:";
            btn_adicionar.Text = "Editar Artigo";
            btn_adicionar.Click += btn_EditarArtigo_Click;

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            consultaArtigos.AdicionarArtigos(

               txt_nomeArtigos.Text,
               txt_subtitulo.Text,
               txt_descricao.Text,
               txt_linkArtigo.Text,
               dtp_dataPublicaçao.Value.ToString("yyyy-MM-dd"),
               Convert.ToInt32(cbx_categoria.SelectedValue)

           );

            this.Close();
        }
        private void btn_EditarArtigo_Click(object sender, EventArgs e)
        {
            consultaArtigos.EditarArtigos(

               _artigoSelecionado.First().id,
               txt_nomeArtigos.Text,
               txt_subtitulo.Text,
               txt_descricao.Text,
               txt_linkArtigo.Text,
               dtp_dataPublicaçao.Value.ToString("yyyy-MM-dd"),
               Convert.ToInt32(cbx_categoria.SelectedValue)

           );

            this.Close();
        }
    }
}
