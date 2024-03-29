﻿using MediatR;

namespace MicroAdvocate.CQRS.Queries
{
    public interface IQueryHandler<in TRequest, TResponse> : IRequestHandler<TRequest, TResponse> where TRequest: IQuery<TResponse>
    {
    }
}