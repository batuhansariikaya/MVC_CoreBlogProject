#pragma checksum "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb9c7cda3f7dfa1837fd147a5b1f5a827881e6c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Blog_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Blog\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb9c7cda3f7dfa1837fd147a5b1f5a827881e6c6", @"/Areas/Admin/Views/Blog/Index.cshtml")]
    public class Areas_Admin_Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/css/plugins/dataTables/datatables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/js/plugins/dataTables/datatables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/js/plugins/dataTables/dataTables.bootstrap4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eb9c7cda3f7dfa1837fd147a5b1f5a827881e6c64666", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb9c7cda3f7dfa1837fd147a5b1f5a827881e6c65781", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb9c7cda3f7dfa1837fd147a5b1f5a827881e6c66820", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""ibox "">
            <div class=""ibox-title"">
                <h5>Basic Data Tables example with responsive plugin</h5>
                <div class=""ibox-tools"">
                    <a class=""collapse-link"">
                        <i class=""fa fa-chevron-up""></i>
                    </a>
                    <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                        <i class=""fa fa-wrench""></i>
                    </a>
                    <ul class=""dropdown-menu dropdown-user"">
                        <li>
                            <a href=""#"" class=""dropdown-item"">Config option 1</a>
                        </li>
                        <li>
                            <a href=""#"" class=""dropdown-item"">Config option 2</a>
                        </li>
                    </ul>
                    <a class=""close-link"">
                        <i class=""fa fa-times""></i>
                    </a>");
            WriteLiteral(@"
                </div>
            </div>
            <div class=""ibox-content"">

                <div class=""table-responsive"">
                    <table class=""table table-striped table-bordered table-hover dataTables-example"">
                        
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Blog Adı</th>
                                <th>Kategori</th>
                                <th>Durum</th>
                                <th>Tarih</th>
                                <th>İşlemler</th>
                            </tr>
                        </thead>
");
#nullable restore
#line 51 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Blog\Index.cshtml"
                         foreach (var item in Model)
                       {                                               

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tbody>\r\n                            <tr class=\"gradeX\">\r\n                                <td>");
#nullable restore
#line 55 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Blog\Index.cshtml"
                               Write(item.BlogID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                   ");
#nullable restore
#line 57 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Blog\Index.cshtml"
                              Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>kategori</td>\r\n                                <td>");
#nullable restore
#line 60 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Blog\Index.cshtml"
                               Write(item.BlogStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"center\">");
#nullable restore
#line 61 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Blog\Index.cshtml"
                                               Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 2769, "\"", 2811, 2);
            WriteAttributeValue("", 2776, "/Admin/Blog/DeleteBlog/", 2776, 23, true);
#nullable restore
#line 62 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2799, item.BlogID, 2799, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info text-white\">Sil</a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2892, "\"", 2935, 2);
            WriteAttributeValue("", 2899, "/Admin/Blog/GetBlogInfo/", 2899, 24, true);
#nullable restore
#line 63 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2923, item.BlogID, 2923, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success text-white\">Güncelle</a></td>\r\n                               \r\n                            </tr>\r\n                          </tbody>\r\n");
#nullable restore
#line 67 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Blog\Index.cshtml"
                               }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </table>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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