namespace DataStoreDesktop
{
    partial class FormCarrinho
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
            label4 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel22 = new Panel();
            btn_limpar_filtros = new Button();
            btn_pesquisar_form_pesquisar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel22.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(23, 24, 29);
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(0);
            label4.MinimumSize = new Size(259, 0);
            label4.Name = "label4";
            label4.Size = new Size(800, 17);
            label4.TabIndex = 0;
            label4.Text = "Qualtidade Solicitada";
            label4.TextAlign = ContentAlignment.BottomCenter;
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(23, 24, 29);
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 17);
            label2.Margin = new Padding(0);
            label2.MinimumSize = new Size(259, 0);
            label2.Name = "label2";
            label2.Size = new Size(800, 17);
            label2.TabIndex = 24;
            label2.Text = "23";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(23, 24, 29);
            panel2.Controls.Add(panel22);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 42);
            panel2.TabIndex = 25;
            // 
            // panel22
            // 
            panel22.BackColor = Color.FromArgb(23, 24, 29);
            panel22.Controls.Add(btn_limpar_filtros);
            panel22.Controls.Add(btn_pesquisar_form_pesquisar);
            panel22.Dock = DockStyle.Left;
            panel22.Location = new Point(0, 0);
            panel22.Name = "panel22";
            panel22.Size = new Size(336, 42);
            panel22.TabIndex = 26;
            // 
            // btn_limpar_filtros
            // 
            btn_limpar_filtros.BackColor = Color.FromArgb(23, 24, 29);
            btn_limpar_filtros.BackgroundImageLayout = ImageLayout.Center;
            btn_limpar_filtros.Dock = DockStyle.Left;
            btn_limpar_filtros.FlatAppearance.BorderSize = 0;
            btn_limpar_filtros.FlatStyle = FlatStyle.Flat;
            btn_limpar_filtros.ForeColor = Color.White;
            btn_limpar_filtros.Image = Properties.Resources.vassoura_16;
            btn_limpar_filtros.ImageAlign = ContentAlignment.MiddleLeft;
            btn_limpar_filtros.Location = new Point(0, 0);
            btn_limpar_filtros.Margin = new Padding(0);
            btn_limpar_filtros.Name = "btn_limpar_filtros";
            btn_limpar_filtros.Size = new Size(164, 42);
            btn_limpar_filtros.TabIndex = 17;
            btn_limpar_filtros.Text = "          Cancelar solicitação";
            btn_limpar_filtros.TextAlign = ContentAlignment.MiddleLeft;
            btn_limpar_filtros.UseVisualStyleBackColor = false;
            // 
            // btn_pesquisar_form_pesquisar
            // 
            btn_pesquisar_form_pesquisar.BackColor = Color.FromArgb(23, 24, 29);
            btn_pesquisar_form_pesquisar.BackgroundImageLayout = ImageLayout.Center;
            btn_pesquisar_form_pesquisar.Dock = DockStyle.Right;
            btn_pesquisar_form_pesquisar.FlatAppearance.BorderSize = 0;
            btn_pesquisar_form_pesquisar.FlatStyle = FlatStyle.Flat;
            btn_pesquisar_form_pesquisar.ForeColor = Color.White;
            btn_pesquisar_form_pesquisar.Image = Properties.Resources.enviar_16_azul;
            btn_pesquisar_form_pesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_pesquisar_form_pesquisar.Location = new Point(172, 0);
            btn_pesquisar_form_pesquisar.Margin = new Padding(0);
            btn_pesquisar_form_pesquisar.Name = "btn_pesquisar_form_pesquisar";
            btn_pesquisar_form_pesquisar.Size = new Size(164, 42);
            btn_pesquisar_form_pesquisar.TabIndex = 19;
            btn_pesquisar_form_pesquisar.Text = "          Enviar solicitação";
            btn_pesquisar_form_pesquisar.TextAlign = ContentAlignment.MiddleLeft;
            btn_pesquisar_form_pesquisar.UseVisualStyleBackColor = false;
            // 
            // FormCarrinho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCarrinho";
            Text = "FormCarrinho";
            Load += FormCarrinho_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel22.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel22;
        private Button btn_limpar_filtros;
        private Button btn_pesquisar_form_pesquisar;
    }
}