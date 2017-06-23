using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ripple.JsonRpc
{
    public enum ResponseStatus
    {
        success,
        error
    }

    public interface IResponse
    {
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        ResponseStatus Status { get; set; }

        bool IsSuccess { get; }

        bool IsError { get; }
    }
}
