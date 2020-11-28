using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Braintree;
using LibraryApp.Data.Services;
using LibraryApp.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Stripe;

namespace LibraryApp.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly IBookService _courseService;
        private readonly IBraintreeService _braintreeService;

        public CheckoutController(IBookService courseService, IBraintreeService braintreeService)
        {
            _courseService = courseService;
            this._braintreeService = braintreeService;
        }

        public IActionResult Purchase(Guid id)
        {

            var book = _courseService.GetById(id);
            if (book == null) return NotFound();

            var gateway = _braintreeService.CreateGateway();

            var clientToken = gateway.ClientToken.Generate();

            ViewBag.ClientToken = clientToken;

            ViewBag.PurchaseAmount = book.Price;
            var data = new BookPurchaseVM
            {
                Id = book.Id,
                Description = book.Description,
                Author = book.Author,
                Thumbnail = book.Thumbnail,
                Title = book.Title,
                Price = book.Price,
                Nonce = ""
            };

            return View(data);
        }


        public IActionResult Create(BookPurchaseVM model)
        {
            var gateway = _braintreeService.GetGateway();

            var book = _courseService.GetById(model.Id);

            var request = new TransactionRequest()
            {
                Amount = Convert.ToDecimal(book.Price),
                PaymentMethodNonce = model.Nonce,
                Options = new TransactionOptionsRequest()
                {
                    SubmitForSettlement = true
                }
            };

            Result<Transaction> result = gateway.Transaction.Sale(request);

            if (result.IsSuccess())
                return View("Success");
            else
                return View("Failure");
        }

        public IActionResult BraintreePlans()
        {
            var gateway = _braintreeService.GetGateway();
            var plans = gateway.Plan.All();

            return
                View(plans);
        }

        public IActionResult SubscriptionPlan(string id)
        {
            var gateway = _braintreeService.GetGateway();


            var Subscriptionrequest = new SubscriptionRequest()
            {
              PaymentMethodToken= "My-Paymen-Token-Value",
              PlanId=id
            };

            Result<Braintree.Subscription> result = gateway.Subscription.Create(Subscriptionrequest);

            if (result.IsSuccess())
                return View("Subscribed");
            else
                return View("FailSub");
        }



        //Scripe


        public IActionResult PurchaseWithScripe(Guid id)
        {

            var book = _courseService.GetById(id);
            if (book == null) return NotFound();

            var gateway = _braintreeService.CreateGateway();

            var clientToken = gateway.ClientToken.Generate();

            ViewBag.ClientToken = clientToken;

            ViewBag.PurchaseAmount = book.Price;
            var data = new BookPurchaseVM
            {
                Id = book.Id,
                Description = book.Description,
                Author = book.Author,
                Thumbnail = book.Thumbnail,
                Title = book.Title,
                Price = book.Price,
                Nonce = ""
            };

            return View(data);
        }



        public IActionResult CreateStripe(string stripeToken, Guid id)
        {
            var book = _courseService.GetById(id);

            var chargeOptions = new ChargeCreateOptions()
            {
                Amount = (long)(Convert.ToDouble(book.Price) * 100),
                Currency = "Usd",
                Source = stripeToken,

                // if you want to add meta data then, otherwise its enought

                Metadata = new Dictionary<string, string>()
                {
                    { "BookId", book.Id.ToString()},
                    {"BookTitle",book.Title },
                    {"BookAuthor",book.Author }
                }
            };

            var service = new ChargeService();

            Charge charge = service.Create(chargeOptions);

            if (charge.Status == "succeeded")
                return View("Success");
            else
                return View("Failure");
        }
    }
}