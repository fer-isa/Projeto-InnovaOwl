using Aula_15_04.conexao;
using Aula_15_04.DAL;
using Aula_15_04.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_15_04.Controles
{
    public partial class ControleCardArtigos : UserControl
    {
        public ControleCardArtigos()
        {
            InitializeComponent();


            cbx_CategoriaCardsArtigos.DataSource = ConsultaCategoria.ListarCategoriaFormularios();
            cbx_CategoriaCardsArtigos.DisplayMember = "nome";
            cbx_CategoriaCardsArtigos.ValueMember = "id_categoria";
            cbx_CategoriaCardsArtigos.SelectedIndex = 0;

            flp_listaDeArtigos.AutoScroll = true;
            flp_listaDeArtigos.Controls.Clear();


            foreach (var itemArtigos in consultaArtigos.ListarTodosOsArtigosDTO())
            {
                cardArtigos Meucard = new cardArtigos(itemArtigos);
                Meucard.Text = "Teste";
                flp_listaDeArtigos.Controls.Add(Meucard);



            }

        }

        public ControleCardArtigos(int categoria)
        {
            InitializeComponent();
            flp_listaDeArtigos.AutoScroll = true;
            flp_listaDeArtigos.Controls.Clear();

            cbx_CategoriaCardsArtigos.DataSource = ConsultaCategoria.ListarCategoriaFormularios();
            cbx_CategoriaCardsArtigos.DisplayMember = "nome";
            cbx_CategoriaCardsArtigos.ValueMember = "id_categoria";
            cbx_CategoriaCardsArtigos.SelectedIndex = 0;

            foreach (var itemArtigos in consultaArtigos.ListarTodosOsArtigosDTO().Where(itemArtigos => itemArtigos.id_categoria == categoria))
            {
                cardArtigos Meucard = new cardArtigos(itemArtigos);
                Meucard.Text = "Teste";
                flp_listaDeArtigos.Controls.Add(Meucard);

            }

        }

        private void btn_BuscaCards_Click(object sender, EventArgs e)
        {
            flp_listaDeArtigos.Controls.Clear();

            IEnumerable<ArtigosDTOs> lista;
            lista = consultaArtigos.ListarTodosOsArtigosDTO();

            lista = lista.Where(itemArtigos => itemArtigos.id_categoria == Convert.ToInt32(cbx_CategoriaCardsArtigos.SelectedValue));

            foreach (var itemArtigos in lista)
            {
                cardArtigos Meucard = new cardArtigos(itemArtigos);
                Meucard.Text = "Teste";
                flp_listaDeArtigos.Controls.Add(Meucard);

            }

        }
    }
}
