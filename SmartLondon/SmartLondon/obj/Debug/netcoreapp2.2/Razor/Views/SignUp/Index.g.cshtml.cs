#pragma checksum "C:\Users\engin\SOAIWTTermProject\SmartLondon\SmartLondon\Views\SignUp\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abdb4db7c8a304852a0273b673fbc99239dcfbf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SignUp_Index), @"mvc.1.0.view", @"/Views/SignUp/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SignUp/Index.cshtml", typeof(AspNetCore.Views_SignUp_Index))]
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
#line 1 "C:\Users\engin\SOAIWTTermProject\SmartLondon\SmartLondon\Views\_ViewImports.cshtml"
using SmartLondon;

#line default
#line hidden
#line 2 "C:\Users\engin\SOAIWTTermProject\SmartLondon\SmartLondon\Views\_ViewImports.cshtml"
using SmartLondon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abdb4db7c8a304852a0273b673fbc99239dcfbf1", @"/Views/SignUp/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67d1a73ce2143db528227b6f174d78a57e8bcf9c", @"/Views/_ViewImports.cshtml")]
    public class Views_SignUp_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-signin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SignUp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\engin\SOAIWTTermProject\SmartLondon\SmartLondon\Views\SignUp\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 156, true);
            WriteLiteral("\r\n<div class=\"form-wrapper\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12 col-md-12 col-lg-12\">\r\n                ");
            EndContext();
            BeginContext(199, 1417, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abdb4db7c8a304852a0273b673fbc99239dcfbf15031", async() => {
                BeginContext(282, 844, true);
                WriteLiteral(@"

                    <h1 class=""h3 mb-3 font-weight-normal"">Please sign up</h1>
                    <label for=""username"" class=""sr-only""> Username</label>
                    <input name=""username"" type=""text"" id=""username"" class=""form-control"" placeholder=""Username"" required autofocus>

                    <label for=""inputEmail"" class=""sr-only"">Email address</label>
                    <input name=""email"" type=""email"" id=""inputEmail"" class=""form-control"" placeholder=""Email address"" required autofocus>

                    <label for=""inputPassword"" class=""sr-only"">Password</label>
                    <input name=""password"" type=""password"" id=""inputPassword"" class=""form-control"" placeholder=""Password"" required>

                    <button class=""btn btn-lg btn-primary btn-block"" type=""submit"">Sign Up</button><br />
");
                EndContext();
#line 23 "C:\Users\engin\SOAIWTTermProject\SmartLondon\SmartLondon\Views\SignUp\Index.cshtml"
                     if (ViewData["registerSuccess"] != null)
                    {

#line default
#line hidden
                BeginContext(1212, 57, true);
                WriteLiteral("                        <div class=\"alert alert-success\">");
                EndContext();
                BeginContext(1270, 27, false);
#line 25 "C:\Users\engin\SOAIWTTermProject\SmartLondon\SmartLondon\Views\SignUp\Index.cshtml"
                                                    Write(ViewData["registerSuccess"]);

#line default
#line hidden
                EndContext();
                BeginContext(1297, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 26 "C:\Users\engin\SOAIWTTermProject\SmartLondon\SmartLondon\Views\SignUp\Index.cshtml"

                    }

#line default
#line hidden
                BeginContext(1330, 20, true);
                WriteLiteral("                    ");
                EndContext();
#line 28 "C:\Users\engin\SOAIWTTermProject\SmartLondon\SmartLondon\Views\SignUp\Index.cshtml"
                     if (ViewData["userExist"] != null)
                    {

#line default
#line hidden
                BeginContext(1410, 56, true);
                WriteLiteral("                        <div class=\"alert alert-danger\">");
                EndContext();
                BeginContext(1467, 21, false);
#line 30 "C:\Users\engin\SOAIWTTermProject\SmartLondon\SmartLondon\Views\SignUp\Index.cshtml"
                                                   Write(ViewData["userExist"]);

#line default
#line hidden
                EndContext();
                BeginContext(1488, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 31 "C:\Users\engin\SOAIWTTermProject\SmartLondon\SmartLondon\Views\SignUp\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(1519, 90, true);
                WriteLiteral("                    <p class=\"mt-5 mb-3 text-muted\">&copy; 2017-2019</p>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1616, 78, true);
            WriteLiteral("\r\n                \r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
