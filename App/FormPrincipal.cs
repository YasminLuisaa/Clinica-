using App.Cadastro;
using App.Infra;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace App
{
    public partial class FormPrincipal : MaterialForm
    {

        public FormPrincipal()
        {
            InitializeComponent();
        }


        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroPaciente>();
        }

        private void médicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroMedico>();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroConsulta>();
        }

        private void especialidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroEspecialidade>();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ExibeFormulario<TFormulario>() where TFormulario : Form
        {
            foreach (Form openForm in MdiChildren)
            {
                openForm.Close();
            }

            var cad = ConfigureDI.ServicesProvider!.GetService<TFormulario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }

    }
}