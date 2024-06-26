using ReproductorMultimedia;
class Program
{
    static void Main()
    {
        // Crear una lista de elementos multimedia
        List<Multimedia> biblioteca = new List<Multimedia>();

        // Agregar canciones a la biblioteca
        Cancion cancion1 = new Cancion(1, "Ella y Yo", "Don Omar ft. Aventura ", 4.30);
        Cancion cancion2 = new Cancion(2, "Amor Prohibido", "Selena", 3.54);
        Cancion cancion3 = new Cancion(3, "La Incondicional", "Luis Miguel", 4.44);
        biblioteca.Add(cancion1);
        biblioteca.Add(cancion2);
        biblioteca.Add(cancion3);


        bool reproducirOtra = true;
        int indiceCancion = 0;

        while (reproducirOtra && indiceCancion < biblioteca.Count)
        {
            Multimedia elemento = biblioteca[indiceCancion];

            if (elemento is IReproducible reproducible)
            {
                reproducible.Reproducir();
                reproducible.DetenerReproduccion();
            }

            Console.WriteLine("¿Desea reproducir otra canción? (s/n)");
            string? respuesta = Console.ReadLine(); ;

            if (string.IsNullOrEmpty(respuesta) || respuesta.ToLower() != "s")
            {
                reproducirOtra = false;
            }
            else
            {
                indiceCancion++;
            }
        }
    }
}