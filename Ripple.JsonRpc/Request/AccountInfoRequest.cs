using Ripple.JsonRpc.Response;
using Ripple.JsonRpc.Request.RequestParameter;

namespace Ripple.JsonRpc.Request
{
    public class AccountInfoRequest : RequestBase<AccountInfoResponse>
    {
        private static readonly string methodName = "account_info";

        public override string Method { get { return methodName; } }

        public AccountInfoRequest(string account, bool? strict = null,
                              string ledgerHash = null, uint? ledgerIndex = null,
                              bool? queue = null, bool? signerLists = null)
        {
            AccountInfo accountInfo = new AccountInfo()
            {
                Account = account,
                Strict = strict,
                LedgerHash = ledgerHash,
                LedgerIndex = ledgerIndex,
                Queue = queue,
                SignerLists = signerLists,
            };
            this.Parameters = accountInfo;
        }
    }
}