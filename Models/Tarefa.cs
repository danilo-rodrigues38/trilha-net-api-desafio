namespace TrilhaApiDesafio.Models
{
    public class Tarefa : Entity
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public EnumStatusTarefa Status { get; set; }
    }
}