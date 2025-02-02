using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using App.Base;
using App.Models;
using Domain.Base;
using Domain.Entities;
using Service.Validators;

namespace App.Cadastros
{
    public partial class CadastroConsulta : CadastroBase
    {
        private readonly IBaseService<Consulta> _consultaService;
        private readonly IBaseService<Paciente> _pacienteService;
        private readonly IBaseService<Medico> _medicoService;

        private List<ConsultaModel>? consultas;

        public CadastroConsulta(IBaseService<Consulta> consultaService, IBaseService<Paciente> pacienteService, IBaseService<Medico> medicoService)
        {
            _consultaService = consultaService;
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
                    MessageBoxIcon.Question) == DialogResult.Yes)
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
                        MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void CarregarCombo()
        {
            cboPaciente.ValueMember = "Id";
            cboPaciente.DisplayMember = "Nome";
            cboPaciente.DataSource = _pacienteService.Get<PacienteModel>().ToList();

            cboMedico.ValueMember = "Id";
            cboMedico.DisplayMember = "Nome";
            cboMedico.DataSource = _medicoService.Get<MedicoModel>().ToList();
        }

        #endregion

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtData.Text))
            {
                MessageBox.Show("O campo Data é obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtData.Focus();
                return false;
            }

            if (!DateTime.TryParseExact(txtData.Text, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("Formato de data inválido! Use dd/MM/yyyy HH:mm", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtData.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtStatus.Text))
            {
                MessageBox.Show("O campo Status é obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStatus.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                MessageBox.Show("O campo Motivo é obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMotivo.Focus();
                return false;
            }

            if (cboPaciente.SelectedValue == null)
            {
                MessageBox.Show("Selecione um Paciente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPaciente.Focus();
                return false;
            }

            if (cboMedico.SelectedValue == null)
            {
                MessageBox.Show("Selecione um Médico!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMedico.Focus();
                return false;
            }

            return true;
        }

        private void PreencheObjeto(Consulta consulta)
        {
            consulta.DataHora = DateTime.ParseExact(txtData.Text, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            consulta.Status = txtStatus.Text;
            consulta.Motivo = txtMotivo.Text;

            if (cboPaciente.SelectedValue != null && int.TryParse(cboPaciente.SelectedValue.ToString(), out var idPaciente))
            {
                consulta.Paciente = _pacienteService.GetById<Paciente>(idPaciente);
            }

            if (cboMedico.SelectedValue != null && int.TryParse(cboMedico.SelectedValue.ToString(), out var idMedico))
            {
                consulta.Medico = _medicoService.GetById<Medico>(idMedico);
            }
        }

        protected override void Salvar()
        {
            try
            {
                if (!ValidarCampos()) return; // Se os campos estiverem inválidos, não salva

                var dataHora = DateTime.ParseExact(txtData.Text, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                var idPaciente = Convert.ToInt32(cboPaciente.SelectedValue);
                var idMedico = Convert.ToInt32(cboMedico.SelectedValue);
                int idConsulta = 0;

                if (!string.IsNullOrWhiteSpace(txtId.Text) && int.TryParse(txtId.Text, out var parsedId))
                {
                    idConsulta = parsedId;
                }

                // Verifica se já existe uma consulta para a mesma data, paciente e médico
                bool existeConsulta = _consultaService
                    .Get<Consulta>()
                    .Any(c => c.DataHora == dataHora &&
                              c.Paciente != null && c.Paciente.Id == idPaciente &&
                              c.Medico != null && c.Medico.Id == idMedico &&
                              c.Id != idConsulta); // Ignora a própria consulta em caso de edição

                if (existeConsulta)
                {
                    MessageBox.Show("Já existe uma consulta marcada para essa data, paciente e médico!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (idConsulta > 0)
                {
                    var consulta = _consultaService.GetById<Consulta>(idConsulta);
                    PreencheObjeto(consulta);
                    _consultaService.Update<Consulta, Consulta, ConsultaValidator>(consulta);
                }
                else
                {
                    var consulta = new Consulta();
                    PreencheObjeto(consulta);
                    _consultaService.Add<Consulta, Consulta, ConsultaValidator>(consulta);
                }

                MessageBox.Show("Consulta salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabPage.SelectedIndex = 1;
                CarregaGrid();
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
                _consultaService.Delete(id);
                MessageBox.Show("Consulta deletada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clínica DDD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            consultas = _consultaService.Get<ConsultaModel>(new[] { "Paciente", "Medico" }).ToList();
            dataGridView.DataSource = consultas;
            dataGridView.Columns["IdPaciente"].Visible = false;
            dataGridView.Columns["IdMedico"].Visible = false;
        }
    }
}
