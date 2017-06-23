using Ripple.JsonRpc.Response;
using Ripple.JsonRpc.Request.RequestParameter;

namespace Ripple.JsonRpc.Request
{
    public class AccountCurrenciesRequest : RequestBase<AccountCurrenciesResponse>
    {
        private static readonly string methodName = "account_currencies";

        public override string Method { get { return methodName; } }

        public AccountCurrenciesRequest(string account, bool? strict = null,
                              string ledgerHash = null, uint? ledgerIndex = null)
        {
            AccountCurrencies accountCurrencies = new AccountCurrencies()
            {
                Account = account,
                Strict = strict,
                LedgerHash = ledgerHash,
                LedgerIndex = ledgerIndex,
            };
            this.Parameters = accountCurrencies;
        }
    }
}