namespace Aula_15_04.Controles
{
    partial class ControleCardArtigos
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pnl_cabecalho = new Panel();
            panel1 = new Panel();
            pnl_cabecalhoArtigos = new Panel();
            lbl_CategoriaArtigos = new Label();
            cbx_CategoriaCardsArtigos = new ComboBox();
            btn_BuscaCards = new Button();
            lbl_CategoriaCards = new Label();
            btn_Busca = new Button();
            flp_listaDeArtigos = new FlowLayoutPanel();
            pnl_cabecalho.SuspendLayout();
            panel1.SuspendLayout();
            pnl_cabecalhoArtigos.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_cabecalho
            // 
            pnl_cabecalho.BackColor = Color.FromArgb(255, 128, 0);
            pnl_cabecalho.Controls.Add(panel1);
            pnl_cabecalho.Controls.Add(lbl_CategoriaCards);
            pnl_cabecalho.Controls.Add(btn_Busca);
            pnl_cabecalho.Dock = DockStyle.Top;
            pnl_cabecalho.Location = new Point(0, 0);
            pnl_cabecalho.Name = "pnl_cabecalho";
            pnl_cabecalho.Size = new Size(823, 100);
            pnl_cabecalho.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(pnl_cabecalhoArtigos);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(823, 100);
            panel1.TabIndex = 6;
            // 
            // pnl_cabecalhoArtigos
            // 
            pnl_cabecalhoArtigos.BackColor = Color.FromArgb(255, 128, 0);
            pnl_cabecalhoArtigos.Controls.Add(lbl_CategoriaArtigos);
            pnl_cabecalhoArtigos.Controls.Add(cbx_CategoriaCardsArtigos);
            pnl_cabecalhoArtigos.Controls.Add(btn_BuscaCards);
            pnl_cabecalhoArtigos.Dock = DockStyle.Top;
            pnl_cabecalhoArtigos.Location = new Point(0, 0);
            pnl_cabecalhoArtigos.Name = "pnl_cabecalhoArtigos";
            pnl_cabecalhoArtigos.Size = new Size(823, 100);
            pnl_cabecalhoArtigos.TabIndex = 1;
            // 
            // lbl_CategoriaArtigos
            // 
            lbl_CategoriaArtigos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_CategoriaArtigos.AutoSize = true;
            lbl_CategoriaArtigos.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_CategoriaArtigos.Location = new Point(372, 37);
            lbl_CategoriaArtigos.Name = "lbl_CategoriaArtigos";
            lbl_CategoriaArtigos.Size = new Size(87, 21);
            lbl_CategoriaArtigos.TabIndex = 5;
            lbl_CategoriaArtigos.Text = "Categorias:";
            // 
            // cbx_CategoriaCardsArtigos
            // 
            cbx_CategoriaCardsArtigos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbx_CategoriaCardsArtigos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_CategoriaCardsArtigos.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbx_CategoriaCardsArtigos.FormattingEnabled = true;
            cbx_CategoriaCardsArtigos.Location = new Point(465, 34);
            cbx_CategoriaCardsArtigos.Name = "cbx_CategoriaCardsArtigos";
            cbx_CategoriaCardsArtigos.Size = new Size(177, 29);
            cbx_CategoriaCardsArtigos.TabIndex = 4;
            // 
            // btn_BuscaCards
            // 
            btn_BuscaCards.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_BuscaCards.BackColor = Color.PeachPuff;
            btn_BuscaCards.Cursor = Cursors.Hand;
            btn_BuscaCards.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn_BuscaCards.FlatStyle = FlatStyle.Flat;
            btn_BuscaCards.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            btn_BuscaCards.ForeColor = Color.FromArgb(20, 20, 20);
            btn_BuscaCards.Location = new Point(653, 27);
            btn_BuscaCards.Margin = new Padding(8);
            btn_BuscaCards.Name = "btn_BuscaCards";
            btn_BuscaCards.Size = new Size(154, 42);
            btn_BuscaCards.TabIndex = 3;
            btn_BuscaCards.Text = "Pesquisar";
            btn_BuscaCards.UseVisualStyleBackColor = false;
            btn_BuscaCards.Click += btn_BuscaCards_Click;
            // 
            // lbl_CategoriaCards
            // 
            lbl_CategoriaCards.AutoSize = true;
            lbl_CategoriaCards.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_CategoriaCards.Location = new Point(372, 37);
            lbl_CategoriaCards.Name = "lbl_CategoriaCards";
            lbl_CategoriaCards.Size = new Size(87, 21);
            lbl_CategoriaCards.TabIndex = 5;
            lbl_CategoriaCards.Text = "Categorias:";
            // 
            // btn_Busca
            // 
            btn_Busca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Busca.BackColor = Color.PeachPuff;
            btn_Busca.Cursor = Cursors.Hand;
            btn_Busca.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn_Busca.FlatStyle = FlatStyle.Flat;
            btn_Busca.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            btn_Busca.ForeColor = Color.FromArgb(20, 20, 20);
            btn_Busca.Location = new Point(1276, 27);
            btn_Busca.Margin = new Padding(8);
            btn_Busca.Name = "btn_Busca";
            btn_Busca.Size = new Size(154, 42);
            btn_Busca.TabIndex = 3;
            btn_Busca.Text = "Busca";
            btn_Busca.UseVisualStyleBackColor = false;
            // 
            // flp_listaDeArtigos
            // 
            flp_listaDeArtigos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flp_listaDeArtigos.AutoScroll = true;
            flp_listaDeArtigos.BorderStyle = BorderStyle.FixedSingle;
            flp_listaDeArtigos.Location = new Point(16, 119);
            flp_listaDeArtigos.Margin = new Padding(16);
            flp_listaDeArtigos.Name = "flp_listaDeArtigos";
            flp_listaDeArtigos.Size = new Size(791, 413);
            flp_listaDeArtigos.TabIndex = 3;
            // 
            // ControllsCardsArtigos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnl_cabecalho);
            Controls.Add(flp_listaDeArtigos);
            Name = "ControllsCardsArtigos";
            Size = new Size(823, 548);
            pnl_cabecalho.ResumeLayout(false);
            pnl_cabecalho.PerformLayout();
            panel1.ResumeLayout(false);
            pnl_cabecalhoArtigos.ResumeLayout(false);
            pnl_cabecalhoArtigos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_cabecalho;
        private Label lbl_CategoriaCards;
        private Button btn_Busca;
        private FlowLayoutPanel flp_listaDeArtigos;
        private Panel panel1;
        private Panel pnl_cabecalhoArtigos;
        private Label lbl_CategoriaArtigos;
        private ComboBox cbx_CategoriaCardsArtigos;
        private Button btn_BuscaCards;
    }
}
