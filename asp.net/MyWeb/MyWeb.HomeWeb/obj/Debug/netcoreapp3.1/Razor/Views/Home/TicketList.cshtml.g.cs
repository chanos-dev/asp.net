#pragma checksum "C:\Users\Chanos\Desktop\git\asp.net\asp.net\MyWeb\MyWeb.HomeWeb\Views\Home\TicketList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a5006e0fc9deccc660b76d5ee5c08294357fa19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TicketList), @"mvc.1.0.view", @"/Views/Home/TicketList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a5006e0fc9deccc660b76d5ee5c08294357fa19", @"/Views/Home/TicketList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d515280afbb24f34010e28d208872f4ac0784a77", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TicketList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TicketModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Chanos\Desktop\git\asp.net\asp.net\MyWeb\MyWeb.HomeWeb\Views\Home\TicketList.cshtml"
  
    //var dt = ViewData["dt"] as System.Data.DataTable;

    //string title = string.Empty;
    //int ticket_id = 0;

    //if (dt.Rows.Count > 0)
    //{
    //    ticket_id = (dt.Rows[0]["ticket_id"] as int?).GetValueOrDefault(0);
    //    title = dt.Rows[0]["title"] as string;
    //}

    //var list = ViewData["list"] as List<TicketModel>;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--Axios CDN-->
<script src=""https://unpkg.com/axios/dist/axios.min.js""></script>

<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""row"">
                    <!-- Column -->
                    <div class=""col-md-6 col-lg-3 col-xlg-3"">
                        <div class=""card card-hover"">
                            <div class=""p-2 bg-primary text-center"">
                                <h1 class=""font-light text-white"">2,064</h1>
                                <h6 class=""text-white"">Total Tickets</h6>
                            </div>
                        </div>
                    </div>
                    <!-- Column -->
                    <div class=""col-md-6 col-lg-3 col-xlg-3"">
                        <div class=""card card-hover"">
                            <div class=""p-2 bg-cyan text-center"">
                                <h1 class=""font-light text-white"">1,738</h1>
                ");
            WriteLiteral(@"                <h6 class=""text-white"">Responded</h6>
                            </div>
                        </div>
                    </div>
                    <!-- Column -->
                    <div class=""col-md-6 col-lg-3 col-xlg-3"">
                        <div class=""card card-hover"">
                            <div class=""p-2 bg-success text-center"">
                                <h1 class=""font-light text-white"">1100</h1>
                                <h6 class=""text-white"">Resolve</h6>
                            </div>
                        </div>
                    </div>
                    <!-- Column -->
                    <div class=""col-md-6 col-lg-3 col-xlg-3"">
                        <div class=""card card-hover"">
                            <div class=""p-2 bg-danger text-center"">
                                <h1 class=""font-light text-white"">964</h1>
                                <h6 class=""text-white"">Pending</h6>
                            </div>
 ");
            WriteLiteral(@"                       </div>
                    </div>
                    <!-- Column -->
                </div>
                <div class=""table-responsive"">
                    <table id=""zero_config"" class=""table table-striped table-bordered no-wrap"">
                        <thead>
                            <tr>
                                <th>Status</th>
                                <th>Title</th>
                                <th>ID</th>
                                <th>Product</th>
                                <th>Created by</th>
                                <th>Date</th>
                                <th>Agent</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 89 "C:\Users\Chanos\Desktop\git\asp.net\asp.net\MyWeb\MyWeb.HomeWeb\Views\Home\TicketList.cshtml"
                             foreach (var m in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 92 "C:\Users\Chanos\Desktop\git\asp.net\asp.net\MyWeb\MyWeb.HomeWeb\Views\Home\TicketList.cshtml"
                                   Write(m.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 93 "C:\Users\Chanos\Desktop\git\asp.net\asp.net\MyWeb\MyWeb.HomeWeb\Views\Home\TicketList.cshtml"
                                   Write(m.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 94 "C:\Users\Chanos\Desktop\git\asp.net\asp.net\MyWeb\MyWeb.HomeWeb\Views\Home\TicketList.cshtml"
                                   Write(m.TicketID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td></td>\r\n                                    <td></td>\r\n                                    <td></td>\r\n                                </tr>\r\n");
#nullable restore
#line 99 "C:\Users\Chanos\Desktop\git\asp.net\asp.net\MyWeb\MyWeb.HomeWeb\Views\Home\TicketList.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n");
            WriteLiteral("                    </table>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            WriteLiteral("\r\n<div>\r\n    <div>\r\n        <input id=\"ticket_id\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 5696, "\"", 5704, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input id=\"title\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 5747, "\"", 5755, 0);
            EndWriteAttribute();
            WriteLiteral(@" />

        <button id=""btn1"" type=""button"" class=""btn btn-sm btn-primary"">?????? ??????</button>

        <button id=""btn2"" type=""button"" class=""btn btn-sm btn-primary"">Web API</button>
    </div> 

    <script>
        $(""#btn1"").click(function () {
            var ticket_id = $(""#ticket_id"").val();
            var title = $(""#title"").val();

            ////1. ?????? js  
            //var xhr = new XMLHttpRequest();
            //xhr.open(""POST"", ""/home/ticketupdate"", true);
            //xhr.setRequestHeader(""Content-Type"", ""application/x-www-form-urlencoded"");
            //xhr.onreadystatechange = function () {
            //    if (xhr.readyState == 4) {
            //        if (xhr.status == 200) {
            //            alert(""?????? ??????"");
            //            location.reload();
            //        }
            //    }
            //}

            //console.log(""TicketID="" + ticket_id + ""&Title="" + decodeURIComponent(title));
            //xhr.send(""TicketID="" + ticket_id + ""&");
            WriteLiteral(@"Title="" + decodeURIComponent(title));

            // 2. jquery ajax
            // default async
            //$.ajax({
            //    type: ""POST"",
            //    url: ""/home/ticketupdate"",
            //    dataType: ""json"",
            //    data: {
            //        ""ticketid"": ticket_id,
            //        ""title"": title
            //    },
            //    success: function (data) {
            //        alert(data.title);
            //        location.reload();
            //    },
            //    error: function (xhr) {
            //        alert(xhr.responseText);
            //    }
            //});

            // 3. axios 
            axios.post(""/home/ticketupdate"", {
                //""ticketid"": Number(ticket_id),
                ""ticketid"": ticket_id,
                ""title"": title
            }).then(function (response) {
                alert(response.data.Title);
                location.reload();
            }).catch(function (xhr) {
     ");
            WriteLiteral(@"           alert(xhr.responseText);
            });

        });

        $(""#btn2"").click(function () {            
            axios.get(""https://localhost:44332/weatherforecast"", {
                ""num"": 1
            }).then(function (response) {
                console.log(""??????"");
            }).catch(function (xhr) {
                console.log(""??????"");
            });
        });
         
    </script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TicketModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
