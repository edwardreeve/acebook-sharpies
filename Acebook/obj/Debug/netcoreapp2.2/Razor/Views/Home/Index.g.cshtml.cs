#pragma checksum "/Users/student/Documents/cSharp/acebook-sharpies/Acebook/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c07ca4a1e2aaf74e9ec8a034b04cc7d168d3f214"
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
#line 1 "/Users/student/Documents/cSharp/acebook-sharpies/Acebook/Views/_ViewImports.cshtml"
using Acebook;

#line default
#line hidden
#line 2 "/Users/student/Documents/cSharp/acebook-sharpies/Acebook/Views/_ViewImports.cshtml"
using Acebook.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c07ca4a1e2aaf74e9ec8a034b04cc7d168d3f214", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bc9a51b0b0cbcff56f96d393889c25471cfec22", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Acebook.Models.Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/student/Documents/cSharp/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(86, 229, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome Sharpies</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building top-notch Shoobie Doobie Web apps with ASP.NET Core</a>.</p>\r\n\r\n    <ul>\r\n");
            EndContext();
#line 11 "/Users/student/Documents/cSharp/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
     foreach(var item in Model) 
    {

#line default
#line hidden
            BeginContext(356, 18, true);
            WriteLiteral("        <li><span>");
            EndContext();
            BeginContext(375, 9, false);
#line 13 "/Users/student/Documents/cSharp/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
             Write(item.Body);

#line default
#line hidden
            EndContext();
            BeginContext(384, 14, true);
            WriteLiteral("</span> <span>");
            EndContext();
            BeginContext(399, 14, false);
#line 13 "/Users/student/Documents/cSharp/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                                     Write(item.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(413, 16, true);
            WriteLiteral("</span></li>  \r\n");
            EndContext();
#line 14 "/Users/student/Documents/cSharp/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(436, 19, true);
            WriteLiteral("    </ul>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Acebook.Models.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
