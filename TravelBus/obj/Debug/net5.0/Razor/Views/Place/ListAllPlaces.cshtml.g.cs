#pragma checksum "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\ListAllPlaces.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6b79753e9972a79d791f16113eafeff8db5d3b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Place_ListAllPlaces), @"mvc.1.0.view", @"/Views/Place/ListAllPlaces.cshtml")]
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
#line 1 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\ListAllPlaces.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\ListAllPlaces.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\ListAllPlaces.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6b79753e9972a79d791f16113eafeff8db5d3b7", @"/Views/Place/ListAllPlaces.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb8b434404d2cf89c0aa5ac6c890a93fb054eda5", @"/Views/_ViewImports.cshtml")]
    public class Views_Place_ListAllPlaces : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<EntityLayer.Concrete.Place>>
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
#nullable restore
#line 6 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\ListAllPlaces.cshtml"
  
    ViewData["Title"] = "ListAllPlaces";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/MaterialDesign-Webfont/5.3.45/css/materialdesignicons.css\" integrity=\"sha256-NAxhqDvtY0l4xn+YVa6WjAcmd94NNfttjNsDmNatFVc=\" crossorigin=\"anonymous\" />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d6b79753e9972a79d791f16113eafeff8db5d3b75065", async() => {
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
            WriteLiteral(@"
    <div class=""page"">
        <!-- Breadcrumbs -->
        <section class=""breadcrumbs-custom-inset"">
            <div class=""breadcrumbs-custom context-dark bg-overlay-60"">
                <div class=""container"">
                    <h2 class=""breadcrumbs-custom-title"">About</h2>
                    <ul class=""breadcrumbs-custom-path"">
                        <li><a href=""index.html"">Home</a></li>
                        <li class=""active"">About</li>
                    </ul>
                </div>
                <div class=""box-position"" style=""background-image: url(https://www.desktopbackground.org/download/o/2011/08/23/254359_ocean-views-wallpapers-wallpapers-cave_1920x1080_h.jpg);""></div>
            </div>
        </section>
        <section class=""section section-sm section-first bg-default section-md section-xl section-lg section-xs"">
            <div class=""container"">
                <h3>Best Destinations</h3>
                <div class=""row row-30"">
                    <div cl");
            WriteLiteral("ass=\"row\">\r\n");
#nullable restore
#line 31 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\ListAllPlaces.cshtml"
                         foreach (var x in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-lg-4 col-md-6 mt-4 pt-2"">
                                <div class=""blog-post rounded border"">
                                    <div class=""blog-img d-block overflow-hidden position-relative"">
                                        <img");
            BeginWriteAttribute("src", " src=\"", 1899, "\"", 1919, 1);
#nullable restore
#line 36 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\ListAllPlaces.cshtml"
WriteAttributeValue("", 1905, x.LocationUrl, 1905, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid rounded-top\">\r\n                                        <div class=\"overlay rounded-top bg-dark\"></div>\r\n                                        <div class=\"post-meta\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2153, "\"", 2191, 3);
            WriteAttributeValue("", 2160, "/Place/PlaceDetails/", 2160, 20, true);
#nullable restore
#line 39 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\ListAllPlaces.cshtml"
WriteAttributeValue("", 2180, x.PlaceID, 2180, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2190, "/", 2190, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""text-light read-more"">Read More <i class=""mdi mdi-chevron-right""></i></a>
                                        </div>
                                    </div>
                                    <div class=""content p-3"">
                                        <small class=""text-muted p float-right"">");
#nullable restore
#line 43 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\ListAllPlaces.cshtml"
                                                                            Write(((DateTime)x.CreatedDate).ToString("dd-MMMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                        <small><a href=\"javascript:void(0)\" class=\"text-primary\"></a></small>\r\n                                        <h4 class=\"mt-2\"><a");
            BeginWriteAttribute("href", " href=\"", 2743, "\"", 2781, 3);
            WriteAttributeValue("", 2750, "/Place/PlaceDetails/", 2750, 20, true);
#nullable restore
#line 45 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\ListAllPlaces.cshtml"
WriteAttributeValue("", 2770, x.PlaceID, 2770, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2780, "/", 2780, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-dark title\">");
#nullable restore
#line 45 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\ListAllPlaces.cshtml"
                                                                                                                      Write(x.PlaceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                        <p class=\"text-muted mt-2\">Explore the ");
#nullable restore
#line 46 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\ListAllPlaces.cshtml"
                                                                          Write(x.PlaceName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" in ");
#nullable restore
#line 46 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\ListAllPlaces.cshtml"
                                                                                          Write(x.CityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("...</p>\r\n                                    </div>\r\n                                </div><!--end blog post-->\r\n                            </div><!--end col-->\r\n");
#nullable restore
#line 50 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\ListAllPlaces.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div><!--end row-->\r\n                </div>\r\n            </div>\r\n            <br />\r\n            ");
#nullable restore
#line 55 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\ListAllPlaces.cshtml"
       Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("ListAllPlaces", new { page }), new PagedListRenderOptions
                   {
                            DisplayLinkToIndividualPages = true,
                            DisplayPageCountAndCurrentLocation = true,
                            LiElementClasses = new string[] { "page-item" },
                       PageClasses = new string[] { "page-link" },

    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </section>\r\n    </div><!--end row-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<EntityLayer.Concrete.Place>> Html { get; private set; }
    }
}
#pragma warning restore 1591