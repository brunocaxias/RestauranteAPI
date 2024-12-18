using RestauranteAPI.Domain.Common;
using RestauranteAPI.Domain.Enums;
using RestauranteAPI.Domain.Validation;

namespace RestauranteAPI.Domain.Entities
{
    public class Pedido : BaseEntity
    {
        public DateTimeOffset Data { get; set; }
        public decimal Valor { get; set; }
        public Guid PedidoClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        public EstadoPedido EstadoPedido { get; set; }

        public Pedido(DateTimeOffset data, decimal valor, Guid pedidoClienteId)
        {
            var validationErrors = PedidoValidator(data, valor, pedidoClienteId);

            if (validationErrors.Count > 0)
            {
                throw new DomainValidationException(validationErrors);
            }

            Data = data;
            Valor = valor;
            PedidoClienteId = pedidoClienteId;
        }

        private List<string> PedidoValidator(DateTimeOffset data, decimal valor, Guid pedidoClienteId)
        {
            var errors = new List<string>();

            if (data == default)
            {
                errors.Add("O campo Data de Pedido é obrigatório");
            }
            if (valor == default)
            {
                errors.Add("O campo Valor de Pedido é obrigatório");
            }
            if (valor <= 0)
            {
                errors.Add("O campo Valor de Pedido não pode ser negativo");
            }
            if (pedidoClienteId == Guid.Empty)
            {
                errors.Add("O Id de cliente em Pedido não pode ser vazio");
            }


            return errors;
        }
    }
}
