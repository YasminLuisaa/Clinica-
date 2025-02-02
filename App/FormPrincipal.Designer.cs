namespace App
{
    partial class FormPrincipal
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
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            consultaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            médicoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            pacienteToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            pagamentoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            prontuárioToolStripMenuItem = new ToolStripMenuItem();
            relátorioToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            saidaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, relátorioToolStripMenuItem, ajudaToolStripMenuItem, saidaToolStripMenuItem });
            menuStrip1.Location = new Point(3, 64);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(794, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultaToolStripMenuItem, toolStripMenuItem1, médicoToolStripMenuItem, toolStripMenuItem2, pacienteToolStripMenuItem, toolStripMenuItem3, pagamentoToolStripMenuItem, toolStripMenuItem4, prontuárioToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // consultaToolStripMenuItem
            // 
            consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            consultaToolStripMenuItem.Size = new Size(180, 22);
            consultaToolStripMenuItem.Text = "Consulta";
            consultaToolStripMenuItem.Click += ConsultaToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(177, 6);
            // 
            // médicoToolStripMenuItem
            // 
            médicoToolStripMenuItem.Name = "médicoToolStripMenuItem";
            médicoToolStripMenuItem.Size = new Size(180, 22);
            médicoToolStripMenuItem.Text = "Médico";
            médicoToolStripMenuItem.Click += MedicoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(177, 6);
            // 
            // pacienteToolStripMenuItem
            // 
            pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            pacienteToolStripMenuItem.Size = new Size(180, 22);
            pacienteToolStripMenuItem.Text = "Paciente";
            pacienteToolStripMenuItem.Click += PacienteStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(177, 6);
            // 
            // pagamentoToolStripMenuItem
            // 
            pagamentoToolStripMenuItem.Name = "pagamentoToolStripMenuItem";
            pagamentoToolStripMenuItem.Size = new Size(180, 22);
            pagamentoToolStripMenuItem.Text = "Pagamento";
            pagamentoToolStripMenuItem.Click += PagamentoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(177, 6);
            // 
            // prontuárioToolStripMenuItem
            // 
            prontuárioToolStripMenuItem.Name = "prontuárioToolStripMenuItem";
            prontuárioToolStripMenuItem.Size = new Size(180, 22);
            prontuárioToolStripMenuItem.Text = "Prontuário";
            prontuárioToolStripMenuItem.Click += ProntuarioToolStripMenuItem_Click;
            // 
            // relátorioToolStripMenuItem
            // 
            relátorioToolStripMenuItem.Name = "relátorioToolStripMenuItem";
            relátorioToolStripMenuItem.Size = new Size(66, 20);
            relátorioToolStripMenuItem.Text = "Relátorio";
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // saidaToolStripMenuItem
            // 
            saidaToolStripMenuItem.Name = "saidaToolStripMenuItem";
            saidaToolStripMenuItem.Size = new Size(47, 20);
            saidaToolStripMenuItem.Text = "Saida";
            saidaToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            Text = "Clinica Dr Yasmin Gomes";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem médicoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem pacienteToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem pagamentoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem prontuárioToolStripMenuItem;
        private ToolStripMenuItem relátorioToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem saidaToolStripMenuItem;
    }
}
