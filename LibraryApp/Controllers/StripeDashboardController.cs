using LibraryApp.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Controllers
{
    public class StripeDashboardController : Controller
    {
        public IActionResult Index()
        {
            var response = new StripeDashboardVM();
            var balanceService = new BalanceService();
            var balanceResult = balanceService.Get();

            response.Balance = balanceResult;

            var transactionService = new BalanceTransactionService();
            var transactionResult = transactionService.List().ToList();

            response.Transactions = transactionResult;

            var customerService = new CustomerService();

            var customerResult = customerService.List().ToList();

            response.Customers = customerResult;

            var chargeService = new ChargeService();
            var chargeResult = chargeService.List().ToList();
            response.Charges = chargeResult;


            var disputeService = new DisputeService();

            var disputeResult = disputeService.List().ToList();

            response.Disputes = disputeResult;

            var refundService = new RefundService();
            var refundResult = refundService.List().ToList();
            response.Charges = chargeResult;

            var productsService = new ProductService();
            var productsResult = productsService.List().ToList();
            response.Products = productsResult;

            return View(response);
        }
    }
}
