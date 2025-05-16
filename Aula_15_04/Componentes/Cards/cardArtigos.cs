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

namespace Aula_15_04.Controles
{
    [DefaultEvent("Click")]

    public partial class cardArtigos : UserControl
    {
        private string _linkDoArtigo;

        [Category("# Opções do Card")]
        public string nomeCardArtigos
        {
            get { return lbl_nomeCardArtigos.Text; }

            set { lbl_nomeCardArtigos.Text = value; }

        }




        [Category("# Opções do Card")]
        public string subtituloCard
        {

            get { return lbl_subtitulo.Text; }

            set { lbl_subtitulo.Text = value; }

        }


        [Category("# Opções do Card")]
        public string descricaoCardArtigos
        {

            get { return lbl_descricaoArtigos.Text; }

            set { lbl_descricaoArtigos.Text = value; }

        }

        [Category("# Opções do Card")]
        public string categoriaCard
        {

            get { return lbl_categoriaArtigos.Text; }

            set { lbl_categoriaArtigos.Text = value; }

        }



        [Category("# Opções do Card")]
        public string dataDePublicacao
        {

            get { return lbl_dataPublicacaoArtigos.Text; }

            set { lbl_dataPublicacaoArtigos.Text = value; }

        }


        public cardArtigos()
        {
            InitializeComponent();
        }

        public cardArtigos(ArtigosDTOs artigos)
        {
            InitializeComponent();
            _linkDoArtigo = artigos.link_artigos;

            lbl_nomeCardArtigos.Text = artigos.titulo;
            lbl_subtitulo.Text = artigos.subtitulo;
            lbl_dataPublicacaoArtigos.Text = artigos.data_publicacao.ToString("yyyy-MM-dd");
            lbl_descricaoArtigos.Text = artigos.descricao;
            lbl_categoriaArtigos.Text = artigos.nome_categoria;

            // Remove a parte repetida do inicio do link:
            string link = artigos.link_artigos;
            link = link.Replace("https://www.youtube.com/watch?v=", "");
            link = link.Replace("https://www.youtube.com/playlist?list=", "");

            // separa a segunda parte do video caso o mesmo faça parte de uma playlist:
            string[] pedacosDoLinkDoArtigo = link.Split("&");


            //img_cardArtigos.ImageLocation = $"https://i.ytimg.com/vi/{pedacosDoLinkDoArtigo[0]}/hqdefault.jpg";
        
            
        }


        private void btn_cardArtigos_Click(object sender, EventArgs e)
        {

            // Define a chamada do link do video no terminal do windows
            ProcessStartInfo artigoQueSeraAcessado = new ProcessStartInfo
            {
                FileName = _linkDoArtigo, // link a ser aberto
                UseShellExecute = true  // define que podera ser chamado pelo terminal
            };

            // Executa o comando de chamada de video
            Process.Start(artigoQueSeraAcessado);
        }
    }
}
