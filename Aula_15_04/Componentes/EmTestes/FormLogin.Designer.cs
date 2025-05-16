namespace Aula_15_04.Componentes.EmTestes
{
    partial class FormLogin
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
            btn_entrar = new Button();
            lbl_usuario = new Label();
            txt_usuario = new TextBox();
            txt_senha = new TextBox();
            lbl_senha = new Label();
            btn_cadastrar = new Button();
            btn_senha = new Button();
            lbl_login = new Label();
            SuspendLayout();
            // 
            // btn_entrar
            // 
            btn_entrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_entrar.BackColor = Color.FromArgb(255, 112, 43);
            btn_entrar.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_entrar.FlatAppearance.BorderSize = 0;
            btn_entrar.FlatStyle = FlatStyle.Flat;
            btn_entrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_entrar.ForeColor = SystemColors.Info;
            btn_entrar.Location = new Point(79, 376);
            btn_entrar.Margin = new Padding(3, 4, 3, 4);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(259, 47);
            btn_entrar.TabIndex = 3;
            btn_entrar.Text = "Entrar";
            btn_entrar.UseVisualStyleBackColor = false;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // lbl_usuario
            // 
            lbl_usuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_usuario.AutoSize = true;
            lbl_usuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_usuario.ForeColor = Color.FromArgb(255, 112, 43);
            lbl_usuario.Location = new Point(79, 159);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(116, 37);
            lbl_usuario.TabIndex = 1;
            lbl_usuario.Text = "Usuário";
            // 
            // txt_usuario
            // 
            txt_usuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_usuario.BackColor = SystemColors.Info;
            txt_usuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_usuario.ForeColor = Color.Black;
            txt_usuario.Location = new Point(79, 215);
            txt_usuario.Margin = new Padding(0);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(259, 32);
            txt_usuario.TabIndex = 1;
            txt_usuario.Text = "USUARIOSENAC";
            // 
            // txt_senha
            // 
            txt_senha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_senha.BackColor = SystemColors.Info;
            txt_senha.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_senha.ForeColor = Color.Black;
            txt_senha.Location = new Point(79, 323);
            txt_senha.Margin = new Padding(0);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(259, 32);
            txt_senha.TabIndex = 2;
            txt_senha.Text = "CONHECIMENTO";
            txt_senha.UseSystemPasswordChar = true;
            // 
            // lbl_senha
            // 
            lbl_senha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_senha.ForeColor = Color.FromArgb(22, 70, 90);
            lbl_senha.Location = new Point(79, 267);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(94, 37);
            lbl_senha.TabIndex = 3;
            lbl_senha.Text = "Senha";
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_cadastrar.BackColor = Color.FromArgb(22, 70, 90);
            btn_cadastrar.FlatAppearance.BorderSize = 0;
            btn_cadastrar.FlatStyle = FlatStyle.Flat;
            btn_cadastrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_cadastrar.ForeColor = SystemColors.Info;
            btn_cadastrar.Location = new Point(79, 448);
            btn_cadastrar.Margin = new Padding(0);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(259, 47);
            btn_cadastrar.TabIndex = 4;
            btn_cadastrar.Text = "Cadastrar-se";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click_1;
            // 
            // btn_senha
            // 
            btn_senha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_senha.BackColor = Color.Transparent;
            btn_senha.FlatAppearance.BorderSize = 0;
            btn_senha.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_senha.FlatStyle = FlatStyle.Flat;
            btn_senha.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btn_senha.ForeColor = Color.FromArgb(22, 70, 90);
            btn_senha.Location = new Point(105, 511);
            btn_senha.Margin = new Padding(3, 4, 3, 4);
            btn_senha.Name = "btn_senha";
            btn_senha.Size = new Size(193, 35);
            btn_senha.TabIndex = 5;
            btn_senha.Text = "Esqueceu sua senha?";
            btn_senha.UseVisualStyleBackColor = false;
            // 
            // lbl_login
            // 
            lbl_login.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_login.ForeColor = Color.FromArgb(255, 112, 43);
            lbl_login.Location = new Point(105, 12);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(222, 81);
            lbl_login.TabIndex = 7;
            lbl_login.Text = "LOGIN";
            lbl_login.Click += lbl_login_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 217, 184);
            ClientSize = new Size(402, 629);
            Controls.Add(lbl_login);
            Controls.Add(btn_senha);
            Controls.Add(btn_cadastrar);
            Controls.Add(txt_senha);
            Controls.Add(lbl_senha);
            Controls.Add(txt_usuario);
            Controls.Add(lbl_usuario);
            Controls.Add(btn_entrar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_entrar;
        private Label lbl_usuario;
        private TextBox txt_usuario;
        private TextBox txt_senha;
        private Label lbl_senha;
        private Button btn_cadastrar;
        private Button btn_senha;
        private Label lbl_login;
    }
}
