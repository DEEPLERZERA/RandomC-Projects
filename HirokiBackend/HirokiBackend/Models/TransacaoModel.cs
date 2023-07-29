namespace HirokiBackend.Models
{
    public class TransacaoModel
    {
        public int id { get; set; }

        public int accountId { get; set; }

        public string transactionType { get; set; }

        public int amount { get; set; }

        public int date { get; set; }

        public int otherAccount { get; set; }

        public virtual ContaModel? account { get; set; }

    }
}
