#pragma checksum "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Products/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db6793d660069f7a2c7b63c83cb1a2a882e6eee8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Delete), @"mvc.1.0.view", @"/Views/Products/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Delete.cshtml", typeof(AspNetCore.Views_Products_Delete))]
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
#line 1 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/_ViewImports.cshtml"
using Chushka.Web;

#line default
#line hidden
#line 2 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/_ViewImports.cshtml"
using Chushka.Web.Models;

#line default
#line hidden
#line 1 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Products/Delete.cshtml"
using Chushka.Web.ViewModels.Products;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db6793d660069f7a2c7b63c83cb1a2a882e6eee8", @"/Views/Products/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c44956251f488a34d3e1b34758bbc1293fc924d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EditDeleteProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mx-auto half-width"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(75, 110, true);
            WriteLiteral("\n<main class=\"mt-3\">\n    <h1 class=\"text-center\">Delete Product</h1>\n    <hr class=\"bg-secondary hr-2\" />\n    ");
            EndContext();
            BeginContext(185, 2186, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "134b4d11f7f34adaa4937500d66a8b9e", async() => {
                BeginContext(278, 39, true);
                WriteLiteral("\n        <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 317, "\"", 334, 1);
#line 8 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Products/Delete.cshtml"
WriteAttributeValue("", 325, Model.Id, 325, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(335, 195, true);
                WriteLiteral(" />\n        <div class=\"form-group\">\n            <label for=\"name\">Name</label>\n            <input disabled=\"disabled\" type=\"text\" class=\"form-control\" id=\"name\" placeholder=\"Name...\" name=\"name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 530, "\"", 549, 1);
#line 11 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Products/Delete.cshtml"
WriteAttributeValue("", 538, Model.Name, 538, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(550, 226, true);
                WriteLiteral(">\n        </div>\n        <div class=\"form-group\">\n            <label for=\"price\">Price</label>\n            <input disabled=\"disabled\" type=\"number\" step=\"any\" class=\"form-control\" id=\"price\" placeholder=\"Price...\" name=\"price\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 776, "\"", 796, 1);
#line 15 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Products/Delete.cshtml"
WriteAttributeValue("", 784, Model.Price, 784, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(797, 253, true);
                WriteLiteral(">\n        </div>\n        <div class=\"form-group\">\n            <label for=\"description\">Description</label>\n            <textarea disabled=\"disabled\" class=\"form-control\" id=\"description\" name=\"description\" cols=\"4\" rows=\"3\" placeholder=\"Description...\">");
                EndContext();
                BeginContext(1051, 17, false);
#line 19 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Products/Delete.cshtml"
                                                                                                                                             Write(Model.Description);

#line default
#line hidden
                EndContext();
                BeginContext(1068, 206, true);
                WriteLiteral("</textarea>\n        </div>\n        <h2 class=\"text-center\">Product Type</h2>\n        <hr class=\"bg-secondary hr-2 half-width\" />\n        <div class=\"channel-type-holder mt-4 d-flex justify-content-around\">\n");
                EndContext();
#line 24 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Products/Delete.cshtml"
               var types = new string[] { "Food", "Domestic", "Health", "Cosmetic", "Other" }; 

#line default
#line hidden
                BeginContext(1371, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 26 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Products/Delete.cshtml"
             foreach (var type in types)
            {

#line default
#line hidden
                BeginContext(1427, 85, true);
                WriteLiteral("                <div class=\"form-check form-check-inline\">\n                    <input");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1512, "\"", 1528, 3);
                WriteAttributeValue("", 1517, "type(", 1517, 5, true);
#line 29 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Products/Delete.cshtml"
WriteAttributeValue("", 1522, type, 1522, 5, false);

#line default
#line hidden
                WriteAttributeValue("", 1527, ")", 1527, 1, true);
                EndWriteAttribute();
                BeginContext(1529, 68, true);
                WriteLiteral("\n                           type=\"radio\"\n                           ");
                EndContext();
#line 31 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Products/Delete.cshtml"
                            if (type == Model.ProductType.ToString())
                           {
                               

#line default
#line hidden
                BeginContext(1701, 31, false);
#line 33 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Products/Delete.cshtml"
                          Write(Html.Raw("checked=\"checked\""));

#line default
#line hidden
                EndContext();
#line 33 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Products/Delete.cshtml"
                                                               ;
                           }

#line default
#line hidden
                BeginContext(1763, 127, true);
                WriteLiteral("                           disabled=\"disabled\"\n                           name=\"productType\"\n                           value=\"");
                EndContext();
                BeginContext(1891, 4, false);
#line 37 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Products/Delete.cshtml"
                             Write(type);

#line default
#line hidden
                EndContext();
                BeginContext(1895, 61, true);
                WriteLiteral("\" />\n                    <label class=\"ml-1 form-check-label\"");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 1956, "\"", 1973, 3);
                WriteAttributeValue("", 1962, "type(", 1962, 5, true);
#line 38 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Products/Delete.cshtml"
WriteAttributeValue("", 1967, type, 1967, 5, false);

#line default
#line hidden
                WriteAttributeValue("", 1972, ")", 1972, 1, true);
                EndWriteAttribute();
                BeginContext(1974, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1976, 4, false);
#line 38 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Products/Delete.cshtml"
                                                                      Write(type);

#line default
#line hidden
                EndContext();
                BeginContext(1980, 32, true);
                WriteLiteral("</label>\n                </div>\n");
                EndContext();
#line 40 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Products/Delete.cshtml"
            }

#line default
#line hidden
                BeginContext(2026, 338, true);
                WriteLiteral(@"        </div>
        <hr class=""bg-secondary hr-2 half-width"" />
        <div class=""button-holder d-flex justify-content-center"">
            <button type=""submit"" class=""btn chushka-bg-color mr-5"">Delete</button>
            <button onclick=""window.history.back()"" class=""btn chushka-bg-color ml-5"">Cancel</button>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2371, 8, true);
            WriteLiteral("\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EditDeleteProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
