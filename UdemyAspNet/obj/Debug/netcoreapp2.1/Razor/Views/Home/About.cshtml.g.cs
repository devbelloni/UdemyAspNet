#pragma checksum "D:\PROGRAMAÇÃO\C#\ws-vs2019\UdemyAspNet\UdemyAspNet\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9187c87c40dd1376fc5b30da9a8e25c8df23d173"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "D:\PROGRAMAÇÃO\C#\ws-vs2019\UdemyAspNet\UdemyAspNet\Views\_ViewImports.cshtml"
using UdemyAspNet;

#line default
#line hidden
#line 2 "D:\PROGRAMAÇÃO\C#\ws-vs2019\UdemyAspNet\UdemyAspNet\Views\_ViewImports.cshtml"
using UdemyAspNet.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9187c87c40dd1376fc5b30da9a8e25c8df23d173", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2025f33eaaf7d4457c1408f47f2013dd098e75f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\PROGRAMAÇÃO\C#\ws-vs2019\UdemyAspNet\UdemyAspNet\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(41, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(46, 17, false);
#line 4 "D:\PROGRAMAÇÃO\C#\ws-vs2019\UdemyAspNet\UdemyAspNet\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(63, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(75, 19, false);
#line 5 "D:\PROGRAMAÇÃO\C#\ws-vs2019\UdemyAspNet\UdemyAspNet\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(94, 22, true);
            WriteLiteral("</h3>\r\n\r\n<p>Professor ");
            EndContext();
            BeginContext(117, 21, false);
#line 7 "D:\PROGRAMAÇÃO\C#\ws-vs2019\UdemyAspNet\UdemyAspNet\Views\Home\About.cshtml"
        Write(ViewData["Professor"]);

#line default
#line hidden
            EndContext();
            BeginContext(138, 161, true);
            WriteLiteral("</p>\r\n\r\n<address>\r\n    <strong>More information:</strong> <a href=\"http....\">Site</a>\r\n</address>\r\n\r\n<p>Use this area to provide additional information.</p>\r\n<p>");
            EndContext();
            BeginContext(300, 17, false);
#line 14 "D:\PROGRAMAÇÃO\C#\ws-vs2019\UdemyAspNet\UdemyAspNet\Views\Home\About.cshtml"
Write(ViewData["email"]);

#line default
#line hidden
            EndContext();
            BeginContext(317, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
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
