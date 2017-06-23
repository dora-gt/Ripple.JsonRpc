using System;
namespace Ripple.JsonRpc
{
    public class ClientConfig : IClientConfig
    {
        public Uri Endpoint { get; private set; }

        public ClientConfig(Uri endpoint)
        {
            this.Endpoint = endpoint;
        }
    }
}
