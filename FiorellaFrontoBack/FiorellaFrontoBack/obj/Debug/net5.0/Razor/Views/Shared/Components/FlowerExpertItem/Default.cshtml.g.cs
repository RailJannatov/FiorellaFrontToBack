#pragma checksum "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\Shared\Components\FlowerExpertItem\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a94e00c5d7020a8457369c3358e91be2226ded4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FlowerExpertItem_Default), @"mvc.1.0.view", @"/Views/Shared/Components/FlowerExpertItem/Default.cshtml")]
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
#line 1 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\_ViewImports.cshtml"
using FiorellaFrontoBack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\_ViewImports.cshtml"
using FiorellaFrontoBack.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a94e00c5d7020a8457369c3358e91be2226ded4b", @"/Views/Shared/Components/FlowerExpertItem/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3affbab3dd6dd820638bac0f135457aa2ac4619", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_FlowerExpertItem_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FlowerItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:200px;height:200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\Shared\Components\FlowerExpertItem\Default.cshtml"
  foreach(var item in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-lg-3\">\r\n                    <div class=\"item text-center\">\r\n                        <div class=\"img\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a94e00c5d7020a8457369c3358e91be2226ded4b4910", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 246, "~/img/", 246, 6, true);
#nullable restore
#line 7 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\Shared\Components\FlowerExpertItem\Default.cshtml"
AddHtmlAttributeValue("", 252, item.ImageName, 252, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                     <div class=\"text mt-3\">\r\n                           <h6>");
#nullable restore
#line 10 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\Shared\Components\FlowerExpertItem\Default.cshtml"
                          Write(item.ExpertName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                       <p class=\"text-black-50\">");
#nullable restore
#line 11 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\Shared\Components\FlowerExpertItem\Default.cshtml"
                                           Write(item.ExpertProfession);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                       </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 15 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\Shared\Components\FlowerExpertItem\Default.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        \r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FlowerItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
