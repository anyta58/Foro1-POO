namespace Abstraccion
{
    public abstract class FiguraGeometrica
    {
        public abstract double CalcularArea();
    }
    public class Cuadrado : FiguraGeometrica
    {
        private double lado;
        public Cuadrado(double lado)
        {
            this.lado = lado;
        }
        public override double CalcularArea()
        {
            return lado * lado;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cuadrado cuadrado = new Cuadrado(7);
            Console.WriteLine($"Área del cuadrado: {cuadrado.CalcularArea()}");
        }
    }
}