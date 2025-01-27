using App.Base;
using App.Models;
using Domain.Base;
using Domain.Entities;
using Service.Validators;

namespace App.Cadastro
{
    public partial class CadastroPaciente : CadastroBase
    {
        // Serviços injetados para gerenciar Pacientes e Cidades
        private readonly IBaseService<Paciente> _pacienteService;

        // Lista para armazenar os modelos de Paciente
        private List<PacienteModel>? pacientes;

        // Construtor que recebe os serviços via injeção de dependência
        public CadastroPaciente(IBaseService<Paciente> pacienteService)
        {
            _pacienteService = pacienteService;
            InitializeComponent();
            //CarregarCombo();
        }

        /// <summary>
        /// Carrega as cidades no ComboBox para seleção.
        /// </summary>

        /// <summary>
        /// Preenche o objeto Paciente com os dados do formulário.
        /// </summary>
        /// <param name="paciente">Objeto Paciente a ser preenchido.</param>
        private void PreencheObjeto(Paciente paciente)
        {
            paciente.Nome = txtNome.Text;

            // Aqui, converta o valor de txtDataNascimento.Text para DateTime antes de atribuir
            if (DateTime.TryParse(txtDataNascimento.Text, out var dataNascimento))
            {
                paciente.DataNascimento = dataNascimento;
            }
            else
            {
                // Caso a conversão falhe, você pode optar por definir um valor padrão ou lançar uma exceção
                MessageBox.Show("Data de nascimento inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            paciente.Endereco = txtEndereço.Text;
            paciente.Telefone = txtTelefone.Text;
        }

        /// <summary>
        /// Salva ou atualiza um Paciente no sistema.
        /// </summary>
        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(IDPAciente.Text, out var id))
                    {
                        var paciente = _pacienteService.GetById<Paciente>(id);
                        PreencheObjeto(paciente);
                        _pacienteService.Update<Paciente, Paciente, PacienteValidator>(paciente);
                    }
                }
                else
                {
                    var paciente = new Paciente();
                    PreencheObjeto(paciente);
                    _pacienteService.Add<Paciente, Paciente, PacienteValidator>(paciente);
                }

                // Para alterar para a aba de consulta
                materialTabControl.SelectedIndex = 1; // Muda para a aba de consulta
                                                      // Navega para a aba de consulta
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"ClinicaApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Deleta um Paciente com base no ID fornecido.
        /// </summary>
        /// <param name="id">ID do Paciente a ser deletado.</param>
        protected override void Deletar(int id)
        {
            try
            {
                _pacienteService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"ClinicaApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Carrega os dados dos Pacientes no DataGridView.
        /// </summary>
        protected override void CarregaGrid()
        {
            // pacientes = _pacienteService.Get<PacienteModel>(new[] { "Cidade" }).ToList();
            dataGridViewConsulta.DataSource = pacientes;
            //poisonDataGridView1.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //poisonDataGridView1.Columns["IdCidade"]!.Visible = false;
            //poisonDataGridView1.Columns["CidadeNome"]!.HeaderText = "Cidade";
        }

        /// <summary>
        /// Carrega os dados de um registro selecionado no formulário.
        /// </summary>
        /// <param name="linha">Linha do DataGridView selecionada.</param>
        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            IDPAciente.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();

            // Converte o valor para DateTime e atribui à caixa de texto
            txtDataNascimento.Text = Convert.ToDateTime(linha?.Cells["DataNascimento"].Value).ToString("dd/MM/yyyy");

            txtEndereço.Text = linha?.Cells["Endereco"].Value.ToString();
            txtTelefone.Text = linha?.Cells["Telefone"].Value.ToString();
            //cboCidade.SelectedValue = linha?.Cells["IdCidade"].Value;
        }
    }
}
