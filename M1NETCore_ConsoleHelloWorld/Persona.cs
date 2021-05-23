namespace M1NETCore_ConsoleHelloWorld
{
    public class Persona
    {
        public string dni { get; set; }
        public string nombre { get; set; }
        public int telefono { get; set; }

        public Persona()
        {
        }

        public Persona(string dni, string nombre, int telefono)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.telefono = telefono;
        }
    }
}