class Animal
{
    public string Nombre { get; set; }
    public Animal(string nombre)
    {
        Nombre = nombre;
    }
    public virtual void EmitirSonido()
    {
        Console.WriteLine("El animal emite un sonido.");
    }
}
class Perro : Animal
{
    public Perro(string nombre) : base(nombre)
    {
    }
    public override void EmitirSonido()
    {
        Console.WriteLine("El perro ladra: ¡Guau, guau!");
    }
}
class Gato : Animal
{
    public Gato(string nombre) : base(nombre)
    {
    }
    public override void EmitirSonido()
    {
        Console.WriteLine("El gato maulla: ¡Miau, miau!");
    }
}
class Program
{
    static void Main()
    {
        Animal animal1 = new Perro("Fido");
        Animal animal2 = new Gato("Garfield");
        animal1.EmitirSonido();
        animal2.EmitirSonido();
    }
}