#pragma checksum "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Areas\AdminPanel\Views\FlowerExpert\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ea3e957c41c5bc934431efcfaeb0da5c053f225"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_FlowerExpert_Detail), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/FlowerExpert/Detail.cshtml")]
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
#line 1 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Areas\AdminPanel\Views\_ViewImports.cshtml"
using FiorellaFrontoBack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Areas\AdminPanel\Views\_ViewImports.cshtml"
using FiorellaFrontoBack.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ea3e957c41c5bc934431efcfaeb0da5c053f225", @"/Areas/AdminPanel/Views/FlowerExpert/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5217ebb76b4dc451c0dfc21bab7097e24f6cf1b2", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_FlowerExpert_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FlowerItem>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:100px;width:100px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "FlowerExpert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Areas\AdminPanel\Views\FlowerExpert\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body \">\r\n                ");
#nullable restore
#line 10 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Areas\AdminPanel\Views\FlowerExpert\Detail.cshtml"
           Write(ViewBag);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = ~/img/");
#nullable restore
#line 10 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Areas\AdminPanel\Views\FlowerExpert\Detail.cshtml"
                            Write(Model.ImageName);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                <div class=\"mt-5\" style=\"text-align:center;\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6ea3e957c41c5bc934431efcfaeb0da5c053f2255976", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 326, "~/img/", 326, 6, true);
#nullable restore
#line 11 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Areas\AdminPanel\Views\FlowerExpert\Detail.cshtml"
AddHtmlAttributeValue("", 332, Model.ImageName, 332, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </div>\r\n                <h4 class=\"card-title\" style=\"border:2px solid gray; text-align:center; padding:10px;\">");
#nullable restore
#line 12 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Areas\AdminPanel\Views\FlowerExpert\Detail.cshtml"
                                                                                                  Write(Model.ExpertName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <p style=\"border:2px solid gray; text-align:center; padding:10px;\">\r\n                    ");
#nullable restore
#line 14 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Areas\AdminPanel\Views\FlowerExpert\Detail.cshtml"
               Write(Model.ExpertProfession);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <div style=\"text-align:center\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ea3e957c41c5bc934431efcfaeb0da5c053f2258610", async() => {
                WriteLiteral("Go back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FlowerItem> Html { get; private set; }
    }
}
#pragma warning restore 1591
