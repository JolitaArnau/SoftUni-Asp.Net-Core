#pragma checksum "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Orders/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75cc87fd06e4245a2ca2a579d7d39e8110bc6a97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Index.cshtml", typeof(AspNetCore.Views_Orders_Index))]
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
#line 1 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Orders/Index.cshtml"
using Chushka.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75cc87fd06e4245a2ca2a579d7d39e8110bc6a97", @"/Views/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c44956251f488a34d3e1b34758bbc1293fc924d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Order[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 543, true);
            WriteLiteral(@"
<main>
    <h1 class=""text-center mt-3"">All Orders</h1>
    <hr class=""chushka-bg-color hr-2"" />
    <div class=""container-fluid w-75"">
        <table class=""table table-hover"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Order ID</th>
                    <th scope=""col"">Customer</th>
                    <th scope=""col"">Product</th>
                    <th scope=""col"">Ordered On</th>
                </tr>
            </thead>
            <tbody>
                ");
            EndContext();
            BeginContext(583, 48, false);
#line 19 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Orders/Index.cshtml"
           Write(await Html.PartialAsync("_OrdersPartial", Model));

#line default
#line hidden
            EndContext();
            BeginContext(631, 58, true);
            WriteLiteral(";\n            </tbody>\n        </table>\n    </div>\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Order[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
