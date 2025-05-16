namespace Aula_15_04.Forms
{
    partial class frm_cursos
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
            btn_adicionar = new Button();
            lbl_adicionarCursos = new Label();
            lbl_nomeCursos = new Label();
            lbl_descricao = new Label();
            lbl_cargaHoraria = new Label();
            lbl_link = new Label();
            nud_cargaHoraria = new NumericUpDown();
            txt_descricao = new TextBox();
            txt_nomeCursos = new TextBox();
            txt_link = new TextBox();
            lbl_professor = new Label();
            label2 = new Label();
            cbx_professor = new ComboBox();
            cbx_categoria = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nud_cargaHoraria).BeginInit();
            SuspendLayout();
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
            btn_adicionar.TabIndex = 0;
            btn_adicionar.Text = "Adicionar";
            btn_adicionar.UseVisualStyleBackColor = false;
            // 
            // lbl_adicionarCursos
            // 
            lbl_adicionarCursos.AutoSize = true;
            lbl_adicionarCursos.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_adicionarCursos.Location = new Point(12, 9);
            lbl_adicionarCursos.Name = "lbl_adicionarCursos";
            lbl_adicionarCursos.Size = new Size(160, 28);
            lbl_adicionarCursos.TabIndex = 2;
            lbl_adicionarCursos.Text = "Adicionar Curso:";
            // 
            // lbl_nomeCursos
            // 
            lbl_nomeCursos.AutoSize = true;
            lbl_nomeCursos.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_nomeCursos.Location = new Point(12, 45);
            lbl_nomeCursos.Name = "lbl_nomeCursos";
            lbl_nomeCursos.Size = new Size(110, 19);
            lbl_nomeCursos.TabIndex = 3;
            lbl_nomeCursos.Text = "Nome do Curso:";
            // 
            // lbl_descricao
            // 
            lbl_descricao.AutoSize = true;
            lbl_descricao.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_descricao.Location = new Point(12, 105);
            lbl_descricao.Name = "lbl_descricao";
            lbl_descricao.Size = new Size(73, 19);
            lbl_descricao.TabIndex = 4;
            lbl_descricao.Text = "Descrição:";
            // 
            // lbl_cargaHoraria
            // 
            lbl_cargaHoraria.AutoSize = true;
            lbl_cargaHoraria.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_cargaHoraria.Location = new Point(12, 184);
            lbl_cargaHoraria.Name = "lbl_cargaHoraria";
            lbl_cargaHoraria.Size = new Size(98, 19);
            lbl_cargaHoraria.TabIndex = 5;
            lbl_cargaHoraria.Text = "Carga Horaria:";
            // 
            // lbl_link
            // 
            lbl_link.AutoSize = true;
            lbl_link.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_link.Location = new Point(12, 235);
            lbl_link.Name = "lbl_link";
            lbl_link.Size = new Size(39, 19);
            lbl_link.TabIndex = 6;
            lbl_link.Text = "Link:";
            // 
            // nud_cargaHoraria
            // 
            nud_cargaHoraria.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            nud_cargaHoraria.Location = new Point(12, 206);
            nud_cargaHoraria.Name = "nud_cargaHoraria";
            nud_cargaHoraria.Size = new Size(140, 26);
            nud_cargaHoraria.TabIndex = 7;
            nud_cargaHoraria.ValueChanged += nud_cargaHoraria_ValueChanged;
            // 
            // txt_descricao
            // 
            txt_descricao.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_descricao.Location = new Point(12, 127);
            txt_descricao.Multiline = true;
            txt_descricao.Name = "txt_descricao";
            txt_descricao.Size = new Size(140, 54);
            txt_descricao.TabIndex = 11;
            // 
            // txt_nomeCursos
            // 
            txt_nomeCursos.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_nomeCursos.Location = new Point(12, 67);
            txt_nomeCursos.Name = "txt_nomeCursos";
            txt_nomeCursos.Size = new Size(140, 26);
            txt_nomeCursos.TabIndex = 12;
            // 
            // txt_link
            // 
            txt_link.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_link.Location = new Point(12, 257);
            txt_link.Name = "txt_link";
            txt_link.Size = new Size(140, 26);
            txt_link.TabIndex = 13;
            // 
            // lbl_professor
            // 
            lbl_professor.AutoSize = true;
            lbl_professor.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_professor.Location = new Point(12, 286);
            lbl_professor.Name = "lbl_professor";
            lbl_professor.Size = new Size(71, 19);
            lbl_professor.TabIndex = 14;
            lbl_professor.Text = "Professor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.Location = new Point(12, 334);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 15;
            label2.Text = "Categoria:";
            // 
            // cbx_professor
            // 
            cbx_professor.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbx_professor.FormattingEnabled = true;
            cbx_professor.Location = new Point(12, 308);
            cbx_professor.Name = "cbx_professor";
            cbx_professor.Size = new Size(140, 27);
            cbx_professor.TabIndex = 16;
            // 
            // cbx_categoria
            // 
            cbx_categoria.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbx_categoria.FormattingEnabled = true;
            cbx_categoria.Location = new Point(12, 356);
            cbx_categoria.Name = "cbx_categoria";
            cbx_categoria.Size = new Size(140, 27);
            cbx_categoria.TabIndex = 17;
            // 
            // frm_cursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(345, 441);
            Controls.Add(cbx_categoria);
            Controls.Add(cbx_professor);
            Controls.Add(label2);
            Controls.Add(lbl_professor);
            Controls.Add(txt_link);
            Controls.Add(txt_nomeCursos);
            Controls.Add(txt_descricao);
            Controls.Add(nud_cargaHoraria);
            Controls.Add(lbl_link);
            Controls.Add(lbl_cargaHoraria);
            Controls.Add(lbl_descricao);
            Controls.Add(lbl_nomeCursos);
            Controls.Add(lbl_adicionarCursos);
            Controls.Add(btn_adicionar);
            Name = "frm_cursos";
            Text = "Adicionar Cursos";
            ((System.ComponentModel.ISupportInitialize)nud_cargaHoraria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_adicionar;
        private Label lbl_adicionarCursos;
        private Label lbl_nomeCursos;
        private Label lbl_descricao;
        private Label lbl_cargaHoraria;
        private Label lbl_link;
        private NumericUpDown nud_cargaHoraria;
        private TextBox txt_descricao;
        private TextBox txt_nomeCursos;
        private TextBox txt_link;
        private Label lbl_professor;
        private Label label2;
        private ComboBox cbx_professor;
        private ComboBox cbx_categoria;
    }
}