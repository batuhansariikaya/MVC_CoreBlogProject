#pragma checksum "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Views\Shared\Components\WriterName\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c54fc6ad5049bc40e2db2aec6d0797bcd2fd3f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterName_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterName/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c54fc6ad5049bc40e2db2aec6d0797bcd2fd3f1", @"/Views/Shared/Components/WriterName/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"489d51d8aff94f7b19f5c397c763638bcd9574ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_WriterName_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" <div class=\"nav-profile-text\">\r\n                  <p class=\"mb-1 text-black\">");
#nullable restore
#line 2 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Views\Shared\Components\WriterName\Default.cshtml"
                                        Write(ViewBag.writerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>");
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
