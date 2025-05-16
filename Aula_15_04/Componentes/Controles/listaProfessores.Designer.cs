namespace Aula_15_04.Controles
{
    partial class listaProfessores
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
            btn_editarProfessor = new Button();
            btn_RemoverProfessor = new Button();
            btn_adicionarProfessor = new Button();
            dgv_ListaDeProfessores = new DataGridView();
            btn_pesquisar = new Button();
            txt_pesquisar = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_ListaDeProfessores).BeginInit();
            SuspendLayout();
            // 
            // btn_editarProfessor
            // 
            btn_editarProfessor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_editarProfessor.BackColor = Color.FromArgb(47, 146, 187);
            btn_editarProfessor.FlatStyle = FlatStyle.Flat;
            btn_editarProfessor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_editarProfessor.Location = new Point(689, 77);
            btn_editarProfessor.Name = "btn_editarProfessor";
            btn_editarProfessor.Size = new Size(124, 27);
            btn_editarProfessor.TabIndex = 20;
            btn_editarProfessor.Text = "Editar Professor";
            btn_editarProfessor.UseVisualStyleBackColor = false;
            btn_editarProfessor.Click += btn_editarProfessor_Click;
            // 
            // btn_RemoverProfessor
            // 
            btn_RemoverProfessor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_RemoverProfessor.BackColor = Color.FromArgb(47, 146, 187);
            btn_RemoverProfessor.FlatStyle = FlatStyle.Flat;
            btn_RemoverProfessor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_RemoverProfessor.Location = new Point(559, 77);
            btn_RemoverProfessor.Name = "btn_RemoverProfessor";
            btn_RemoverProfessor.Size = new Size(124, 27);
            btn_RemoverProfessor.TabIndex = 19;
            btn_RemoverProfessor.Text = "Remover Professor";
            btn_RemoverProfessor.UseVisualStyleBackColor = false;
            btn_RemoverProfessor.Click += btn_RemoverProfessor_Click;
            // 
            // btn_adicionarProfessor
            // 
            btn_adicionarProfessor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_adicionarProfessor.BackColor = Color.FromArgb(47, 146, 187);
            btn_adicionarProfessor.FlatStyle = FlatStyle.Flat;
            btn_adicionarProfessor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_adicionarProfessor.Location = new Point(429, 77);
            btn_adicionarProfessor.Name = "btn_adicionarProfessor";
            btn_adicionarProfessor.Size = new Size(124, 27);
            btn_adicionarProfessor.TabIndex = 18;
            btn_adicionarProfessor.Text = "Adicionar Professor";
            btn_adicionarProfessor.UseVisualStyleBackColor = false;
            btn_adicionarProfessor.Click += btn_AdicionarCurso_Click;
            // 
            // dgv_ListaDeProfessores
            // 
            dgv_ListaDeProfessores.AllowUserToAddRows = false;
            dgv_ListaDeProfessores.AllowUserToDeleteRows = false;
            dgv_ListaDeProfessores.AllowUserToOrderColumns = true;
            dgv_ListaDeProfessores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_ListaDeProfessores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ListaDeProfessores.BackgroundColor = Color.White;
            dgv_ListaDeProfessores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ListaDeProfessores.Location = new Point(29, 111);
            dgv_ListaDeProfessores.Margin = new Padding(32);
            dgv_ListaDeProfessores.Name = "dgv_ListaDeProfessores";
            dgv_ListaDeProfessores.ReadOnly = true;
            dgv_ListaDeProfessores.Size = new Size(784, 395);
            dgv_ListaDeProfessores.TabIndex = 17;
            dgv_ListaDeProfessores.CellContentClick += dgv_Lista_CellContentClick;
            // 
            // btn_pesquisar
            // 
            btn_pesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_pesquisar.BackColor = Color.FromArgb(47, 146, 187);
            btn_pesquisar.BackgroundImageLayout = ImageLayout.None;
            btn_pesquisar.FlatStyle = FlatStyle.Flat;
            btn_pesquisar.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_pesquisar.Location = new Point(689, 35);
            btn_pesquisar.Name = "btn_pesquisar";
            btn_pesquisar.Size = new Size(124, 27);
            btn_pesquisar.TabIndex = 16;
            btn_pesquisar.Text = "pesquisar";
            btn_pesquisar.UseVisualStyleBackColor = false;
            btn_pesquisar.Click += btn_pesquisar_Click;
            // 
            // txt_pesquisar
            // 
            txt_pesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_pesquisar.Location = new Point(368, 35);
            txt_pesquisar.Name = "txt_pesquisar";
            txt_pesquisar.PlaceholderText = "Pesquisar Artigos...";
            txt_pesquisar.Size = new Size(315, 23);
            txt_pesquisar.TabIndex = 15;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 28F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.Location = new Point(44, 27);
            label1.Name = "label1";
            label1.Size = new Size(276, 38);
            label1.TabIndex = 14;
            label1.Text = "Lista de Professores:";
            // 
            // listaProfessores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            Controls.Add(btn_editarProfessor);
            Controls.Add(btn_RemoverProfessor);
            Controls.Add(btn_adicionarProfessor);
            Controls.Add(dgv_ListaDeProfessores);
            Controls.Add(btn_pesquisar);
            Controls.Add(txt_pesquisar);
            Controls.Add(label1);
            Name = "listaProfessores";
            Size = new Size(848, 527);
            ((System.ComponentModel.ISupportInitialize)dgv_ListaDeProfessores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_editarProfessor;
        private Button btn_RemoverProfessor;
        private Button btn_adicionarProfessor;
        private DataGridView dgv_ListaDeProfessores;
        private Button btn_pesquisar;
        private TextBox txt_pesquisar;
        private Label label1;
    }
}
