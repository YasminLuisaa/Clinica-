namespace App.Cadastros
{
    partial class CadastroMedico
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
            txtEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtTelefone = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCRM = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEspecialidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPage.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage
            // 
            tabPage.Location = new Point(3, 24);
            tabPage.Size = new Size(794, 423);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtEmail);
            tabPageCadastro.Controls.Add(txtTelefone);
            tabPageCadastro.Controls.Add(txtCRM);
            tabPageCadastro.Controls.Add(txtEspecialidade);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Size = new Size(786, 395);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtEspecialidade, 0);
            tabPageCadastro.Controls.SetChildIndex(txtCRM, 0);
            tabPageCadastro.Controls.SetChildIndex(txtTelefone, 0);
            tabPageCadastro.Controls.SetChildIndex(txtEmail, 0);
            // 
            // btnCancelar
            // 
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Click += btnSalvar_Click;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Size = new Size(786, 395);
            // 
            // btnEditar
            // 
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnNovo
            // 
            btnNovo.Click += btnNovo_Click;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.AutoCompleteMode = AutoCompleteMode.None;
            txtEmail.AutoCompleteSource = AutoCompleteSource.None;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.Hint = "E-mail";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(204, 207);
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.ReadOnly = false;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(576, 48);
            txtEmail.TabIndex = 14;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // txtTelefone
            // 
            txtTelefone.AnimateReadOnly = false;
            txtTelefone.AutoCompleteMode = AutoCompleteMode.None;
            txtTelefone.AutoCompleteSource = AutoCompleteSource.None;
            txtTelefone.BackgroundImageLayout = ImageLayout.None;
            txtTelefone.CharacterCasing = CharacterCasing.Normal;
            txtTelefone.Depth = 0;
            txtTelefone.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefone.HideSelection = true;
            txtTelefone.Hint = "Telefone";
            txtTelefone.LeadingIcon = null;
            txtTelefone.Location = new Point(6, 207);
            txtTelefone.MaxLength = 32767;
            txtTelefone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PasswordChar = '\0';
            txtTelefone.PrefixSuffixText = null;
            txtTelefone.ReadOnly = false;
            txtTelefone.RightToLeft = RightToLeft.No;
            txtTelefone.SelectedText = "";
            txtTelefone.SelectionLength = 0;
            txtTelefone.SelectionStart = 0;
            txtTelefone.ShortcutsEnabled = true;
            txtTelefone.Size = new Size(191, 48);
            txtTelefone.TabIndex = 13;
            txtTelefone.TabStop = false;
            txtTelefone.TextAlign = HorizontalAlignment.Left;
            txtTelefone.TrailingIcon = null;
            txtTelefone.UseSystemPasswordChar = false;
            // 
            // txtCRM
            // 
            txtCRM.AnimateReadOnly = false;
            txtCRM.AutoCompleteMode = AutoCompleteMode.None;
            txtCRM.AutoCompleteSource = AutoCompleteSource.None;
            txtCRM.BackgroundImageLayout = ImageLayout.None;
            txtCRM.CharacterCasing = CharacterCasing.Normal;
            txtCRM.Depth = 0;
            txtCRM.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCRM.HideSelection = true;
            txtCRM.Hint = "CRM";
            txtCRM.LeadingIcon = null;
            txtCRM.Location = new Point(203, 153);
            txtCRM.MaxLength = 32767;
            txtCRM.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCRM.Name = "txtCRM";
            txtCRM.PasswordChar = '\0';
            txtCRM.PrefixSuffixText = null;
            txtCRM.ReadOnly = false;
            txtCRM.RightToLeft = RightToLeft.No;
            txtCRM.SelectedText = "";
            txtCRM.SelectionLength = 0;
            txtCRM.SelectionStart = 0;
            txtCRM.ShortcutsEnabled = true;
            txtCRM.Size = new Size(576, 48);
            txtCRM.TabIndex = 12;
            txtCRM.TabStop = false;
            txtCRM.TextAlign = HorizontalAlignment.Left;
            txtCRM.TrailingIcon = null;
            txtCRM.UseSystemPasswordChar = false;
            // 
            // txtEspecialidade
            // 
            txtEspecialidade.AnimateReadOnly = false;
            txtEspecialidade.AutoCompleteMode = AutoCompleteMode.None;
            txtEspecialidade.AutoCompleteSource = AutoCompleteSource.None;
            txtEspecialidade.BackgroundImageLayout = ImageLayout.None;
            txtEspecialidade.CharacterCasing = CharacterCasing.Normal;
            txtEspecialidade.Depth = 0;
            txtEspecialidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEspecialidade.HideSelection = true;
            txtEspecialidade.Hint = "Especialidade";
            txtEspecialidade.LeadingIcon = null;
            txtEspecialidade.Location = new Point(6, 153);
            txtEspecialidade.MaxLength = 32767;
            txtEspecialidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEspecialidade.Name = "txtEspecialidade";
            txtEspecialidade.PasswordChar = '\0';
            txtEspecialidade.PrefixSuffixText = null;
            txtEspecialidade.ReadOnly = false;
            txtEspecialidade.RightToLeft = RightToLeft.No;
            txtEspecialidade.SelectedText = "";
            txtEspecialidade.SelectionLength = 0;
            txtEspecialidade.SelectionStart = 0;
            txtEspecialidade.ShortcutsEnabled = true;
            txtEspecialidade.Size = new Size(191, 48);
            txtEspecialidade.TabIndex = 11;
            txtEspecialidade.TabStop = false;
            txtEspecialidade.TextAlign = HorizontalAlignment.Left;
            txtEspecialidade.TrailingIcon = null;
            txtEspecialidade.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(203, 99);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(576, 48);
            txtNome.TabIndex = 10;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Código";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(6, 99);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = false;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(191, 48);
            txtId.TabIndex = 9;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // CadastroMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            Location = new Point(0, 0);
            Name = "CadastroMedico";
            Padding = new Padding(3, 24, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroMedico";
            tabPage.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEmail;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTelefone;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCRM;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEspecialidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}