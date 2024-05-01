namespace EstudoDTO.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public required string Titulo { get; set; }
        public int Ano { get; set; }
        public decimal Preco { get; set; }
        public required string Genero { get; set; }

        // Foreign Key
        public int AutorId { get; set; }
        // Navigation property
        public required Autor Autor { get; set; }
    }
}
