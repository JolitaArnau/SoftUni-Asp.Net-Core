#pragma checksum "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Shared/_IndexPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "196d09b477f331652d3e69ab4816aa8f205a5eaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__IndexPartial), @"mvc.1.0.view", @"/Views/Shared/_IndexPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_IndexPartial.cshtml", typeof(AspNetCore.Views_Shared__IndexPartial))]
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
#line 1 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Shared/_IndexPartial.cshtml"
using Chushka.Web.ViewModels.Products;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"196d09b477f331652d3e69ab4816aa8f205a5eaa", @"/Views/Shared/_IndexPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c44956251f488a34d3e1b34758bbc1293fc924d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__IndexPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AllProductsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(68, 49, true);
            WriteLiteral("\n<div class=\"row d-flex justify-content-around\">\n");
            EndContext();
#line 5 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Shared/_IndexPartial.cshtml"
     for (int index = 0; index < @Model.Products.Count(); index++)
    {
        var product = @Model.Products.ElementAt(index);
        if (index % 5 == 0 && (index != 1 || index != 0))
        {
            

#line default
#line hidden
            BeginContext(327, 73, false);
#line 10 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Shared/_IndexPartial.cshtml"
       Write(Html.Raw(" </div><div class=\"row d-flex justify-content-around mt-4\">"));

#line default
#line hidden
            EndContext();
#line 10 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Shared/_IndexPartial.cshtml"
                                                                                      
        }

#line default
#line hidden
            BeginContext(411, 10, true);
            WriteLiteral("        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 421, "\"", 460, 2);
            WriteAttributeValue("", 428, "/products/details?id=", 428, 21, true);
#line 12 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Shared/_IndexPartial.cshtml"
WriteAttributeValue("", 449, product.Id, 449, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(461, 146, true);
            WriteLiteral(" class=\"col-md-2\">\n            <div class=\"product p-1 chushka-bg-color rounded-top rounded-bottom\">\n                <h5 class=\"text-center mt-3\">");
            EndContext();
            BeginContext(608, 12, false);
#line 14 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Shared/_IndexPartial.cshtml"
                                        Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(620, 102, true);
            WriteLiteral("</h5>\n                <hr class=\"hr-1 bg-white\" />\n                <p class=\"text-white text-center\">\n");
            EndContext();
#line 17 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Shared/_IndexPartial.cshtml"
                     if (product.Description.Length > 50)
                    {
                        

#line default
#line hidden
            BeginContext(827, 23, false);
#line 19 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Shared/_IndexPartial.cshtml"
                   Write(product.LongDescription);

#line default
#line hidden
            EndContext();
#line 19 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Shared/_IndexPartial.cshtml"
                                                
                    }
                    else
                    {
                        

#line default
#line hidden
            BeginContext(945, 24, false);
#line 23 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Shared/_IndexPartial.cshtml"
                   Write(product.ShortDescription);

#line default
#line hidden
            EndContext();
#line 23 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Shared/_IndexPartial.cshtml"
                                                 
                    }

#line default
#line hidden
            BeginContext(992, 123, true);
            WriteLiteral("                </p>\n                <hr class=\"hr-1 bg-white\" />\n                <h6 class=\"text-center text-white mb-3\">$");
            EndContext();
            BeginContext(1116, 13, false);
#line 27 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Shared/_IndexPartial.cshtml"
                                                    Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1129, 38, true);
            WriteLiteral("</h6>\n            </div>\n        </a>\n");
            EndContext();
#line 30 "/Users/jolitaarnaudova/Documents/Programming/C#/C# Web Development/C#-Asp.Net-Core/02. Views And Layouts/Chushka.Web/Views/Shared/_IndexPartial.cshtml"
    }

#line default
#line hidden
            BeginContext(1173, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllProductsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
