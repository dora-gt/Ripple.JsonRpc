using System;

namespace Ripple.JsonRpc
{
    public interface IClientConfig
    {
        Uri Endpoint { get; }
    }
}
