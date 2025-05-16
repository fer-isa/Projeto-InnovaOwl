namespace Aula_15_04.Controles
{
    partial class cardArtigos
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
            pnl_Header = new FlowLayoutPanel();
            lbl_categoriaArtigos = new Label();
            img_cardArtigos = new PictureBox();
            lbl_descricaoArtigos = new Label();
            lbl_nomeCardArtigos = new Label();
            btn_cardArtigos = new Button();
            lbl_dataPublicacaoArtigos = new Label();
            lbl_subtitulo = new Label();
            pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_cardArtigos).BeginInit();
            SuspendLayout();
            // 
            // pnl_Header
            // 
            pnl_Header.BackColor = Color.FromArgb(47, 146, 187);
            pnl_Header.Controls.Add(lbl_categoriaArtigos);
            pnl_Header.Dock = DockStyle.Top;
            pnl_Header.Location = new Point(0, 0);
            pnl_Header.Margin = new Padding(0);
            pnl_Header.Name = "pnl_Header";
            pnl_Header.Size = new Size(348, 36);
            pnl_Header.TabIndex = 1;
            // 
            // lbl_categoriaArtigos
            // 
            lbl_categoriaArtigos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_categoriaArtigos.AutoEllipsis = true;
            lbl_categoriaArtigos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_categoriaArtigos.ForeColor = Color.White;
            lbl_categoriaArtigos.Location = new Point(14, 3);
            lbl_categoriaArtigos.Margin = new Padding(14, 3, 14, 3);
            lbl_categoriaArtigos.Name = "lbl_categoriaArtigos";
            lbl_categoriaArtigos.Size = new Size(253, 30);
            lbl_categoriaArtigos.TabIndex = 0;
            lbl_categoriaArtigos.Text = "Categoria:";
            // 
            // img_cardArtigos
            // 
            img_cardArtigos.BackColor = Color.FromArgb(47, 128, 164);
            img_cardArtigos.Dock = DockStyle.Top;
            img_cardArtigos.Image = Properties.Resources.file_chart_column_increasing__1_;
            img_cardArtigos.Location = new Point(0, 36);
            img_cardArtigos.Margin = new Padding(0);
            img_cardArtigos.Name = "img_cardArtigos";
            img_cardArtigos.Size = new Size(348, 139);
            img_cardArtigos.SizeMode = PictureBoxSizeMode.CenterImage;
            img_cardArtigos.TabIndex = 3;
            img_cardArtigos.TabStop = false;
            // 
            // lbl_descricaoArtigos
            // 
            lbl_descricaoArtigos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_descricaoArtigos.AutoEllipsis = true;
            lbl_descricaoArtigos.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_descricaoArtigos.Location = new Point(7, 257);
            lbl_descricaoArtigos.Name = "lbl_descricaoArtigos";
            lbl_descricaoArtigos.Size = new Size(334, 106);
            lbl_descricaoArtigos.TabIndex = 6;
            lbl_descricaoArtigos.Text = "Desc:";
            // 
            // lbl_nomeCardArtigos
            // 
            lbl_nomeCardArtigos.AutoEllipsis = true;
            lbl_nomeCardArtigos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nomeCardArtigos.Location = new Point(7, 181);
            lbl_nomeCardArtigos.Margin = new Padding(7, 6, 7, 6);
            lbl_nomeCardArtigos.Name = "lbl_nomeCardArtigos";
            lbl_nomeCardArtigos.Size = new Size(266, 20);
            lbl_nomeCardArtigos.TabIndex = 5;
            lbl_nomeCardArtigos.Text = "Nome:";
            // 
            // btn_cardArtigos
            // 
            btn_cardArtigos.BackColor = Color.LightSkyBlue;
            btn_cardArtigos.Dock = DockStyle.Bottom;
            btn_cardArtigos.FlatAppearance.BorderSize = 0;
            btn_cardArtigos.FlatStyle = FlatStyle.Flat;
            btn_cardArtigos.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            btn_cardArtigos.Location = new Point(0, 379);
            btn_cardArtigos.Margin = new Padding(7, 6, 7, 6);
            btn_cardArtigos.Name = "btn_cardArtigos";
            btn_cardArtigos.Size = new Size(348, 38);
            btn_cardArtigos.TabIndex = 7;
            btn_cardArtigos.Text = "Acessar";
            btn_cardArtigos.UseVisualStyleBackColor = false;
            btn_cardArtigos.Click += btn_cardArtigos_Click;
            // 
            // lbl_dataPublicacaoArtigos
            // 
            lbl_dataPublicacaoArtigos.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_dataPublicacaoArtigos.Location = new Point(7, 231);
            lbl_dataPublicacaoArtigos.Name = "lbl_dataPublicacaoArtigos";
            lbl_dataPublicacaoArtigos.Size = new Size(309, 26);
            lbl_dataPublicacaoArtigos.TabIndex = 8;
            lbl_dataPublicacaoArtigos.Text = "Data de Publicação:";
            // 
            // lbl_subtitulo
            // 
            lbl_subtitulo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_subtitulo.Location = new Point(7, 205);
            lbl_subtitulo.Name = "lbl_subtitulo";
            lbl_subtitulo.Size = new Size(309, 26);
            lbl_subtitulo.TabIndex = 9;
            lbl_subtitulo.Text = "Subtitulo:";
            // 
            // cardArtigos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lbl_subtitulo);
            Controls.Add(lbl_dataPublicacaoArtigos);
            Controls.Add(btn_cardArtigos);
            Controls.Add(lbl_descricaoArtigos);
            Controls.Add(lbl_nomeCardArtigos);
            Controls.Add(img_cardArtigos);
            Controls.Add(pnl_Header);
            Margin = new Padding(3, 2, 3, 2);
            Name = "cardArtigos";
            Size = new Size(348, 417);
            pnl_Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)img_cardArtigos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnl_Header;
        private Label lbl_categoriaArtigos;
        private PictureBox img_cardArtigos;
        private Label lbl_descricaoArtigos;
        private Label lbl_nomeCardArtigos;
        private Button btn_cardArtigos;
        private Label lbl_dataPublicacaoArtigos;
        private Label lbl_subtitulo;
    }
}
