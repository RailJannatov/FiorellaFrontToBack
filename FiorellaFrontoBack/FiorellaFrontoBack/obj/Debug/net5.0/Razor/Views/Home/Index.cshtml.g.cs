#pragma checksum "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08fa1678de79e31d73ed2f7401a5b1c2b2a7bfb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08fa1678de79e31d73ed2f7401a5b1c2b2a7bfb4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3affbab3dd6dd820638bac0f135457aa2ac4619", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    HomeViewModel homeViewModel = Model;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- SLIDER START -->\r\n\r\n<section id=\"slider\">\r\n    <div class=\"owl-carousel slider\">\r\n");
#nullable restore
#line 13 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\Home\Index.cshtml"
         foreach (var item in homeViewModel.SliderImages)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div> <img");
            BeginWriteAttribute("src", " src=\"", 270, "\"", 291, 2);
            WriteAttributeValue("", 276, "img/", 276, 4, true);
#nullable restore
#line 15 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 280, item.Image, 280, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 292, "\"", 298, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"height:250px; width:250px;\"> </div>\r\n");
#nullable restore
#line 16 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"container context pl-lg-5 ml-lg-3\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-5\">\r\n                <div class=\"text\">\r\n                       ");
#nullable restore
#line 22 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\Home\Index.cshtml"
                  Write(Html.Raw(homeViewModel.Slider.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <p class=\"text-black-50 d-none d-sm-block\">\r\n                       ");
#nullable restore
#line 24 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\Home\Index.cshtml"
                  Write(homeViewModel.Slider.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n                <div class=\"img\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 810, "\"", 851, 2);
            WriteAttributeValue("", 816, "img/", 816, 4, true);
#nullable restore
#line 28 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 820, homeViewModel.Slider.Signature, 820, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 852, "\"", 858, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
            </div>
        </div>
    </div>
</section>

<!-- SLIDER END -->
<!-- PRODUCTS START -->

<section id=""products"">
    <div class=""container"">
        <div class=""row pt-5"">
            <div class=""col-12 d-flex justify-content-between"">
                <ul class=""category-mobile d-md-none list-unstyled"">
                    <li>
                        <a");
            BeginWriteAttribute("href", " href=\"", 1269, "\"", 1276, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"categories mr-2\">Categories</a>\r\n                        <i class=\"fas fa-caret-down\"></i>\r\n                        <ul class=\"category list-unstyled\" style=\"display: none;\">\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1495, "\"", 1502, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n\r\n");
#nullable restore
#line 49 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\Home\Index.cshtml"
                             foreach (var item in homeViewModel.Categories)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1680, "\"", 1687, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 51 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\Home\Index.cshtml"
                                                   Write(item.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 51 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\Home\Index.cshtml"
                                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 52 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </li>\r\n                </ul>\r\n                <ul class=\"category d-none d-md-flex list-unstyled\">\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1949, "\"", 1956, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n");
#nullable restore
#line 58 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\Home\Index.cshtml"
                     foreach (var item in homeViewModel.Categories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2108, "\"", 2115, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 60 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\Home\Index.cshtml"
                                           Write(item.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 60 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\Home\Index.cshtml"
                                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 61 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n                <ul class=\"list-unstyled\">\r\n                    <li>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2311, "\"", 2318, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\">Filter</a>\r\n                        <i class=\"fas fa-caret-down\"></i>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            ");
#nullable restore
#line 72 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("Product"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" 
         
        </div>
    </div>
</section>

<!-- PRODUCTS END -->
<!-- ABOUT START -->

<section id=""about"">
    <div class=""container py-5"">
        <div class=""row py-5"">
            <div class=""col-lg-6"">
                <div class=""img"">
                    <img src=""img/h3-video-img.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 2899, "\"", 2905, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""player position-absolute rounded-circle d-flex align-items-center justify-content-center"">
                        <i class=""fas fa-play fa-lg""></i>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""about-text mt-5 mt-lg-0 px-lg-5"">
                    <h1>Suprise Your <span>Valentine!</span> Let us arrange a smile.</h1>
                    <p class=""py-3"">
                        Where flowers are our inspiration to create lasting memories. Whatever the
                        occasion...
                    </p>
                    <ul class=""list-unstyled"">
                        <li class=""mt-3"">
                            <img src=""img/h1-custom-icon.png"" class=""mr-2""");
            BeginWriteAttribute("alt", " alt=\"", 3720, "\"", 3726, 0);
            EndWriteAttribute();
            WriteLiteral("> Hand picked just\r\n                            for you.\r\n                        </li>\r\n                        <li class=\"mt-3\">\r\n                            <img src=\"img/h1-custom-icon.png\" class=\"mr-2\"");
            BeginWriteAttribute("alt", " alt=\"", 3933, "\"", 3939, 0);
            EndWriteAttribute();
            WriteLiteral("> Unique flower\r\n                            arrangements\r\n                        </li>\r\n                        <li class=\"mt-3\">\r\n                            <img src=\"img/h1-custom-icon.png\" class=\"mr-2\"");
            BeginWriteAttribute("alt", " alt=\"", 4147, "\"", 4153, 0);
            EndWriteAttribute();
            WriteLiteral(@"> Best way to say
                            you care.
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</section>

<!-- ABOUT END -->
<!-- EXPERTS START -->

<section id=""experts"">
    <div class=""container"">
        <div class=""row py-5"">
            <div class=""offset-lg-3 col-lg-6"">
                <div class=""section-title"">
                    <h1>");
#nullable restore
#line 127 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\Home\Index.cshtml"
                   Write(homeViewModel.FlowerTitle.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <p class=\"text-black-50\">\r\n                   ");
#nullable restore
#line 129 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\Home\Index.cshtml"
              Write(homeViewModel.FlowerTitle.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row pb-5\">\r\n            ");
#nullable restore
#line 135 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("FlowerExpertItem",4));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"     
        </div>
    </div>
</section>

<!-- EXPERTS END -->
<!-- SUBSCRIBE START -->

<section id=""subscribe"">
    <div class=""container py-5"">
        <div class=""row py-5"">
            <div class=""col-12"">
                <div class=""content text-center py-5"">
                    <h3>Join The Colorful Bunch!</h3>
                    <div class=""form-group d-flex justify-content-center flex-wrap mt-5"">
                        <input type=""email"" placeholder=""Email Address"" class=""form-control-lg rounded-0"">
                        <button class=""btn btn-danger btn-lg rounded-0 px-5 mt-3 mt-sm-0"">Subscribe</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<!-- SUBSCRIBE END -->
<!-- BLOG START -->

<section id=""blog"">
    <div class=""container"">
        <div class=""row py-5"">
            <div class=""offset-lg-3 col-lg-6"">
                <div class=""section-title"">
                    <h1>");
#nullable restore
#line 167 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\Home\Index.cshtml"
                   Write(homeViewModel.BlogTitle.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <p class=\"text-black-50\">\r\n                        ");
#nullable restore
#line 169 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\Home\Index.cshtml"
                   Write(homeViewModel.BlogTitle.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row pb-5\">\r\n          ");
#nullable restore
#line 175 "C:\Users\Rail\Desktop\Asp.Net MVC\FiorellaFrontToBack\FiorellaFrontoBack\FiorellaFrontoBack\Views\Home\Index.cshtml"
     Write(await Component.InvokeAsync("BlogItem"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</section>

<!-- BLOG END -->
<!-- SAY START -->

<section id=""say"">
    <div class=""container"">
        <div class=""row py-5 justify-content-center"">
            <div class=""col-md-8 col-xl-6"">
                <div class=""owl-carousel say"">
                    <div>
                        <div class=""item text-center"">
                            <div class=""img d-flex justify-content-center"">
                                <img src=""img/testimonial-img-1.png""");
            BeginWriteAttribute("alt", " alt=\"", 6752, "\"", 6758, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""text text-muted pt-3 pb-5"">
                                <i>
                                    Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus
                                    lingua.
                                </i>
                            </div>
                            <div class=""author"">
                                <h6>Anna Barnes</h6>
                                <p class=""text-black-50"">Florist</p>
                            </div>
                        </div>
                    </div>
                    <div>
                        <div class=""item text-center"">
                            <div class=""img d-flex justify-content-center"">
                                <img src=""img/testimonial-img-2.png""");
            BeginWriteAttribute("alt", " alt=\"", 7634, "\"", 7640, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""text text-muted pt-3 pb-5"">
                                <i>
                                    Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo
                                    ligula eget.
                                </i>
                            </div>
                            <div class=""author"">
                                <h6>Jasmine White</h6>
                                <p class=""text-black-50"">Florist</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<!-- SAY END -->
<!-- INSTAGRAM START -->

<section id=""instagram"">
    <div class=""owl-carousel instagram"">
        <div><img src=""img/instagram1.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 8552, "\"", 8558, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n        <div><img src=\"img/instagram2.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 8628, "\"", 8634, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n        <div><img src=\"img/instagram3.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 8704, "\"", 8710, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n        <div><img src=\"img/instagram4.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 8780, "\"", 8786, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n        <div><img src=\"img/instagram5.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 8856, "\"", 8862, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n        <div><img src=\"img/instagram6.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 8932, "\"", 8938, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n        <div><img src=\"img/instagram7.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 9008, "\"", 9014, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n        <div><img src=\"img/instagram8.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 9084, "\"", 9090, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n    </div>\r\n    <div class=\"hastag bg-light text-muted py-2 px-3\">\r\n        #FIORELLO\r\n    </div>\r\n</section>\r\n\r\n<!-- INSTAGRAM END -->\r\n");
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
