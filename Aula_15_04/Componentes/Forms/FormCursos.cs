using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula_15_04.DAL;
using Aula_15_04.DTOs;

namespace Aula_15_04.Forms
{
    public partial class frm_cursos : Form
    {
        private IEnumerable<CursoDTOs> _cursoSelecionado;

        public frm_cursos()
        {
            InitializeComponent();// Momento onde a tela é desenhada

            //Preenchendo as comboBoxes de categorias
            cbx_categoria.DataSource = ConsultaCategoria.ListarCategoriaFormularios();
            cbx_categoria.DisplayMember = "nome";
            cbx_categoria.ValueMember = "id_categoria";


            //Preenchendo as comboBoxes de categorias
            cbx_professor.DataSource = consultaProfessores.ListarProfessores();
            cbx_professor.DisplayMember = "nome";
            cbx_professor.ValueMember = "id_professor";

            btn_adicionar.Click += btn_adicionar_Click;
        }

        public frm_cursos(int ID)
        {
            InitializeComponent();// Momento onde a tela é desenhada

            lbl_adicionarCursos.Text = "Editar Curso";
            _cursoSelecionado = ConsultaCursos.ListarTodosOsCursosDTO().Where(curso => curso.id == ID);

            //Preenchendo as comboBoxes de categorias
            cbx_categoria.DataSource = ConsultaCategoria.ListarCategoriaFormularios();
            cbx_categoria.DisplayMember = "nome";
            cbx_categoria.ValueMember = "id_categoria";


            //Recuperando informações preenchidas posteriormente
            txt_nomeCursos.Text = _cursoSelecionado.First().nome;
            txt_descricao.Text = _cursoSelecionado.First().descricao;
            Convert.ToInt32(nud_cargaHoraria.Value);
            txt_link.Text = _cursoSelecionado.First().link;
            cbx_professor.SelectedValue = _cursoSelecionado.First().id_professor;
            cbx_categoria.SelectedValue = _cursoSelecionado.First().id_categoria;


            //Preenchendo as comboBoxes de categorias
            cbx_professor.DataSource = consultaProfessores.ListarProfessores();
            cbx_professor.DisplayMember = "nome";
            cbx_professor.ValueMember = "id_professor";

            btn_adicionar.Text = "Editar Curso";
            btn_adicionar.Click += btn_editar_Click;
        }


        private void nud_cargaHoraria_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            ConsultaCursos.AdicionarCursos(

                txt_nomeCursos.Text,
                txt_descricao.Text,
                Convert.ToInt32(nud_cargaHoraria.Value),
                txt_link.Text,
                Convert.ToInt32(cbx_professor.SelectedValue),
                Convert.ToInt32(cbx_categoria.SelectedValue)
            );
            this.Close();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            ConsultaCursos.EditarCurso(

                _cursoSelecionado.First().id,
               txt_nomeCursos.Text,
               txt_descricao.Text,
               Convert.ToInt32(nud_cargaHoraria.Value),
               txt_link.Text,
               Convert.ToInt32(cbx_professor.SelectedValue),
               Convert.ToInt32(cbx_categoria.SelectedValue)

            );
            this.Close();
        }
    }

}
