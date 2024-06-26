namespace Encapsulacion
{
    public class Persona
    {
        //Atributos
        public string nombre = string.Empty;
        public DateTime fechaNacimiento;
        private int edad;
        //Métodos
        public void registrar()
        {
            calcularEdad(fechaNacimiento);
            Console.WriteLine(nombre + " con " + edad + " años de edad, ha sido registrado correctamente");
        }
        private void calcularEdad(DateTime fechaNacimientoPersona)
        {
            DateTime fechaActual = DateTime.Now;
            edad = fechaActual.Year - fechaNacimientoPersona.Year;
        }
        static void Main(string[] args)
        {
            Persona alumno = new Persona();
            alumno.nombre = "Roger";
            alumno.fechaNacimiento = Convert.ToDateTime("10/10/1996");
            alumno.registrar();

            Console.WriteLine();
        }
    }
}
