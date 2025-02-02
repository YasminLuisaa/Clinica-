using App.Base;
using App.Models;
using Domain.Base;
using Domain.Entities;
using ReaLTaiizor.Controls;
using Service.Validators;

namespace App.Cadastros
{
    public partial class CadastroProntuarioMedico : CadastroBase
    {
        private readonly IBaseService<ProntuarioMedico> _prontuarioService;
        private readonly IBaseService<Paciente> _pacienteService;
        private readonly IBaseService<Medico> _medicoService;

        private List<ProntuarioMedicoModel>? prontuarios;

        public CadastroProntuarioMedico(IBaseService<ProntuarioMedico> prontuarioService, IBaseService<Paciente> pacienteService, IBaseService<Medico> medicoService)
        {
            _prontuarioService = prontuarioService;
            _pacienteService = pacienteService;
            _medicoService = medicoService;
            InitializeComponent();
            CarregarCombo();
            CarregaGrid();
        }

        #region Eventos

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Deseja realmente cancelar?", @"Clínica DDD", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                LimpaCampos();
                tabPage.SelectedIndex = 1; // Volta para a aba de consulta
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
                if (MessageBox.Show(@"Deseja realmente deletar?", @"Clínica DDD", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    int id = (int)dataGridView.SelectedRows[0].Cells["Id"].Value;
                    Deletar(id);
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!", @"Clínica DDD", MessageBoxButtons.OK,
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

        private void CarregarCombo()
        {
            cboPaciente.ValueMember = "Id";
            cboPaciente.DisplayMember = "Nome";
            cboPaciente.DataSource = _pacienteService.Get<PacienteModel>().ToList();

            cboMedico.ValueMember = "Id";
            cboMedico.DisplayMember = "Nome";
            cboMedico.DataSource = _medicoService.Get<MedicoModel>().ToList();
        }

        private void PreencheObjeto(ProntuarioMedico prontuario)
        {
            prontuario.DataHora = DateTime.Parse(txtData.Text);
            prontuario.Descricao = txtDescricao.Text;
            prontuario.Prescricao = txtPrescricao.Text;

            if (cboPaciente.SelectedValue != null && int.TryParse(cboPaciente.SelectedValue.ToString(), out var idPaciente))
            {
                var paciente = _pacienteService.GetById<Paciente>(idPaciente);
                prontuario.Paciente = paciente;
            }

            if (cboMedico.SelectedValue != null && int.TryParse(cboMedico.SelectedValue.ToString(), out var idMedico))
            {
                var medico = _medicoService.GetById<Medico>(idMedico);
                prontuario.Medico = medico;
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
                        var prontuario = _prontuarioService.GetById<ProntuarioMedico>(id);
                        PreencheObjeto(prontuario);
                        prontuario = _prontuarioService.Update<ProntuarioMedico, ProntuarioMedico, ProntuarioMedicoValidator>(prontuario);
                    }
                }
                else
                {
                    var prontuario = new ProntuarioMedico();
                    PreencheObjeto(prontuario);
                    _prontuarioService.Add<ProntuarioMedico, ProntuarioMedico, ProntuarioMedicoValidator>(prontuario);
                }

                tabPage.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Clínica DDD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _prontuarioService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Clínica DDD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            prontuarios = _prontuarioService.Get<ProntuarioMedicoModel>(new[] { "Paciente", "Medico" }).ToList();
            dataGridView.DataSource = prontuarios;
            dataGridView.Columns["IdPaciente"]!.Visible = false;
            dataGridView.Columns["IdMedico"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtData.Text = linha?.Cells["DataHora"].Value.ToString();
            txtDescricao.Text = linha?.Cells["Descricao"].Value.ToString();
            txtPrescricao.Text = linha?.Cells["Prescricao"].Value.ToString();
            cboPaciente.SelectedValue = linha?.Cells["IdPaciente"].Value;
            cboMedico.SelectedValue = linha?.Cells["IdMedico"].Value;
        }
    }


}