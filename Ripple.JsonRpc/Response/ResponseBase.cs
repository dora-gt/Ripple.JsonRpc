using System;
namespace Ripple.JsonRpc.Response
{
    public abstract class ResponseBase : IResponse
    {
        public ResponseStatus Status { get; set; }

        public bool IsSuccess
        {
            get
            {
                return this.Status == ResponseStatus.success;
            }
        }

        public bool IsError
        {
            get
            {
                return this.Status == ResponseStatus.error;
            }
        }
    }
}
