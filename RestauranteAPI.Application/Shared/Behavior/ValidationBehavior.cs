﻿using FluentValidation;
using MediatR;
using RestauranteAPI.Domain.Common;

namespace RestauranteAPI.Application.Shared.Behavior
{
    public sealed class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
        where TResponse : Result, new()
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public async Task<TResponse> Handle(TRequest request,
                                     RequestHandlerDelegate<TResponse> next,
                                     CancellationToken cancellationToken)
        {
            if (_validators.Any())
            {
                var context = new ValidationContext<TRequest>(request);

                var validationResults = await Task.WhenAll(_validators.Select(v => v.ValidateAsync(context, cancellationToken)));

                var failures = validationResults.SelectMany(r => r.Errors).Where(f => f != null).ToList();


                if (failures.Count != 0)
                {
                    var result = new TResponse();

                    foreach (var error in failures)
                    {
                        result.AddError($"{error.PropertyName}: {error.ErrorMessage}");
                    }
                    return result;
                }
            }

            return await next();
        }
    }
}