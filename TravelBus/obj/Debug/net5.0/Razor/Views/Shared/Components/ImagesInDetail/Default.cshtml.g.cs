#pragma checksum "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\ImagesInDetail\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e57b8934a4a755580c69515b20cc55a1a152cd59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ImagesInDetail_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ImagesInDetail/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e57b8934a4a755580c69515b20cc55a1a152cd59", @"/Views/Shared/Components/ImagesInDetail/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb8b434404d2cf89c0aa5ac6c890a93fb054eda5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ImagesInDetail_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Image>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\ImagesInDetail\Default.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <h4>Fotograf bulunamadı.</h4>\r\n    <br />\r\n");
#nullable restore
#line 7 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\ImagesInDetail\Default.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <section class=""section section-sm section-top-0 section-fluid section-relative bg-gray-4"">
        <div class=""container-fluid"">
            <h6 class=""gallery-title"">Gallery</h6>
            <!-- Owl Carousel-->
            <div class=""owl-carousel owl-classic owl-dots-secondary"" data-items=""1"" data-sm-items=""2"" data-md-items=""3"" data-lg-items=""3"" data-xl-items=""5"" data-xxl-items=""3"" data-stage-padding=""15"" data-xxl-stage-padding=""0"" data-margin=""30"" data-autoplay=""true"" data-nav=""true"" data-dots=""true"">
                <!-- Thumbnail Classic-->
");
#nullable restore
#line 16 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\ImagesInDetail\Default.cshtml"
                 foreach (var x in Model)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <article class=\"thumbnail thumbnail-mary\">\r\n                        <div class=\"thumbnail-mary-figure\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 933, "\"", 950, 1);
#nullable restore
#line 21 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\ImagesInDetail\Default.cshtml"
WriteAttributeValue("", 939, x.ImageUrl, 939, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 951, "\"", 957, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"270\" height=\"195\" />\r\n                        </div>\r\n                        <div class=\"thumbnail-mary-caption\">\r\n                            <a class=\"icon fl-bigmug-line-zoom60\"");
            BeginWriteAttribute("href", " href=\"", 1147, "\"", 1165, 1);
#nullable restore
#line 24 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\ImagesInDetail\Default.cshtml"
WriteAttributeValue("", 1154, x.ImageUrl, 1154, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-lightgallery=\"item\"><img src=\"images/gallery-image-1-270x195.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1237, "\"", 1243, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"270\" height=\"195\" /></a>\r\n                        </div>\r\n                    </article>\r\n");
#nullable restore
#line 27 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\ImagesInDetail\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 31 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\ImagesInDetail\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Image>> Html { get; private set; }
    }
}
#pragma warning restore 1591