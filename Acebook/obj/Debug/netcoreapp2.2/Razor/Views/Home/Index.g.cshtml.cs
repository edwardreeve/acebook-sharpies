#pragma checksum "/Users/student/Documents/cSharp/acebook-sharpies/Acebook/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "182a23b577c458ad9232cfaf0c651ff990c31ee0"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"182a23b577c458ad9232cfaf0c651ff990c31ee0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bc9a51b0b0cbcff56f96d393889c25471cfec22", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/signin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "/Users/student/Documents/cSharp/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    var url = @Url.Action("CreatePost", "Home");
    var urlAddComment = @Url.Action("CreateComment","Home");

#line default
#line hidden
            BeginContext(159, 77, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h2 class=\"display-4\">News Feed</h2>\r\n\r\n    ");
            EndContext();
            BeginContext(236, 415, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "182a23b577c458ad9232cfaf0c651ff990c31ee05002", async() => {
                BeginContext(270, 374, true);
                WriteLiteral(@"
        <div class=""container"">
            <!-- <label for=""content""><b>Post </b></label> -->
            <input type=""text"" width=30px placeholder=""Add message"" style=""text-align: center"" name=""body"" required>
            <button type=""submit"" class=""btn btn-primary postbtn"">post</button>
            <div class=""clearfix"">
            </div>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 11 "/Users/student/Documents/cSharp/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 250, url, 250, 4, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(651, 61, true);
            WriteLiteral("\r\n\r\n    <div class=\"flex-container justify-content-center\">\r\n");
            EndContext();
#line 22 "/Users/student/Documents/cSharp/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
     foreach(var item in ViewData["Posts"] as IEnumerable<Acebook.Models.Post>)
    {
        string dataTarget = "#collapse" + item.Id;
        string divId ="collapse" + item.Id;


#line default
#line hidden
            BeginContext(899, 64, true);
            WriteLiteral("        <div id=\"accordion\">\r\n            <div class=\"card mt-3\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 963, "", 975, 1);
#line 28 "/Users/student/Documents/cSharp/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
WriteAttributeValue("", 967, item.Id, 967, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(975, 160, true);
            WriteLiteral(">\r\n                <div class=\"card-header text-center\">\r\n                    <blockquote class=\"blockquote mb-0\">\r\n                        <p class=\"postBody\">");
            EndContext();
            BeginContext(1136, 9, false);
#line 31 "/Users/student/Documents/cSharp/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                                       Write(item.Body);

#line default
#line hidden
            EndContext();
            BeginContext(1145, 74, true);
            WriteLiteral("</p>\r\n                        <footer class=\"blockquote-footer\">Posted at ");
            EndContext();
            BeginContext(1220, 14, false);
#line 32 "/Users/student/Documents/cSharp/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                                                               Write(item.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(1234, 140, true);
            WriteLiteral("</footer>\r\n                    </blockquote>\r\n                    <button class=\"btn btn-link collapsed\" data-toggle=\"collapse\" data-target=");
            EndContext();
            BeginContext(1375, 10, false);
#line 34 "/Users/student/Documents/cSharp/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                                                                                         Write(dataTarget);

#line default
#line hidden
            EndContext();
            BeginContext(1385, 22, true);
            WriteLiteral(" aria-expanded=\"false\"");
            EndContext();
            BeginWriteAttribute("aria-controls", " aria-controls=", 1407, "", 1428, 1);
#line 34 "/Users/student/Documents/cSharp/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
WriteAttributeValue("", 1422, divId, 1422, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1428, 113, true);
            WriteLiteral(">\r\n                        Comments\r\n                    </button>\r\n                </div>\r\n                 <div");
            EndContext();
            BeginWriteAttribute("id", " id=", 1541, "", 1551, 1);
#line 38 "/Users/student/Documents/cSharp/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
WriteAttributeValue("", 1545, divId, 1545, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1551, 119, true);
            WriteLiteral(" class=\"collapse\" aria-labelledby=\"headingOne\" data-parent=\"#accordion\">\r\n                    <div class=\"card-body\">\r\n");
            EndContext();
#line 40 "/Users/student/Documents/cSharp/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                         foreach(var comment in ViewData["Comments"] as IEnumerable<Acebook.Models.Comment>)
                        {
                            if (comment.postId == item.Id)
                                {

#line default
#line hidden
            BeginContext(1902, 325, true);
            WriteLiteral(@"                                    <div class=""list-group"">
                                        <div class=""d-flex w-60 justify-content-between list-group-item list-group-item-action flex-column align-items-start active"">
                                        <h6 class=""mb-1 text-center"" style=""text-align: center"">");
            EndContext();
            BeginContext(2228, 12, false);
#line 46 "/Users/student/Documents/cSharp/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                                                                                           Write(comment.Body);

#line default
#line hidden
            EndContext();
            BeginContext(2240, 149, true);
            WriteLiteral("</h6>\r\n                                        </div>\r\n                                        <h6 class=\"mb-1\"><small>User name will display here - ");
            EndContext();
            BeginContext(2390, 17, false);
#line 48 "/Users/student/Documents/cSharp/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                                                                                         Write(comment.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(2407, 105, true);
            WriteLiteral("</small></h6>\r\n                                        <br>\r\n                                    </div>\r\n");
            EndContext();
#line 51 "/Users/student/Documents/cSharp/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                                }
                        }

#line default
#line hidden
            BeginContext(2574, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2598, 814, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "182a23b577c458ad9232cfaf0c651ff990c31ee013042", async() => {
                BeginContext(2642, 328, true);
                WriteLiteral(@"
                            <div class=""container"">
                                <!-- <label for=""content""><b>Post </b></label> -->
                                <input type=""text"" placeholder=""comment"" style=""text-align: center"" name=""body"" required>
                                <input type=""hidden"" name=""postId""");
                EndContext();
                BeginWriteAttribute("value", " value=", 2970, "", 2985, 1);
#line 57 "/Users/student/Documents/cSharp/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
WriteAttributeValue("", 2977, item.Id, 2977, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2985, 78, true);
                WriteLiteral(" required>\r\n                                <input type=\"hidden\" name=\"userId\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 3063, "", 3082, 1);
#line 58 "/Users/student/Documents/cSharp/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
WriteAttributeValue("", 3070, item.UserId, 3070, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3082, 133, true);
                WriteLiteral(" required>\r\n                                <button type=\"submit\" class=\"btn btn-primary postbtn\" data-toggle=\"collapse\" data-target=");
                EndContext();
                BeginContext(3216, 10, false);
#line 59 "/Users/student/Documents/cSharp/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                                                                                                                    Write(dataTarget);

#line default
#line hidden
                EndContext();
                BeginContext(3226, 179, true);
                WriteLiteral(">Add comment</button>\r\n                                <div class=\"clearfix\">\r\n                                </div>\r\n                            </div>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 53 "/Users/student/Documents/cSharp/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 2612, urlAddComment, 2612, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3412, 90, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 68 "/Users/student/Documents/cSharp/acebook-sharpies/Acebook/Views/Home/Index.cshtml"

    }

#line default
#line hidden
            BeginContext(3511, 589, true);
            WriteLiteral(@"    </div>
    <br />

    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
        <div class=""modal-header"">
            <h5 class=""modal-title"" id=""exampleModalLabel"">Log in to Acebook</h5>
            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
            <span aria-hidden=""true"">&times;</span>
            </button>
        </div>
        <div class=""modal-body"">
            ");
            EndContext();
            BeginContext(4100, 337, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "182a23b577c458ad9232cfaf0c651ff990c31ee018043", async() => {
                BeginContext(4151, 279, true);
                WriteLiteral(@"
                Email: <br>
                <input type=""email"" name=""email""><br><br>
                Password: <br>
                <input type=""password"" name=""password""><br><br>
                <input type =""submit"" value=""Sign In"" class=""btn btn-primary"">
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4437, 66, true);
            WriteLiteral("\r\n        </div>\r\n        </div>\r\n    </div>\r\n    </div>\r\n</div>\r\n");
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
