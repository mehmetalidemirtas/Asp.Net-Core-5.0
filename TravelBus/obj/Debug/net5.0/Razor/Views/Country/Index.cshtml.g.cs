#pragma checksum "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Country\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3812f0e64a12ece971d8c418819c5367a85e2ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Country_Index), @"mvc.1.0.view", @"/Views/Country/Index.cshtml")]
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
#line 1 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Country\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Country\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Country\Index.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3812f0e64a12ece971d8c418819c5367a85e2ad", @"/Views/Country/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb8b434404d2cf89c0aa5ac6c890a93fb054eda5", @"/Views/_ViewImports.cshtml")]
    public class Views_Country_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<EntityLayer.Concrete.Country>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Country\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/MaterialDesign-Webfont/5.3.45/css/materialdesignicons.css\" integrity=\"sha256-NAxhqDvtY0l4xn+YVa6WjAcmd94NNfttjNsDmNatFVc=\" crossorigin=\"anonymous\" />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b3812f0e64a12ece971d8c418819c5367a85e2ad5285", async() => {
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
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html class=\"wide wow-animation\" lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3812f0e64a12ece971d8c418819c5367a85e2ad6469", async() => {
                WriteLiteral("\r\n    <title>Countries</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3812f0e64a12ece971d8c418819c5367a85e2ad7467", async() => {
                WriteLiteral(@"
    <div class=""page"">
        <!-- Breadcrumbs -->
        <section class=""breadcrumbs-custom-inset"">
            <div class=""breadcrumbs-custom context-dark bg-overlay-40"">
                <div class=""container"">
                    <h2 class=""breadcrumbs-custom-title"">Countries</h2>
                    <ul class=""breadcrumbs-custom-path"">
                        <li><a href=""/Home/Index/"">Home</a></li>
                        <li class=""active"">Countries</li>
                    </ul>
                </div>
                <div class=""box-position"" style=""background-image: url(https://www.desktopbackground.org/download/o/2011/08/23/254359_ocean-views-wallpapers-wallpapers-cave_1920x1080_h.jpg);""></div>
            </div>
        </section>
        <section class=""section section-lg section-top-0 bg-gray-4"">
            <div class=""container offset-negative-1"">
                <div class=""box-categories cta-box-wrap"">
                    <div class=""box-categories-content"">
             ");
                WriteLiteral("           <div class=\"row justify-content-center\">\r\n");
#nullable restore
#line 37 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Country\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <div class=""col-xl-3 col-md-6 col-sm-6 wow fadeInDown col-9"" data-wow-delay="".2s"">
                                    <ul class=""list-marked-2 box-categories-list"">
                                        <li>
                                            <a");
                BeginWriteAttribute("href", " href=\"", 2065, "\"", 2108, 2);
                WriteAttributeValue("", 2072, "/Place/ListAllPlaces/", 2072, 21, true);
#nullable restore
#line 42 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Country\Index.cshtml"
WriteAttributeValue("", 2093, item.CountryID, 2093, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><img");
                BeginWriteAttribute("src", " src=\"", 2114, "\"", 2138, 1);
#nullable restore
#line 42 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Country\Index.cshtml"
WriteAttributeValue("", 2120, item.ImageCountry, 2120, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\" display: inline-block; \"");
                BeginWriteAttribute("alt", " alt=\"", 2172, "\"", 2178, 0);
                EndWriteAttribute();
                WriteLiteral(" width=\"368\" height=\"300\" /></a>\r\n                                            <h5 class=\"box-categories-title\">");
#nullable restore
#line 43 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Country\Index.cshtml"
                                                                        Write(item.CountryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                                        </li>\r\n                                    </ul>\r\n                                    <br />\r\n                                </div>\r\n");
#nullable restore
#line 48 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Country\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            ");
#nullable restore
#line 53 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Country\Index.cshtml"
       Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page }), new PagedListRenderOptions
                     {
                              DisplayLinkToIndividualPages = true,
                              DisplayPageCountAndCurrentLocation = true,
                              LiElementClasses = new string[] { "page-item" },
                         PageClasses = new string[] { "page-link" },

      }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </section>\r\n      \r\n    </div><!--end row-->\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<EntityLayer.Concrete.Country>> Html { get; private set; }
    }
}
#pragma warning restore 1591