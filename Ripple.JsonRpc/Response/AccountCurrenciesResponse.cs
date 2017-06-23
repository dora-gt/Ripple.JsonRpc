using System;

using Newtonsoft.Json;

namespace Ripple.JsonRpc.Response
{
    public class AccountCurrenciesResponse : ResponseBase
    {
		[JsonProperty("ledger_hash")]
		public string LedgerHash { get; set; }
		[JsonProperty("ledger_index")]
		public int LedgerIndex { get; set; }
        [JsonProperty("receive_currencies")]
        public string[] ReceiveCurrencies { get; set; }
		[JsonProperty("send_currencies")]
		public string[] SendCurrencies { get; set; }
		[JsonProperty("validated")]
		public bool Validated { get; set; }
    }
}
