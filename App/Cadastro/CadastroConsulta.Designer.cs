namespace App.Cadastro
{
    partial class CadastroConsulta
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
            txtDataHora = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            IDPaciente = new ReaLTaiizor.Controls.MaterialComboBox();
            IDMedico = new ReaLTaiizor.Controls.MaterialComboBox();
            txtObservacoes = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtID = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtID);
            tabPageCadastro.Controls.Add(txtObservacoes);
            tabPageCadastro.Controls.Add(IDMedico);
            tabPageCadastro.Controls.Add(IDPaciente);
            tabPageCadastro.Controls.Add(txtDataHora);
            tabPageCadastro.Location = new Point(4, 38);
            tabPageCadastro.Size = new Size(752, 328);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDataHora, 0);
            tabPageCadastro.Controls.SetChildIndex(IDPaciente, 0);
            tabPageCadastro.Controls.SetChildIndex(IDMedico, 0);
            tabPageCadastro.Controls.SetChildIndex(txtObservacoes, 0);
            tabPageCadastro.Controls.SetChildIndex(txtID, 0);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Location = new Point(4, 38);
            tabPageConsulta.Size = new Size(752, 328);
            // 
            // txtDataHora
            // 
            txtDataHora.AllowPromptAsInput = true;
            txtDataHora.AnimateReadOnly = false;
            txtDataHora.AsciiOnly = false;
            txtDataHora.BackgroundImageLayout = ImageLayout.None;
            txtDataHora.BeepOnError = false;
            txtDataHora.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataHora.Depth = 0;
            txtDataHora.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataHora.HidePromptOnLeave = false;
            txtDataHora.HideSelection = true;
            txtDataHora.Hint = "Data e Hora";
            txtDataHora.InsertKeyMode = InsertKeyMode.Default;
            txtDataHora.LeadingIcon = null;
            txtDataHora.Location = new Point(11, 128);
            txtDataHora.Mask = "__/__/__ às   :  ";
            txtDataHora.MaxLength = 32767;
            txtDataHora.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataHora.Name = "txtDataHora";
            txtDataHora.PasswordChar = '\0';
            txtDataHora.PrefixSuffixText = null;
            txtDataHora.PromptChar = '_';
            txtDataHora.ReadOnly = false;
            txtDataHora.RejectInputOnFirstFailure = false;
            txtDataHora.ResetOnPrompt = true;
            txtDataHora.ResetOnSpace = true;
            txtDataHora.RightToLeft = RightToLeft.No;
            txtDataHora.SelectedText = "";
            txtDataHora.SelectionLength = 0;
            txtDataHora.SelectionStart = 0;
            txtDataHora.ShortcutsEnabled = true;
            txtDataHora.Size = new Size(735, 48);
            txtDataHora.SkipLiterals = true;
            txtDataHora.TabIndex = 7;
            txtDataHora.TabStop = false;
            txtDataHora.Text = "__/__/__ às   :  ";
            txtDataHora.TextAlign = HorizontalAlignment.Left;
            txtDataHora.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataHora.TrailingIcon = null;
            txtDataHora.UseSystemPasswordChar = false;
            txtDataHora.ValidatingType = null;
            // 
            // IDPaciente
            // 
            IDPaciente.AutoResize = false;
            IDPaciente.BackColor = Color.FromArgb(255, 255, 255);
            IDPaciente.Depth = 0;
            IDPaciente.DrawMode = DrawMode.OwnerDrawVariable;
            IDPaciente.DropDownHeight = 174;
            IDPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            IDPaciente.DropDownWidth = 121;
            IDPaciente.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            IDPaciente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            IDPaciente.FormattingEnabled = true;
            IDPaciente.Hint = "Código do Paciente";
            IDPaciente.IntegralHeight = false;
            IDPaciente.ItemHeight = 43;
            IDPaciente.Location = new Point(11, 18);
            IDPaciente.MaxDropDownItems = 4;
            IDPaciente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            IDPaciente.Name = "IDPaciente";
            IDPaciente.Size = new Size(735, 49);
            IDPaciente.StartIndex = 0;
            IDPaciente.TabIndex = 8;
            // 
            // IDMedico
            // 
            IDMedico.AutoResize = false;
            IDMedico.BackColor = Color.FromArgb(255, 255, 255);
            IDMedico.Depth = 0;
            IDMedico.DrawMode = DrawMode.OwnerDrawVariable;
            IDMedico.DropDownHeight = 174;
            IDMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            IDMedico.DropDownWidth = 121;
            IDMedico.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            IDMedico.ForeColor = Color.FromArgb(222, 0, 0, 0);
            IDMedico.FormattingEnabled = true;
            IDMedico.Hint = "Código do Médico";
            IDMedico.IntegralHeight = false;
            IDMedico.ItemHeight = 43;
            IDMedico.Location = new Point(11, 73);
            IDMedico.MaxDropDownItems = 4;
            IDMedico.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            IDMedico.Name = "IDMedico";
            IDMedico.Size = new Size(735, 49);
            IDMedico.StartIndex = 0;
            IDMedico.TabIndex = 9;
            // 
            // txtObservacoes
            // 
            txtObservacoes.AnimateReadOnly = false;
            txtObservacoes.AutoCompleteMode = AutoCompleteMode.None;
            txtObservacoes.AutoCompleteSource = AutoCompleteSource.None;
            txtObservacoes.BackgroundImageLayout = ImageLayout.None;
            txtObservacoes.CharacterCasing = CharacterCasing.Normal;
            txtObservacoes.Depth = 0;
            txtObservacoes.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtObservacoes.HideSelection = true;
            txtObservacoes.Hint = "Observações";
            txtObservacoes.LeadingIcon = null;
            txtObservacoes.Location = new Point(11, 182);
            txtObservacoes.MaxLength = 32767;
            txtObservacoes.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.PasswordChar = '\0';
            txtObservacoes.PrefixSuffixText = null;
            txtObservacoes.ReadOnly = false;
            txtObservacoes.RightToLeft = RightToLeft.No;
            txtObservacoes.SelectedText = "";
            txtObservacoes.SelectionLength = 0;
            txtObservacoes.SelectionStart = 0;
            txtObservacoes.ShortcutsEnabled = true;
            txtObservacoes.Size = new Size(735, 48);
            txtObservacoes.TabIndex = 10;
            txtObservacoes.TabStop = false;
            txtObservacoes.TextAlign = HorizontalAlignment.Left;
            txtObservacoes.TrailingIcon = null;
            txtObservacoes.UseSystemPasswordChar = false;
            // 
            // txtID
            // 
            txtID.AnimateReadOnly = false;
            txtID.AutoCompleteMode = AutoCompleteMode.None;
            txtID.AutoCompleteSource = AutoCompleteSource.None;
            txtID.BackgroundImageLayout = ImageLayout.None;
            txtID.CharacterCasing = CharacterCasing.Normal;
            txtID.Depth = 0;
            txtID.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtID.HideSelection = true;
            txtID.Hint = "ID Consulta (Auto Incremento)";
            txtID.LeadingIcon = null;
            txtID.Location = new Point(311, 271);
            txtID.MaxLength = 32767;
            txtID.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtID.Name = "txtID";
            txtID.PasswordChar = '\0';
            txtID.PrefixSuffixText = null;
            txtID.ReadOnly = false;
            txtID.RightToLeft = RightToLeft.No;
            txtID.SelectedText = "";
            txtID.SelectionLength = 0;
            txtID.SelectionStart = 0;
            txtID.ShortcutsEnabled = true;
            txtID.Size = new Size(243, 48);
            txtID.TabIndex = 11;
            txtID.TabStop = false;
            txtID.TextAlign = HorizontalAlignment.Left;
            txtID.TrailingIcon = null;
            txtID.UseSystemPasswordChar = false;
            txtID.Visible = false;
            // 
            // CadastroConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroConsulta";
            Text = "CadastroConsulta";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtObservacoes;
        private ReaLTaiizor.Controls.MaterialComboBox IDMedico;
        private ReaLTaiizor.Controls.MaterialComboBox IDPaciente;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataHora;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtID;
    }
}