#pragma checksum "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Writer\AdminWriterProfilDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76888a4423b1f5acd6d48b9a10b154a31fdb18fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Writer_AdminWriterProfilDetail), @"mvc.1.0.view", @"/Areas/Admin/Views/Writer/AdminWriterProfilDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76888a4423b1f5acd6d48b9a10b154a31fdb18fa", @"/Areas/Admin/Views/Writer/AdminWriterProfilDetail.cshtml")]
    public class Areas_Admin_Views_Writer_AdminWriterProfilDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Writer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Writer\AdminWriterProfilDetail.cshtml"
  
    ViewData["Title"] = "AdminWriterProfilDetail";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Writer\AdminWriterProfilDetail.cshtml"
 using (Html.BeginForm("AdminWriterProfileEdit", "Writer", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Writer\AdminWriterProfilDetail.cshtml"
Write(Html.Label("Yazar Ad"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Writer\AdminWriterProfilDetail.cshtml"
Write(Html.TextBoxFor(x=>x.WriterName,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Writer\AdminWriterProfilDetail.cshtml"
Write(Html.Label("Yazar Soyad"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Writer\AdminWriterProfilDetail.cshtml"
Write(Html.TextBoxFor(x=>x.WriterSurname,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Writer\AdminWriterProfilDetail.cshtml"
Write(Html.Label("Yazar Mail"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Writer\AdminWriterProfilDetail.cshtml"
Write(Html.TextBoxFor(x=>x.WriterMail,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Writer\AdminWriterProfilDetail.cshtml"
Write(Html.Label("Yazar Hakkında"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Writer\AdminWriterProfilDetail.cshtml"
Write(Html.TextBoxFor(x=>x.WriterAbout,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Writer\AdminWriterProfilDetail.cshtml"
Write(Html.Label("Yazar Resim"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Writer\AdminWriterProfilDetail.cshtml"
Write(Html.TextBoxFor(x=>x.WriterImage,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Writer\AdminWriterProfilDetail.cshtml"
Write(Html.Label("Yazar Durum"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Writer\AdminWriterProfilDetail.cshtml"
Write(Html.TextBoxFor(x=>x.WriterStatus,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Writer\AdminWriterProfilDetail.cshtml"
                                                                   
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 27 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Writer\AdminWriterProfilDetail.cshtml"
Write(ViewBag.idd);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Writer> Html { get; private set; }
    }
}
#pragma warning restore 1591
