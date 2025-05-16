namespace Aula_15_04
{
    partial class Form_principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnl_Menu = new Panel();
            label1 = new Label();
            btn_cardArtigos = new Button();
            btn_Professores = new Button();
            btn_cardsCursos = new Button();
            btn_Artigos = new Button();
            btn_Cursos = new Button();
            pictureBox1 = new PictureBox();
            btn_Inicio = new Button();
            pnl_Conteudo = new Panel();
            pnl_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnl_Menu
            // 
            pnl_Menu.BackColor = Color.FromArgb(255, 112, 43);
            pnl_Menu.Controls.Add(label1);
            pnl_Menu.Controls.Add(btn_cardArtigos);
            pnl_Menu.Controls.Add(btn_Professores);
            pnl_Menu.Controls.Add(btn_cardsCursos);
            pnl_Menu.Controls.Add(btn_Artigos);
            pnl_Menu.Controls.Add(btn_Cursos);
            pnl_Menu.Controls.Add(pictureBox1);
            pnl_Menu.Controls.Add(btn_Inicio);
            pnl_Menu.Dock = DockStyle.Left;
            pnl_Menu.Location = new Point(0, 0);
            pnl_Menu.Margin = new Padding(0);
            pnl_Menu.Name = "pnl_Menu";
            pnl_Menu.Size = new Size(267, 908);
            pnl_Menu.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.Location = new Point(23, 634);
            label1.Margin = new Padding(3, 21, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 28);
            label1.TabIndex = 9;
            label1.Text = "Área Administrativa:";
            // 
            // btn_cardArtigos
            // 
            btn_cardArtigos.BackColor = Color.PeachPuff;
            btn_cardArtigos.Cursor = Cursors.Hand;
            btn_cardArtigos.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn_cardArtigos.FlatStyle = FlatStyle.Flat;
            btn_cardArtigos.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            btn_cardArtigos.ForeColor = Color.FromArgb(20, 20, 20);
            btn_cardArtigos.Location = new Point(9, 507);
            btn_cardArtigos.Margin = new Padding(9, 11, 9, 11);
            btn_cardArtigos.Name = "btn_cardArtigos";
            btn_cardArtigos.Size = new Size(246, 56);
            btn_cardArtigos.TabIndex = 8;
            btn_cardArtigos.Text = " Artigos";
            btn_cardArtigos.UseVisualStyleBackColor = false;
            btn_cardArtigos.Click += btn_cardArtigos_Click;
            // 
            // btn_Professores
            // 
            btn_Professores.BackColor = Color.PeachPuff;
            btn_Professores.Cursor = Cursors.Hand;
            btn_Professores.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn_Professores.FlatStyle = FlatStyle.Flat;
            btn_Professores.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            btn_Professores.ForeColor = Color.FromArgb(20, 20, 20);
            btn_Professores.Location = new Point(9, 841);
            btn_Professores.Margin = new Padding(9, 11, 9, 11);
            btn_Professores.Name = "btn_Professores";
            btn_Professores.Size = new Size(246, 56);
            btn_Professores.TabIndex = 7;
            btn_Professores.Text = "Lista Professores";
            btn_Professores.UseVisualStyleBackColor = false;
            btn_Professores.Click += btn_Professores_Click;
            // 
            // btn_cardsCursos
            // 
            btn_cardsCursos.BackColor = Color.PeachPuff;
            btn_cardsCursos.Cursor = Cursors.Hand;
            btn_cardsCursos.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn_cardsCursos.FlatStyle = FlatStyle.Flat;
            btn_cardsCursos.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            btn_cardsCursos.ForeColor = Color.FromArgb(20, 20, 20);
            btn_cardsCursos.Location = new Point(9, 430);
            btn_cardsCursos.Margin = new Padding(9, 11, 9, 11);
            btn_cardsCursos.Name = "btn_cardsCursos";
            btn_cardsCursos.Size = new Size(246, 56);
            btn_cardsCursos.TabIndex = 6;
            btn_cardsCursos.Text = "Cursos";
            btn_cardsCursos.UseVisualStyleBackColor = false;
            btn_cardsCursos.Click += btn_cardsCursos_Click;
            // 
            // btn_Artigos
            // 
            btn_Artigos.BackColor = Color.PeachPuff;
            btn_Artigos.Cursor = Cursors.Hand;
            btn_Artigos.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn_Artigos.FlatStyle = FlatStyle.Flat;
            btn_Artigos.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            btn_Artigos.ForeColor = Color.FromArgb(20, 20, 20);
            btn_Artigos.Location = new Point(9, 763);
            btn_Artigos.Margin = new Padding(9, 11, 9, 11);
            btn_Artigos.Name = "btn_Artigos";
            btn_Artigos.Size = new Size(246, 56);
            btn_Artigos.TabIndex = 5;
            btn_Artigos.Text = "Lista de Artigos";
            btn_Artigos.UseVisualStyleBackColor = false;
            btn_Artigos.Click += btn_Artigos_Click_1;
            // 
            // btn_Cursos
            // 
            btn_Cursos.BackColor = Color.PeachPuff;
            btn_Cursos.Cursor = Cursors.Hand;
            btn_Cursos.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn_Cursos.FlatStyle = FlatStyle.Flat;
            btn_Cursos.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            btn_Cursos.ForeColor = Color.FromArgb(20, 20, 20);
            btn_Cursos.Location = new Point(9, 686);
            btn_Cursos.Margin = new Padding(9, 11, 9, 11);
            btn_Cursos.Name = "btn_Cursos";
            btn_Cursos.Size = new Size(246, 56);
            btn_Cursos.TabIndex = 0;
            btn_Cursos.Text = "Lista de Cursos";
            btn_Cursos.UseVisualStyleBackColor = false;
            btn_Cursos.Click += btn_Cursos_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.Logo_New;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(267, 288);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btn_Inicio
            // 
            btn_Inicio.BackColor = Color.PeachPuff;
            btn_Inicio.Cursor = Cursors.Hand;
            btn_Inicio.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn_Inicio.FlatStyle = FlatStyle.Flat;
            btn_Inicio.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            btn_Inicio.ForeColor = Color.FromArgb(20, 20, 20);
            btn_Inicio.Location = new Point(9, 352);
            btn_Inicio.Margin = new Padding(9, 11, 9, 11);
            btn_Inicio.Name = "btn_Inicio";
            btn_Inicio.Size = new Size(246, 56);
            btn_Inicio.TabIndex = 0;
            btn_Inicio.Text = "Inicio";
            btn_Inicio.UseVisualStyleBackColor = false;
            btn_Inicio.Click += btn_Inicio_Click;
            // 
            // pnl_Conteudo
            // 
            pnl_Conteudo.BackColor = Color.PeachPuff;
            pnl_Conteudo.Dock = DockStyle.Fill;
            pnl_Conteudo.Location = new Point(267, 0);
            pnl_Conteudo.Margin = new Padding(3, 4, 3, 4);
            pnl_Conteudo.Name = "pnl_Conteudo";
            pnl_Conteudo.Size = new Size(1054, 908);
            pnl_Conteudo.TabIndex = 1;
            // 
            // Form_principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1321, 908);
            Controls.Add(pnl_Conteudo);
            Controls.Add(pnl_Menu);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(820, 624);
            Name = "Form_principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Innova Owl";
            pnl_Menu.ResumeLayout(false);
            pnl_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_Menu;
        private Button btn_Inicio;
        private Panel pnl_Conteudo;
        private PictureBox pictureBox1;
        private Button btn_Cursos;
        private Button btn_Artigos;
        private Button btn_cardsCursos;
        private Button btn_Professores;
        private Label label1;
        private Button btn_cardArtigos;
    }
}
