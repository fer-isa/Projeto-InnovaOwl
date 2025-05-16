namespace Aula_15_04.Controles
{
    partial class cardCursos
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
            lbl_categoria = new Label();
            btn_card = new Button();
            img_card = new PictureBox();
            lbl_nomeCard = new Label();
            lbl_descricao = new Label();
            pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_card).BeginInit();
            SuspendLayout();
            // 
            // pnl_Header
            // 
            pnl_Header.BackColor = Color.FromArgb(47, 146, 187);
            pnl_Header.Controls.Add(lbl_categoria);
            pnl_Header.Dock = DockStyle.Top;
            pnl_Header.Location = new Point(0, 0);
            pnl_Header.Margin = new Padding(0);
            pnl_Header.Name = "pnl_Header";
            pnl_Header.Size = new Size(320, 32);
            pnl_Header.TabIndex = 0;
            // 
            // lbl_categoria
            // 
            lbl_categoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_categoria.AutoEllipsis = true;
            lbl_categoria.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_categoria.ForeColor = Color.White;
            lbl_categoria.Location = new Point(16, 4);
            lbl_categoria.Margin = new Padding(16, 4, 16, 4);
            lbl_categoria.Name = "lbl_categoria";
            lbl_categoria.Size = new Size(288, 24);
            lbl_categoria.TabIndex = 0;
            lbl_categoria.Text = "Categoria:";
            // 
            // btn_card
            // 
            btn_card.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_card.BackColor = Color.LightSkyBlue;
            btn_card.FlatAppearance.BorderSize = 0;
            btn_card.FlatStyle = FlatStyle.Flat;
            btn_card.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            btn_card.Location = new Point(8, 320);
            btn_card.Margin = new Padding(8);
            btn_card.Name = "btn_card";
            btn_card.Size = new Size(304, 32);
            btn_card.TabIndex = 1;
            btn_card.Text = "Acessar";
            btn_card.UseVisualStyleBackColor = false;
            btn_card.Click += btn_card_Click;
            // 
            // img_card
            // 
            img_card.BackColor = Color.White;
            img_card.Dock = DockStyle.Top;
            img_card.Location = new Point(0, 32);
            img_card.Margin = new Padding(0);
            img_card.Name = "img_card";
            img_card.Size = new Size(320, 165);
            img_card.SizeMode = PictureBoxSizeMode.Zoom;
            img_card.TabIndex = 2;
            img_card.TabStop = false;
            // 
            // lbl_nomeCard
            // 
            lbl_nomeCard.AutoEllipsis = true;
            lbl_nomeCard.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nomeCard.Location = new Point(8, 205);
            lbl_nomeCard.Margin = new Padding(8);
            lbl_nomeCard.Name = "lbl_nomeCard";
            lbl_nomeCard.Size = new Size(296, 21);
            lbl_nomeCard.TabIndex = 3;
            lbl_nomeCard.Text = "Nome:";
            // 
            // lbl_descricao
            // 
            lbl_descricao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_descricao.AutoEllipsis = true;
            lbl_descricao.Location = new Point(8, 234);
            lbl_descricao.Name = "lbl_descricao";
            lbl_descricao.Size = new Size(304, 78);
            lbl_descricao.TabIndex = 4;
            lbl_descricao.Text = "Desc:";
            // 
            // cardCursos
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lbl_descricao);
            Controls.Add(lbl_nomeCard);
            Controls.Add(img_card);
            Controls.Add(btn_card);
            Controls.Add(pnl_Header);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Margin = new Padding(4);
            Name = "cardCursos";
            Size = new Size(320, 360);
            pnl_Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)img_card).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnl_Header;
        private Button btn_card;
        private PictureBox img_card;
        private Label lbl_nomeCard;
        private Label lbl_descricao;
        private Label lbl_categoria;
    }
}
