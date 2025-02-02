using App.Base;
using App.Models;
using Domain.Base;
using Domain.Entities;
using Service.Validators;

namespace App.Cadastros
{
    public partial class CadastroPagamento : CadastroBase
    {
        private readonly IBaseService<Pagamento> _pagamentoService;
        private readonly IBaseService<Paciente> _pacienteService;
        private readonly IBaseService<Consulta> _consultaService;

        private List<PagamentoModel>? pagamentos;

        public CadastroPagamento(IBaseService<Pagamento> pagamentoService, IBaseService<Paciente> pacienteService, IBaseService<Consulta> consultaService)
        {
            _pagamentoService = pagamentoService;
            _pacienteService = pacienteService;
            _consultaService = consultaService;
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

        private void CarregarCombo()
        {
            cboPaciente.ValueMember = "Id";
            cboPaciente.DisplayMember = "Id";
            cboPaciente.DataSource = _pacienteService.Get<PacienteModel>().ToList();

            cboConsulta.ValueMember = "Id";
            cboConsulta.DisplayMember = "Id";
            cboConsulta.DataSource = _consultaService.Get<ConsultaModel>().ToList();
        }

        #endregion

        private void PreencheObjeto(Pagamento pagamento)
        {
            pagamento.DataHora = DateTime.Parse(txtData.Text);
            pagamento.Valor = decimal.Parse(txtValor.Text);
            pagamento.MetodoPagamento = txtMetodoPagamento.Text;

            if (cboPaciente.SelectedValue != null && int.TryParse(cboPaciente.SelectedValue.ToString(), out var idPaciente))
            {
                var paciente = _pacienteService.GetById<Paciente>(idPaciente);
                pagamento.Paciente = paciente;
            }

            if (cboConsulta.SelectedValue != null && int.TryParse(cboConsulta.SelectedValue.ToString(), out var idConsulta))
            {
                var consulta = _consultaService.GetById<Consulta>(idConsulta);
                pagamento.Consulta = consulta;
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
                        var pagamento = _pagamentoService.GetById<Pagamento>(id);
                        PreencheObjeto(pagamento);
                        pagamento = _pagamentoService.Update<Pagamento, Pagamento, PagamentoValidator>(pagamento);
                    }
                }
                else
                {
                    var pagamento = new Pagamento();
                    PreencheObjeto(pagamento);
                    _pagamentoService.Add<Pagamento, Pagamento, PagamentoValidator>(pagamento);
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
                _pagamentoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Clínica DDD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            pagamentos = _pagamentoService.Get<PagamentoModel>(new[] { "Paciente", "Consulta" }).ToList();
            dataGridView.DataSource = pagamentos;
            dataGridView.Columns["IdPaciente"]!.Visible = false;
            dataGridView.Columns["IdConsulta"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtData.Text = linha?.Cells["DataHora"].Value.ToString();
            txtValor.Text = linha?.Cells["Valor"].Value.ToString();
            txtMetodoPagamento.Text = linha?.Cells["MetodoPagamento"].Value.ToString();
            cboPaciente.SelectedValue = linha?.Cells["IdPaciente"].Value;
            cboConsulta.SelectedValue = linha?.Cells["IdConsulta"].Value;
        }
    }
}