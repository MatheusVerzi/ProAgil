namespace ProAgil.WebAPI.Models
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string Tema { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }
        public int QtdPessoa { get; set; }
        public string Lote { get; set; }
    }
}