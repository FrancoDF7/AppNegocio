using AppNegocio.Vista.Utilidades;

namespace AppNegocio.Vista
{
    public partial class formGestionUsuarios : Form
    {
        public formGestionUsuarios()
        {
            InitializeComponent();
        }

        AutoResizeForm auto = new AutoResizeForm();

        private void btnCambiarImagen_Click(object sender, EventArgs e)
        {



        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            auto.EscalarFormulario(this);
        }

        private void GestionUsuarios_Resize(object sender, EventArgs e)
        {
            auto.RedimensionarFormulario(this);
        }

    }
}
