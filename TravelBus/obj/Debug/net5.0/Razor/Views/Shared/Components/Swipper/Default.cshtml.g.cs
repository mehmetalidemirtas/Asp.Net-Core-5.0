#pragma checksum "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\Swipper\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c475084826606a59b64ad4a95024a879f7e2838d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Swipper_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Swipper/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c475084826606a59b64ad4a95024a879f7e2838d", @"/Views/Shared/Components/Swipper/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb8b434404d2cf89c0aa5ac6c890a93fb054eda5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Swipper_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Place>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Swiper-->
<section class=""section swiper-container swiper-slider swiper-slider-corporate swiper-pagination-style-2"" data-loop=""true"" data-autoplay=""5000"" data-simulate-touch=""true"" data-nav=""false"" data-direction=""vertical"">    
    <div class=""swiper-wrapper text-left"">
");
#nullable restore
#line 5 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\Swipper\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"swiper-slide context-dark\" data-slide-bg=\"");
#nullable restore
#line 7 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\Swipper\Default.cshtml"
                                                             Write(item.LocationUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                <div class=""swiper-slide-caption section-md"">
                    <div class=""container"">
                        <div class=""row"">
                            <div class=""col-md-10"">
                                <h6 class=""text-uppercase"" data-caption-animate=""fadeInRight"" data-caption-delay=""0""><span class=""font-weight-bold"">");
#nullable restore
#line 12 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\Swipper\Default.cshtml"
                                                                                                                                               Write(item.Country.CountryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h6>\r\n                                <h2 class=\"oh font-weight-light\" data-caption-animate=\"slideInUp\" data-caption-delay=\"100\"><span class=\"font-weight-bold\">");
#nullable restore
#line 13 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\Swipper\Default.cshtml"
                                                                                                                                                     Write(item.PlaceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h2><a class=\"button button-default-outline button-wapasha\"");
            BeginWriteAttribute("href", " href=\"", 1091, "\"", 1131, 2);
            WriteAttributeValue("", 1098, "/Place/PlaceDetails/", 1098, 20, true);
#nullable restore
#line 13 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\Swipper\Default.cshtml"
WriteAttributeValue("", 1118, item.PlaceID, 1118, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-caption-animate=\"fadeInLeft\" data-caption-delay=\"0\">Read More</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 19 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\Swipper\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    <!-- Swiper Pagination-->\r\n    <div class=\"swiper-pagination\"></div>\r\n</section>");
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
