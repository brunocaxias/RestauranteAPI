<<<<<<< HEAD
﻿using RestauranteAPI.Application.DTOs.Common;
using RestauranteAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Application.DTOs.Response
{
    public class CidadeResponseDTO : BaseDTO
    {
        public string? Nome { get; set; }
        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
=======
﻿namespace RestauranteAPI.Application.DTOs.Response
{
    public class CidadeResponseDTO : BaseDTO
    {
        public string Nome { get; set; } = string.Empty;
        public virtual ICollection<ClienteResponseDTO> Clientes { get; set; } = [];
>>>>>>> 624371678c4db7d24d90d4c257a8334cf0c67e7d
    }
}
