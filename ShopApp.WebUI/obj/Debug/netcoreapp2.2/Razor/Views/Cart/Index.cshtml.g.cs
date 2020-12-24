#pragma checksum "C:\Users\MSİ\Desktop\coreLearn\ShopApp\ShopApp.WebUI\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c8be0ef7cceddddc2b4577a407ffb8127bba47a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Index.cshtml", typeof(AspNetCore.Views_Cart_Index))]
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
#line 1 "C:\Users\MSİ\Desktop\coreLearn\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.Entities;

#line default
#line hidden
#line 2 "C:\Users\MSİ\Desktop\coreLearn\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Extensions;

#line default
#line hidden
#line 3 "C:\Users\MSİ\Desktop\coreLearn\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c8be0ef7cceddddc2b4577a407ffb8127bba47a", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bba9d18e6cd03824774928bc0c6e7efed7781353", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\MSİ\Desktop\coreLearn\ShopApp\ShopApp.WebUI\Views\Cart\Index.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
            BeginContext(51, 155, true);
            WriteLiteral("\n<h1>Shopping Cart</h1>\n\n<div class=\"row mt-5\">\n    <div class=\"col-md-8\">\n        <div class=\"text-left\">\n            <h4>Cart Items</h4>\n        </div>\n\n");
            EndContext();
