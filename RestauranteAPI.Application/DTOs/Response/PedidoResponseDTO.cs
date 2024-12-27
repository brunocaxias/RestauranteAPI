<<<<<<< HEAD
﻿using RestauranteAPI.Application.DTOs.Common;
using RestauranteAPI.Domain.Entities;
using RestauranteAPI.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
﻿using RestauranteAPI.Domain.Enums;
>>>>>>> 624371678c4db7d24d90d4c257a8334cf0c67e7d

namespace RestauranteAPI.Application.DTOs.Response
{
    public class PedidoResponseDTO : BaseDTO
    {
        public DateTimeOffset Data { get; set; }
        public decimal Valor { get; set; }
<<<<<<< HEAD
        public Guid PedidoClienteId { get; set; }
        public Cliente? Cliente { get; set; }
=======
        public ClienteResponseDTO? Cliente { get; set; }
>>>>>>> 624371678c4db7d24d90d4c257a8334cf0c67e7d
        public EstadoPedido EstadoPedido { get; set; }
    }
}
