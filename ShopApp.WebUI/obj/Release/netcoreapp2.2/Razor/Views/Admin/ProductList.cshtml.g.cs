#pragma checksum "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core---N-Tier-Architecture\ShopApp.WebUI\Views\Admin\ProductList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c349e567c345c794a11e36090d50140b88bb619"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ProductList), @"mvc.1.0.view", @"/Views/Admin/ProductList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ProductList.cshtml", typeof(AspNetCore.Views_Admin_ProductList))]
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
#line 1 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core---N-Tier-Architecture\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.Entities;

#line default
#line hidden
#line 2 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core---N-Tier-Architecture\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Extensions;

#line default
#line hidden
#line 3 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core---N-Tier-Architecture\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c349e567c345c794a11e36090d50140b88bb619", @"/Views/Admin/ProductList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bba9d18e6cd03824774928bc0c6e7efed7781353", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ProductList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/deleteproduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core---N-Tier-Architecture\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
  
    ViewData["Title"] = "CreateProduct";

#line default
#line hidden
            BeginContext(74, 35, true);
            WriteLiteral("\r\n<h1>Admin Products</h1>\r\n<hr />\r\n");
            EndContext();
#line 8 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core---N-Tier-Architecture\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
 if (Model.Products.Count() > 0)
{

#line default
#line hidden
            BeginContext(146, 364, true);
            WriteLiteral(@"    <table class=""table table-bordered"">
        <thead>
            <tr>
                <td style=""width:30px;"">Id</td>
                <td style=""width:100px;"">Image</td>
                <td>Name</td>
                <td style=""width:12px;"">Price</td>
                <td style=""width:150px;""></td>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 21 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core---N-Tier-Architecture\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
             foreach (var item in Model.Products)
            {

#line default
#line hidden
            BeginContext(576, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(623, 7, false);
#line 24 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core---N-Tier-Architecture\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
                   Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(630, 78, true);
            WriteLiteral("</td>\r\n                    <td style=\"width:100px;\">\r\n                        ");
            EndContext();
            BeginContext(708, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3c349e567c345c794a11e36090d50140b88bb6196908", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 718, "~/img/", 718, 6, true);
#line 26 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core---N-Tier-Architecture\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
AddHtmlAttributeValue("", 724, item.ImageUrl, 724, 14, false);

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
            BeginContext(753, 53, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
            EndContext();
            BeginContext(807, 9, false);
#line 28 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core---N-Tier-Architecture\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(816, 51, true);
            WriteLiteral("</td>\r\n                    <td style=\"width:12px;\">");
            EndContext();
            BeginContext(868, 10, false);
#line 29 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core---N-Tier-Architecture\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
                                       Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(878, 116, true);
            WriteLiteral("</td>\r\n                    <td style=\"width:150px;\">\r\n                        <a class=\"btn btn-primary btn-sm mr-2\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 994, "\"", 1025, 2);
            WriteAttributeValue("", 1001, "/admin/products/", 1001, 16, true);
#line 31 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core---N-Tier-Architecture\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
WriteAttributeValue("", 1017, item.Id, 1017, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1026, 35, true);
            WriteLiteral(">Edit</a>\r\n                        ");
            EndContext();
            BeginContext(1061, 291, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c349e567c345c794a11e36090d50140b88bb61910134", async() => {
                BeginContext(1135, 67, true);
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"productId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1202, "\"", 1218, 1);
#line 33 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core---N-Tier-Architecture\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
WriteAttributeValue("", 1210, item.Id, 1210, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1219, 126, true);
                WriteLiteral(" />\r\n                            <button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1352, 75, true);
            WriteLiteral("                       \r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 38 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core---N-Tier-Architecture\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
            }

#line default
#line hidden
            BeginContext(1442, 36, true);
            WriteLiteral("\r\n        </tbody>\r\n\r\n    </table>\r\n");
            EndContext();
#line 43 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core---N-Tier-Architecture\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1490, 81, true);
            WriteLiteral("    <div class=\"alert alert-warning\">\r\n        <h4>No Products</h4>\r\n    </div>\r\n");
            EndContext();
#line 49 "C:\Users\MSİ\Desktop\ShopApp-Githup\Asp.Net-Core---N-Tier-Architecture\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
