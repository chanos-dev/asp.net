#pragma checksum "C:\Users\Chanos\Desktop\git\asp.net\asp.net\MyWeb\MyWeb.HomeWeb\Views\Home\BoardList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c95ab673dba072fb8d9c64cc873832b981c13c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BoardList), @"mvc.1.0.view", @"/Views/Home/BoardList.cshtml")]
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
#line 1 "C:\Users\Chanos\Desktop\git\asp.net\asp.net\MyWeb\MyWeb.HomeWeb\Views\_ViewImports.cshtml"
using MyWeb.HomeWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Chanos\Desktop\git\asp.net\asp.net\MyWeb\MyWeb.HomeWeb\Views\_ViewImports.cshtml"
using MyWeb.HomeWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c95ab673dba072fb8d9c64cc873832b981c13c9", @"/Views/Home/BoardList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d515280afbb24f34010e28d208872f4ac0784a77", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BoardList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BoardModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table table-striped table-bordered no-wrap"">
                        <colgroup>
                            <col style=""width:100px"" />
                            <col style=""width:auto"" />
                            <col style=""width:150px"" />
                            <col style=""width:120px"" />
                        </colgroup>
                        <thead>
                            <tr>
                                <th>??????</th>
                                <th>??????</th>
                                <th>?????????</th>
                                <th>?????????</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 27 "C:\Users\Chanos\Desktop\git\asp.net\asp.net\MyWeb\MyWeb.HomeWeb\Views\Home\BoardList.cshtml"
                             foreach (var item in @Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\n                                    <th>");
#nullable restore
#line 30 "C:\Users\Chanos\Desktop\git\asp.net\asp.net\MyWeb\MyWeb.HomeWeb\Views\Home\BoardList.cshtml"
                                   Write(item.Idx);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                    <th><a");
            BeginWriteAttribute("href", " href=\"", 1123, "\"", 1159, 2);
            WriteAttributeValue("", 1130, "/home/boardview?idx=", 1130, 20, true);
#nullable restore
#line 31 "C:\Users\Chanos\Desktop\git\asp.net\asp.net\MyWeb\MyWeb.HomeWeb\Views\Home\BoardList.cshtml"
WriteAttributeValue("", 1150, item.Idx, 1150, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "C:\Users\Chanos\Desktop\git\asp.net\asp.net\MyWeb\MyWeb.HomeWeb\Views\Home\BoardList.cshtml"
                                                                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></th>\n                                    <th>");
#nullable restore
#line 32 "C:\Users\Chanos\Desktop\git\asp.net\asp.net\MyWeb\MyWeb.HomeWeb\Views\Home\BoardList.cshtml"
                                   Write(item.RegUsername);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                    <th>");
#nullable restore
#line 33 "C:\Users\Chanos\Desktop\git\asp.net\asp.net\MyWeb\MyWeb.HomeWeb\Views\Home\BoardList.cshtml"
                                   Write(item.RegDate.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                </tr> \n");
#nullable restore
#line 35 "C:\Users\Chanos\Desktop\git\asp.net\asp.net\MyWeb\MyWeb.HomeWeb\Views\Home\BoardList.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                    </table>\n                </div>\n\n");
#nullable restore
#line 40 "C:\Users\Chanos\Desktop\git\asp.net\asp.net\MyWeb\MyWeb.HomeWeb\Views\Home\BoardList.cshtml"
                 if (Model.Count < 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-info\">???????????? ????????????.</div>\r\n");
#nullable restore
#line 43 "C:\Users\Chanos\Desktop\git\asp.net\asp.net\MyWeb\MyWeb.HomeWeb\Views\Home\BoardList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <div class=\"text-right\">\n                    <a href=\"/home/boardwrite\" class=\"btn btn-sm btn-warning\">?????????</a>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BoardModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
