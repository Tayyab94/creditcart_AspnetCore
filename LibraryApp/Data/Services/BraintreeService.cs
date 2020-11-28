using Braintree;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Data.Services
{
    public class BraintreeService : IBraintreeService
    {
        private readonly IConfiguration _configuration;

        public BraintreeService(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public IBraintreeGateway CreateGateway()
        {
            var newGateway = new BraintreeGateway()
            {
                Environment = Braintree.Environment.SANDBOX,
                MerchantId = _configuration.GetValue<string>("BraintreeGateway:MerchantId"),
                PublicKey = _configuration.GetValue<string>("BraintreeGateway:PublicKey"),
                PrivateKey = _configuration.GetValue<string>("BraintreeGateway:PrivateKey")
            };

            return newGateway;
        }

        public IBraintreeGateway GetGateway()
        {
            return CreateGateway();
        }
    }
}
