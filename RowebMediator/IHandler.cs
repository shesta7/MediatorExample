using System;
using System.Threading;
using System.Threading.Tasks;

namespace RowebMediator
{
	public interface IHandler<TRequest, TResponse> where TRequest: IRequest<TResponse>
    {
		public Task<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken);
	}
}

