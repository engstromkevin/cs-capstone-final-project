#pragma checksum "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Cart\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d60f49dc5bc6a12185d7f984fd36086c7bc78ed5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Checkout), @"mvc.1.0.view", @"/Views/Cart/Checkout.cshtml")]
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
#line 1 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\_ViewImports.cshtml"
using IT482GroupProjectEngstrom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\_ViewImports.cshtml"
using IT482GroupProjectEngstrom.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d60f49dc5bc6a12185d7f984fd36086c7bc78ed5", @"/Views/Cart/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8485b62847765cb7cca94790cc2310d02f2f3fd3", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewSession", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Cart\Checkout.cshtml"
  
    ViewBag.Title = "Checkout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Viewing Invoice #");
#nullable restore
#line 6 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Cart\Checkout.cshtml"
                Write(Model.GetInvoice().InvoiceNum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Quantity</th>\r\n            <th>Total price</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Cart\Checkout.cshtml"
         foreach (var item in Model.GetCartContents())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Cart\Checkout.cshtml"
               Write(Model.GetContext().Product.Find(item.ProductID).ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Cart\Checkout.cshtml"
               Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Cart\Checkout.cshtml"
               Write(string.Format("{0:C}", item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 24 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Cart\Checkout.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<p><b>Grand total: ");
#nullable restore
#line 27 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Cart\Checkout.cshtml"
              Write(string.Format("{0:C}", Model.GetTotalPrice()));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b><br />\r\n    Thank you for shopping with us today!</p>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d60f49dc5bc6a12185d7f984fd36086c7bc78ed56800", async() => {
                WriteLiteral("Back to Shop");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCart> Html { get; private set; }
    }
}
#pragma warning restore 1591