#pragma checksum "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Views\Writer\WriterProfileEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0943213042e8929ea45b5b555ff4a2731560d214"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Writer_WriterProfileEdit), @"mvc.1.0.view", @"/Views/Writer/WriterProfileEdit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0943213042e8929ea45b5b555ff4a2731560d214", @"/Views/Writer/WriterProfileEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"489d51d8aff94f7b19f5c397c763638bcd9574ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Writer_WriterProfileEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Writer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Views\Writer\WriterProfileEdit.cshtml"
  
    ViewData["Title"] = "WriterProfileEdit";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h4 class=\"card-title\">Basic form elements</h4>\r\n            <p class=\"card-description\"> Basic form elements </p>\r\n");
#nullable restore
#line 12 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Views\Writer\WriterProfileEdit.cshtml"
             using (Html.BeginForm("WriterProfileEdit", "Writer", FormMethod.Post))
            {
                   

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Views\Writer\WriterProfileEdit.cshtml"
              Write(Html.HiddenFor(x=>x.WriterID));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group\">\r\n                    <label for=\"exampleInputName1\">İsim</label>\r\n                    ");
#nullable restore
#line 17 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Views\Writer\WriterProfileEdit.cshtml"
               Write(Html.TextBoxFor(x=>x.WriterName,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"exampleInputName1\">Soyisim</label>\r\n                    ");
#nullable restore
#line 21 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Views\Writer\WriterProfileEdit.cshtml"
               Write(Html.TextBoxFor(x=>x.WriterSurname,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"exampleInputEmail3\">E-mail</label>\r\n                    ");
#nullable restore
#line 25 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Views\Writer\WriterProfileEdit.cshtml"
               Write(Html.TextBoxFor(x=>x.WriterMail,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"exampleInputPassword4\">Password</label>\r\n                    ");
#nullable restore
#line 29 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Views\Writer\WriterProfileEdit.cshtml"
               Write(Html.TextBoxFor(x=>x.WriterPassword,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                  <div class=\"form-group\">\r\n                    <label for=\"exampleInputPassword4\">hakkında</label>\r\n                    ");
#nullable restore
#line 33 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Views\Writer\WriterProfileEdit.cshtml"
               Write(Html.TextBoxFor(x=>x.WriterAbout,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                  <div class=\"form-group\">\r\n                    <label for=\"exampleInputPassword4\">image</label>\r\n                    ");
#nullable restore
#line 37 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Views\Writer\WriterProfileEdit.cshtml"
               Write(Html.TextBoxFor(x=>x.WriterImage,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <div class=""form-group"">
                    <label>Yazar Görsel </label>
                    <input type=""file"" name=""img[]"" class=""file-upload-default"">
                    <div class=""input-group col-xs-12"">
                        <input type=""text"" class=""form-control file-upload-info"" disabled placeholder=""Upload Image"">
                        <span class=""input-group-append"">
                            <button class=""file-upload-browse btn btn-gradient-primary"" type=""button"">Upload</button>
                        </span>
                    </div>
                </div>
");
            WriteLiteral("                <button  class=\"btn btn-gradient-primary mr-2\">Güncelle</button>\r\n                <button class=\"btn btn-light\">Cancel</button>\r\n");
#nullable restore
#line 59 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Views\Writer\WriterProfileEdit.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
