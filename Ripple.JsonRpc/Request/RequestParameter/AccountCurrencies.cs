using System;

using Newtonsoft.Json;

namespace Ripple.JsonRpc.Request.RequestParameter
{
    public class AccountCurrencies : IRequestParameter
    {
        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("strict")]
        public bool? Strict { get; set; }

        [JsonProperty("ledger_hash")]
        public string LedgerHash { get; set; }

        [JsonProperty("ledger_index")]
        public uint? LedgerIndex { get; set; }
    }
}
