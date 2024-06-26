class Animal
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public Animal(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }
    public void Comer()
    {
        Console.WriteLine($"{Nombre} está comiendo.");
    }
}
class Perro : Animal
{
    public string Raza { get; set; }
    public Perro(string nombre, int edad, string raza) : base(nombre, edad)
    {
        Raza = raza;
    }
    public void Ladrar()
    {
        Console.WriteLine($"{Nombre} está ladrando.");
    }
}
class Program
{
    static void Main()
    {
        Perro miPerro = new Perro("Max", 5, "Labrador");

        Console.WriteLine($"Nombre: {miPerro.Nombre}, Edad: {miPerro.Edad}, Raza: {miPerro.Raza}");
        miPerro.Comer();
        miPerro.Ladrar();
    }
}