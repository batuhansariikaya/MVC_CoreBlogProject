#pragma checksum "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Widget\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9905e9128618f7bbb72d8a93de263196a396404"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Widget_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Widget/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9905e9128618f7bbb72d8a93de263196a396404", @"/Areas/Admin/Views/Widget/Index.cshtml")]
    public class Areas_Admin_Views_Widget_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/img/a4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle circle-border m-b-md"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/img/a2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Widget\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""wrapper wrapper-content animated fadeInRight"">
        <div class=""row"">
            <div class=""col-lg-3"">
                <div class=""widget style1"">
                        <div class=""row"">
                            <div class=""col-4 text-center"">
                                <i class=""fa fa-trophy fa-5x""></i>
                            </div>
                            <div class=""col-8 text-right"">
                                <span> Toplam Blog</span>
                                <h2 class=""font-bold"">");
#nullable restore
#line 17 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Widget\Index.cshtml"
                                                 Write(ViewBag.blogCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            </div>\r\n                        </div>\r\n                </div>\r\n            </div>\r\n            ");
#nullable restore
#line 22 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Widget\Index.cshtml"
       Write(await Component.InvokeAsync("WeatherAPI"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <div class=""col-lg-3"">
                <div class=""widget style1 lazur-bg"">
                    <div class=""row"">
                        <div class=""col-4"">
                            <i class=""fa fa-envelope-o fa-5x""></i>
                        </div>
                        <div class=""col-8 text-right"">
                            <span> New messages </span>
                            <h2 class=""font-bold"">260</h2>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3"">
                <div class=""widget style1 yellow-bg"">
                    <div class=""row"">
                        <div class=""col-4"">
                            <i class=""fa fa-music fa-5x""></i>
                        </div>
                        <div class=""col-8 text-right"">
                            <span> New albums </span>
                            <h2 class=""font-bold"">12</h2>
                        </div>");
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-6"">
                <div class=""widget navy-bg no-padding"">
                    <div class=""p-m"">
                        <h1 class=""m-xs"">$ 1,540</h1>

                        <h3 class=""font-bold no-margins"">
                            Annual income
                        </h3>
                        <small>Income form project Alpha.</small>
                    </div>
                    <div class=""flot-chart"">
                        <div class=""flot-chart-content"" id=""flot-chart1""></div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3"">
                <div class=""widget lazur-bg no-padding"">
                    <div class=""p-m"">
                        <h1 class=""m-xs"">$ 210,660</h1>

                        <h3 class=""font-bold no-margins"">
                            Monthly incom");
            WriteLiteral(@"e
                        </h3>
                        <small>Income form project Beta.</small>
                    </div>
                    <div class=""flot-chart"">
                        <div class=""flot-chart-content"" id=""flot-chart2""></div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3"">
                <div class=""widget yellw-bg no-padding"">
                    <div class=""p-m"">
                        <h1 class=""m-xs"">$ 50,992</h1>

                        <h3 class=""font-bold no-margins"">
                            Half-year revenue margin
                        </h3>
                        <small>Sales marketing.</small>
                    </div>
                    <div class=""flot-chart"">
                        <div class=""flot-chart-content"" id=""flot-chart3""></div>
                    </div>
                </div>
            </div>
        </div>
            <div class=""row"">
                <div class=""col");
            WriteLiteral(@"-lg-2"">
                    <div class=""widget style1 navy-bg"">
                        <div class=""row vertical-align"">
                            <div class=""col-3"">
                                <i class=""fa fa-user fa-3x""></i>
                            </div>
                            <div class=""col-9 text-right"">
                                <h2 class=""font-bold"">217</h2>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-2"">
                    <div class=""widget style1 navy-bg"">
                        <div class=""row vertical-align"">
                            <div class=""col-3"">
                                <i class=""fa fa-thumbs-up fa-3x""></i>
                            </div>
                            <div class=""col-9 text-right"">
                                <h2 class=""font-bold"">400</h2>
                            </div>
                        </div>
  ");
            WriteLiteral(@"                  </div>
                </div>
                <div class=""col-lg-2"">
                    <div class=""widget style1 navy-bg"">
                        <div class=""row vertical-align"">
                            <div class=""col-3"">
                                <i class=""fa fa-rss fa-3x""></i>
                            </div>
                            <div class=""col-9 text-right"">
                                <h2 class=""font-bold"">10</h2>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-2"">
                    <div class=""widget style1 lazur-bg"">
                        <div class=""row vertical-align"">
                            <div class=""col-3"">
                                <i class=""fa fa-phone fa-3x""></i>
                            </div>
                            <div class=""col-9 text-right"">
                                <h2 class=""font-bold"">120<");
            WriteLiteral(@"/h2>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-2"">
                    <div class=""widget style1 lazur-bg"">
                        <div class=""row vertical-align"">
                            <div class=""col-3"">
                                <i class=""fa fa-euro fa-3x""></i>
                            </div>
                            <div class=""col-9 text-right"">
                                <h2 class=""font-bold"">462</h2>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-2"">
                    <div class=""widget style1 yellow-bg"">
                        <div class=""row vertical-align"">
                            <div class=""col-3"">
                                <i class=""fa fa-shield fa-3x""></i>
                            </div>
                            <div clas");
            WriteLiteral(@"s=""col-9 text-right"">
                                <h2 class=""font-bold"">610</h2>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-4"">
                        <div class=""widget-head-color-box navy-bg p-lg text-center"">
                            <div class=""m-b-md"">
                            <h2 class=""font-bold no-margins"">
                                Alex Smith
                            </h2>
                                <small>Founder of Groupeq</small>
                            </div>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b9905e9128618f7bbb72d8a93de263196a39640413565", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <div>
                                <span>100 Tweets</span> |
                                <span>350 Following</span> |
                                <span>610 Followers</span>
                            </div>
                        </div>
                        <div class=""widget-text-box"">
                            <h4 class=""media-heading"">Alex Smith</h4>
                            <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry.</p>
                            <div class=""text-right"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 8399, "\"", 8406, 0);
            EndWriteAttribute();
            WriteLiteral("  class=\"btn btn-xs btn-white\"><i class=\"fa fa-thumbs-up\"></i> Like </a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 8515, "\"", 8522, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-xs btn-primary""><i class=""fa fa-heart""></i> Love</a>
                            </div>
                        </div>
                </div>
                <div class=""col-lg-2"">
                    <div class=""widget navy-bg p-lg text-center"">
                        <div class=""m-b-md"">
                            <i class=""fa fa-shield fa-4x""></i>
                            <h1 class=""m-xs"">456</h1>
                            <h3 class=""font-bold no-margins"">
                                Shield
                            </h3>
                            <small>power</small>
                        </div>
                    </div>
                    <div class=""widget  p-lg text-center"">
                        <div class=""m-b-md"">
                            <i class=""fa fa-flash fa-4x""></i>
                            <h1 class=""m-xs"">612</h1>
                            <h3 class=""font-bold no-margins"">
                                Thunder
              ");
            WriteLiteral(@"              </h3>
                            <small>amount</small>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-4"">
                    <div class=""widget lazur-bg p-xl"">

                                <h2>
                                    Janet Smith
                                </h2>
                        <ul class=""list-unstyled m-t-md"">
                            <li>
                                <span class=""fa fa-envelope m-r-xs""></span>
                                <label>Email:</label>
                                mike@mail.com
                            </li>
                            <li>
                                <span class=""fa fa-home m-r-xs""></span>
                                <label>Address:</label>
                                Street 200, Avenue 10
                            </li>
                            <li>
                                <span class=""fa f");
            WriteLiteral(@"a-phone m-r-xs""></span>
                                <label>Contact:</label>
                                (+121) 678 3462
                            </li>
                        </ul>

                    </div>
                    <div class=""widget red-bg p-lg text-center"">
                        <div class=""m-b-md"">
                            <i class=""fa fa-bell fa-4x""></i>
                            <h1 class=""m-xs"">47</h1>
                            <h3 class=""font-bold no-margins"">
                                Notification
                            </h3>
                            <small>We detect the error.</small>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-2"">
                <div class=""widget yellow-bg p-lg text-center"">
                    <div class=""m-b-md"">
                        <i class=""fa fa-thumbs-up fa-4x""></i>
                        <h1 class=""m-xs"">520</h1>
               ");
            WriteLiteral(@"         <h3 class=""font-bold no-margins"">
                            Likes
                        </h3>
                        <small>amount</small>
                    </div>
                </div>
                    <div class=""widget yellow-bg p-lg text-center"">
                        <div class=""m-b-md"">
                            <i class=""fa fa-warning fa-4x""></i>
                            <h1 class=""m-xs"">Alarm</h1>
                            <h3 class=""font-bold no-margins"">
                                Do
                            </h3>
                            <small>something</small>
                        </div>
                    </div>
                    </div>
            </div>
        <div class=""row m-t-lg"">
            <div class=""col-lg-6"">
                <div class=""ibox "">

                    <div class=""ibox-content"">

                        <div>
                <div class=""chat-activity-list"">

                    <div class=""chat-ele");
            WriteLiteral("ment\">\r\n                        <a href=\"#\" class=\"float-left\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b9905e9128618f7bbb72d8a93de263196a39640420178", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </a>
                        <div class=""media-body "">
                            <small class=""float-right text-navy"">1m ago</small>
                            <strong>Mike Smith</strong>
                            <p class=""m-b-xs"">
                                Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been
                            </p>
                            <small class=""text-muted"">Today 4:21 pm - 12.06.2014</small>
                        </div>
                    </div>

                    <div class=""chat-element right"">
                        <a href=""#"" class=""float-right"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b9905e9128618f7bbb72d8a93de263196a39640422111", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </a>
                        <div class=""media-body text-right "">
                            <small class=""float-left"">5m ago</small>
                            <strong>John Smith</strong>
                            <p class=""m-b-xs"">
                                Lorem Ipsum is simply dummy text of the printing.
                            </p>
                            <small class=""text-muted"">Today 4:21 pm - 12.06.2014</small>
                        </div>
                    </div>

                    <div class=""chat-element "">
                        <a href=""#"" class=""float-left"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b9905e9128618f7bbb72d8a93de263196a39640423992", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </a>
                        <div class=""media-body "">
                            <small class=""float-right"">2h ago</small>
                            <strong>Mike Smith</strong>
                            <p class=""m-b-xs"">
                                Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been
                            </p>
                            <small class=""text-muted"">Today 4:21 pm - 12.06.2014</small>
                        </div>
                    </div>
                </div>
                </div>
                        <div class=""chat-form"">
                            <form role=""form"">
                                <div class=""form-group"">
                                    <textarea class=""form-control"" placeholder=""Message""></textarea>
                                </div>
                                <div class=""text-right"">
                                    <button type=");
            WriteLiteral(@"""submit"" class=""btn btn-sm btn-primary m-t-n-xs""><strong>Send message</strong></button>
                                </div>
                            </form>
                        </div>
                </div>
                </div>
            </div>
            <div class=""col-lg-6"">
                <div>
                    <table class=""table"">
                        <tbody>
                        <tr>
                            <td>
                                <button type=""button"" class=""btn btn-danger m-r-sm"">12</button>
                                Total messages
                            </td>
                            <td>
                                <button type=""button"" class=""btn btn-primary m-r-sm"">28</button>
                                Posts
                            </td>
                            <td>
                                <button type=""button"" class=""btn btn-info m-r-sm"">15</button>
                               Comments
   ");
            WriteLiteral(@"                         </td>
                        </tr>
                        <tr>
                            <td>
                                <button type=""button"" class=""btn btn-info m-r-sm"">20</button>
                                News
                            </td>
                            <td>
                                <button type=""button"" class=""btn btn-success m-r-sm"">40</button>
                                Likes
                            </td>
                            <td>
                                <button type=""button"" class=""btn btn-danger m-r-sm"">30</button>
                                Notifications
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <button type=""button"" class=""btn btn-warning m-r-sm"">20</button>
                                Albums
                            </td>
                            <td>
        ");
            WriteLiteral(@"                        <button type=""button"" class=""btn btn-default m-r-sm"">40</button>
                                Groups
                            </td>
                            <td>
                                <button type=""button"" class=""btn btn-warning m-r-sm"">30</button>
                                Permissions
                            </td>
                        </tr>
                        </tbody>
                    </table>
                </div>
                <div>
                    <div class=""row"">
                       ");
#nullable restore
#line 393 "C:\Users\Batuhan\source\repos\CoreProject_MVC\CoreProject_MVC\Areas\Admin\Views\Widget\Index.cshtml"
                  Write(await Component.InvokeAsync("LastWriter"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <div class=""col-md-6"">
                            <div class=""ibox-content"">
                                <div>
                                    <div>
                                        <span>Memory</span>
                                        <small class=""float-right"">10/200 GB</small>
                                    </div>
                                    <div class=""progress progress-small"">
                                        <div style=""width: 60%;"" class=""progress-bar""></div>
                                    </div>

                                    <div>
                                        <span>Bandwidth</span>
                                        <small class=""float-right"">20 GB</small>
                                    </div>
                                    <div class=""progress progress-small"">
                                        <div style=""width: 50%;"" class=""progress-bar""></div>
                            ");
            WriteLiteral(@"        </div>

                                    <div>
                                        <span>Activity</span>
                                        <small class=""float-right"">73%</small>
                                    </div>
                                    <div class=""progress progress-small"">
                                        <div style=""width: 40%;"" class=""progress-bar""></div>
                                    </div>

                                    <div>
                                        <span>FTP</span>
                                        <small class=""float-right"">400 GB</small>
                                    </div>
                                    <div class=""progress progress-small"">
                                        <div style=""width: 20%;"" class=""progress-bar progress-bar-danger""></div>
                                    </div>
                                </div>
                            </div>
                        ");
            WriteLiteral(@"</div>
                    </div>

                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-6"">
                <div class=""ibox-content"">
                    <h2>TODO List</h2>
                    <small>This is example of task list</small>
                    <ul class=""todo-list m-t"">
                        <li>
                            <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 20484, "\"", 20492, 0);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 20493, "\"", 20500, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""i-checks""/>
                            <span class=""m-l-xs"">Buy a milk</span>
                            <small class=""label label-primary""><i class=""fa fa-clock-o""></i> 1 mins</small>
                        </li>
                        <li>
                            <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 20810, "\"", 20818, 0);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 20819, "\"", 20826, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""i-checks"" checked/>
                            <span class=""m-l-xs"">Go to shop and find some products.</span>
                            <small class=""label label-info""><i class=""fa fa-clock-o""></i> 3 mins</small>
                        </li>
                        <li>
                            <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 21165, "\"", 21173, 0);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 21174, "\"", 21181, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""i-checks"" />
                            <span class=""m-l-xs"">Send documents to Mike</span>
                            <small class=""label label-warning""><i class=""fa fa-clock-o""></i> 2 mins</small>
                        </li>
                        <li>
                            <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 21504, "\"", 21512, 0);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 21513, "\"", 21520, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""i-checks""/>
                            <span class=""m-l-xs"">Go to the doctor dr Smith</span>
                            <small class=""label label-danger""><i class=""fa fa-clock-o""></i> 42 mins</small>
                        </li>
                    </ul>
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""ibox "">
                    <div class=""ibox-content"">
                        <h2>TODO Small version</h2>
                        <small>This is example of small version of todo list</small>
                        <ul class=""todo-list m-t small-list"">
                            <li>
                                <a href=""#"" class=""check-link""><i class=""fa fa-check-square""></i> </a>
                                <span class=""m-l-xs todo-completed"">Buy a milk</span>

                            </li>
                            <li>
                                <a href=""#"" class=""check-link""><i class=""fa fa-check-squar");
            WriteLiteral(@"e""></i> </a>
                                <span class=""m-l-xs  todo-completed"">Go to shop and find some products.</span>

                            </li>
                            <li>
                                <a href=""#"" class=""check-link""><i class=""fa fa-square-o""></i> </a>
                                <span class=""m-l-xs"">Send documents to Mike</span>
                                <small class=""label label-primary""><i class=""fa fa-clock-o""></i> 1 mins</small>
                            </li>
                            <li>
                                <a href=""#"" class=""check-link""><i class=""fa fa-square-o""></i> </a>
                                <span class=""m-l-xs"">Go to the doctor dr Smith</span>
                            </li>
                            <li>
                                <a href=""#"" class=""check-link""><i class=""fa fa-square-o""></i> </a>
                                <span class=""m-l-xs"">Plan vacation</span>
                            </");
            WriteLiteral(@"li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row m-t-lg"">
            <div class=""col-lg-12"">
                <div class=""ibox-content"">
                    <h2>Word map</h2>
                    <small>This is simple example of map</small>
                <div id=""world-map"" style=""height: 300px;""></div>
                    </div>
            </div>

        </div>

        </div>");
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
