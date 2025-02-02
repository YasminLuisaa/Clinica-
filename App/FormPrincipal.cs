using App.Cadastros;
using App.Infra;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace App
{
    public partial class FormPrincipal : MaterialForm
    {
        
        

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Exibeformulario<TFormlario>() where TFormlario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormlario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void ConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroConsulta>();
        }

        private void MedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroMedico>();
        }

        private void PacienteStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroPaciente>();
        }

        private void PagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroPagamento>();
        }

        private void ProntuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroProntuarioMedico>();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