#line 12 "C:\Users\MSİ\Desktop\coreLearn\ShopApp\ShopApp.WebUI\Views\Cart\Index.cshtml"
         if (Model.CartItems.Count > 0)
        {

#line default
#line hidden
            BeginContext(256, 260, true);
            WriteLiteral(@"<table class=""table table-hover"">
    <thead>
        <tr>
            <th></th>
            <th>Product Name</th>
            <th>Price</th>
            <th>Quantity</th>
            <th>Total</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 26 "C:\Users\MSİ\Desktop\coreLearn\ShopApp\ShopApp.WebUI\Views\Cart\Index.cshtml"
         foreach (var item in Model.CartItems)
        {

#line default
#line hidden
            BeginContext(573, 22, true);
            WriteLiteral("<tr>\n    <td>\n        ");
            EndContext();
            BeginContext(595, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7c8be0ef7cceddddc2b4577a407ffb8127bba47a6042", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 605, "~/img/", 605, 6, true);
#line 30 "C:\Users\MSİ\Desktop\coreLearn\ShopApp\ShopApp.WebUI\Views\Cart\Index.cshtml"
AddHtmlAttributeValue("", 611, item.ImageUrl, 611, 14, false);

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
            BeginContext(640, 19, true);
            WriteLiteral("\n    </td>\n    <td>");
            EndContext();
            BeginContext(660, 9, false);
#line 32 "C:\Users\MSİ\Desktop\coreLearn\ShopApp\ShopApp.WebUI\Views\Cart\Index.cshtml"
   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(669, 14, true);
            WriteLiteral("</td>\n    <td>");
            EndContext();
            BeginContext(684, 24, false);
#line 33 "C:\Users\MSİ\Desktop\coreLearn\ShopApp\ShopApp.WebUI\Views\Cart\Index.cshtml"
   Write(item.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(708, 14, true);
            WriteLiteral("</td>\n    <td>");
            EndContext();
            BeginContext(723, 13, false);
#line 34 "C:\Users\MSİ\Desktop\coreLearn\ShopApp\ShopApp.WebUI\Views\Cart\Index.cshtml"
   Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(736, 14, true);
            WriteLiteral("</td>\n    <td>");
            EndContext();
            BeginContext(752, 42, false);
#line 35 "C:\Users\MSİ\Desktop\coreLearn\ShopApp\ShopApp.WebUI\Views\Cart\Index.cshtml"
    Write((item.Quantity * item.Price).ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(795, 23, true);
            WriteLiteral("</td>\n    <td>\n        ");
            EndContext();
            BeginContext(818, 300, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c8be0ef7cceddddc2b4577a407ffb8127bba47a9086", async() => {
                BeginContext(888, 50, true);
                WriteLiteral("\n            <input type=\"hidden\" name=\"productId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 938, "\"", 961, 1);
#line 38 "C:\Users\MSİ\Desktop\coreLearn\ShopApp\ShopApp.WebUI\Views\Cart\Index.cshtml"
WriteAttributeValue("", 946, item.ProductId, 946, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(962, 149, true);
                WriteLiteral(" />\n            <button type=\"submit\" class=\"btn btn-danger btn-sm\">\n                <i class=\"fa fa-times fa-fw\"></i>\n            </button>\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1118, 17, true);
            WriteLiteral("\n\n    </td>\n</tr>");
            EndContext();
#line 45 "C:\Users\MSİ\Desktop\coreLearn\ShopApp\ShopApp.WebUI\Views\Cart\Index.cshtml"
     }

#line default
#line hidden
            BeginContext(1137, 23, true);
            WriteLiteral("    </tbody>\n\n</table> ");
            EndContext();
#line 48 "C:\Users\MSİ\Desktop\coreLearn\ShopApp\ShopApp.WebUI\Views\Cart\Index.cshtml"
         }
            else
            {

#line default
#line hidden
            BeginContext(1193, 64, true);
            WriteLiteral("<div class=\"alert alert-warning\">\n    No Product in Cart!\n</div>");
            EndContext();
#line 53 "C:\Users\MSİ\Desktop\coreLearn\ShopApp\ShopApp.WebUI\Views\Cart\Index.cshtml"
      }

#line default
#line hidden
            BeginContext(1259, 39, true);
            WriteLiteral("    </div>\n    <div class=\"col-md-4\">\n\n");
            EndContext();
#line 57 "C:\Users\MSİ\Desktop\coreLearn\ShopApp\ShopApp.WebUI\Views\Cart\Index.cshtml"
         if (Model.CartItems.Count > 0)
        {

#line default
#line hidden
            BeginContext(1348, 232, true);
            WriteLiteral("<div class=\"text-left\">\n    <h4>Cart Summary</h4>\n</div>\n                <table class=\"table\">\n                    <tbody>\n                        <tr>\n                            <th>Cart Total</th>\n                            <td>");
            EndContext();
            BeginContext(1581, 32, false);
#line 66 "C:\Users\MSİ\Desktop\coreLearn\ShopApp\ShopApp.WebUI\Views\Cart\Index.cshtml"
                           Write(Model.TotalPrice().ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(1613, 293, true);
            WriteLiteral(@"</td>
                        </tr>
                        <tr>
                            <th>Shipping</th>
                            <td>Free</td>
                        </tr>
                        <tr>
                            <th>Order Total</th>
                            <td>");
            EndContext();
            BeginContext(1907, 32, false);
#line 74 "C:\Users\MSİ\Desktop\coreLearn\ShopApp\ShopApp.WebUI\Views\Cart\Index.cshtml"
                           Write(Model.TotalPrice().ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(1939, 622, true);
            WriteLiteral(@"</td>
                        </tr>
                    </tbody>
                </table>
                                <div class=""text-center"">
                                    <a href=""/"" class=""btn btn-primary"">
                                        <i class=""fa fa-arrow-circle-left fa-fw""></i> Continue Shopping
                                    </a>
                                    <a href=""/checkout"" class=""btn btn-primary"">
                                        Checkout <i class=""fa fa-arrow-circle-right fa-fw""></i>
                                    </a>
                                </div>");
            EndContext();
#line 85 "C:\Users\MSİ\Desktop\coreLearn\ShopApp\ShopApp.WebUI\Views\Cart\Index.cshtml"
                                      }

#line default
#line hidden
            BeginContext(2563, 19, true);
            WriteLiteral("    </div>\n</div>\n\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
