#pragma checksum "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Account/Logout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69fa6cfb559006d6f3dbc2391c3efda1f022f018"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Logout), @"mvc.1.0.view", @"/Views/Account/Logout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Logout.cshtml", typeof(AspNetCore.Views_Account_Logout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69fa6cfb559006d6f3dbc2391c3efda1f022f018", @"/Views/Account/Logout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c44956251f488a34d3e1b34758bbc1293fc924d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Logout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 17, true);
            WriteLiteral("<header>\n    <h1>");
            EndContext();
            BeginContext(18, 17, false);
#line 2 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Account/Logout.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(35, 79, true);
            WriteLiteral("</h1>\n    <p>You have successfully logged out of the application.</p>\n</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
