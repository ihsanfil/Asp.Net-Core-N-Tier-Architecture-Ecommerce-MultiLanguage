#pragma checksum "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core-N-Tier-Architecture-Ecommerce-MultiLanguage\ShopApp.WebUI\Views\Cart\GetOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d361d3cc1badb4817149a0cbc5fbb3f2574683f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_GetOrders), @"mvc.1.0.view", @"/Views/Cart/GetOrders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/GetOrders.cshtml", typeof(AspNetCore.Views_Cart_GetOrders))]
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
#line 1 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core-N-Tier-Architecture-Ecommerce-MultiLanguage\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.Entities;

#line default
#line hidden
#line 2 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core-N-Tier-Architecture-Ecommerce-MultiLanguage\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Extensions;

#line default
#line hidden
#line 3 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core-N-Tier-Architecture-Ecommerce-MultiLanguage\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d361d3cc1badb4817149a0cbc5fbb3f2574683f", @"/Views/Cart/GetOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bba9d18e6cd03824774928bc0c6e7efed7781353", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_GetOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderListModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core-N-Tier-Architecture-Ecommerce-MultiLanguage\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
   ViewData["Title"] = "getordermodels"; 

#line default
#line hidden
            BeginContext(71, 25, true);
            WriteLiteral("\n<h1>Orders</h1>\n<hr />\n\n");
            EndContext();
#line 7 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core-N-Tier-Architecture-Ecommerce-MultiLanguage\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
 foreach (var order in Model)
{

#line default
#line hidden
            BeginContext(130, 163, true);
            WriteLiteral("    <table  class=\"table table-bordered table-sm mb-3\">\r\n        <thead class=\"bg-primary text-white\">\r\n           <tr>\r\n               <td colspan=\"2\">Order Id: #");
            EndContext();
            BeginContext(294, 13, false);
#line 12 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core-N-Tier-Architecture-Ecommerce-MultiLanguage\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                                     Write(order.OrderId);

#line default
#line hidden
            EndContext();
            BeginContext(307, 125, true);
            WriteLiteral("</td>\r\n               <th>Price</th>\r\n               <th>Quantity</th>\r\n           </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 18 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core-N-Tier-Architecture-Ecommerce-MultiLanguage\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
             foreach (var orderItem in order.OrderItems)
            {

#line default
#line hidden
            BeginContext(505, 92, true);
            WriteLiteral("                <tr>\r\n                    <td style=\"width:60px;\">\r\n                        ");
            EndContext();
            BeginContext(597, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5d361d3cc1badb4817149a0cbc5fbb3f2574683f5680", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 607, "~/img/", 607, 6, true);
#line 22 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core-N-Tier-Architecture-Ecommerce-MultiLanguage\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
AddHtmlAttributeValue("", 613, orderItem.ImageUrl, 613, 19, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(646, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(726, 14, false);
#line 25 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core-N-Tier-Architecture-Ecommerce-MultiLanguage\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                   Write(orderItem.Name);

#line default
#line hidden
            EndContext();
            BeginContext(740, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(820, 15, false);
#line 28 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core-N-Tier-Architecture-Ecommerce-MultiLanguage\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                   Write(orderItem.Price);

#line default
#line hidden
            EndContext();
            BeginContext(835, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(915, 18, false);
#line 31 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core-N-Tier-Architecture-Ecommerce-MultiLanguage\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                   Write(orderItem.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(933, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 34 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core-N-Tier-Architecture-Ecommerce-MultiLanguage\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
            }

#line default
#line hidden
            BeginContext(1000, 124, true);
            WriteLiteral("        </tbody>\r\n        <tfoot>\n            <tr>\n                <td colspan=\"2\">Customer Name: </td>\n                <td>");
            EndContext();
            BeginContext(1125, 15, false);
#line 39 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core-N-Tier-Architecture-Ecommerce-MultiLanguage\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
               Write(order.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1140, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1142, 14, false);
#line 39 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core-N-Tier-Architecture-Ecommerce-MultiLanguage\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                                Write(order.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1156, 45, true);
            WriteLiteral("</td>\n                <td rowspan=\"3\">Total: ");
            EndContext();
            BeginContext(1202, 18, false);
#line 40 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core-N-Tier-Architecture-Ecommerce-MultiLanguage\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                                  Write(order.TotalPrice());

#line default
#line hidden
            EndContext();
            BeginContext(1220, 105, true);
            WriteLiteral("</td>\n            </tr>\n            <tr>\n                <td colspan=\"2\">Adres:</td>\n                <td>");
            EndContext();
            BeginContext(1326, 13, false);
#line 44 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core-N-Tier-Architecture-Ecommerce-MultiLanguage\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
               Write(order.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1339, 105, true);
            WriteLiteral("</td>\n            </tr>\n            <tr>\n                <td colspan=\"2\">Phone:</td>\n                <td>");
            EndContext();
            BeginContext(1445, 11, false);
#line 48 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core-N-Tier-Architecture-Ecommerce-MultiLanguage\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
               Write(order.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1456, 105, true);
            WriteLiteral("</td>\n            </tr>\n            <tr>\n                <td colspan=\"2\">Email:</td>\n                <td>");
            EndContext();
            BeginContext(1562, 11, false);
#line 52 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core-N-Tier-Architecture-Ecommerce-MultiLanguage\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
               Write(order.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1573, 114, true);
            WriteLiteral("</td>\n            </tr>\n            <tr>\n                <td colspan=\"2\">Payment Status:</td>\n                <td>");
            EndContext();
            BeginContext(1688, 18, false);
#line 56 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core-N-Tier-Architecture-Ecommerce-MultiLanguage\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
               Write(order.PaymentTypes);

#line default
#line hidden
            EndContext();
            BeginContext(1706, 112, true);
            WriteLiteral("</td>\n            </tr>\n            <tr>\n                <td colspan=\"2\">Order Status:</td>\n                <td>");
            EndContext();
            BeginContext(1819, 16, false);
#line 60 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core-N-Tier-Architecture-Ecommerce-MultiLanguage\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
               Write(order.OrderState);

#line default
#line hidden
            EndContext();
            BeginContext(1835, 56, true);
            WriteLiteral("</td>\n            </tr>\n        </tfoot>\r\n    </table>\r\n");
            EndContext();
#line 64 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core-N-Tier-Architecture-Ecommerce-MultiLanguage\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
