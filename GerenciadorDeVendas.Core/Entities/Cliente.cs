namespace GerenciadorDeVendas.Entities
{
    public class Cliente
    {
        public Cliente(int clientId, string nome, string email, string telefone)
        {
            ClientId = clientId;
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }

        public int ClientId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        // Relacionamento com pedido
        public ICollection<Pedido> Pedidos { get; set;}
    }
}
