#pragma checksum "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cf263c65c1edfb0c3680b58d409e2e54832d6a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cf263c65c1edfb0c3680b58d409e2e54832d6a5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8485b62847765cb7cca94790cc2310d02f2f3fd3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CartIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Shopping Application";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Browse Products</h2>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cf263c65c1edfb0c3680b58d409e2e54832d6a56623", async() => {
                WriteLiteral("\r\n    <p>\r\n        Search for products by name: <input type=\"text\" name=\"SearchString\">\r\n        <input type=\"submit\" value=\"Search\" />\r\n    </p>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cf263c65c1edfb0c3680b58d409e2e54832d6a58619", async() => {
                WriteLiteral(@"
    <table class=""table table-bordered table-striped"">
        <thead>
            <tr>
                <th>Name</th>
                <th>Brand</th>
                <th>Category</th>
                <th>Description</th>
                <th>Quantity</th>
                <th>Price</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 28 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Home\Index.cshtml"
             for(var p = 0; p < Model.Count; p++) { Product product = Model[p]; int q = 1;

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr> \r\n                    <td>");
#nullable restore
#line 30 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Home\Index.cshtml"
                   Write(product.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Home\Index.cshtml"
                   Write(product.Brand);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Home\Index.cshtml"
                   Write(product.Category.CatDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Home\Index.cshtml"
                   Write(product.ProductDescr);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Home\Index.cshtml"
                   Write(product.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Home\Index.cshtml"
                   Write(string.Format("{0:C}", product.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 37 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Home\Index.cshtml"
                         if (product.Quantity > 0)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <p>\r\n                            Qty: <select");
                BeginWriteAttribute("id", " id=\"", 1374, "\"", 1391, 2);
#nullable restore
#line 40 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Home\Index.cshtml"
WriteAttributeValue("", 1379, p, 1379, 4, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1383, "quantity", 1383, 8, true);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1392, "\"", 1411, 2);
#nullable restore
#line 40 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Home\Index.cshtml"
WriteAttributeValue("", 1399, p, 1399, 4, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1403, "quantity", 1403, 8, true);
                EndWriteAttribute();
                WriteLiteral(" onchange=\"function yes() { sessionStorage.setItem(\'a\', \'hello\'); console.log(sessionStorage.getItem(\'a\')) }\">\r\n");
#nullable restore
#line 41 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Home\Index.cshtml"
                                 for (var i = 1; i <= product.Quantity; i++)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cf263c65c1edfb0c3680b58d409e2e54832d6a513227", async() => {
#nullable restore
#line 43 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Home\Index.cshtml"
                                                  Write(i);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Home\Index.cshtml"
                                       WriteLiteral(i);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 44 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </select>\r\n");
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cf263c65c1edfb0c3680b58d409e2e54832d6a515511", async() => {
                    WriteLiteral("Add to Cart");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-prodId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Home\Index.cshtml"
                                                                                  WriteLiteral(product.ProductID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["prodId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-prodId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["prodId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Home\Index.cshtml"
                                                                                                                          WriteLiteral(q);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["quantity"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-quantity", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["quantity"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </p>\r\n");
#nullable restore
#line 50 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Home\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <p>Sold out, sorry</p>\r\n");
#nullable restore
#line 54 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 59 "C:\Users\e0676268\source\repos\IT482GroupProjectEngstrom\IT482GroupProjectEngstrom\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cf263c65c1edfb0c3680b58d409e2e54832d6a521451", async() => {
                WriteLiteral("Go to Cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
