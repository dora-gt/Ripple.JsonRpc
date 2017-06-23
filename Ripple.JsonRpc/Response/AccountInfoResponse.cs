using System;

using Newtonsoft.Json;

namespace Ripple.JsonRpc.Response
{
    public class AccountInfoResponse : ResponseBase
    {
        public class AccountRoot
        {
            [JsonProperty("Account")]
            public string Account { get; set; }
            [JsonProperty("Balance")]
            public string Balance { get; set; }
            [JsonProperty("Flags")]
            public int Flags { get; set; }
        }

        [JsonProperty("account_data")]
        public AccountRoot AccountData { get; set; }
        [JsonProperty("ledger_current_index")]
        public int LedgerCurrentIndex { get; set; }
        [JsonProperty("ledger_index")]
        public int LedgerIndex { get; set; }
        [JsonProperty("queue_data")]
        public object QueueData { get; set; }
        [JsonProperty("validated")]
        public bool Validated { get; set; }
    }
}
