<<<<<<< HEAD
﻿using RestauranteAPI.Application.DTOs.Common;
using RestauranteAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
﻿using RestauranteAPI.Domain.Entities;
>>>>>>> 624371678c4db7d24d90d4c257a8334cf0c67e7d

namespace RestauranteAPI.Application.DTOs.Response
{
    public class ClienteResponseDTO : BaseDTO
    {
<<<<<<< HEAD
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? Cpf { get; set; }
        public Cidade? Cidade { get; set; }
        public List<Pedido> Pedidos { get; set; } = [];
=======
        public string Nome { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public virtual Cidade? Cidade { get; set; }
        public virtual ICollection<PedidoResponseDTO> Pedidos { get; set; } = [];
>>>>>>> 624371678c4db7d24d90d4c257a8334cf0c67e7d
    }
}
