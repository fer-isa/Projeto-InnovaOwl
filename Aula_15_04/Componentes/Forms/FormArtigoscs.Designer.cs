namespace Aula_15_04.Forms
{
    partial class frm_artigos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_adicionarArtigos = new Label();
            lbl_subtitulo = new Label();
            lbl_categoria = new Label();
            lbl_nomeArtigos = new Label();
            txt_subtitulo = new TextBox();
            cbx_categoria = new ComboBox();
            btn_adicionar = new Button();
            txt_nomeArtigos = new TextBox();
            lbl_descricao = new Label();
            txt_descricao = new TextBox();
            dtp_dataPublicaçao = new DateTimePicker();
            label1 = new Label();
            txt_linkArtigo = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // lbl_adicionarArtigos
            // 
            lbl_adicionarArtigos.AutoSize = true;
            lbl_adicionarArtigos.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_adicionarArtigos.Location = new Point(18, 16);
            lbl_adicionarArtigos.Name = "lbl_adicionarArtigos";
            lbl_adicionarArtigos.Size = new Size(165, 28);
            lbl_adicionarArtigos.TabIndex = 0;
            lbl_adicionarArtigos.Text = "Adicionar Artigo:";
            // 
            // lbl_subtitulo
            // 
            lbl_subtitulo.AutoSize = true;
            lbl_subtitulo.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_subtitulo.Location = new Point(18, 125);
            lbl_subtitulo.Name = "lbl_subtitulo";
            lbl_subtitulo.Size = new Size(70, 19);
            lbl_subtitulo.TabIndex = 1;
            lbl_subtitulo.Text = "Subtitulo:";
            // 
            // lbl_categoria
            // 
            lbl_categoria.AutoSize = true;
            lbl_categoria.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_categoria.Location = new Point(18, 332);
            lbl_categoria.Name = "lbl_categoria";
            lbl_categoria.Size = new Size(72, 19);
            lbl_categoria.TabIndex = 2;
            lbl_categoria.Text = "Categoria:";
            // 
            // lbl_nomeArtigos
            // 
            lbl_nomeArtigos.AutoSize = true;
            lbl_nomeArtigos.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_nomeArtigos.Location = new Point(18, 50);
            lbl_nomeArtigos.Name = "lbl_nomeArtigos";
            lbl_nomeArtigos.Size = new Size(112, 19);
            lbl_nomeArtigos.TabIndex = 3;
            lbl_nomeArtigos.Text = "Título do Artigo:";
            // 
            // txt_subtitulo
            // 
            txt_subtitulo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_subtitulo.Location = new Point(18, 149);
            txt_subtitulo.Multiline = true;
            txt_subtitulo.Name = "txt_subtitulo";
            txt_subtitulo.Size = new Size(140, 23);
            txt_subtitulo.TabIndex = 4;
            // 
            // cbx_categoria
            // 
            cbx_categoria.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbx_categoria.FormattingEnabled = true;
            cbx_categoria.Location = new Point(18, 362);
            cbx_categoria.Name = "cbx_categoria";
            cbx_categoria.Size = new Size(140, 29);
            cbx_categoria.TabIndex = 5;
            // 
            // btn_adicionar
            // 
            btn_adicionar.BackColor = Color.DarkOrange;
            btn_adicionar.Dock = DockStyle.Bottom;
            btn_adicionar.FlatStyle = FlatStyle.Flat;
            btn_adicionar.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_adicionar.Location = new Point(0, 401);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(345, 40);
            btn_adicionar.TabIndex = 6;
            btn_adicionar.Text = "Adicionar";
            btn_adicionar.UseVisualStyleBackColor = false;
            // 
            // txt_nomeArtigos
            // 
            txt_nomeArtigos.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_nomeArtigos.Location = new Point(18, 78);
            txt_nomeArtigos.Name = "txt_nomeArtigos";
            txt_nomeArtigos.Size = new Size(140, 29);
            txt_nomeArtigos.TabIndex = 8;
            // 
            // lbl_descricao
            // 
            lbl_descricao.AutoSize = true;
            lbl_descricao.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_descricao.Location = new Point(18, 188);
            lbl_descricao.Name = "lbl_descricao";
            lbl_descricao.Size = new Size(73, 19);
            lbl_descricao.TabIndex = 10;
            lbl_descricao.Text = "Descrição:";
            // 
            // txt_descricao
            // 
            txt_descricao.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_descricao.Location = new Point(18, 206);
            txt_descricao.Multiline = true;
            txt_descricao.Name = "txt_descricao";
            txt_descricao.Size = new Size(212, 66);
            txt_descricao.TabIndex = 11;
            // 
            // dtp_dataPublicaçao
            // 
            dtp_dataPublicaçao.Location = new Point(20, 308);
            dtp_dataPublicaçao.Name = "dtp_dataPublicaçao";
            dtp_dataPublicaçao.Size = new Size(276, 23);
            dtp_dataPublicaçao.TabIndex = 12;
            dtp_dataPublicaçao.Value = new DateTime(2025, 5, 11, 22, 34, 48, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.Location = new Point(20, 284);
            label1.Name = "label1";
            label1.Size = new Size(132, 19);
            label1.TabIndex = 13;
            label1.Text = "Data de Publicação:";
            // 
            // txt_linkArtigo
            // 
            txt_linkArtigo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_linkArtigo.Location = new Point(193, 149);
            txt_linkArtigo.Multiline = true;
            txt_linkArtigo.Name = "txt_linkArtigo";
            txt_linkArtigo.Size = new Size(140, 23);
            txt_linkArtigo.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.Location = new Point(193, 125);
            label2.Name = "label2";
            label2.Size = new Size(39, 19);
            label2.TabIndex = 14;
            label2.Text = "Link:";
            // 
            // frm_artigos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(345, 441);
            Controls.Add(txt_linkArtigo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtp_dataPublicaçao);
            Controls.Add(txt_descricao);
            Controls.Add(lbl_descricao);
            Controls.Add(txt_nomeArtigos);
            Controls.Add(btn_adicionar);
            Controls.Add(cbx_categoria);
            Controls.Add(txt_subtitulo);
            Controls.Add(lbl_nomeArtigos);
            Controls.Add(lbl_categoria);
            Controls.Add(lbl_subtitulo);
            Controls.Add(lbl_adicionarArtigos);
            ForeColor = SystemColors.ControlText;
            Name = "frm_artigos";
            Text = "Adicionar Artigos:";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_adicionarArtigos;
        private Label lbl_subtitulo;
        private Label lbl_categoria;
        private Label lbl_nomeArtigos;
        private TextBox txt_subtitulo;
        private ComboBox cbx_categoria;
        private Button btn_adicionar;
        private TextBox txt_nomeArtigos;
        private Label lbl_descricao;
        private TextBox txt_descricao;
        private DateTimePicker dtp_dataPublicaçao;
        private Label label1;
        private TextBox txt_linkArtigo;
        private Label label2;
    }
}