using System;

using System.Threading.Tasks;

namespace Ripple.JsonRpc.Request
{
    public abstract class RequestBase<T> : IRequest
    {
        public abstract string Method { get; }

        public IRequestParameter Parameters { get; protected set; }

        public async virtual Task<T> InvokeAsync(IClient client)
        {
            return await client.InvokeAsync<T>(this);
        }
    }
}
