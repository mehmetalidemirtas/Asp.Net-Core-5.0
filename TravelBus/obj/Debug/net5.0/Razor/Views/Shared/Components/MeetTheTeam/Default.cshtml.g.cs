#pragma checksum "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\MeetTheTeam\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70e54be205a944f6ae643ac1cc04d30359e65bd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MeetTheTeam_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MeetTheTeam/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70e54be205a944f6ae643ac1cc04d30359e65bd7", @"/Views/Shared/Components/MeetTheTeam/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb8b434404d2cf89c0aa5ac6c890a93fb054eda5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MeetTheTeam_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Place>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/MeetTheTeam.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("  <!--  Meet the Team -->\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/MaterialDesign-Webfont/5.3.45/css/materialdesignicons.css\" integrity=\"sha256-NAxhqDvtY0l4xn+YVa6WjAcmd94NNfttjNsDmNatFVc=\" crossorigin=\"anonymous\" />\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "70e54be205a944f6ae643ac1cc04d30359e65bd74252", async() => {
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
<section class=""section section-lg section-top-1 bg-gray-4"">
    <br />
    <br />
    <div class=""container bootdey"">
        <div class=""row"">
            <div class=""col-12 text-center"">
                <div class=""section-title"">
                    <h3>Meet The Team</h3>
                    <p class=""text-muted para-desc mx-auto mb-0"">Build responsive, mobile-first projects on the web with the world's most popular front-end component library.</p>
                </div>
            </div><!--end col-->
        </div><!--end row-->

        <div class=""row"">
");
#nullable restore
#line 19 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\MeetTheTeam\Default.cshtml"
             foreach (var x in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-lg-4 col-md-6 col-12 mt-4 pt-2\">\n    <div class=\"team text-center rounded p-3 py-4\">\n        <img");
            BeginWriteAttribute("src", " src=\"", 1079, "\"", 1099, 1);
#nullable restore
#line 23 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\MeetTheTeam\Default.cshtml"
WriteAttributeValue("", 1085, x.LocationUrl, 1085, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid avatar avatar-medium shadow rounded-pill\"");
            BeginWriteAttribute("alt", " alt=\"", 1159, "\"", 1165, 0);
            EndWriteAttribute();
            WriteLiteral(">\n        <div class=\"content mt-3\">\n            <h4 class=\"title mb-0\">");
#nullable restore
#line 25 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\MeetTheTeam\Default.cshtml"
                              Write(x.PlaceName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
            <small class=""text-muted"">Founder</small>
            <ul class=""list-unstyled mt-3 social-icon social mb-0"">
                <li class=""list-inline-item""><a href=""javascript:void(0)"" class=""rounded""><i class=""mdi mdi-facebook"" title=""Facebook""></i></a></li>
                <li class=""list-inline-item""><a href=""javascript:void(0)"" class=""rounded""><i class=""mdi mdi-instagram"" title=""Instagram""></i></a></li>
                <li class=""list-inline-item""><a href=""javascript:void(0)"" class=""rounded""><i class=""mdi mdi-twitter"" title=""Twitter""></i></a></li>
                <li class=""list-inline-item""><a href=""javascript:void(0)"" class=""rounded""><i class=""mdi mdi-google-plus"" title=""Google +""></i></a></li>
                <li class=""list-inline-item""><a href=""javascript:void(0)"" class=""rounded""><i class=""mdi mdi-linkedin"" title=""Linkedin""></i></a></li>
            </ul><!--end icon-->
        </div>
    </div>
</div><!--end col-->");
#nullable restore
#line 36 "C:\Users\Mehmetali Demirtaş\source\repos\TravelBusProject\TravelBus\Views\Shared\Components\MeetTheTeam\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div><!--end row-->\n    </div>\n</section>\n");
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
