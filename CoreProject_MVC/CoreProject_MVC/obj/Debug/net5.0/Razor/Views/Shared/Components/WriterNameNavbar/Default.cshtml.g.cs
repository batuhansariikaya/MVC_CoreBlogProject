#pragma checksum "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Views\Shared\Components\WriterNameNavbar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec470502b789740d076eccebc21123d142b6d2bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterNameNavbar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterNameNavbar/Default.cshtml")]
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
#line 1 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Views\_ViewImports.cshtml"
using MVC_CoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Views\_ViewImports.cshtml"
using MVC_CoreProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec470502b789740d076eccebc21123d142b6d2bf", @"/Views/Shared/Components/WriterNameNavbar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"489d51d8aff94f7b19f5c397c763638bcd9574ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_WriterNameNavbar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"nav-profile-text d-flex flex-column\">\r\n    <span class=\"font-weight-bold mb-2\">");
#nullable restore
#line 2 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Views\Shared\Components\WriterNameNavbar\Default.cshtml"
                                   Write(ViewBag.writerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    <span class=\"text-secondary text-small\">");
#nullable restore
#line 3 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Views\Shared\Components\WriterNameNavbar\Default.cshtml"
                                       Write(ViewBag.mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</div>");
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