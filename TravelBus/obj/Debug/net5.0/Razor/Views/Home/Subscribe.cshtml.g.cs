#pragma checksum "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Home\Subscribe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10e4dbec3e0a66f1b5f0065929b3726e8e1462c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Subscribe), @"mvc.1.0.view", @"/Views/Home/Subscribe.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10e4dbec3e0a66f1b5f0065929b3726e8e1462c5", @"/Views/Home/Subscribe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb8b434404d2cf89c0aa5ac6c890a93fb054eda5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Subscribe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Subscribe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Section Subscribe-->
<section class=""section bg-gray-4 text-center offset-top-50"">
    <div class=""parallax-container"" data-parallax-img=""https://blog.mystart.com/wp-content/uploads/shutterstock_330839996-e1523646795412.jpg"">
        <div class=""parallax-content section-xl section-inset-custom-1 context-dark bg-overlay-2-21"">
            <div class=""container"">
                <h2 class=""heading-2 oh font-weight-normal wow slideInDown""><span class=""d-block font-weight-semi-bold"">First-class Impressions</span><span class=""d-block font-weight-light"">are Waiting for You!</span></h2>
                <p class=""text-width-medium text-spacing-75 wow fadeInLeft"" data-wow-delay="".1s"">Our agency offers travelers various tours and excursions with destinations all over the world. Browse our website to find your dream tour!</p>
                <br />
");
#nullable restore
#line 13 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Home\Subscribe.cshtml"
                 using (Html.BeginForm("Subscribe", "Home", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-group row\">\r\n                        <div class=\"col-lg-4\"");
            BeginWriteAttribute("style", " style=\"", 1217, "\"", 1225, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"col-lg-4\"");
            BeginWriteAttribute("style", " style=\"", 1306, "\"", 1314, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 19 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Home\Subscribe.cshtml"
                       Write(Html.TextBoxFor(x=>x.SubscribeMail,new { @class="form-control form-control-lg ", @placeholder = "Enter your email address", @type = "email" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 20 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Home\Subscribe.cshtml"
                       Write(Html.ValidationMessageFor(x=>x.SubscribeMail,"",new { @style= "color:#fff200" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                        <button type=\"submit\" id=\"btn\" class=\"button button-secondary button-pipaluk\">Subscribe</button>\r\n");
#nullable restore
#line 24 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Home\Subscribe.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Subscribe> Html { get; private set; }
    }
}
#pragma warning restore 1591
