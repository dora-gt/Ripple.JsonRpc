using System;
using System.Collections;
using System.Collections.Generic;

using Ripple.JsonRpc.Request;

namespace Ripple.JsonRpc
{
    public interface IRequest
    {
        string Method { get; }

        IRequestParameter Parameters { get; }
    }
}
