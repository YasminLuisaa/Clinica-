using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace App.Base
{
    public partial class CadastroBase : MaterialForm
    {
        #region Declarações
        protected bool IsAlteracao = false;
        #endregion

        #region Construtor
        public CadastroBase()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Deseja realmente cancelar?", @"Clinica", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                tabPage.SelectedIndex = 1;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(@"Deseja realmente deletar?", @"Clinica", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dataGridView.SelectedRows[0].Cells["Id"].Value;
                    Deletar(id);
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!", @"Clinica", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void tabPageConsulta_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void dataGridViewConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        #endregion

        #region CRUD Methods
        protected void LimpaCampos()
        {
            IsAlteracao = false;
            foreach (var control in tabPageCadastro.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }

                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }

        protected virtual void CarregaGrid() { }

        protected virtual void Novo()
        {
            LimpaCampos();
            tabPage.SelectedIndex = 0;
            tabPageCadastro.Focus();
        }

        protected virtual void Salvar() { }

        protected virtual void Editar()
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                IsAlteracao = true;
                var linha = dataGridView.SelectedRows[0];
                CarregaRegistro(linha);
                tabPage.SelectedIndex = 0;
                tabPageCadastro.Focus();
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!", @"Clinica", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        protected virtual void Deletar(int id) { }

        protected virtual void CarregaRegistro(DataGridViewRow? linha) { }

        #endregion

        private void CadastroBase_Load(object sender, EventArgs e) { }
    }
}
