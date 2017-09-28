namespace Entidades
{
    public class ClienteIndividuo : Persona
    {
        public string CUIT { get; set; }

        public ClienteIndividuo(string nombre, string apellido, string email, string telefono, string direccion, 
            string cuit) 
            : base(nombre, apellido, email, telefono, direccion)
        {
            CUIT = cuit;
        }

    }
}
