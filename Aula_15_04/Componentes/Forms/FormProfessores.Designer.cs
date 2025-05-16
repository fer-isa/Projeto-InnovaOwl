namespace Aula_15_04.Forms
{
    partial class frm_professores
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
            lbl_adicionarProfessor = new Label();
            lbl_nomeProfessor = new Label();
            lbl_email = new Label();
            btn_adicionarProfessor = new Button();
            txt_nomeProfessor = new TextBox();
            txt_email = new TextBox();
            SuspendLayout();
            // 
            // lbl_adicionarProfessor
            // 
            lbl_adicionarProfessor.AutoSize = true;
            lbl_adicionarProfessor.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_adicionarProfessor.Location = new Point(14, 24);
            lbl_adicionarProfessor.Name = "lbl_adicionarProfessor";
            lbl_adicionarProfessor.Size = new Size(195, 28);
            lbl_adicionarProfessor.TabIndex = 0;
            lbl_adicionarProfessor.Text = "Adicionar Professor:";
            lbl_adicionarProfessor.Click += lbl_adicionarProfessor_Click;
            // 
            // lbl_nomeProfessor
            // 
            lbl_nomeProfessor.AutoSize = true;
            lbl_nomeProfessor.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_nomeProfessor.Location = new Point(14, 85);
            lbl_nomeProfessor.Name = "lbl_nomeProfessor";
            lbl_nomeProfessor.Size = new Size(146, 20);
            lbl_nomeProfessor.TabIndex = 1;
            lbl_nomeProfessor.Text = "Nome do Professor:";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_email.Location = new Point(14, 227);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(50, 20);
            lbl_email.TabIndex = 2;
            lbl_email.Text = "Email:";
            // 
            // btn_adicionarProfessor
            // 
            btn_adicionarProfessor.BackColor = Color.DarkOrange;
            btn_adicionarProfessor.Dock = DockStyle.Bottom;
            btn_adicionarProfessor.FlatStyle = FlatStyle.Flat;
            btn_adicionarProfessor.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_adicionarProfessor.Location = new Point(0, 407);
            btn_adicionarProfessor.Margin = new Padding(3, 4, 3, 4);
            btn_adicionarProfessor.Name = "btn_adicionarProfessor";
            btn_adicionarProfessor.Size = new Size(369, 40);
            btn_adicionarProfessor.TabIndex = 4;
            btn_adicionarProfessor.Text = "Adicionar";
            btn_adicionarProfessor.UseVisualStyleBackColor = false;
            // 
            // txt_nomeProfessor
            // 
            txt_nomeProfessor.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_nomeProfessor.Location = new Point(14, 127);
            txt_nomeProfessor.Margin = new Padding(3, 4, 3, 4);
            txt_nomeProfessor.Name = "txt_nomeProfessor";
            txt_nomeProfessor.Size = new Size(255, 29);
            txt_nomeProfessor.TabIndex = 6;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_email.Location = new Point(14, 268);
            txt_email.Margin = new Padding(3, 4, 3, 4);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(255, 29);
            txt_email.TabIndex = 7;
            // 
            // frm_professores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(369, 447);
            Controls.Add(txt_email);
            Controls.Add(txt_nomeProfessor);
            Controls.Add(btn_adicionarProfessor);
            Controls.Add(lbl_email);
            Controls.Add(lbl_nomeProfessor);
            Controls.Add(lbl_adicionarProfessor);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_professores";
            Text = "Adicionar Professores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_adicionarProfessor;
        private Label lbl_nomeProfessor;
        private Label lbl_email;
        private Button btn_adicionarProfessor;
        private TextBox txt_nomeProfessor;
        private TextBox txt_email;
    }
}