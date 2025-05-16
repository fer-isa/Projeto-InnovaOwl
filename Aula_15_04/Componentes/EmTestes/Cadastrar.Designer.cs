namespace Aula_15_04.Componentes.EmTestes
{
    partial class Cadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txt_nascimento = new TextBox();
            txt_genero = new TextBox();
            txt_email = new TextBox();
            txt_usuario = new TextBox();
            txt_senha = new TextBox();
            txt_cep = new TextBox();
            btn_cad = new Button();
            txt_descricao = new RichTextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // txt_nascimento
            // 
            txt_nascimento.BackColor = SystemColors.Info;
            txt_nascimento.BorderStyle = BorderStyle.FixedSingle;
            txt_nascimento.ForeColor = Color.Black;
            txt_nascimento.Location = new Point(53, 196);
            txt_nascimento.Margin = new Padding(4);
            txt_nascimento.Multiline = true;
            txt_nascimento.Name = "txt_nascimento";
            txt_nascimento.PlaceholderText = "Data de Nascimento";
            txt_nascimento.Size = new Size(191, 28);
            txt_nascimento.TabIndex = 2;
            // 
            // txt_genero
            // 
            txt_genero.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_genero.BackColor = SystemColors.Info;
            txt_genero.BorderStyle = BorderStyle.FixedSingle;
            txt_genero.ForeColor = Color.Black;
            txt_genero.Location = new Point(298, 196);
            txt_genero.Margin = new Padding(4);
            txt_genero.Multiline = true;
            txt_genero.Name = "txt_genero";
            txt_genero.PlaceholderText = "Gênero";
            txt_genero.Size = new Size(209, 28);
            txt_genero.TabIndex = 3;
            // 
            // txt_email
            // 
            txt_email.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_email.BackColor = SystemColors.Info;
            txt_email.BorderStyle = BorderStyle.FixedSingle;
            txt_email.ForeColor = Color.Black;
            txt_email.Location = new Point(53, 310);
            txt_email.Margin = new Padding(4);
            txt_email.Multiline = true;
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "Email ou Celular";
            txt_email.Size = new Size(454, 28);
            txt_email.TabIndex = 5;
            // 
            // txt_usuario
            // 
            txt_usuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_usuario.BackColor = SystemColors.Info;
            txt_usuario.BorderStyle = BorderStyle.FixedSingle;
            txt_usuario.ForeColor = Color.Black;
            txt_usuario.Location = new Point(53, 141);
            txt_usuario.Margin = new Padding(4);
            txt_usuario.Multiline = true;
            txt_usuario.Name = "txt_usuario";
            txt_usuario.PlaceholderText = "Nome Completo";
            txt_usuario.Size = new Size(454, 28);
            txt_usuario.TabIndex = 1;
            // 
            // txt_senha
            // 
            txt_senha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_senha.BackColor = SystemColors.Info;
            txt_senha.BorderStyle = BorderStyle.FixedSingle;
            txt_senha.ForeColor = Color.Black;
            txt_senha.Location = new Point(53, 366);
            txt_senha.Margin = new Padding(4);
            txt_senha.Multiline = true;
            txt_senha.Name = "txt_senha";
            txt_senha.PlaceholderText = "Nova Senha";
            txt_senha.Size = new Size(454, 28);
            txt_senha.TabIndex = 6;
            // 
            // txt_cep
            // 
            txt_cep.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_cep.BackColor = SystemColors.Info;
            txt_cep.BorderStyle = BorderStyle.FixedSingle;
            txt_cep.ForeColor = Color.Black;
            txt_cep.Location = new Point(53, 254);
            txt_cep.Multiline = true;
            txt_cep.Name = "txt_cep";
            txt_cep.PlaceholderText = "CEP";
            txt_cep.Size = new Size(454, 28);
            txt_cep.TabIndex = 4;
            // 
            // btn_cad
            // 
            btn_cad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_cad.BackColor = Color.FromArgb(255, 112, 43);
            btn_cad.BackgroundImageLayout = ImageLayout.Center;
            btn_cad.FlatAppearance.BorderSize = 0;
            btn_cad.FlatStyle = FlatStyle.Flat;
            btn_cad.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_cad.ForeColor = SystemColors.Info;
            btn_cad.Location = new Point(159, 542);
            btn_cad.Name = "btn_cad";
            btn_cad.Size = new Size(237, 58);
            btn_cad.TabIndex = 7;
            btn_cad.Text = "Cadastrar-se";
            btn_cad.UseVisualStyleBackColor = false;
            btn_cad.Click += btn_cad_Click;
            // 
            // txt_descricao
            // 
            txt_descricao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_descricao.BackColor = Color.FromArgb(22, 70, 90);
            txt_descricao.BorderStyle = BorderStyle.None;
            txt_descricao.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            txt_descricao.ForeColor = SystemColors.Info;
            txt_descricao.Location = new Point(53, 410);
            txt_descricao.Name = "txt_descricao";
            txt_descricao.Size = new Size(454, 126);
            txt_descricao.TabIndex = 9;
            txt_descricao.Text = resources.GetString("txt_descricao.Text");
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.FromArgb(22, 70, 90);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.Info;
            textBox1.Location = new Point(115, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 86);
            textBox1.TabIndex = 10;
            textBox1.Text = "InnovaOwl";
            // 
            // Cadastrar
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 70, 90);
            ClientSize = new Size(558, 635);
            Controls.Add(textBox1);
            Controls.Add(txt_descricao);
            Controls.Add(btn_cad);
            Controls.Add(txt_cep);
            Controls.Add(txt_senha);
            Controls.Add(txt_usuario);
            Controls.Add(txt_email);
            Controls.Add(txt_genero);
            Controls.Add(txt_nascimento);
            Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Cadastrar";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Cadastrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txt_nascimento;
        private TextBox txt_genero;
        private TextBox txt_email;
        private TextBox txt_usuario;
        private TextBox txt_senha;
        private TextBox txt_cep;
        private Button btn_cad;
        private RichTextBox txt_descricao;
        private TextBox textBox1;
    }
}
