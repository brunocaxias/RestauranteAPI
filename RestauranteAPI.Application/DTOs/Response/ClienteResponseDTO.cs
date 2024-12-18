using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Application.DTOs.Response
{
    public class ClienteResponseDTO : BaseDTO
    {
        public string Nome { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public virtual Cidade? Cidade { get; set; }
        public virtual ICollection<PedidoResponseDTO> Pedidos { get; set; } = [];
    }
}
