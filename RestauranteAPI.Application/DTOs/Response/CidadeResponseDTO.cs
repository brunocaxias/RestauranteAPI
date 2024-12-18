namespace RestauranteAPI.Application.DTOs.Response
{
    public class CidadeResponseDTO : BaseDTO
    {
        public string Nome { get; set; } = string.Empty;
        public virtual ICollection<ClienteResponseDTO> Clientes { get; set; } = [];
    }
}
