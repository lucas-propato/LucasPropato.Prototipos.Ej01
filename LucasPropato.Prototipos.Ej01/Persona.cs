namespace LucasPropato.Prototipos.Ej01
{
    internal class Persona
    {
        public Persona()
        {
        }

        public int Dni { get; internal set; }
        public string Nombre { get; internal set; }
        public string Apellido { get; internal set; }
        public DateTime FechaNacimiento { get; internal set; }

        internal string Validar()
        {
            if(Dni < 1_000_000 || Dni > 99_999_999)
            {
                return "El DNI debe tener entre 7 y 8 dígitos."; // El mensaje de error es el reverso del if.
            }

            if(string.IsNullOrWhiteSpace(Nombre))
            {
                return "El nombre es requerido.";
            }

            if(Nombre.Length > 50)
            {
                return "El nombre debe tener menos de 50 caractéres.";
            }

            if (string.IsNullOrWhiteSpace(Apellido))
            {
                return "El apellido es requerido.";
            }

            if (Nombre.Length > 50)
            {
                return "El apellido debe tener menos de 50 caractéres.";
            }

            // etc...

            return null;
        }
}