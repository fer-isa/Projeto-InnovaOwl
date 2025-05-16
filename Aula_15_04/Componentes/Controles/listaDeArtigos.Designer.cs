namespace Aula_15_04.Controles
{
    partial class listaDeArtigos
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
            label1 = new Label();
            txt_pesquisar = new TextBox();
            btn_pesquisar = new Button();
            dgv_ListaArtigos = new DataGridView();
            btn_EditarCurso = new Button();
            btn_RemoverCurso = new Button();
            btn_AdicionarArtigos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_ListaArtigos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 28F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.Location = new Point(49, 16);
            label1.Name = "label1";
            label1.Size = new Size(223, 38);
            label1.TabIndex = 0;
            label1.Text = "Lista de Artigos:";
            // 
            // txt_pesquisar
            // 
            txt_pesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_pesquisar.Location = new Point(375, 31);
            txt_pesquisar.Name = "txt_pesquisar";
            txt_pesquisar.PlaceholderText = "Pesquisar Artigos...";
            txt_pesquisar.Size = new Size(315, 23);
            txt_pesquisar.TabIndex = 1;
            // 
            // btn_pesquisar
            // 
            btn_pesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_pesquisar.BackColor = Color.FromArgb(47, 146, 187);
            btn_pesquisar.BackgroundImageLayout = ImageLayout.None;
            btn_pesquisar.FlatStyle = FlatStyle.Flat;
            btn_pesquisar.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_pesquisar.Location = new Point(696, 31);
            btn_pesquisar.Name = "btn_pesquisar";
            btn_pesquisar.Size = new Size(124, 27);
            btn_pesquisar.TabIndex = 2;
            btn_pesquisar.Text = "pesquisar";
            btn_pesquisar.UseVisualStyleBackColor = false;
            btn_pesquisar.Click += btn_pesquisar_Click;
            // 
            // dgv_ListaArtigos
            // 
            dgv_ListaArtigos.AllowUserToAddRows = false;
            dgv_ListaArtigos.AllowUserToDeleteRows = false;
            dgv_ListaArtigos.AllowUserToOrderColumns = true;
            dgv_ListaArtigos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_ListaArtigos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ListaArtigos.BackgroundColor = Color.White;
            dgv_ListaArtigos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ListaArtigos.Location = new Point(32, 100);
            dgv_ListaArtigos.Margin = new Padding(32);
            dgv_ListaArtigos.Name = "dgv_ListaArtigos";
            dgv_ListaArtigos.ReadOnly = true;
            dgv_ListaArtigos.Size = new Size(784, 393);
            dgv_ListaArtigos.TabIndex = 3;
            // 
            // btn_EditarCurso
            // 
            btn_EditarCurso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_EditarCurso.BackColor = Color.FromArgb(47, 146, 187);
            btn_EditarCurso.FlatStyle = FlatStyle.Flat;
            btn_EditarCurso.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_EditarCurso.Location = new Point(696, 64);
            btn_EditarCurso.Name = "btn_EditarCurso";
            btn_EditarCurso.Size = new Size(124, 27);
            btn_EditarCurso.TabIndex = 13;
            btn_EditarCurso.Text = "Editar Artigo";
            btn_EditarCurso.UseVisualStyleBackColor = false;
            btn_EditarCurso.Click += btn_EditarCurso_Click;
            // 
            // btn_RemoverCurso
            // 
            btn_RemoverCurso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_RemoverCurso.BackColor = Color.FromArgb(47, 146, 187);
            btn_RemoverCurso.FlatStyle = FlatStyle.Flat;
            btn_RemoverCurso.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_RemoverCurso.Location = new Point(566, 64);
            btn_RemoverCurso.Name = "btn_RemoverCurso";
            btn_RemoverCurso.Size = new Size(124, 27);
            btn_RemoverCurso.TabIndex = 12;
            btn_RemoverCurso.Text = "Remover Artigo";
            btn_RemoverCurso.UseVisualStyleBackColor = false;
            btn_RemoverCurso.Click += btn_RemoverCurso_Click;
            // 
            // btn_AdicionarArtigos
            // 
            btn_AdicionarArtigos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_AdicionarArtigos.BackColor = Color.FromArgb(47, 146, 187);
            btn_AdicionarArtigos.FlatStyle = FlatStyle.Flat;
            btn_AdicionarArtigos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AdicionarArtigos.Location = new Point(436, 64);
            btn_AdicionarArtigos.Name = "btn_AdicionarArtigos";
            btn_AdicionarArtigos.Size = new Size(124, 27);
            btn_AdicionarArtigos.TabIndex = 11;
            btn_AdicionarArtigos.Text = "Adicionar Artigo";
            btn_AdicionarArtigos.UseVisualStyleBackColor = false;
            btn_AdicionarArtigos.Click += btn_AdicionarArtigos_Click;
            // 
            // listaDeArtigos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            Controls.Add(btn_EditarCurso);
            Controls.Add(btn_RemoverCurso);
            Controls.Add(btn_AdicionarArtigos);
            Controls.Add(dgv_ListaArtigos);
            Controls.Add(btn_pesquisar);
            Controls.Add(txt_pesquisar);
            Controls.Add(label1);
            Name = "listaDeArtigos";
            Size = new Size(848, 525);
            ((System.ComponentModel.ISupportInitialize)dgv_ListaArtigos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_pesquisar;
        private Button btn_pesquisar;
        private DataGridView dgv_ListaArtigos;
        private Button btn_EditarCurso;
        private Button btn_RemoverCurso;
        private Button btn_AdicionarArtigos;
    }
}
