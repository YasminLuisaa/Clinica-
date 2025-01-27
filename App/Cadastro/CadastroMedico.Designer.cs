namespace App.Cadastro
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
            txtID = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCRM = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtTelefone = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtExpecialidade = new ReaLTaiizor.Controls.MaterialComboBox();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtExpecialidade);
            tabPageCadastro.Controls.Add(txtTelefone);
            tabPageCadastro.Controls.Add(txtCRM);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Controls.Add(txtID);
            tabPageCadastro.Location = new Point(4, 38);
            tabPageCadastro.Size = new Size(752, 328);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtID, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtCRM, 0);
            tabPageCadastro.Controls.SetChildIndex(txtTelefone, 0);
            tabPageCadastro.Controls.SetChildIndex(txtExpecialidade, 0);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Location = new Point(4, 38);
            tabPageConsulta.Size = new Size(752, 328);
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
            txtID.Hint = "ID Médico (Auto Incremento)";
            txtID.LeadingIcon = null;
            txtID.Location = new Point(324, 271);
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
            txtID.Size = new Size(230, 48);
            txtID.TabIndex = 5;
            txtID.TabStop = false;
            txtID.TextAlign = HorizontalAlignment.Left;
            txtID.TrailingIcon = null;
            txtID.UseSystemPasswordChar = false;
            txtID.Visible = false;
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
            txtNome.Location = new Point(25, 24);
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
            txtNome.Size = new Size(716, 48);
            txtNome.TabIndex = 6;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
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
            txtCRM.Location = new Point(25, 78);
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
            txtCRM.Size = new Size(716, 48);
            txtCRM.TabIndex = 7;
            txtCRM.TabStop = false;
            txtCRM.TextAlign = HorizontalAlignment.Left;
            txtCRM.TrailingIcon = null;
            txtCRM.UseSystemPasswordChar = false;
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
            txtTelefone.Location = new Point(25, 132);
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
            txtTelefone.Size = new Size(716, 48);
            txtTelefone.TabIndex = 8;
            txtTelefone.TabStop = false;
            txtTelefone.TextAlign = HorizontalAlignment.Left;
            txtTelefone.TrailingIcon = null;
            txtTelefone.UseSystemPasswordChar = false;
            // 
            // txtExpecialidade
            // 
            txtExpecialidade.AutoResize = false;
            txtExpecialidade.BackColor = Color.FromArgb(255, 255, 255);
            txtExpecialidade.Depth = 0;
            txtExpecialidade.DrawMode = DrawMode.OwnerDrawVariable;
            txtExpecialidade.DropDownHeight = 174;
            txtExpecialidade.DropDownStyle = ComboBoxStyle.DropDownList;
            txtExpecialidade.DropDownWidth = 121;
            txtExpecialidade.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtExpecialidade.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtExpecialidade.FormattingEnabled = true;
            txtExpecialidade.Hint = "Especialidade";
            txtExpecialidade.IntegralHeight = false;
            txtExpecialidade.ItemHeight = 43;
            txtExpecialidade.Location = new Point(25, 186);
            txtExpecialidade.MaxDropDownItems = 4;
            txtExpecialidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtExpecialidade.Name = "txtExpecialidade";
            txtExpecialidade.Size = new Size(716, 49);
            txtExpecialidade.StartIndex = 0;
            txtExpecialidade.TabIndex = 9;
            // 
            // CadastroMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroMedico";
            Text = "CadastroMedico";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtID;
        private ReaLTaiizor.Controls.MaterialComboBox txtExpecialidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTelefone;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCRM;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
    }
}