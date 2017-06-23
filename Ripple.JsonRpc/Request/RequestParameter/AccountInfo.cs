using System;

using Newtonsoft.Json;

namespace Ripple.JsonRpc.Request.RequestParameter
{
    public class AccountInfo : IRequestParameter
    {
        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("strict")]
        public bool? Strict { get; set; }

        [JsonProperty("ledger_hash")]
        public string LedgerHash { get; set; }

        [JsonProperty("ledger_index")]
        public uint? LedgerIndex { get; set; }

        [JsonProperty("queue")]
        public bool? Queue { get; set; }

        [JsonProperty("signerLists")]
        public bool? SignerLists { get; set; }
    }
}
