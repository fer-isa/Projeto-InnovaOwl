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

namespace Aula_15_04.Controles
{
    public partial class ControlesCardCursos : UserControl
    {
        public ControlesCardCursos()
        {
            InitializeComponent();

            //Preenchendo as comboBoxes de categorias
            cbx_filtroDeCategoria.DataSource = ConsultaCategoria.ListarCategoriaFormularios();
            cbx_filtroDeCategoria.DisplayMember = "nome";
            cbx_filtroDeCategoria.ValueMember = "id_categoria";

            cbx_filtroDeCategoria.SelectedIndex = 0;

            flp_listaDeCursos.AutoScroll = true;

            flp_listaDeCursos.Controls.Clear();

            foreach (var item in ConsultaCursos.ListarTodosOsCursosDTO())
            {
                cardCursos Meucard = new cardCursos(item);
                flp_listaDeCursos.Controls.Add(Meucard);
            }
        }

        public ControlesCardCursos(int id_categoria)
        {
            InitializeComponent();

            flp_listaDeCursos.AutoScroll = true;
            flp_listaDeCursos.Controls.Clear();

            foreach (var item in ConsultaCursos.ListarTodosOsCursosDTO().Where(item => item.id_categoria == id_categoria))
            {
                cardCursos Meucard = new cardCursos(item);
                flp_listaDeCursos.Controls.Add(Meucard);
            }
        }

        private void flp_listaDeCursos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_filtroPesquisar_Click(object sender, EventArgs e)
        {
            flp_listaDeCursos.Controls.Clear();

            IEnumerable<CursoDTOs> cursos;
            cursos = ConsultaCursos.ListarTodosOsCursosDTO();


            cursos = cursos.Where(item => item.id_categoria == Convert.ToInt32(cbx_filtroDeCategoria.SelectedValue));

            foreach (var item in cursos)
            {
                cardCursos Meucard = new cardCursos(item);
                flp_listaDeCursos.Controls.Add(Meucard);

            }
        }

        private void btn_mostrarTudo_Click(object sender, EventArgs e)
        {
            flp_listaDeCursos.Controls.Clear();

            foreach (var item in ConsultaCursos.ListarTodosOsCursosDTO())
            {
                cardCursos Meucard = new cardCursos(item);
                flp_listaDeCursos.Controls.Add(Meucard);
            }
        }
    }
}
