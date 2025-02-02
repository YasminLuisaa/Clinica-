namespace App.Cadastros
{
    partial class CadastroPagamento
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
            txtMetodoPagamento = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtValor = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtData = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboConsulta = new ReaLTaiizor.Controls.MaterialComboBox();
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
            tabPageCadastro.Size = new Size(786, 395);
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
            // txtMetodoPagamento
            // 
            txtMetodoPagamento.AnimateReadOnly = false;
            txtMetodoPagamento.AutoCompleteMode = AutoCompleteMode.None;
            txtMetodoPagamento.AutoCompleteSource = AutoCompleteSource.None;
            txtMetodoPagamento.BackgroundImageLayout = ImageLayout.None;
            txtMetodoPagamento.CharacterCasing = CharacterCasing.Normal;
            txtMetodoPagamento.Depth = 0;
            txtMetodoPagamento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMetodoPagamento.HideSelection = true;
            txtMetodoPagamento.Hint = "Método de Pagamento";
            txtMetodoPagamento.LeadingIcon = null;
            txtMetodoPagamento.Location = new Point(14, 283);
            txtMetodoPagamento.MaxLength = 32767;
            txtMetodoPagamento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtMetodoPagamento.Name = "txtMetodoPagamento";
            txtMetodoPagamento.PasswordChar = '\0';
            txtMetodoPagamento.PrefixSuffixText = null;
            txtMetodoPagamento.ReadOnly = false;
            txtMetodoPagamento.RightToLeft = RightToLeft.No;
            txtMetodoPagamento.SelectedText = "";
            txtMetodoPagamento.SelectionLength = 0;
            txtMetodoPagamento.SelectionStart = 0;
            txtMetodoPagamento.ShortcutsEnabled = true;
            txtMetodoPagamento.Size = new Size(773, 48);
            txtMetodoPagamento.TabIndex = 20;
            txtMetodoPagamento.TabStop = false;
            txtMetodoPagamento.TextAlign = HorizontalAlignment.Left;
            txtMetodoPagamento.TrailingIcon = null;
            txtMetodoPagamento.UseSystemPasswordChar = false;
            // 
            // txtValor
            // 
            txtValor.AnimateReadOnly = false;
            txtValor.AutoCompleteMode = AutoCompleteMode.None;
            txtValor.AutoCompleteSource = AutoCompleteSource.None;
            txtValor.BackgroundImageLayout = ImageLayout.None;
            txtValor.CharacterCasing = CharacterCasing.Normal;
            txtValor.Depth = 0;
            txtValor.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtValor.HideSelection = true;
            txtValor.Hint = "Valor";
            txtValor.LeadingIcon = null;
            txtValor.Location = new Point(14, 229);
            txtValor.MaxLength = 32767;
            txtValor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtValor.Name = "txtValor";
            txtValor.PasswordChar = '\0';
            txtValor.PrefixSuffixText = null;
            txtValor.ReadOnly = false;
            txtValor.RightToLeft = RightToLeft.No;
            txtValor.SelectedText = "";
            txtValor.SelectionLength = 0;
            txtValor.SelectionStart = 0;
            txtValor.ShortcutsEnabled = true;
            txtValor.Size = new Size(773, 48);
            txtValor.TabIndex = 19;
            txtValor.TabStop = false;
            txtValor.TextAlign = HorizontalAlignment.Left;
            txtValor.TrailingIcon = null;
            txtValor.UseSystemPasswordChar = false;
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
            txtData.Location = new Point(14, 175);
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
            txtData.TabIndex = 18;
            txtData.TabStop = false;
            txtData.TextAlign = HorizontalAlignment.Left;
            txtData.TrailingIcon = null;
            txtData.UseSystemPasswordChar = false;
            // 
            // cboConsulta
            // 
            cboConsulta.AutoResize = false;
            cboConsulta.BackColor = Color.FromArgb(255, 255, 255);
            cboConsulta.Depth = 0;
            cboConsulta.DrawMode = DrawMode.OwnerDrawVariable;
            cboConsulta.DropDownHeight = 174;
            cboConsulta.DropDownStyle = ComboBoxStyle.DropDownList;
            cboConsulta.DropDownWidth = 121;
            cboConsulta.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboConsulta.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboConsulta.FormattingEnabled = true;
            cboConsulta.Hint = "Consulta";
            cboConsulta.IntegralHeight = false;
            cboConsulta.ItemHeight = 43;
            cboConsulta.Location = new Point(209, 174);
            cboConsulta.MaxDropDownItems = 4;
            cboConsulta.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboConsulta.Name = "cboConsulta";
            cboConsulta.Size = new Size(578, 49);
            cboConsulta.StartIndex = 0;
            cboConsulta.TabIndex = 17;
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
            cboPaciente.Location = new Point(209, 120);
            cboPaciente.MaxDropDownItems = 4;
            cboPaciente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(578, 49);
            cboPaciente.StartIndex = 0;
            cboPaciente.TabIndex = 16;
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
            txtId.Location = new Point(14, 120);
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
            txtId.TabIndex = 15;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // CadastroPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMetodoPagamento);
            Controls.Add(txtValor);
            Controls.Add(txtData);
            Controls.Add(cboConsulta);
            Controls.Add(cboPaciente);
            Controls.Add(txtId);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            Location = new Point(0, 0);
            Name = "CadastroPagamento";
            Padding = new Padding(3, 24, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroPagamento";
            Controls.SetChildIndex(tabPage, 0);
            Controls.SetChildIndex(txtId, 0);
            Controls.SetChildIndex(cboPaciente, 0);
            Controls.SetChildIndex(cboConsulta, 0);
            Controls.SetChildIndex(txtData, 0);
            Controls.SetChildIndex(txtValor, 0);
            Controls.SetChildIndex(txtMetodoPagamento, 0);
            tabPage.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtMetodoPagamento;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtValor;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtData;
        private ReaLTaiizor.Controls.MaterialComboBox cboConsulta;
        private ReaLTaiizor.Controls.MaterialComboBox cboPaciente;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}