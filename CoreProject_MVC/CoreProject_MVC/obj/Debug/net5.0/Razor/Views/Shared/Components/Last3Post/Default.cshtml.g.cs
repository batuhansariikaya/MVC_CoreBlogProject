#pragma checksum "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Views\Shared\Components\Last3Post\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9df0b7f979bdd59c42d0514b02b81e319d42daa3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Last3Post_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Last3Post/Default.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Views\Shared\Components\Last3Post\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9df0b7f979bdd59c42d0514b02b81e319d42daa3", @"/Views/Shared/Components/Last3Post/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"489d51d8aff94f7b19f5c397c763638bcd9574ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Last3Post_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"tech-btm\">\r\n    <h3>Son Postlar</h3>\r\n");
#nullable restore
#line 6 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Views\Shared\Components\Last3Post\Default.cshtml"
     foreach (var item in Model)
   {         

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"blog-grids row mb-3\">\r\n        <div class=\"col-md-5 blog-grid-left\">\r\n            <a href=\"single.html\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 290, "\"", 311, 1);
#nullable restore
#line 11 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Views\Shared\Components\Last3Post\Default.cshtml"
WriteAttributeValue("", 296, item.BlogImage, 296, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 330, "\"", 336, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </a>\r\n        </div>\r\n        <div class=\"col-md-7 blog-grid-right\">\r\n\r\n            <h5>\r\n                <a href=\"single.html\">");
#nullable restore
#line 17 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Views\Shared\Components\Last3Post\Default.cshtml"
                                 Write(item.BlogContent.Substring(0,25));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n            </h5>\r\n            <div class=\"sub-meta\">\r\n                <span>\r\n                    <i class=\"far fa-clock\"></i>");
#nullable restore
#line 21 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Views\Shared\Components\Last3Post\Default.cshtml"
                                            Write(((DateTime)@item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 27 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Views\Shared\Components\Last3Post\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591