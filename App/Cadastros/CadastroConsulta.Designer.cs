namespace App.Cadastros
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
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboPaciente = new ReaLTaiizor.Controls.MaterialComboBox();
            cboMedico = new ReaLTaiizor.Controls.MaterialComboBox();
            txtData = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtStatus = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtMotivo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
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
            tabPageCadastro.Controls.Add(txtMotivo);
            tabPageCadastro.Controls.Add(txtStatus);
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
            tabPageCadastro.Controls.SetChildIndex(txtStatus, 0);
            tabPageCadastro.Controls.SetChildIndex(txtMotivo, 0);
            // 
            // btnCancelar
            // 
            btnCancelar.Click += BtnCancelar_Click;
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
            txtId.Location = new Point(6, 53);
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
            txtId.TabIndex = 3;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
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
            cboPaciente.Location = new Point(201, 53);
            cboPaciente.MaxDropDownItems = 4;
            cboPaciente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(578, 49);
            cboPaciente.StartIndex = 0;
            cboPaciente.TabIndex = 4;
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
            cboMedico.Location = new Point(201, 107);
            cboMedico.MaxDropDownItems = 4;
            cboMedico.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboMedico.Name = "cboMedico";
            cboMedico.Size = new Size(578, 49);
            cboMedico.StartIndex = 0;
            cboMedico.TabIndex = 5;
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
            txtData.Location = new Point(6, 108);
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
            txtData.TabIndex = 6;
            txtData.TabStop = false;
            txtData.TextAlign = HorizontalAlignment.Left;
            txtData.TrailingIcon = null;
            txtData.UseSystemPasswordChar = false;
            // 
            // txtStatus
            // 
            txtStatus.AnimateReadOnly = false;
            txtStatus.AutoCompleteMode = AutoCompleteMode.None;
            txtStatus.AutoCompleteSource = AutoCompleteSource.None;
            txtStatus.BackgroundImageLayout = ImageLayout.None;
            txtStatus.CharacterCasing = CharacterCasing.Normal;
            txtStatus.Depth = 0;
            txtStatus.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtStatus.HideSelection = true;
            txtStatus.Hint = "Status";
            txtStatus.LeadingIcon = null;
            txtStatus.Location = new Point(6, 162);
            txtStatus.MaxLength = 32767;
            txtStatus.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtStatus.Name = "txtStatus";
            txtStatus.PasswordChar = '\0';
            txtStatus.PrefixSuffixText = null;
            txtStatus.ReadOnly = false;
            txtStatus.RightToLeft = RightToLeft.No;
            txtStatus.SelectedText = "";
            txtStatus.SelectionLength = 0;
            txtStatus.SelectionStart = 0;
            txtStatus.ShortcutsEnabled = true;
            txtStatus.Size = new Size(773, 48);
            txtStatus.TabIndex = 7;
            txtStatus.TabStop = false;
            txtStatus.TextAlign = HorizontalAlignment.Left;
            txtStatus.TrailingIcon = null;
            txtStatus.UseSystemPasswordChar = false;
            // 
            // txtMotivo
            // 
            txtMotivo.AnimateReadOnly = false;
            txtMotivo.AutoCompleteMode = AutoCompleteMode.None;
            txtMotivo.AutoCompleteSource = AutoCompleteSource.None;
            txtMotivo.BackgroundImageLayout = ImageLayout.None;
            txtMotivo.CharacterCasing = CharacterCasing.Normal;
            txtMotivo.Depth = 0;
            txtMotivo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMotivo.HideSelection = true;
            txtMotivo.Hint = "Motivo";
            txtMotivo.LeadingIcon = null;
            txtMotivo.Location = new Point(6, 216);
            txtMotivo.MaxLength = 32767;
            txtMotivo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.PasswordChar = '\0';
            txtMotivo.PrefixSuffixText = null;
            txtMotivo.ReadOnly = false;
            txtMotivo.RightToLeft = RightToLeft.No;
            txtMotivo.SelectedText = "";
            txtMotivo.SelectionLength = 0;
            txtMotivo.SelectionStart = 0;
            txtMotivo.ShortcutsEnabled = true;
            txtMotivo.Size = new Size(773, 48);
            txtMotivo.TabIndex = 8;
            txtMotivo.TabStop = false;
            txtMotivo.TextAlign = HorizontalAlignment.Left;
            txtMotivo.TrailingIcon = null;
            txtMotivo.UseSystemPasswordChar = false;
            // 
            // CadastroConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            Location = new Point(0, 0);
            Name = "CadastroConsulta";
            Padding = new Padding(3, 24, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroConsulta";
            tabPage.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cboPaciente;
        private ReaLTaiizor.Controls.MaterialComboBox cboMedico;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtData;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtStatus;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtMotivo;
    }
}