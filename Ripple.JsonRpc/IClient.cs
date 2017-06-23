using System;
using System.Threading.Tasks;

namespace Ripple.JsonRpc
{
    public interface IClient
    {
        Task<T> InvokeAsync<T>(IRequest request);
    }
}
