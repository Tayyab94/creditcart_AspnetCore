#pragma checksum "C:\Users\AdminSSD\Desktop\Gatway\LibraryApp\LibraryApp\Views\StripeDashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4d18ae1fa321b7d6e8df475ead7d978ccc021e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StripeDashboard_Index), @"mvc.1.0.view", @"/Views/StripeDashboard/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\AdminSSD\Desktop\Gatway\LibraryApp\LibraryApp\Views\_ViewImports.cshtml"
using LibraryApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AdminSSD\Desktop\Gatway\LibraryApp\LibraryApp\Views\_ViewImports.cshtml"
using LibraryApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\AdminSSD\Desktop\Gatway\LibraryApp\LibraryApp\Views\StripeDashboard\Index.cshtml"
using LibraryApp.Data.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4d18ae1fa321b7d6e8df475ead7d978ccc021e3", @"/Views/StripeDashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4d938fd633361b29333d6c38f61b28eb71ba8ab", @"/Views/_ViewImports.cshtml")]
    public class Views_StripeDashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StripeDashboardVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\AdminSSD\Desktop\Gatway\LibraryApp\LibraryApp\Views\StripeDashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Stripe Overview</h1>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <h4>Available Credit: $");
#nullable restore
#line 12 "C:\Users\AdminSSD\Desktop\Gatway\LibraryApp\LibraryApp\Views\StripeDashboard\Index.cshtml"
                          Write(string.Format("{0:#.00}", Convert.ToDecimal(Model.Balance.Available.Sum(s => s.Amount)) / 100));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        <h4>Pending Credit $");
#nullable restore
#line 15 "C:\Users\AdminSSD\Desktop\Gatway\LibraryApp\LibraryApp\Views\StripeDashboard\Index.cshtml"
                       Write(string.Format("{0:#.00}", Convert.ToDecimal(Model.Balance.Pending.Sum(s => s.Amount)) / 100));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
    </div>
</div>

<div class=""table"">
    <table class=""table-responsive"">
        <thead>
            <tr>
                <th>Type</th>
                <th>Status</th>
                <th>Amount</th>
                <th>Created</th>
                <th>Available On</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 31 "C:\Users\AdminSSD\Desktop\Gatway\LibraryApp\LibraryApp\Views\StripeDashboard\Index.cshtml"
             foreach (var item in Model.Transactions)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\AdminSSD\Desktop\Gatway\LibraryApp\LibraryApp\Views\StripeDashboard\Index.cshtml"
                   Write(item.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\AdminSSD\Desktop\Gatway\LibraryApp\LibraryApp\Views\StripeDashboard\Index.cshtml"
                   Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>$");
#nullable restore
#line 36 "C:\Users\AdminSSD\Desktop\Gatway\LibraryApp\LibraryApp\Views\StripeDashboard\Index.cshtml"
                    Write(string.Format("{0:#.00}", Convert.ToDecimal(item.Amount) / 100));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "C:\Users\AdminSSD\Desktop\Gatway\LibraryApp\LibraryApp\Views\StripeDashboard\Index.cshtml"
                   Write(item.Created);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "C:\Users\AdminSSD\Desktop\Gatway\LibraryApp\LibraryApp\Views\StripeDashboard\Index.cshtml"
                   Write(item.AvailableOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 40 "C:\Users\AdminSSD\Desktop\Gatway\LibraryApp\LibraryApp\Views\StripeDashboard\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </tbody>
    </table>
</div>

<hr />
<h3>Service Customer</h3>
<div class=""table"">
    <table class=""table-responsive"">
        <thead>
            <tr>
                <th>Name</th>
                <th>phone</th>
                <th>Amount</th>
                <th>ID</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 59 "C:\Users\AdminSSD\Desktop\Gatway\LibraryApp\LibraryApp\Views\StripeDashboard\Index.cshtml"
             foreach (var customer in Model.Customers)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 62 "C:\Users\AdminSSD\Desktop\Gatway\LibraryApp\LibraryApp\Views\StripeDashboard\Index.cshtml"
                   Write(customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 63 "C:\Users\AdminSSD\Desktop\Gatway\LibraryApp\LibraryApp\Views\StripeDashboard\Index.cshtml"
                   Write(customer.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>$");
#nullable restore
#line 64 "C:\Users\AdminSSD\Desktop\Gatway\LibraryApp\LibraryApp\Views\StripeDashboard\Index.cshtml"
                    Write(string.Format("{0:#.00}", Convert.ToDecimal(customer.Balance) / 100));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 65 "C:\Users\AdminSSD\Desktop\Gatway\LibraryApp\LibraryApp\Views\StripeDashboard\Index.cshtml"
                   Write(customer.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 67 "C:\Users\AdminSSD\Desktop\Gatway\LibraryApp\LibraryApp\Views\StripeDashboard\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </tbody>
    </table>
</div>
<hr />
<h3>Service Charges</h3>
<div class=""table"">
    <table class=""table-responsive"">
        <thead>
            <tr>
                <th>Amount</th>
                <th>Source</th>
                <th>Receipt Email</th>
                <th>Receipt No</th>
                <th>Receipt Url</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 86 "C:\Users\AdminSSD\Desktop\Gatway\LibraryApp\LibraryApp\Views\StripeDashboard\Index.cshtml"
             foreach (var charge in Model.Charges)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>$");
#nullable restore
#line 89 "C:\Users\AdminSSD\Desktop\Gatway\LibraryApp\LibraryApp\Views\StripeDashboard\Index.cshtml"
                Write(string.Format("{0:#.00}", Convert.ToDecimal(charge.Amount) / 100));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 90 "C:\Users\AdminSSD\Desktop\Gatway\LibraryApp\LibraryApp\Views\StripeDashboard\Index.cshtml"
               Write(charge.Source);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 91 "C:\Users\AdminSSD\Desktop\Gatway\LibraryApp\LibraryApp\Views\StripeDashboard\Index.cshtml"
               Write(charge.ReceiptEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 92 "C:\Users\AdminSSD\Desktop\Gatway\LibraryApp\LibraryApp\Views\StripeDashboard\Index.cshtml"
               Write(charge.ReceiptNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 93 "C:\Users\AdminSSD\Desktop\Gatway\LibraryApp\LibraryApp\Views\StripeDashboard\Index.cshtml"
               Write(charge.ReceiptUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 95 "C:\Users\AdminSSD\Desktop\Gatway\LibraryApp\LibraryApp\Views\StripeDashboard\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StripeDashboardVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
