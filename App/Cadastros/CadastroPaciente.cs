using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using App.Base;
using App.Models;
using Domain.Base;
using Domain.Entities;
using Service.Validators;

namespace App.Cadastros
{
    public partial class CadastroPaciente : CadastroBase
    {
        private readonly IBaseService<Paciente> _pacienteService;
        private List<PacienteModel>? pacientes;

        public CadastroPaciente(IBaseService<Paciente> pacienteService)
        {
            _pacienteService = pacienteService;
            InitializeComponent();
            ConfigurarEventos();
            CarregaGrid();
        }

        private void ConfigurarEventos()
        {
            btnSalvar.Click -= btnSalvar_Click;
            btnSalvar.Click += btnSalvar_Click;

            btnNovo.Click -= btnNovo_Click;
            btnNovo.Click += btnNovo_Click;

            btnEditar.Click -= btnEditar_Click;
            btnEditar.Click += btnEditar_Click;

            btnExcluir.Click -= btnExcluir_Click;
            btnExcluir.Click += btnExcluir_Click;
        }

        #region Eventos

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar?", "Clínica DDD", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                tabPage.SelectedIndex = 1;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false; // Evita múltiplos cliques
            Salvar();
            btnSalvar.Enabled = true;
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
                MessageBox.Show("Selecione algum registro!", "Clínica DDD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O nome do paciente é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!DateTime.TryParseExact(txtData.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("Formato de data inválido! Use dd/MM/yyyy", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void PreencheObjeto(Paciente paciente)
        {
            paciente.Nome = txtNome.Text;
            paciente.DataNascimento = DateTime.ParseExact(txtData.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            paciente.Endereco = txtEndereco.Text;
            paciente.Telefone = txtTelefone.Text;
            paciente.Email = txtEmail.Text;
        }

        protected override void Salvar()
        {
            Debug.WriteLine("Método Salvar() chamado");

            if (!ValidarCampos()) return;

            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var paciente = _pacienteService.GetById<Paciente>(id);
                        PreencheObjeto(paciente);
                        paciente = _pacienteService.Update<Paciente, Paciente, PacienteValidator>(paciente);
                    }
                }
                else
                {
                    // Verifica se já existe um paciente com o mesmo nome e data de nascimento
                    var existePaciente = _pacienteService
                        .Get<Paciente>()
                        .Any(p => p.Nome == txtNome.Text && p.DataNascimento == DateTime.ParseExact(txtData.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture));

                    if (existePaciente)
                    {
                        MessageBox.Show("Paciente já cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var paciente = new Paciente();
                    PreencheObjeto(paciente);
                    _pacienteService.Add<Paciente, Paciente, PacienteValidator>(paciente);
                }

                MessageBox.Show("Paciente salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                _pacienteService.Delete(id);
                MessageBox.Show("Paciente deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clínica DDD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            pacientes = _pacienteService.Get<PacienteModel>().Distinct().ToList();
            dataGridView.DataSource = null;
            dataGridView.DataSource = pacientes;
            dataGridView.Columns["Id"].Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            if (linha == null) return;

            txtId.Text = linha.Cells["Id"].Value.ToString();
            txtNome.Text = linha.Cells["Nome"].Value.ToString();
            txtData.Text = Convert.ToDateTime(linha.Cells["DataNascimento"].Value).ToString("dd/MM/yyyy");
            txtEndereco.Text = linha.Cells["Endereco"].Value.ToString();
            txtTelefone.Text = linha.Cells["Telefone"].Value.ToString();
            txtEmail.Text = linha.Cells["Email"].Value.ToString();
        }

        private void Editar()
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var linha = dataGridView.SelectedRows[0];
                CarregaRegistro(linha);
            }
            else
            {
                MessageBox.Show("Selecione um paciente para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
