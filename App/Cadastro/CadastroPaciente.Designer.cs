namespace App.Cadastro
{
    partial class CadastroPaciente
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
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEndereço = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtTelefone = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            IDPAciente = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDataNascimento = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // poisonTabControl1
            // 
            materialTabControl.Location = new Point(3, 64);
            materialTabControl.Size = new Size(794, 383);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtDataNascimento);
            tabPageCadastro.Controls.Add(IDPAciente);
            tabPageCadastro.Controls.Add(txtTelefone);
            tabPageCadastro.Controls.Add(txtEndereço);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Location = new Point(4, 38);
            tabPageCadastro.Size = new Size(786, 341);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtEndereço, 0);
            tabPageCadastro.Controls.SetChildIndex(txtTelefone, 0);
            tabPageCadastro.Controls.SetChildIndex(IDPAciente, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDataNascimento, 0);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Location = new Point(4, 38);
            tabPageConsulta.Size = new Size(786, 341);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(561, 267);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(665, 267);
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
            txtNome.Location = new Point(6, 22);
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
            txtNome.Size = new Size(735, 48);
            txtNome.TabIndex = 5;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtEndereço
            // 
            txtEndereço.AnimateReadOnly = false;
            txtEndereço.AutoCompleteMode = AutoCompleteMode.None;
            txtEndereço.AutoCompleteSource = AutoCompleteSource.None;
            txtEndereço.BackgroundImageLayout = ImageLayout.None;
            txtEndereço.CharacterCasing = CharacterCasing.Normal;
            txtEndereço.Depth = 0;
            txtEndereço.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEndereço.HideSelection = true;
            txtEndereço.Hint = "Endereço";
            txtEndereço.LeadingIcon = null;
            txtEndereço.Location = new Point(6, 130);
            txtEndereço.MaxLength = 32767;
            txtEndereço.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEndereço.Name = "txtEndereço";
            txtEndereço.PasswordChar = '\0';
            txtEndereço.PrefixSuffixText = null;
            txtEndereço.ReadOnly = false;
            txtEndereço.RightToLeft = RightToLeft.No;
            txtEndereço.SelectedText = "";
            txtEndereço.SelectionLength = 0;
            txtEndereço.SelectionStart = 0;
            txtEndereço.ShortcutsEnabled = true;
            txtEndereço.Size = new Size(735, 48);
            txtEndereço.TabIndex = 7;
            txtEndereço.TabStop = false;
            txtEndereço.TextAlign = HorizontalAlignment.Left;
            txtEndereço.TrailingIcon = null;
            txtEndereço.UseSystemPasswordChar = false;
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
            txtTelefone.Location = new Point(6, 184);
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
            txtTelefone.Size = new Size(735, 48);
            txtTelefone.TabIndex = 8;
            txtTelefone.TabStop = false;
            txtTelefone.TextAlign = HorizontalAlignment.Left;
            txtTelefone.TrailingIcon = null;
            txtTelefone.UseSystemPasswordChar = false;
            // 
            // IDPAciente
            // 
            IDPAciente.AnimateReadOnly = false;
            IDPAciente.AutoCompleteMode = AutoCompleteMode.None;
            IDPAciente.AutoCompleteSource = AutoCompleteSource.None;
            IDPAciente.BackgroundImageLayout = ImageLayout.None;
            IDPAciente.CharacterCasing = CharacterCasing.Normal;
            IDPAciente.Depth = 0;
            IDPAciente.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            IDPAciente.HideSelection = true;
            IDPAciente.Hint = "ID Paciente (Auto Incremento)";
            IDPAciente.LeadingIcon = null;
            IDPAciente.Location = new Point(300, 255);
            IDPAciente.MaxLength = 32767;
            IDPAciente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            IDPAciente.Name = "IDPAciente";
            IDPAciente.PasswordChar = '\0';
            IDPAciente.PrefixSuffixText = null;
            IDPAciente.ReadOnly = false;
            IDPAciente.RightToLeft = RightToLeft.No;
            IDPAciente.SelectedText = "";
            IDPAciente.SelectionLength = 0;
            IDPAciente.SelectionStart = 0;
            IDPAciente.ShortcutsEnabled = true;
            IDPAciente.Size = new Size(254, 48);
            IDPAciente.TabIndex = 9;
            IDPAciente.TabStop = false;
            IDPAciente.TextAlign = HorizontalAlignment.Left;
            IDPAciente.TrailingIcon = null;
            IDPAciente.UseSystemPasswordChar = false;
            IDPAciente.Visible = false;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.AllowPromptAsInput = true;
            txtDataNascimento.AnimateReadOnly = false;
            txtDataNascimento.AsciiOnly = false;
            txtDataNascimento.BackgroundImageLayout = ImageLayout.None;
            txtDataNascimento.BeepOnError = false;
            txtDataNascimento.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataNascimento.Depth = 0;
            txtDataNascimento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataNascimento.HidePromptOnLeave = false;
            txtDataNascimento.HideSelection = true;
            txtDataNascimento.Hint = "Data de Nascimento";
            txtDataNascimento.InsertKeyMode = InsertKeyMode.Default;
            txtDataNascimento.LeadingIcon = null;
            txtDataNascimento.Location = new Point(6, 76);
            txtDataNascimento.Mask = "__/__/__";
            txtDataNascimento.MaxLength = 32767;
            txtDataNascimento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.PasswordChar = '\0';
            txtDataNascimento.PrefixSuffixText = null;
            txtDataNascimento.PromptChar = '_';
            txtDataNascimento.ReadOnly = false;
            txtDataNascimento.RejectInputOnFirstFailure = false;
            txtDataNascimento.ResetOnPrompt = true;
            txtDataNascimento.ResetOnSpace = true;
            txtDataNascimento.RightToLeft = RightToLeft.No;
            txtDataNascimento.SelectedText = "";
            txtDataNascimento.SelectionLength = 0;
            txtDataNascimento.SelectionStart = 0;
            txtDataNascimento.ShortcutsEnabled = true;
            txtDataNascimento.Size = new Size(735, 48);
            txtDataNascimento.SkipLiterals = true;
            txtDataNascimento.TabIndex = 10;
            txtDataNascimento.TabStop = false;
            txtDataNascimento.Text = "__/__/__";
            txtDataNascimento.TextAlign = HorizontalAlignment.Left;
            txtDataNascimento.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataNascimento.TrailingIcon = null;
            txtDataNascimento.UseSystemPasswordChar = false;
            txtDataNascimento.ValidatingType = null;
            // 
            // CadastroPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroPaciente";
            Text = "CadastroPaciente";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox materialComboBox1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTelefone;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEndereço;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit IDPAciente;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataNascimento;
    }
}