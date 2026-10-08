namespace Model
{
    public class Socios
    {
        public int IdSocio { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Direccion { get; set; }
        public int Dni { get; set; }
        public int IdLocalidad { get; set; }
        public string? NombreLocalidad { get; set; }
        public string? Email { get; set; }

        public static int Suma(int a, int b){
            return a + b;
        }

        public int Resta(int a, int b)
        {
            return a - b;
        }
    }
}
