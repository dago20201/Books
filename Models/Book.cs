namespace books.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string titulo { get; set; }  // ✅ Cambiado a propiedad
        public string autor { get; set; }   // ✅ Cambiado a propiedad
        public int anio { get; set; }       // ✅ Cambiado a propiedad

        public Book() { }

        public Book(int p_Id, string p_titulo, string p_autor, int p_anio)
        {
            this.Id = p_Id;
            this.titulo = p_titulo;
            this.autor = p_autor;
            this.anio = p_anio;
        }
    }
}


