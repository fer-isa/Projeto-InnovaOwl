using Aula_15_04.Componentes.Controles;
using Aula_15_04.conexao;
using Aula_15_04.Controles;

namespace Aula_15_04
{
    public partial class Form_principal : Form
    {
        public Form_principal()
        {
            InitializeComponent();
        }


        private void btn_Artigos_Click_1(object sender, EventArgs e)
        {
            pnl_Conteudo.Controls.Clear();

            listaDeArtigos listaDeCursosTech = new listaDeArtigos();
            pnl_Conteudo.Controls.Add(listaDeCursosTech);
            listaDeCursosTech.Dock = DockStyle.Fill;
        }

        private void btn_Cursos_Click_1(object sender, EventArgs e)
        {
            pnl_Conteudo.Controls.Clear();

            listaDeCursos listaDeCursosTech = new listaDeCursos();
            pnl_Conteudo.Controls.Add(listaDeCursosTech);
            listaDeCursosTech.Dock = DockStyle.Fill;
        }

        private void btn_cardsCursos_Click(object sender, EventArgs e)
        {
            pnl_Conteudo.Controls.Clear();

            ControlesCardCursos cardsDeCursosTech = new ControlesCardCursos();
            pnl_Conteudo.Controls.Add(cardsDeCursosTech);
            cardsDeCursosTech.Dock = DockStyle.Fill;


        }

        private void btn_Professores_Click(object sender, EventArgs e)
        {
            pnl_Conteudo.Controls.Clear();

            listaProfessores listaProfessores = new listaProfessores();
            pnl_Conteudo.Controls.Add(listaProfessores);
            listaProfessores.Dock = DockStyle.Fill;
        }

        private void btn_cardArtigos_Click(object sender, EventArgs e)
        {
            pnl_Conteudo.Controls.Clear();

            ControleCardArtigos controleCardArtigos = new ControleCardArtigos();
            pnl_Conteudo.Controls.Add(controleCardArtigos);
            controleCardArtigos.Dock = DockStyle.Fill;
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            pnl_Conteudo.Controls.Clear();

            Inicio controleInicio = new Inicio();
            pnl_Conteudo.Controls.Add(controleInicio);
            controleInicio.Dock = DockStyle.Fill;
        }
    }

}
