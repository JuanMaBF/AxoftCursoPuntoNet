namespace Entidades
{
    public class Vendedor : Persona
    {
        public string DNI { get; set; }

        public Vendedor(string nombre, string apellido, string email, string telefono, string direccion, string dni) 
            :base(nombre, apellido, email, telefono, direccion){
            DNI = dni;
        }
    }
}
