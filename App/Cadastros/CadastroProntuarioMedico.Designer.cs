namespace App.Cadastros
{
    partial class CadastroProntuarioMedico
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
            txtPrescricao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDescricao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtData = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboMedico = new ReaLTaiizor.Controls.MaterialComboBox();
            cboPaciente = new ReaLTaiizor.Controls.MaterialComboBox();
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
            tabPageCadastro.Controls.Add(txtPrescricao);
            tabPageCadastro.Controls.Add(txtDescricao);
            tabPageCadastro.Controls.Add(txtData);
            tabPageCadastro.Controls.Add(cboMedico);
            tabPageCadastro.Controls.Add(cboPaciente);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Size = new Size(786, 395);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(cboPaciente, 0);
            tabPageCadastro.Controls.SetChildIndex(cboMedico, 0);
            tabPageCadastro.Controls.SetChildIndex(txtData, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDescricao, 0);
            tabPageCadastro.Controls.SetChildIndex(txtPrescricao, 0);
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
            // txtPrescricao
            // 
            txtPrescricao.AnimateReadOnly = false;
            txtPrescricao.AutoCompleteMode = AutoCompleteMode.None;
            txtPrescricao.AutoCompleteSource = AutoCompleteSource.None;
            txtPrescricao.BackgroundImageLayout = ImageLayout.None;
            txtPrescricao.CharacterCasing = CharacterCasing.Normal;
            txtPrescricao.Depth = 0;
            txtPrescricao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrescricao.HideSelection = true;
            txtPrescricao.Hint = "Prescrição";
            txtPrescricao.LeadingIcon = null;
            txtPrescricao.Location = new Point(7, 235);
            txtPrescricao.MaxLength = 32767;
            txtPrescricao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPrescricao.Name = "txtPrescricao";
            txtPrescricao.PasswordChar = '\0';
            txtPrescricao.PrefixSuffixText = null;
            txtPrescricao.ReadOnly = false;
            txtPrescricao.RightToLeft = RightToLeft.No;
            txtPrescricao.SelectedText = "";
            txtPrescricao.SelectionLength = 0;
            txtPrescricao.SelectionStart = 0;
            txtPrescricao.ShortcutsEnabled = true;
            txtPrescricao.Size = new Size(773, 48);
            txtPrescricao.TabIndex = 14;
            txtPrescricao.TabStop = false;
            txtPrescricao.TextAlign = HorizontalAlignment.Left;
            txtPrescricao.TrailingIcon = null;
            txtPrescricao.UseSystemPasswordChar = false;
            // 
            // txtDescricao
            // 
            txtDescricao.AnimateReadOnly = false;
            txtDescricao.AutoCompleteMode = AutoCompleteMode.None;
            txtDescricao.AutoCompleteSource = AutoCompleteSource.None;
            txtDescricao.BackgroundImageLayout = ImageLayout.None;
            txtDescricao.CharacterCasing = CharacterCasing.Normal;
            txtDescricao.Depth = 0;
            txtDescricao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescricao.HideSelection = true;
            txtDescricao.Hint = "Descrição";
            txtDescricao.LeadingIcon = null;
            txtDescricao.Location = new Point(7, 181);
            txtDescricao.MaxLength = 32767;
            txtDescricao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PasswordChar = '\0';
            txtDescricao.PrefixSuffixText = null;
            txtDescricao.ReadOnly = false;
            txtDescricao.RightToLeft = RightToLeft.No;
            txtDescricao.SelectedText = "";
            txtDescricao.SelectionLength = 0;
            txtDescricao.SelectionStart = 0;
            txtDescricao.ShortcutsEnabled = true;
            txtDescricao.Size = new Size(773, 48);
            txtDescricao.TabIndex = 13;
            txtDescricao.TabStop = false;
            txtDescricao.TextAlign = HorizontalAlignment.Left;
            txtDescricao.TrailingIcon = null;
            txtDescricao.UseSystemPasswordChar = false;
            // 
            // txtData
            // 
            txtData.AnimateReadOnly = false;
            txtData.AutoCompleteMode = AutoCompleteMode.None;
            txtData.AutoCompleteSource = AutoCompleteSource.None;
            txtData.BackgroundImageLayout = ImageLayout.None;
            txtData.CharacterCasing = CharacterCasing.Normal;
            txtData.Depth = 0;
            txtData.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtData.HideSelection = true;
            txtData.Hint = "Data";
            txtData.LeadingIcon = null;
            txtData.Location = new Point(7, 127);
            txtData.MaxLength = 32767;
            txtData.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtData.Name = "txtData";
            txtData.PasswordChar = '\0';
            txtData.PrefixSuffixText = null;
            txtData.ReadOnly = false;
            txtData.RightToLeft = RightToLeft.No;
            txtData.SelectedText = "";
            txtData.SelectionLength = 0;
            txtData.SelectionStart = 0;
            txtData.ShortcutsEnabled = true;
            txtData.Size = new Size(189, 48);
            txtData.TabIndex = 12;
            txtData.TabStop = false;
            txtData.TextAlign = HorizontalAlignment.Left;
            txtData.TrailingIcon = null;
            txtData.UseSystemPasswordChar = false;
            // 
            // cboMedico
            // 
            cboMedico.AutoResize = false;
            cboMedico.BackColor = Color.FromArgb(255, 255, 255);
            cboMedico.Depth = 0;
            cboMedico.DrawMode = DrawMode.OwnerDrawVariable;
            cboMedico.DropDownHeight = 174;
            cboMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMedico.DropDownWidth = 121;
            cboMedico.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboMedico.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboMedico.FormattingEnabled = true;
            cboMedico.Hint = "Médico";
            cboMedico.IntegralHeight = false;
            cboMedico.ItemHeight = 43;
            cboMedico.Location = new Point(202, 126);
            cboMedico.MaxDropDownItems = 4;
            cboMedico.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboMedico.Name = "cboMedico";
            cboMedico.Size = new Size(578, 49);
            cboMedico.StartIndex = 0;
            cboMedico.TabIndex = 11;
            // 
            // cboPaciente
            // 
            cboPaciente.AutoResize = false;
            cboPaciente.BackColor = Color.FromArgb(255, 255, 255);
            cboPaciente.Depth = 0;
            cboPaciente.DrawMode = DrawMode.OwnerDrawVariable;
            cboPaciente.DropDownHeight = 174;
            cboPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaciente.DropDownWidth = 121;
            cboPaciente.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboPaciente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboPaciente.FormattingEnabled = true;
            cboPaciente.Hint = "Paciente";
            cboPaciente.IntegralHeight = false;
            cboPaciente.ItemHeight = 43;
            cboPaciente.Location = new Point(202, 72);
            cboPaciente.MaxDropDownItems = 4;
            cboPaciente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(578, 49);
            cboPaciente.StartIndex = 0;
            cboPaciente.TabIndex = 10;
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
            txtId.Location = new Point(7, 72);
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
            txtId.Size = new Size(189, 48);
            txtId.TabIndex = 9;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // CadastroProntuarioMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            Location = new Point(0, 0);
            Name = "CadastroProntuarioMedico";
            Padding = new Padding(3, 24, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroProntuarioMedico";
            tabPage.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPrescricao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDescricao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtData;
        private ReaLTaiizor.Controls.MaterialComboBox cboMedico;
        private ReaLTaiizor.Controls.MaterialComboBox cboPaciente;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}