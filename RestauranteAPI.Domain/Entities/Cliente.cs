using RestauranteAPI.Domain.Common;
using RestauranteAPI.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Domain.Entities
{
    public class Cliente : BaseEntity
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public Guid ClienteCidadeId { get; set; }
        public Cidade? Cidade { get; set; }
        public List<Pedido> Pedidos { get; set; } = [];

        public Cliente(string nome, string telefone, string cpf, Guid clienteCidadeId)
        {
            var validationErrors = ClienteValidator(nome, telefone, cpf, clienteCidadeId);

            if (validationErrors.Count > 0)
            {
                throw new DomainValidationException(validationErrors);
            }
            Nome = nome;
            Telefone = telefone;
            Cpf = cpf;
            ClienteCidadeId = clienteCidadeId;
        }

        private List<string> ClienteValidator(string nome, string telefone, string cpf, Guid clienteCidadeId)
        {
            var errors = new List<string>();

            if (string.IsNullOrEmpty(nome))
            {
                errors.Add("O campo nome de Cliente é obrigatório");
            }
            if (string.IsNullOrEmpty(telefone))
            {
                errors.Add("O campo telefone de Cliente é obrigatório");

            }
            if (string.IsNullOrEmpty(cpf))
            {
                errors.Add("O campo cpf de Cliente é obrigatório");
            }
            if (clienteCidadeId == Guid.Empty)
            {
                errors.Add("O Id de cidade em Cliente não pode ser vazio");
            }

            return errors;
        }
    }
}
