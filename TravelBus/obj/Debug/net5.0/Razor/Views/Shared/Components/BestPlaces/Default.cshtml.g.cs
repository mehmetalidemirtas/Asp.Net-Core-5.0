#pragma checksum "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\BestPlaces\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9aa0ba0b6416dd8cb6cc19bceb12fbce6759d212"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BestPlaces_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BestPlaces/Default.cshtml")]
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
#line 1 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\_ViewImports.cshtml"
using TravelBus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\_ViewImports.cshtml"
using TravelBus.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\BestPlaces\Default.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\BestPlaces\Default.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aa0ba0b6416dd8cb6cc19bceb12fbce6759d212", @"/Views/Shared/Components/BestPlaces/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb8b434404d2cf89c0aa5ac6c890a93fb054eda5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BestPlaces_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Place>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/BlogList.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("<!--\tOur Services-->\r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/MaterialDesign-Webfont/5.3.45/css/materialdesignicons.css\" integrity=\"sha256-NAxhqDvtY0l4xn+YVa6WjAcmd94NNfttjNsDmNatFVc=\" crossorigin=\"anonymous\" />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9aa0ba0b6416dd8cb6cc19bceb12fbce6759d2124724", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<section class=\"section section-sm\">\r\n    <div class=\"container\">\r\n        <h3>Popular Places</h3>\r\n        <div class=\"row row-30\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 13 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\BestPlaces\Default.cshtml"
                 foreach (var x in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-lg-4 col-md-6 mt-4 pt-2"">
                        <div class=""blog-post rounded border"">
                            <div class=""blog-img d-block overflow-hidden position-relative"">
                                <img");
            BeginWriteAttribute("src", " src=\"", 877, "\"", 897, 1);
#nullable restore
#line 18 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\BestPlaces\Default.cshtml"
WriteAttributeValue("", 883, x.LocationUrl, 883, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid rounded-top\"");
            BeginWriteAttribute("alt", " alt=\"", 928, "\"", 934, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"overlay rounded-top bg-dark\"></div>\r\n                                <div class=\"post-meta\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1114, "\"", 1152, 3);
            WriteAttributeValue("", 1121, "/Place/PlaceDetails/", 1121, 20, true);
#nullable restore
#line 21 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\BestPlaces\Default.cshtml"
WriteAttributeValue("", 1141, x.PlaceID, 1141, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1151, "/", 1151, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""text-light read-more"">Read More <i class=""mdi mdi-chevron-right""></i></a>
                                </div>
                            </div>
                            <div class=""content p-3"">
                                <small class=""text-muted p float-right"">");
#nullable restore
#line 25 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\BestPlaces\Default.cshtml"
                                                                    Write(((DateTime)x.CreatedDate).ToString("dd-MMMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                <small><a");
            BeginWriteAttribute("href", " href=\"", 1543, "\"", 1583, 2);
            WriteAttributeValue("", 1550, "/Place/ListAllPlaces/", 1550, 21, true);
#nullable restore
#line 26 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\BestPlaces\Default.cshtml"
WriteAttributeValue("", 1571, x.CountryID, 1571, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-primary\">");
#nullable restore
#line 26 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\BestPlaces\Default.cshtml"
                                                                                                   Write(x.Country.CountryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></small>\r\n                                <h4 class=\"mt-2\"><a");
            BeginWriteAttribute("href", " href=\"", 1693, "\"", 1731, 3);
            WriteAttributeValue("", 1700, "/Place/PlaceDetails/", 1700, 20, true);
#nullable restore
#line 27 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\BestPlaces\Default.cshtml"
WriteAttributeValue("", 1720, x.PlaceID, 1720, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1730, "/", 1730, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-dark title\">");
#nullable restore
#line 27 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\BestPlaces\Default.cshtml"
                                                                                                              Write(x.PlaceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                <p class=\"text-muted mt-2\">Explore the ");
#nullable restore
#line 28 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\BestPlaces\Default.cshtml"
                                                                  Write(x.PlaceName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" in ");
#nullable restore
#line 28 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\BestPlaces\Default.cshtml"
                                                                                  Write(x.CityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("...</p>\r\n                            </div>\r\n                        </div><!--end blog post-->\r\n                    </div><!--end col-->\r\n");
#nullable restore
#line 32 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\BestPlaces\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div><!--end row-->\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Place>> Html { get; private set; }
    }
}
#pragma warning restore 1591