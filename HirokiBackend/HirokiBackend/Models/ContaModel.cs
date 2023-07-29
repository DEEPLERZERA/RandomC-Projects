namespace HirokiBackend.Models
{
    public class ContaModel
    {
        public int id { get; set; }
        public int accountNumber { get; set; }

        public int balance { get; set; }

        public string accountType { get; set; }

        public int openedDate { get; set; }

        public int userId { get; set; }

        public virtual UsuarioModel? user { get; set; }

    }
}
