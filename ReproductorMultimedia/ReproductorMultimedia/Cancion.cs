namespace ReproductorMultimedia
{
    public class Cancion : Multimedia, IReproducible
    {
        public string Artista { get; set; }
        public double Duracion { get; set; }

        public Cancion(int id, string nombre, string artista, double duracion)
        {
            ID = id;
            Nombre = nombre;
            Artista = artista;
            Duracion = duracion;
        }

        public void Reproducir()
        {
            Console.WriteLine($"Reproduciendo canción: {Nombre} - {Artista}");
        }

        public void DetenerReproduccion()
        {
            Console.WriteLine("Deteniendo reproducción de la canción.");
        }
    }
}