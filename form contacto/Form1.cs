namespace form_contacto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            //validar nombre
            string nombre = txtnombre.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Por favor, ingrese su nombre.");
                return;
            }
            //validar que selecciono un motivo
            string motivo = "";
            if (rdconsulta.Checked)
            {
                motivo = "Consulta";

            }
            else if (rdqueja.Checked)
            {
                motivo = "queja";
            }
            else if (rdsugerencia.Checked)
            {
                motivo = "Sugerencia";
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un motivo de contacto.");
                return;
            }
            //ver la opcion de checkbox y la confirmacion de envio
            string detallerespuesta = chkdeseo.Checked ? " (daremos solucion)" : "(no daremos solucion)";
            // ver mensaje en txtconfirmacion
            txtconfirmacion.Text = $"Gracias {nombre} por su {motivo}{detallerespuesta }";
        }

        private void linkpolitica_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // muestra politica de privacidad mediante messagebox
            MessageBox.Show(
                "tus datos personales estan protegidos y solo se utilizaran parra gestionar tu consulta, queja o sugerencia.",
                "Politica de privacidad",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }
    }
}
