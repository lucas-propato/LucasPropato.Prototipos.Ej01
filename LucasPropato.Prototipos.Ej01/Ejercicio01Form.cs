namespace LucasPropato.Prototipos.Ej01
{
    public partial class Ejercicio01Form : Form
    {
        private readonly Ejercicio01Model modelo = new();

        public Ejercicio01Form()
        {
            InitializeComponent();
        }

        private void Ejercicio01Form_Load(object sender, EventArgs e)
        {

        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(this.txtDocumento.Text, out int dni)) // si tengo un problema
            {
                MessageBox.Show("El documento debe ser numérico."); // muestro mensaje de error diciéndole al user el problema
                return; // y me voy del método, rápido, sale afuera
            }

            if (!DateTime.TryParse(this.txtFechaNacimiento.Text, out DateTime fechaNacimiento))
            {
                MessageBox.Show("La fecha de nacimiento no es válida.");
                return;
            }


            var persona = new Persona(); // construir objeto persona
            persona.Dni = dni; // ahí cambiar name de textbox a txtDocumento
            persona.Nombre = this.txtNombre.Text;
            persona.Apellido = this.txtApellido.Text;
            persona.FechaNacimiento = fechaNacimiento;

            string error = modelo.Validar(persona); // validame esta persona y devolveme los errores
            if(error == null) // si no hay errores
            {
                MessageBox.Show("Todo OK!");
            }
            else
            {
                MessageBox.Show(error);
            }


        }
    }
}
