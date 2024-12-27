using AutoMapper;
using MediatR;
using RestauranteAPI.Application.DTOs.Common;
using RestauranteAPI.Application.Interfaces;
using RestauranteAPI.Domain.Common;
using RestauranteAPI.Domain.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Application.UseCases.BaseCase
{
    public class CreateHandler<IService, CreateCommand, Request, Response, Entity> : IRequestHandler<CreateCommand, ApiResponse>
        where Entity : BaseEntity
        where Response: BaseDTO
        where CreateCommand : IRequest<ApiResponse>
        where Request : IRequest<ApiResponse>
        where IService : IBaseService<Request, Response, Entity>
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IService _service;
        protected readonly IMapper _mapper;

        public CreateHandler(IUnitOfWork unitOfWork, IService service, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _service = service;
            _mapper = mapper;
        }

        public async Task<ApiResponse> Handle(CreateCommand createCommand, CancellationToken cancellationToken)
        {
            var request = _mapper.Map<Request>(createCommand);
            var response = await _service.Create(request, cancellationToken);
            await _unitOfWork.Commit(cancellationToken);
            return response;
        }
    }
}
