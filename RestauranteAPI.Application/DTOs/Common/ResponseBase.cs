using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Application.DTOs.Common
{
    public class ResponseBase
    {
        public int StatusCode { get; set; } = 200;

        public ResponseBase()
        {
        }

        public ResponseBase(int statusCode)
        {
            StatusCode = statusCode;
        }
    }
}
