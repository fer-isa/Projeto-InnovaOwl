using Aula_15_04.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aula_15_04.Controles
{
    [DefaultEvent("Click")]
    public partial class cardCursos : UserControl
    {
        private string _linkDoCurso;

        [Category("# Opções do Card")]
        public string nomeCard
        {

            get { return lbl_nomeCard.Text; }

            set { lbl_nomeCard.Text = value; }

        }


        [Category("# Opções do Card")]
        public string descricaoCard
        {

            get { return lbl_descricao.Text; }

            set { lbl_descricao.Text = value; }

        }

        [Category("# Opções do Card")]
        public string categoriaCard
        {

            get { return lbl_categoria.Text; }

            set { lbl_categoria.Text = value; }

        }

        [Category("# Opções do Card")]
        public string urlDaImagemCard
        {

            get { return img_card.ImageLocation; }

            set { img_card.ImageLocation = value; }

        }

        [Category("# Opções do Card")]
        public Image blobDaImagemCard
        {

            get { return img_card.Image; }

            set { img_card.Image = value; }

        }

        [Category("# Opções do Card")]
        public Color corCard

        {

            get { return pnl_Header.BackColor; }

            set { pnl_Header.BackColor = value; }

        }

        public cardCursos()
        {
            InitializeComponent();
        }

        public cardCursos(CursoDTOs curso)
        {
            InitializeComponent();

            // Guardar o link do video:
            _linkDoCurso = curso.link;

            // Preenchendo os campos
            lbl_nomeCard.Text = curso.nome;
            lbl_categoria.Text = curso.nome_categoria;
            lbl_descricao.Text = curso.descricao;


            // Remove a parte repetida do inicio do link:
            string link = curso.link;
            link = link.Replace("https://www.youtube.com/watch?v=", "");
            link = link.Replace("https://www.youtube.com/playlist?list=", "");

            // separa a segunda parte do video caso o mesmo faça parte de uma playlist:
            string[] pedacosDoLinkDoVideo = link.Split("&");

            // Substitui a URL da imagem que sera mostrada na pictureBox:
            img_card.ImageLocation = $"https://i.ytimg.com/vi/{pedacosDoLinkDoVideo[0]}/hqdefault.jpg";
        }

        private void btn_card_Click(object sender, EventArgs e)
        {
            // Define a chamada do link do video no terminal do windows
            ProcessStartInfo videoQueSeraAcessado = new ProcessStartInfo
            {
                FileName = _linkDoCurso, // link a ser aberto
                UseShellExecute = true  // define que podera ser chamado pelo terminal
            };

            // Executa o comando de chamada de video
            Process.Start(videoQueSeraAcessado);
        }
    }
}
