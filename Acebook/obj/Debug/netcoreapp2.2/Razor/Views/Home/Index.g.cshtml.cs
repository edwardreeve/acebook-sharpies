#pragma checksum "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ab677a9d4436168e21e86ec44ee1145251c096d"
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
#line 1 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/_ViewImports.cshtml"
using Acebook;

#line default
#line hidden
#line 2 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/_ViewImports.cshtml"
using Acebook.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ab677a9d4436168e21e86ec44ee1145251c096d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bc9a51b0b0cbcff56f96d393889c25471cfec22", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "put", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/signin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
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
#line 2 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    var url = @Url.Action("CreatePost", "Home");
    var urlAddComment = @Url.Action("CreateComment","Home");
    var urlDeletePost = @Url.Action("DeletePost", "Home");
    var urlUpdatePost = @Url.Action("UpdatePost", "Home");

#line default
#line hidden
            BeginContext(279, 77, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h2 class=\"display-4\">News Feed</h2>\r\n\r\n    ");
            EndContext();
            BeginContext(356, 364, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ab677a9d4436168e21e86ec44ee1145251c096d5707", async() => {
                BeginContext(390, 323, true);
                WriteLiteral(@"
        <div class=""container"">
            <textarea col=""20"" row=""10"" placeholder=""Add message"" style=""text-align: center"" name=""body"" required></textarea><br>
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
#line 13 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 370, url, 370, 4, false);

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
            BeginContext(720, 61, true);
            WriteLiteral("\r\n\r\n    <div class=\"flex-container justify-content-center\">\r\n");
            EndContext();
#line 23 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
     foreach(var item in ViewData["Posts"] as IEnumerable<Acebook.Models.Post>)
    {
        string dataTarget = "#collapse" + item.Id;
        string divId ="collapse" + item.Id;


#line default
#line hidden
            BeginContext(968, 64, true);
            WriteLiteral("        <div id=\"accordion\">\r\n            <div class=\"card mt-3\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 1032, "", 1044, 1);
#line 29 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
WriteAttributeValue("", 1036, item.Id, 1036, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1044, 160, true);
            WriteLiteral(">\r\n                <div class=\"card-header text-center\">\r\n                    <blockquote class=\"blockquote mb-0\">\r\n                        <p class=\"postBody\">");
            EndContext();
            BeginContext(1205, 9, false);
#line 32 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                                       Write(item.Body);

#line default
#line hidden
            EndContext();
            BeginContext(1214, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 33 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                             if(ViewBag.SessionUserId == item.UserId)
                            {

#line default
#line hidden
            BeginContext(1322, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1354, 723, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ab677a9d4436168e21e86ec44ee1145251c096d9860", async() => {
                BeginContext(1397, 58, true);
                WriteLiteral("\r\n                                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 1455, "", 1470, 1);
#line 36 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
WriteAttributeValue("", 1462, item.Id, 1462, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1470, 253, true);
                WriteLiteral(" name=\"id\" />\r\n                                    <input type=\"text\" name=\"body\" placeholder=\"Update your post\" />\r\n                                    <input type=\"submit\" class=\"button btn-primary\" value=\"Update\" />\r\n                                 ");
                EndContext();
                BeginContext(1723, 313, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ab677a9d4436168e21e86ec44ee1145251c096d10970", async() => {
                    BeginContext(1769, 58, true);
                    WriteLiteral("\r\n                                    <input type=\"hidden\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=", 1827, "", 1842, 1);
#line 40 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
WriteAttributeValue("", 1834, item.Id, 1834, 8, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(1842, 187, true);
                    WriteLiteral(" name=\"id\" />\r\n                                    <span><input class=\"button btn-primary\" style=\"display: inline\" type=\"submit\" value=\"Delete\" /></span>\r\n                                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 39 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 1753, urlDeletePost, 1753, 14, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2036, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 35 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 1381, urlUpdatePost, 1381, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2077, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 44 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml"

                            }

#line default
#line hidden
            BeginContext(2112, 70, true);
            WriteLiteral("\r\n                        <footer class=\"blockquote-footer\">Posted at ");
            EndContext();
            BeginContext(2183, 14, false);
#line 47 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                                                               Write(item.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(2197, 4, true);
            WriteLiteral(" by ");
            EndContext();
#line 47 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                                                                                        foreach(var user in ViewData["Users"] as IEnumerable<Acebook.Models.User>)
                        {
                            if (user.Id == item.UserId)
                            {

#line default
#line hidden
            BeginContext(2393, 37, true);
            WriteLiteral("                               <span>");
            EndContext();
            BeginContext(2431, 9, false);
#line 51 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                                Write(user.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2440, 7, true);
            WriteLiteral("</span>");
            EndContext();
#line 51 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                                                      ;
                            }
                        }

#line default
#line hidden
            BeginContext(2508, 164, true);
            WriteLiteral("                        </footer>\r\n                    </blockquote>\r\n                    <button class=\"btn btn-link collapsed\" data-toggle=\"collapse\" data-target=");
            EndContext();
            BeginContext(2673, 10, false);
#line 56 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                                                                                         Write(dataTarget);

#line default
#line hidden
            EndContext();
            BeginContext(2683, 22, true);
            WriteLiteral(" aria-expanded=\"false\"");
            EndContext();
            BeginWriteAttribute("aria-controls", " aria-controls=", 2705, "", 2726, 1);
#line 56 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
WriteAttributeValue("", 2720, divId, 2720, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2726, 113, true);
            WriteLiteral(">\r\n                        Comments\r\n                    </button>\r\n                </div>\r\n                 <div");
            EndContext();
            BeginWriteAttribute("id", " id=", 2839, "", 2849, 1);
#line 60 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
WriteAttributeValue("", 2843, divId, 2843, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2849, 119, true);
            WriteLiteral(" class=\"collapse\" aria-labelledby=\"headingOne\" data-parent=\"#accordion\">\r\n                    <div class=\"card-body\">\r\n");
            EndContext();
#line 62 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                         foreach(var comment in ViewData["Comments"] as IEnumerable<Acebook.Models.Comment>)
                        {
                            if (comment.postId == item.Id)
                                {

#line default
#line hidden
            BeginContext(3200, 325, true);
            WriteLiteral(@"                                    <div class=""list-group"">
                                        <div class=""d-flex w-60 justify-content-between list-group-item list-group-item-action flex-column align-items-start active"">
                                        <h6 class=""mb-1 text-center"" style=""text-align: center"">");
            EndContext();
            BeginContext(3526, 12, false);
#line 68 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                                                                                           Write(comment.Body);

#line default
#line hidden
            EndContext();
            BeginContext(3538, 119, true);
            WriteLiteral("</h6>\r\n                                        </div>\r\n                                        <h6 class=\"mb-1\"><small>");
            EndContext();
#line 70 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                                                                 foreach(var commentUser in ViewData["Users"] as IEnumerable<Acebook.Models.User>)
                                                {
                                                if (commentUser.Id == comment.userId)
                                            {

#line default
#line hidden
            BeginContext(3926, 54, true);
            WriteLiteral("                                                <span>");
            EndContext();
            BeginContext(3981, 16, false);
#line 74 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                                                 Write(commentUser.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3997, 7, true);
            WriteLiteral("</span>");
            EndContext();
#line 74 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                                                                              ;
                                            }
                                            }

#line default
#line hidden
            BeginContext(4099, 4, true);
            WriteLiteral(" at ");
            EndContext();
            BeginContext(4104, 17, false);
#line 76 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                                            Write(comment.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(4121, 105, true);
            WriteLiteral("</small></h6>\r\n                                        <br>\r\n                                    </div>\r\n");
            EndContext();
#line 79 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                                }
                        }

#line default
#line hidden
            BeginContext(4288, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(4312, 825, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ab677a9d4436168e21e86ec44ee1145251c096d22451", async() => {
                BeginContext(4356, 350, true);
                WriteLiteral(@"
                            <div class=""container"">
                                <!-- <label for=""content""><b>Post </b></label> -->
                                <textarea col=""5"" row=""3"" placeholder=""comment"" style=""text-align: center"" name=""body"" required></textarea><br>
                                <input type=""hidden"" name=""postId""");
                EndContext();
                BeginWriteAttribute("value", " value=", 4706, "", 4721, 1);
#line 85 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
WriteAttributeValue("", 4713, item.Id, 4713, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4721, 219, true);
                WriteLiteral(" required>\r\n                                <input type=\"hidden\" name=\"userId\" value=1 required>\r\n                                <button type=\"submit\" class=\"btn btn-primary postbtn\" data-toggle=\"collapse\" data-target=");
                EndContext();
                BeginContext(4941, 10, false);
#line 87 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
                                                                                                                    Write(dataTarget);

#line default
#line hidden
                EndContext();
                BeginContext(4951, 179, true);
                WriteLiteral(">Add comment</button>\r\n                                <div class=\"clearfix\">\r\n                                </div>\r\n                            </div>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 81 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 4326, urlAddComment, 4326, 14, false);

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
            BeginContext(5137, 90, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 96 "/Users/edreeve/makers/projects/acebook-sharpies/Acebook/Views/Home/Index.cshtml"

    }

#line default
#line hidden
            BeginContext(5236, 589, true);
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
            BeginContext(5825, 337, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ab677a9d4436168e21e86ec44ee1145251c096d27076", async() => {
                BeginContext(5876, 279, true);
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6162, 66, true);
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
