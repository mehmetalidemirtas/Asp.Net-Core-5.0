#pragma checksum "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\PlaceDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39410c22ed116547ff348a075552b4ffd94d106d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Place_PlaceDetails), @"mvc.1.0.view", @"/Views/Place/PlaceDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39410c22ed116547ff348a075552b4ffd94d106d", @"/Views/Place/PlaceDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb8b434404d2cf89c0aa5ac6c890a93fb054eda5", @"/Views/_ViewImports.cshtml")]
    public class Views_Place_PlaceDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Place>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/PlaceDetails.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\PlaceDetails.cshtml"
  
    ViewData["Title"] = "PlaceDetails";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "39410c22ed116547ff348a075552b4ffd94d106d4145", async() => {
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
            WriteLiteral("\r\n<div class=\"blog-single gray-bg\">\r\n    <div class=\"container\">\r\n        <div class=\"row align-items-start\">\r\n            <div class=\"col-lg-8 m-15px-tb\">\r\n");
#nullable restore
#line 11 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\PlaceDetails.cshtml"
                 foreach (var x in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <article class=\"article\">\r\n\r\n                        <div class=\"article-img\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 549, "\"", 569, 1);
#nullable restore
#line 16 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\PlaceDetails.cshtml"
WriteAttributeValue("", 555, x.LocationUrl, 555, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 570, "\"", 578, 0);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 579, "\"", 585, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"article-title\">\r\n                            <h2>");
#nullable restore
#line 19 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\PlaceDetails.cshtml"
                           Write(x.PlaceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <h6 style=\"text-align:center\">");
#nullable restore
#line 20 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\PlaceDetails.cshtml"
                                                     Write(x.CityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\r\n");
            WriteLiteral("\r\n                        </div>\r\n                        ");
#nullable restore
#line 30 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\PlaceDetails.cshtml"
                   Write(await Component.InvokeAsync("ContentsById", new { id = ViewBag.i }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </article>\r\n");
#nullable restore
#line 32 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\PlaceDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
#nullable restore
#line 33 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\PlaceDetails.cshtml"
           Write(await Component.InvokeAsync("Comment", new { id = ViewBag.i }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 34 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\PlaceDetails.cshtml"
           Write(await Html.PartialAsync("/Views/Comment/AddComment.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
            <div class=""col-lg-4 m-15px-tb blog-aside"">
                <!-- Author -->
                <div class=""widget widget-author"">
                    <div class=""widget-title"">
                        <h3>Author</h3>
                    </div>
                    <div class=""widget-body"">
                        <div class=""media align-items-center"">
                            <div class=""avatar"">
                                <img src=""https://bootdey.com/img/Content/avatar/avatar6.png""");
            BeginWriteAttribute("title", " title=\"", 1950, "\"", 1958, 0);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1959, "\"", 1965, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""media-body"">
                                <h6>Hello, I'm<br> Rachel Roth</h6>
                            </div>
                        </div>
                        <p>I design and develop services for customers of all sizes, specializing in creating stylish, modern websites, web services and online stores</p>
                    </div>
                </div>
                <!-- End Author -->
                <!-- Location -->
                <div class=""widget widget-post"">
                    <div class=""widget-title"">
                        <h3>Location</h3>
                    </div>
");
#nullable restore
#line 60 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\PlaceDetails.cshtml"
                     foreach (var x in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"widget-body\">\r\n                            <iframe");
            BeginWriteAttribute("src", " src=\"", 2817, "\"", 2837, 1);
#nullable restore
#line 63 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\PlaceDetails.cshtml"
WriteAttributeValue("", 2823, x.LocationUrl, 2823, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\" height=\"450\" style=\"border:0;\"");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 2882, "\"", 2900, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\"></iframe>\r\n\r\n                        </div>\r\n");
#nullable restore
#line 66 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\PlaceDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n\r\n                <div class=\"widget widget-post\">\r\n                    <div class=\"widget-title\">\r\n                        <h3>Weather</h3>\r\n                    </div>\r\n");
#nullable restore
#line 73 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\PlaceDetails.cshtml"
                     foreach (var x in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"widget-body\">\r\n                            <div>\r\n                               <i class=\"fa fa-cloud fa-5x\"></i>\r\n                            </div>\r\n                            <h4 class=\"font-bold\">");
#nullable restore
#line 79 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\PlaceDetails.cshtml"
                                             Write(x.CityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <br />\r\n                            <h6 class=\"font-bold\">");
#nullable restore
#line 81 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\PlaceDetails.cshtml"
                                             Write(ViewBag.weather);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \'C</h6>\r\n                        </div>\r\n");
#nullable restore
#line 83 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\PlaceDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>


                <!-- End Location -->
                <!-- Latest Post -->
                <div class=""widget widget-latest-post"">
                    <div class=""widget-title"">
                        <h3>Latest Post</h3>
                    </div>
                    <div class=""widget-body"">
                        <div class=""latest-post-aside media"">
                            <div class=""lpa-left media-body"">
                                <div class=""lpa-title"">
                                    <h5><a href=""#"">Prevent 75% of visitors from google analytics</a></h5>
                                </div>
                                <div class=""lpa-meta"">
                                    <a class=""name"" href=""#"">
                                        Rachel Roth
                                    </a>
                                    <a class=""date"" href=""#"">
                                        26 FEB 2020
                                ");
            WriteLiteral(@"    </a>
                                </div>
                            </div>
                            <div class=""lpa-right"">
                                <a href=""#"">
                                    <img src=""https://via.placeholder.com/400x200/FFB6C1/000000""");
            BeginWriteAttribute("title", " title=\"", 4977, "\"", 4985, 0);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4986, "\"", 4992, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                        </div>
                        <div class=""latest-post-aside media"">
                            <div class=""lpa-left media-body"">
                                <div class=""lpa-title"">
                                    <h5><a href=""#"">Prevent 75% of visitors from google analytics</a></h5>
                                </div>
                                <div class=""lpa-meta"">
                                    <a class=""name"" href=""#"">
                                        Rachel Roth
                                    </a>
                                    <a class=""date"" href=""#"">
                                        26 FEB 2020
                                    </a>
                                </div>
                            </div>
                            <div class=""lpa-right"">
                                <a href=""#"">
                                    <");
            WriteLiteral("img src=\"https://via.placeholder.com/400x200/FFB6C1/000000\"");
            BeginWriteAttribute("title", " title=\"", 6076, "\"", 6084, 0);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 6085, "\"", 6091, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                        </div>
                        <div class=""latest-post-aside media"">
                            <div class=""lpa-left media-body"">
                                <div class=""lpa-title"">
                                    <h5><a href=""#"">Prevent 75% of visitors from google analytics</a></h5>
                                </div>
                                <div class=""lpa-meta"">
                                    <a class=""name"" href=""#"">
                                        Rachel Roth
                                    </a>
                                    <a class=""date"" href=""#"">
                                        26 FEB 2020
                                    </a>
                                </div>
                            </div>
                            <div class=""lpa-right"">
                                <a href=""#"">
                                    <");
            WriteLiteral("img src=\"https://via.placeholder.com/400x200/FFB6C1/000000\"");
            BeginWriteAttribute("title", " title=\"", 7175, "\"", 7183, 0);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 7184, "\"", 7190, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- End Latest Post -->
            </div>
        </div>
    </div>
</div>
");
#nullable restore
#line 161 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Place\PlaceDetails.cshtml"
Write(await Component.InvokeAsync("ImagesInDetail", new { id = ViewBag.i }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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