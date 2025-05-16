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
    public partial class frm_professores : Form
    {
        private IEnumerable<ProfessoresDTOs> _professoreSelecionado;

        public frm_professores()
        {
            InitializeComponent();

            // CHAMAR FUNCAO DE ADICIONAR PROFESSOR
            btn_adicionarProfessor.Click += btn_adicionarProfessor_Click;
        }

        public frm_professores(int ID)
        {
            InitializeComponent();

            // CHAMA A LISTA DE INFORMAÇÕES DOS PROFESSORES
            _professoreSelecionado = consultaProfessores.ListarTodosOsProfessoresDTO().Where(curso => curso.id == ID);

            // Chamar informações
            txt_nomeProfessor.Text = _professoreSelecionado.First().nome;
            txt_email.Text = _professoreSelecionado.First().email;

            // CHAMAR FUNCAO DE EDITAR PROFESSOR
            btn_adicionarProfessor.Click += btn_EditarProfessor_Click;
        }


        private void btn_adicionarProfessor_Click(object sender, EventArgs e)
        {
            consultaProfessores.AdicionarProfessores(
                txt_nomeProfessor.Text,
                txt_email.Text
            );

            this.Close();
        }

        private void btn_EditarProfessor_Click(object sender, EventArgs e)
        {
            consultaProfessores.EditarProfessor(
                _professoreSelecionado.First().id,
                txt_nomeProfessor.Text,
                txt_email.Text
            );

            this.Close();
        }

        private void lbl_adicionarProfessor_Click(object sender, EventArgs e)
        {

        }
    }
}
