namespace Aula_15_04.Controles
{
    partial class ControlesCardCursos
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
            btn_mostrarTudo = new Button();
            lbl_categoria = new Label();
            cbx_filtroDeCategoria = new ComboBox();
            btn_filtroPesquisar = new Button();
            flp_listaDeCursos = new FlowLayoutPanel();
            pnl_cabecalho.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_cabecalho
            // 
            pnl_cabecalho.BackColor = Color.FromArgb(255, 128, 0);
            pnl_cabecalho.Controls.Add(btn_mostrarTudo);
            pnl_cabecalho.Controls.Add(lbl_categoria);
            pnl_cabecalho.Controls.Add(cbx_filtroDeCategoria);
            pnl_cabecalho.Controls.Add(btn_filtroPesquisar);
            pnl_cabecalho.Dock = DockStyle.Top;
            pnl_cabecalho.Location = new Point(0, 0);
            pnl_cabecalho.Name = "pnl_cabecalho";
            pnl_cabecalho.Size = new Size(823, 100);
            pnl_cabecalho.TabIndex = 0;
            // 
            // btn_mostrarTudo
            // 
            btn_mostrarTudo.BackColor = Color.PeachPuff;
            btn_mostrarTudo.Cursor = Cursors.Hand;
            btn_mostrarTudo.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn_mostrarTudo.FlatStyle = FlatStyle.Flat;
            btn_mostrarTudo.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            btn_mostrarTudo.ForeColor = Color.FromArgb(20, 20, 20);
            btn_mostrarTudo.Location = new Point(16, 43);
            btn_mostrarTudo.Margin = new Padding(8);
            btn_mostrarTudo.Name = "btn_mostrarTudo";
            btn_mostrarTudo.Size = new Size(130, 27);
            btn_mostrarTudo.TabIndex = 7;
            btn_mostrarTudo.Text = "Mostrar Tudo";
            btn_mostrarTudo.UseVisualStyleBackColor = false;
            btn_mostrarTudo.Click += btn_mostrarTudo_Click;
            // 
            // lbl_categoria
            // 
            lbl_categoria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_categoria.AutoSize = true;
            lbl_categoria.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_categoria.Location = new Point(470, 51);
            lbl_categoria.Name = "lbl_categoria";
            lbl_categoria.Size = new Size(69, 19);
            lbl_categoria.TabIndex = 5;
            lbl_categoria.Text = "Categoria";
            // 
            // cbx_filtroDeCategoria
            // 
            cbx_filtroDeCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbx_filtroDeCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_filtroDeCategoria.FormattingEnabled = true;
            cbx_filtroDeCategoria.Location = new Point(545, 47);
            cbx_filtroDeCategoria.Name = "cbx_filtroDeCategoria";
            cbx_filtroDeCategoria.Size = new Size(121, 23);
            cbx_filtroDeCategoria.TabIndex = 4;
            // 
            // btn_filtroPesquisar
            // 
            btn_filtroPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_filtroPesquisar.BackColor = Color.PeachPuff;
            btn_filtroPesquisar.Cursor = Cursors.Hand;
            btn_filtroPesquisar.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn_filtroPesquisar.FlatStyle = FlatStyle.Flat;
            btn_filtroPesquisar.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            btn_filtroPesquisar.ForeColor = Color.FromArgb(20, 20, 20);
            btn_filtroPesquisar.Location = new Point(677, 43);
            btn_filtroPesquisar.Margin = new Padding(8);
            btn_filtroPesquisar.Name = "btn_filtroPesquisar";
            btn_filtroPesquisar.Size = new Size(130, 27);
            btn_filtroPesquisar.TabIndex = 3;
            btn_filtroPesquisar.Text = "Pesquisar";
            btn_filtroPesquisar.UseVisualStyleBackColor = false;
            btn_filtroPesquisar.Click += btn_filtroPesquisar_Click;
            // 
            // flp_listaDeCursos
            // 
            flp_listaDeCursos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flp_listaDeCursos.AutoScroll = true;
            flp_listaDeCursos.BorderStyle = BorderStyle.FixedSingle;
            flp_listaDeCursos.Location = new Point(16, 119);
            flp_listaDeCursos.Margin = new Padding(16);
            flp_listaDeCursos.Name = "flp_listaDeCursos";
            flp_listaDeCursos.Size = new Size(791, 413);
            flp_listaDeCursos.TabIndex = 1;
            // 
            // ControllsDeListagemDeCursosDeCards
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flp_listaDeCursos);
            Controls.Add(pnl_cabecalho);
            Name = "ControllsDeListagemDeCursosDeCards";
            Size = new Size(823, 548);
            pnl_cabecalho.ResumeLayout(false);
            pnl_cabecalho.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_cabecalho;
        private FlowLayoutPanel flp_listaDeCursos;
        private Button btn_filtroPesquisar;
        private Label lbl_categoria;
        private ComboBox cbx_filtroDeCategoria;
        private Button btn_mostrarTudo;
    }
}
