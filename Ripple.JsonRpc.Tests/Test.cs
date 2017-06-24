using NUnit.Framework;
using System;
using System.Threading.Tasks;

using Ripple.JsonRpc;
using Ripple.JsonRpc.Request;
using Ripple.JsonRpc.Response;

namespace Ripple.JsonRpc.Tests
{
    /// <summary>
    /// テストになってないです。
    /// ただ実行するだけのサンプルです。
    /// 良い子は真似しないでね。
    /// </summary>
    [TestFixture()]
    public class Test
    {
        // General purpose server
        private static readonly string uriStringS1 = "http://s1.ripple.com:51234";
        // Full-history server
        private static readonly string uriStringS2 = "http://s2.ripple.com:51234";
        // Sample Account
        private static readonly string account = "r9cZA1mLK5R5Am25ArfXFmqgNwjZgnfk59";

        private HttpClient client;

        [TestFixtureSetUp]
        public void SetUp()
        {
            ClientConfig config = new ClientConfig(new Uri(uriStringS2));
            this.client = new HttpClient(config);
        }

        [Test()]
        public void AccountInfoTest()
        {
            AccountInfoRequest request = new AccountInfoRequest(account);
            Task<AccountInfoResponse> task = request.InvokeAsync(this.client);
            task.Wait();
            AccountInfoResponse response = task.Result;

            Console.WriteLine($"Balance: {response.AccountData.Balance}");

            Assert.IsTrue(response.IsSuccess);
        }

        [Test()]
        public void AccountCurrenciesTest()
        {
            AccountCurrenciesRequest request = new AccountCurrenciesRequest(account);
            Task<AccountCurrenciesResponse> task = request.InvokeAsync(client);
            task.Wait();
            AccountCurrenciesResponse response = task.Result;

            Console.WriteLine($"Send Currency");
            foreach (string currency in response.SendCurrencies)
            {
                Console.WriteLine($"\tCurrency: {currency}");
            }

            Console.WriteLine($"Receive Currency");
            foreach (string currency in response.ReceiveCurrencies)
            {
                Console.WriteLine($"\tCurrency: {currency}");
            }

            Assert.IsTrue(response.IsSuccess);
        }
    }
}
