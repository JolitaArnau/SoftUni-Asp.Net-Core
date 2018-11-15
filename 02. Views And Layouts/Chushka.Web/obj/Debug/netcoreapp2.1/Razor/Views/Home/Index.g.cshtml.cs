#pragma checksum "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c734e670c8a75a78496d9258564084bc3aeee087"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Home/Index.cshtml"
using Chushka.Web.ViewModels.Products;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c734e670c8a75a78496d9258564084bc3aeee087", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c44956251f488a34d3e1b34758bbc1293fc924d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AllProductsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(68, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Home/Index.cshtml"
 if (!User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(108, 387, true);
            WriteLiteral(@"    <main>
        <div class=""jumbotron mt-3 chushka-bg-color"">
            <h1>Welcome to Chushka Universal Web Shop</h1>
            <hr class=""bg-white"" />
            <h3><a class=""nav-link-dark"" href=""/account/login"">Login</a> if you have an account.</h3>
            <h3><a class=""nav-link-dark"" href=""/account/register"">Register</a> if you don't.</h3>
        </div>
    </main>
");
            EndContext();
#line 14 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Home/Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(504, 79, true);
            WriteLiteral("    <main class=\"mt-3 mb-5\">\n        <div class=\"container-fluid text-center\">\n");
            EndContext();
#line 19 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Home/Index.cshtml"
             if (User.IsInRole("Admin"))
            {

#line default
#line hidden
            BeginContext(638, 91, true);
            WriteLiteral("                <h2>Greetings, admin!</h2>\n                <h4>Enjoy your work today!</h4>\n");
            EndContext();
#line 23 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Home/Index.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(774, 31, true);
            WriteLiteral("                <h2>Greetings, ");
            EndContext();
            BeginContext(806, 18, false);
#line 26 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Home/Index.cshtml"
                          Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(824, 81, true);
            WriteLiteral("!</h2>\n                <h4>Feel free to view and order any of our products.</h4>\n");
            EndContext();
#line 28 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Home/Index.cshtml"
            }

#line default
#line hidden
            BeginContext(919, 116, true);
            WriteLiteral("        </div>\n        <hr class=\"hr-2 bg-dark\" />\n        <div class=\"container-fluid product-holder\">\n            ");
            EndContext();
            BeginContext(1036, 47, false);
#line 32 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Home/Index.cshtml"
       Write(await Html.PartialAsync("_IndexPartial", Model));

#line default
#line hidden
            EndContext();
            BeginContext(1083, 29, true);
            WriteLiteral(";\n        </div>\n    </main>\n");
            EndContext();
#line 35 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Home/Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllProductsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591