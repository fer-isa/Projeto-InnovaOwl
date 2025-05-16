namespace Aula_15_04.Componentes.Controles
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btn_cadastro = new Button();
            btn_login = new Button();
            panel2 = new Panel();
            label4 = new Label();
            label1 = new Label();
            lbl_texto = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 112, 43);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_cadastro);
            panel1.Controls.Add(btn_login);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(922, 46);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_New;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // btn_cadastro
            // 
            btn_cadastro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_cadastro.BackColor = Color.PeachPuff;
            btn_cadastro.Cursor = Cursors.Hand;
            btn_cadastro.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn_cadastro.FlatStyle = FlatStyle.Flat;
            btn_cadastro.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            btn_cadastro.ForeColor = Color.FromArgb(20, 20, 20);
            btn_cadastro.Location = new Point(783, 8);
            btn_cadastro.Margin = new Padding(8);
            btn_cadastro.Name = "btn_cadastro";
            btn_cadastro.Size = new Size(131, 30);
            btn_cadastro.TabIndex = 13;
            btn_cadastro.Text = "Cadastro";
            btn_cadastro.UseVisualStyleBackColor = false;
            btn_cadastro.Click += btn_cadastro_Click;
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_login.BackColor = Color.PeachPuff;
            btn_login.Cursor = Cursors.Hand;
            btn_login.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            btn_login.ForeColor = Color.FromArgb(20, 20, 20);
            btn_login.Location = new Point(648, 8);
            btn_login.Margin = new Padding(8);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(131, 30);
            btn_login.TabIndex = 12;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 635);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(922, 46);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Info;
            label4.Location = new Point(276, 17);
            label4.Name = "label4";
            label4.Size = new Size(354, 15);
            label4.TabIndex = 1;
            label4.Text = "© Desenvolvido por Fernanda Oliveira, Filipe Reis e Pedro Barbosa";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(242, 17);
            label1.Name = "label1";
            label1.Size = new Size(384, 15);
            label1.TabIndex = 0;
            label1.Text = "Desenvolvido por Fernanda Oliveira, Filipe Reis e Pedro Barbosa. © 2025";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_texto
            // 
            lbl_texto.AutoSize = true;
            lbl_texto.BackColor = Color.LightYellow;
            lbl_texto.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Pixel, 0);
            lbl_texto.ForeColor = Color.FromArgb(117, 39, 0);
            lbl_texto.Location = new Point(12, 85);
            lbl_texto.Name = "lbl_texto";
            lbl_texto.Size = new Size(901, 40);
            lbl_texto.TabIndex = 2;
            lbl_texto.Text = " InnovaOwl: Transforme Seu Futuro com Educação de Qualidade! ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(479, 184);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(436, 345);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(-290, 271);
            label2.Name = "label2";
            label2.Size = new Size(54, 19);
            label2.TabIndex = 4;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Symbol", 20F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(26, 169);
            label3.Name = "label3";
            label3.Size = new Size(438, 210);
            label3.TabIndex = 5;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Info;
            label5.Location = new Point(26, 418);
            label5.Name = "label5";
            label5.Size = new Size(414, 199);
            label5.TabIndex = 6;
            label5.Text = resources.GetString("label5.Text");
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightYellow;
            label6.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Pixel, 0);
            label6.ForeColor = Color.FromArgb(117, 39, 0);
            label6.Location = new Point(26, 400);
            label6.Name = "label6";
            label6.Size = new Size(432, 40);
            label6.TabIndex = 7;
            label6.Text = "Por que escolher a InnovaOwl?";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(22, 70, 90);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(lbl_texto);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(255, 112, 43);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Inicio";
            Size = new Size(922, 681);
            Load += Inicio_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btn_cadastro;
        private Button btn_login;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lbl_texto;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
    }
}
