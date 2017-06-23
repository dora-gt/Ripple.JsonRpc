using System;
using System.Threading.Tasks;
using Spooky.Json20;

namespace Ripple.JsonRpc
{
    public class HttpClient : IClient
    {
        private IClientConfig config { get; set; }

        private JsonRpcHttpClient client { get; set; }

        public HttpClient(IClientConfig config)
        {
            this.config = config;
            this.client = new JsonRpcHttpClient(this.config.Endpoint);
        }

        public async Task<T> InvokeAsync<T>(IRequest request)
        {
            return await this.client.Invoke<T>(request.Method, new object[] { request.Parameters }).ConfigureAwait(false);
        }
    }
}
