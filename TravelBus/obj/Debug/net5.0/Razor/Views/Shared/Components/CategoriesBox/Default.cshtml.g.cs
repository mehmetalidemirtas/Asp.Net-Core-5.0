#pragma checksum "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\CategoriesBox\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "459d9328b33ebb6e06382328e88ad35b9d066c6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoriesBox_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoriesBox/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"459d9328b33ebb6e06382328e88ad35b9d066c6d", @"/Views/Shared/Components/CategoriesBox/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb8b434404d2cf89c0aa5ac6c890a93fb054eda5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoriesBox_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Country>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Section Box Categories-->
<section class=""section section-lg section-top-1 bg-gray-4"">
    <div class=""container offset-negative-1"">
        <div class=""box-categories cta-box-wrap"">
            <div class=""box-categories-content"">
                <div class=""row justify-content-center"">
");
#nullable restore
#line 8 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\CategoriesBox\Default.cshtml"
                     foreach(var item in Model)
                    { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-4 wow fadeInDown col-9\" data-wow-delay=\".2s\">\r\n                            <ul class=\"list-marked-2 box-categories-list\">\r\n                                <li>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 665, "\"", 708, 2);
            WriteAttributeValue("", 672, "/Place/ListAllPlaces/", 672, 21, true);
#nullable restore
#line 13 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\CategoriesBox\Default.cshtml"
WriteAttributeValue("", 693, item.CountryID, 693, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 714, "\"", 738, 1);
#nullable restore
#line 13 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\CategoriesBox\Default.cshtml"
WriteAttributeValue("", 720, item.ImageCountry, 720, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\" display: inline-block; \"");
            BeginWriteAttribute("alt", " alt=\"", 772, "\"", 778, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"368\" height=\"300\" /></a>\r\n                                    <h5 class=\"box-categories-title\">");
#nullable restore
#line 14 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\CategoriesBox\Default.cshtml"
                                                                Write(item.CountryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                </li>\r\n                            </ul>\r\n                        </div>\r\n");
#nullable restore
#line 18 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\CategoriesBox\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div><a class=\"link-classic wow fadeInUp\" href=\"/Country/Index/\">Other Countries<span></span></a>\r\n        <!-- Owl Carousel-->\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Country>> Html { get; private set; }
    }
}
#pragma warning restore 1591