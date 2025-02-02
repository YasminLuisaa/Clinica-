using App.Base;
using App.Models;
using Domain.Base;
using Domain.Entities;
using Service.Validators;

namespace App.Cadastros
{
    public partial class CadastroMedico : CadastroBase
    {
        private readonly IBaseService<Medico> _medicoService;
        private List<MedicoModel>? medicos;
        private bool IsAlteracao = false; // Flag para indicar se é edição

        public CadastroMedico(IBaseService<Medico> medicoService)
        {
            _medicoService = medicoService;
            InitializeComponent();
            CarregaGrid();
        }

        #region Eventos

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar?", "Clínica DDD", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                tabPage.SelectedIndex = 1; // Volta para a aba de consulta
                IsAlteracao = false; // Reseta flag de alteração
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
                if (MessageBox.Show("Deseja realmente deletar?", "Clínica DDD", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dataGridView.SelectedRows[0].Cells["Id"].Value;
                    Deletar(id);
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione algum registro!", "Clínica DDD", MessageBoxButtons.OK,
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

        private void PreencheObjeto(Medico medico)
        {
            medico.Nome = txtNome.Text;
            medico.Especialidade = txtEspecialidade.Text;
            medico.CRM = txtCRM.Text;
            medico.Telefone = txtTelefone.Text;
            medico.Email = txtEmail.Text;
        }

        private void Editar()
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                IsAlteracao = true; // Garante que o sistema entende que é uma edição
                CarregaRegistro(dataGridView.SelectedRows[0]);
                tabPage.SelectedIndex = 0; // Muda para a aba de edição
            }
            else
            {
                MessageBox.Show("Selecione um registro para editar!", "Clínica DDD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var medicoExistente = _medicoService.GetById<Medico>(id);

                        if (medicoExistente != null)
                        {
                            // Atualiza diretamente a instância existente
                            PreencheObjeto(medicoExistente);
                            _medicoService.Update<Medico, Medico, MedicoValidator>(medicoExistente);
                        }
                    }
                }
                else
                {
                    var medico = new Medico();
                    PreencheObjeto(medico);
                    _medicoService.Add<Medico, Medico, MedicoValidator>(medico);
                }

                IsAlteracao = false; // Resetar flag de alteração após salvar
                tabPage.SelectedIndex = 1;
                CarregaGrid(); // Atualiza a lista para evitar duplicações
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clínica DDD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _medicoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clínica DDD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            medicos = _medicoService.Get<MedicoModel>().ToList();

            // Evita adicionar registros duplicados no DataGridView
            dataGridView.DataSource = null;
            dataGridView.DataSource = medicos;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            if (linha != null)
            {
                txtId.Text = linha.Cells["Id"].Value.ToString();
                txtNome.Text = linha.Cells["Nome"].Value.ToString();
                txtEspecialidade.Text = linha.Cells["Especialidade"].Value.ToString();
                txtCRM.Text = linha.Cells["CRM"].Value.ToString();
                txtTelefone.Text = linha.Cells["Telefone"].Value.ToString();
                txtEmail.Text = linha.Cells["Email"].Value.ToString();
            }
        }
    }
}
