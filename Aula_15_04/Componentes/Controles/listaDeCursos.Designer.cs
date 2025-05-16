namespace Aula_15_04.Controles
{
    partial class listaDeCursos
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
            dgv_Lista = new DataGridView();
            btn_pesquisar = new Button();
            txt_pesquisar = new TextBox();
            label1 = new Label();
            btn_AdicionarCurso = new Button();
            btn_RemoverCurso = new Button();
            btn_EditarCurso = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Lista).BeginInit();
            SuspendLayout();
            // 
            // dgv_Lista
            // 
            dgv_Lista.AllowUserToAddRows = false;
            dgv_Lista.AllowUserToDeleteRows = false;
            dgv_Lista.AllowUserToOrderColumns = true;
            dgv_Lista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Lista.BackgroundColor = Color.White;
            dgv_Lista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Lista.Location = new Point(32, 100);
            dgv_Lista.Margin = new Padding(32);
            dgv_Lista.Name = "dgv_Lista";
            dgv_Lista.ReadOnly = true;
            dgv_Lista.Size = new Size(784, 393);
            dgv_Lista.TabIndex = 7;
            dgv_Lista.CellContentClick += dgv_Lista_CellContentClick;
            // 
            // btn_pesquisar
            // 
            btn_pesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_pesquisar.BackColor = Color.FromArgb(47, 146, 187);
            btn_pesquisar.BackgroundImageLayout = ImageLayout.None;
            btn_pesquisar.FlatStyle = FlatStyle.Flat;
            btn_pesquisar.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_pesquisar.Location = new Point(692, 25);
            btn_pesquisar.Name = "btn_pesquisar";
            btn_pesquisar.Size = new Size(124, 27);
            btn_pesquisar.TabIndex = 6;
            btn_pesquisar.Text = "pesquisar";
            btn_pesquisar.UseVisualStyleBackColor = false;
            btn_pesquisar.Click += btn_pesquisar_Click;
            // 
            // txt_pesquisar
            // 
            txt_pesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_pesquisar.Location = new Point(375, 28);
            txt_pesquisar.Name = "txt_pesquisar";
            txt_pesquisar.PlaceholderText = "Pesquisar Cursos...";
            txt_pesquisar.Size = new Size(315, 23);
            txt_pesquisar.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 28F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.Location = new Point(32, 13);
            label1.Name = "label1";
            label1.Size = new Size(214, 38);
            label1.TabIndex = 4;
            label1.Text = "Lista de Cursos:";
            // 
            // btn_AdicionarCurso
            // 
            btn_AdicionarCurso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_AdicionarCurso.BackColor = Color.FromArgb(47, 146, 187);
            btn_AdicionarCurso.FlatStyle = FlatStyle.Flat;
            btn_AdicionarCurso.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AdicionarCurso.Location = new Point(432, 64);
            btn_AdicionarCurso.Name = "btn_AdicionarCurso";
            btn_AdicionarCurso.Size = new Size(124, 27);
            btn_AdicionarCurso.TabIndex = 8;
            btn_AdicionarCurso.Text = "Adicionar Curso";
            btn_AdicionarCurso.UseVisualStyleBackColor = false;
            btn_AdicionarCurso.Click += btn_AdicionarCurso_Click;
            // 
            // btn_RemoverCurso
            // 
            btn_RemoverCurso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_RemoverCurso.BackColor = Color.FromArgb(47, 146, 187);
            btn_RemoverCurso.FlatStyle = FlatStyle.Flat;
            btn_RemoverCurso.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_RemoverCurso.Location = new Point(562, 64);
            btn_RemoverCurso.Name = "btn_RemoverCurso";
            btn_RemoverCurso.Size = new Size(124, 27);
            btn_RemoverCurso.TabIndex = 9;
            btn_RemoverCurso.Text = "Remover Curso";
            btn_RemoverCurso.UseVisualStyleBackColor = false;
            btn_RemoverCurso.Click += btn_RemoverCurso_Click;
            // 
            // btn_EditarCurso
            // 
            btn_EditarCurso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_EditarCurso.BackColor = Color.FromArgb(47, 146, 187);
            btn_EditarCurso.FlatStyle = FlatStyle.Flat;
            btn_EditarCurso.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_EditarCurso.Location = new Point(692, 64);
            btn_EditarCurso.Name = "btn_EditarCurso";
            btn_EditarCurso.Size = new Size(124, 27);
            btn_EditarCurso.TabIndex = 10;
            btn_EditarCurso.Text = "Editar Curso";
            btn_EditarCurso.UseVisualStyleBackColor = false;
            btn_EditarCurso.Click += btn_EditarCurso_Click;
            // 
            // listaDeCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            Controls.Add(btn_EditarCurso);
            Controls.Add(btn_RemoverCurso);
            Controls.Add(btn_AdicionarCurso);
            Controls.Add(dgv_Lista);
            Controls.Add(btn_pesquisar);
            Controls.Add(txt_pesquisar);
            Controls.Add(label1);
            Name = "listaDeCursos";
            Size = new Size(848, 525);
            Load += listaDeCursos_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Lista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Lista;
        private Button btn_pesquisar;
        private TextBox txt_pesquisar;
        private Label label1;
        private Button btn_AdicionarCurso;
        private Button btn_RemoverCurso;
        private Button btn_EditarCurso;
    }
}
