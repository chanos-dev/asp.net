#pragma checksum "C:\Users\Chanos\Desktop\git\asp.net\asp.net\MyWeb\MyWeb.HomeWeb\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80b3c7123edc22caa13c5ce2aff0643722b497d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80b3c7123edc22caa13c5ce2aff0643722b497d2", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d515280afbb24f34010e28d208872f4ac0784a77", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html dir=\"ltr\" lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80b3c7123edc22caa13c5ce2aff0643722b497d24599", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\n    <!-- Tell the browser to be responsive to screen width -->\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 300, "\"", 310, 0);
                EndWriteAttribute();
                WriteLiteral(">\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 336, "\"", 346, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <!-- Favicon icon -->
    <link rel=""icon"" type=""image/png"" sizes=""16x16"" href=""/lib/adminmart-lite/lib/adminmart-lite/assets/images/favicon.png"">
    <title>Adminmart Template - The Ultimate Multipurpose admin template</title>
    <!-- Custom CSS -->
    <link href=""/lib/adminmart-lite/assets/extra-libs/c3/c3.min.css"" rel=""stylesheet"">
    <link href=""/lib/adminmart-lite/assets/libs/chartist/dist/chartist.min.css"" rel=""stylesheet"">
    <link href=""/lib/adminmart-lite/assets/extra-libs/jvector/jquery-jvectormap-2.0.2.css"" rel=""stylesheet"" />
    <!-- Custom CSS -->
    <link href=""/lib/adminmart-lite/dist/css/style.min.css"" rel=""stylesheet"">
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src=""https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js""></script>
        <script src=""https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js""></script>");
                WriteLiteral(@"
    <![endif]-->
    <script src=""/lib/adminmart-lite/assets/libs/jquery/dist/jquery.min.js""></script>
    <script src=""/lib/adminmart-lite/assets/libs/popper.js/dist/umd/popper.min.js""></script>
    <script src=""/lib/adminmart-lite/assets/libs/bootstrap/dist/js/bootstrap.min.js""></script>
    <!-- apps -->
    <!-- apps -->
    <script src=""/lib/adminmart-lite/dist/js/app-style-switcher.js""></script>
    <script src=""/lib/adminmart-lite/dist/js/feather.min.js""></script>
    <script src=""/lib/adminmart-lite/assets/libs/perfect-scrollbar/dist/perfect-scrollbar.jquery.min.js""></script>
    <script src=""/lib/adminmart-lite/dist/js/sidebarmenu.js""></script>
    <!--Custom JavaScript -->
    <script src=""/lib/adminmart-lite/dist/js/custom.min.js""></script>
    <!--This page JavaScript -->
    <script src=""/lib/adminmart-lite/assets/extra-libs/c3/d3.min.js""></script>
    <script src=""/lib/adminmart-lite/assets/extra-libs/c3/c3.min.js""></script>
    <script src=""/lib/adminmart-lite/assets/libs/chartist/dist/chartis");
                WriteLiteral(@"t.min.js""></script>
    <script src=""/lib/adminmart-lite/assets/libs/chartist-plugin-tooltips/dist/chartist-plugin-tooltip.min.js""></script>
    <script src=""/lib/adminmart-lite/assets/extra-libs/jvector/jquery-jvectormap-2.0.2.min.js""></script>
    <script src=""/lib/adminmart-lite/assets/extra-libs/jvector/jquery-jvectormap-world-mill-en.js""></script>
    <script src=""/lib/adminmart-lite/dist/js/pages/dashboards/dashboard1.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80b3c7123edc22caa13c5ce2aff0643722b497d28793", async() => {
                WriteLiteral(@"
    <!-- ============================================================== -->
    <!-- Preloader - style you can find in spinners.css -->
    <!-- ============================================================== -->
    <div class=""preloader"">
        <div class=""lds-ripple"">
            <div class=""lds-pos""></div>
            <div class=""lds-pos""></div>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- Main wrapper - style you can find in pages.scss -->
    <!-- ============================================================== -->
    <div id=""main-wrapper"" data-theme=""light"" data-layout=""vertical"" data-navbarbg=""skin6"" data-sidebartype=""full""
         data-sidebar-position=""fixed"" data-header-position=""fixed"" data-boxed-layout=""full"">
        <!-- ============================================================== -->
        <!-- Topbar header - style you can find in pages.scss -->
        <!-- ============================================================== ");
                WriteLiteral(@"-->
        <header class=""topbar"" data-navbarbg=""skin6"">
            <nav class=""navbar top-navbar navbar-expand-md"">
                <div class=""navbar-header"" data-logobg=""skin6"">
                    <!-- This is for the sidebar toggle which is visible on mobile only -->
                    <a class=""nav-toggler waves-effect waves-light d-block d-md-none"" href=""javascript:void(0)"">
                        <i class=""ti-menu ti-close""></i>
                    </a>
                    <!-- ============================================================== -->
                    <!-- Logo -->
                    <!-- ============================================================== -->
                    <div class=""navbar-brand"">
                        <!-- Logo icon -->
                        <a href=""/"">
                            <b class=""logo-icon"">
                                <!-- Dark Logo icon -->
                                <img src=""/lib/adminmart-lite/assets/images/logo-icon.png"" alt=""homepag");
                WriteLiteral(@"e"" class=""dark-logo"" />
                                <!-- Light Logo icon -->
                                <img src=""/lib/adminmart-lite/assets/images/logo-icon.png"" alt=""homepage"" class=""light-logo"" />
                            </b>
                            <!--End Logo icon -->
                            <!-- Logo text -->
                            <span class=""logo-text"">
                                <!-- dark Logo text -->
                                <img src=""/lib/adminmart-lite/assets/images/logo-text.png"" alt=""homepage"" class=""dark-logo"" />
                                <!-- Light Logo text -->
                                <img src=""/lib/adminmart-lite/assets/images/logo-light-text.png"" class=""light-logo"" alt=""homepage"" />
                            </span>
                        </a>
                    </div>
                    <!-- ============================================================== -->
                    <!-- End Logo -->
                    <!-- ===========");
                WriteLiteral(@"=================================================== -->
                    <!-- ============================================================== -->
                    <!-- Toggle which is visible on mobile only -->
                    <!-- ============================================================== -->
                    <a class=""topbartoggler d-block d-md-none waves-effect waves-light"" href=""javascript:void(0)""
                       data-toggle=""collapse"" data-target=""#navbarSupportedContent""
                       aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <i class=""ti-more""></i>
                    </a>
                </div>
                <!-- ============================================================== -->
                <!-- End Logo -->
                <!-- ============================================================== -->
                <div class=""navbar-collapse collapse"" id=""navbarSupportedContent"">
             ");
                WriteLiteral(@"       <!-- ============================================================== -->
                    <!-- toggle and nav items -->
                    <!-- ============================================================== -->
                    <ul class=""navbar-nav float-left mr-auto ml-3 pl-1"">
                        <!-- Notification -->
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link dropdown-toggle pl-md-3 position-relative"" href=""javascript:void(0)""
                               id=""bell"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true""
                               aria-expanded=""false"">
                                <span><i data-feather=""bell"" class=""svg-icon""></i></span>
                                <span class=""badge badge-primary notify-no rounded-circle"">5</span>
                            </a>
                            <div class=""dropdown-menu dropdown-menu-left mailbox animated bounceInDown"">
                                ");
                WriteLiteral(@"<ul class=""list-style-none"">
                                    <li>
                                        <div class=""message-center notifications position-relative"">
                                            <!-- Message -->
                                            <a href=""javascript:void(0)""
                                               class=""message-item d-flex align-items-center border-bottom px-3 py-2"">
                                                <div class=""btn btn-danger rounded-circle btn-circle"">
                                                    <i data-feather=""airplay"" class=""text-white""></i>
                                                </div>
                                                <div class=""w-75 d-inline-block v-middle pl-2"">
                                                    <h6 class=""message-title mb-0 mt-1"">Luanch Admin</h6>
                                                    <span class=""font-12 text-nowrap d-block text-muted"">
                                ");
                WriteLiteral(@"                        Just see
                                                        the my new
                                                        admin!
                                                    </span>
                                                    <span class=""font-12 text-nowrap d-block text-muted"">9:30 AM</span>
                                                </div>
                                            </a>
                                            <!-- Message -->
                                            <a href=""javascript:void(0)""
                                               class=""message-item d-flex align-items-center border-bottom px-3 py-2"">
                                                <span class=""btn btn-success text-white rounded-circle btn-circle"">
                                                    <i data-feather=""calendar"" class=""text-white""></i>
                                                </span>
                                                <");
                WriteLiteral(@"div class=""w-75 d-inline-block v-middle pl-2"">
                                                    <h6 class=""message-title mb-0 mt-1"">Event today</h6>
                                                    <span class=""font-12 text-nowrap d-block text-muted text-truncate"">
                                                        Just
                                                        a reminder that you have event
                                                    </span>
                                                    <span class=""font-12 text-nowrap d-block text-muted"">9:10 AM</span>
                                                </div>
                                            </a>
                                            <!-- Message -->
                                            <a href=""javascript:void(0)""
                                               class=""message-item d-flex align-items-center border-bottom px-3 py-2"">
                                                <span class=""btn bt");
                WriteLiteral(@"n-info rounded-circle btn-circle"">
                                                    <i data-feather=""settings"" class=""text-white""></i>
                                                </span>
                                                <div class=""w-75 d-inline-block v-middle pl-2"">
                                                    <h6 class=""message-title mb-0 mt-1"">Settings</h6>
                                                    <span class=""font-12 text-nowrap d-block text-muted text-truncate"">
                                                        You
                                                        can customize this template
                                                        as you want
                                                    </span>
                                                    <span class=""font-12 text-nowrap d-block text-muted"">9:08 AM</span>
                                                </div>
                                            </a>
                ");
                WriteLiteral(@"                            <!-- Message -->
                                            <a href=""javascript:void(0)""
                                               class=""message-item d-flex align-items-center border-bottom px-3 py-2"">
                                                <span class=""btn btn-primary rounded-circle btn-circle"">
                                                    <i data-feather=""box"" class=""text-white""></i>
                                                </span>
                                                <div class=""w-75 d-inline-block v-middle pl-2"">
                                                    <h6 class=""message-title mb-0 mt-1"">Pavan kumar</h6> <span class=""font-12 text-nowrap d-block text-muted"">
                                                        Just
                                                        see the my admin!
                                                    </span>
                                                    <span class=""font-12 text-");
                WriteLiteral(@"nowrap d-block text-muted"">9:02 AM</span>
                                                </div>
                                            </a>
                                        </div>
                                    </li>
                                    <li>
                                        <a class=""nav-link pt-3 text-center text-dark"" href=""javascript:void(0);"">
                                            <strong>Check all notifications</strong>
                                            <i class=""fa fa-angle-right""></i>
                                        </a>
                                    </li>
                                </ul>
                            </div>
                        </li>
                        <!-- End Notification -->
                        <!-- ============================================================== -->
                        <!-- create new -->
                        <!-- =============================================================");
                WriteLiteral(@"= -->
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button""
                               data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <i data-feather=""settings"" class=""svg-icon""></i>
                            </a>
                            <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                                <a class=""dropdown-item"" href=""#"">Action</a>
                                <a class=""dropdown-item"" href=""#"">Another action</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"">Something else here</a>
                            </div>
                        </li>
                        <li class=""nav-item d-none d-md-block"">
                            <a class=""nav-link"" href=""javascript:void(0)"">
                              ");
                WriteLiteral("  <div class=\"customize-input\">\n                                    <select class=\"custom-select form-control bg-white custom-radius custom-shadow border-0\">\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80b3c7123edc22caa13c5ce2aff0643722b497d222215", async() => {
                    WriteLiteral("EN");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80b3c7123edc22caa13c5ce2aff0643722b497d223587", async() => {
                    WriteLiteral("AB");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80b3c7123edc22caa13c5ce2aff0643722b497d224845", async() => {
                    WriteLiteral("AK");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80b3c7123edc22caa13c5ce2aff0643722b497d226103", async() => {
                    WriteLiteral("BE");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </select>
                                </div>
                            </a>
                        </li>
                    </ul>
                    <!-- ============================================================== -->
                    <!-- Right side toggle and nav items -->
                    <!-- ============================================================== -->
                    <ul class=""navbar-nav float-right"">
                        <!-- ============================================================== -->
                        <!-- Search -->
                        <!-- ============================================================== -->
                        <li class=""nav-item d-none d-md-block"">
                            <a class=""nav-link"" href=""javascript:void(0)"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80b3c7123edc22caa13c5ce2aff0643722b497d228207", async() => {
                    WriteLiteral(@"
                                    <div class=""customize-input"">
                                        <input class=""form-control custom-shadow custom-radius border-0 bg-white""
                                               type=""search"" placeholder=""Search"" aria-label=""Search"">
                                        <i class=""form-control-icon"" data-feather=""search""></i>
                                    </div>
                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </a>
                        </li>
                        <!-- ============================================================== -->
                        <!-- User profile and search -->
                        <!-- ============================================================== -->
                        <li class=""nav-item dropdown"">
");
#nullable restore
#line 249 "C:\Users\Chanos\Desktop\git\asp.net\asp.net\MyWeb\MyWeb.HomeWeb\Views\Shared\_Layout.cshtml"
                             if (User.Identity.IsAuthenticated)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <a class=""nav-link dropdown-toggle"" href=""javascript:void(0)"" data-toggle=""dropdown""
                                   aria-haspopup=""true"" aria-expanded=""false"">
                                    <img src=""/lib/adminmart-lite/assets/images/users/profile-pic.jpg"" alt=""user"" class=""rounded-circle""
                                         width=""40"">
                                    <span class=""ml-2 d-none d-lg-inline-block"">
                                        <span>Hello,</span> <span class=""text-dark"">");
#nullable restore
#line 256 "C:\Users\Chanos\Desktop\git\asp.net\asp.net\MyWeb\MyWeb.HomeWeb\Views\Shared\_Layout.cshtml"
                                                                               Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span> <i data-feather=\"chevron-down\" class=\"svg-icon\"></i>\n                                    </span>\n                                </a>\n");
#nullable restore
#line 259 "C:\Users\Chanos\Desktop\git\asp.net\asp.net\MyWeb\MyWeb.HomeWeb\Views\Shared\_Layout.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <div class=""dropdown-menu dropdown-menu-right user-dd animated flipInY"">
                                <a class=""dropdown-item"" href=""javascript:void(0)"">
                                    <i data-feather=""user""
                                       class=""svg-icon mr-2 ml-1""></i>
                                    My Profile
                                </a>
                                <a class=""dropdown-item"" href=""javascript:void(0)"">
                                    <i data-feather=""credit-card""
                                       class=""svg-icon mr-2 ml-1""></i>
                                    My Balance
                                </a>
                                <a class=""dropdown-item"" href=""javascript:void(0)"">
                                    <i data-feather=""mail""
                                       class=""svg-icon mr-2 ml-1""></i>
                                    Inbox
                                </a>
                           ");
                WriteLiteral(@"     <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""javascript:void(0)"">
                                    <i data-feather=""settings""
                                       class=""svg-icon mr-2 ml-1""></i>
                                    Account Setting
                                </a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""/login/logout"">
                                    <i data-feather=""power"" class=""svg-icon mr-2 ml-1""></i>
                                    Logout
                                </a>
                                <div class=""dropdown-divider""></div>
                                <div class=""pl-4 p-3"">
                                    <a href=""javascript:void(0)"" class=""btn btn-sm btn-info"">
                                        View
                                        Profile
                                    </a>
   ");
                WriteLiteral(@"                             </div>
                            </div>
                        </li>
                        <!-- ============================================================== -->
                        <!-- User profile and search -->
                        <!-- ============================================================== -->
                    </ul>
                </div>
            </nav>
        </header>
        <!-- ============================================================== -->
        <!-- End Topbar header -->
        <!-- ============================================================== -->
        <!-- ============================================================== -->
        <!-- Left Sidebar - style you can find in sidebar.scss  -->
        <!-- ============================================================== -->
        <aside class=""left-sidebar"" data-sidebarbg=""skin6"">
            <!-- Sidebar scroll-->
            ");
#nullable restore
#line 311 "C:\Users\Chanos\Desktop\git\asp.net\asp.net\MyWeb\MyWeb.HomeWeb\Views\Shared\_Layout.cshtml"
       Write(await Component.InvokeAsync("LeftMenu"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            <!-- End Sidebar scroll-->
        </aside>
        <!-- ============================================================== -->
        <!-- End Left Sidebar - style you can find in sidebar.scss  -->
        <!-- ============================================================== -->
        <!-- ============================================================== -->
        <!-- Page wrapper  -->
        <!-- ============================================================== -->
        <div class=""page-wrapper"">
            ");
#nullable restore
#line 321 "C:\Users\Chanos\Desktop\git\asp.net\asp.net\MyWeb\MyWeb.HomeWeb\Views\Shared\_Layout.cshtml"
       Write(await Component.InvokeAsync("DashBoardTitle"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" 
            <!-- ============================================================== -->
            <!-- End Bread crumb and right sidebar toggle -->
            <!-- ============================================================== -->
            <!-- ============================================================== -->
            <!-- Container fluid  -->
            <!-- ============================================================== -->
            <div class=""container-fluid"">
                ");
#nullable restore
#line 329 "C:\Users\Chanos\Desktop\git\asp.net\asp.net\MyWeb\MyWeb.HomeWeb\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
            <!-- ============================================================== -->
            <!-- End Container fluid  -->
            <!-- ============================================================== -->
            <!-- ============================================================== -->
            <!-- footer -->
            <!-- ============================================================== -->
            <footer class=""footer text-center text-muted"">
                All Rights Reserved by Adminmart. Designed and Developed by <a href=""https://wrappixel.com"">WrapPixel</a>.
            </footer>
            <!-- ============================================================== -->
            <!-- End footer -->
            <!-- ============================================================== -->
        </div>
        <!-- ============================================================== -->
        <!-- End Page wrapper  -->
        <!-- ===================================================");
                WriteLiteral(@"=========== -->
    </div>
    <!-- ============================================================== -->
    <!-- End Wrapper -->
    <!-- ============================================================== -->
    <!-- End Wrapper -->
    <!-- ============================================================== -->
    <!-- All Jquery -->
    <!-- ============================================================== -->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</html>");
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
