#pragma checksum "/Users/riccardptencate/Desktop/dotnet-training-mvc/asvs-labs/Views/Account/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4eb296b9bebc685e47f46615e4b3da8b1b47742a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Index.cshtml", typeof(AspNetCore.Views_Account_Index))]
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
#line 1 "/Users/riccardptencate/Desktop/dotnet-training-mvc/asvs-labs/Views/_ViewImports.cshtml"
using asvs_labs;

#line default
#line hidden
#line 2 "/Users/riccardptencate/Desktop/dotnet-training-mvc/asvs-labs/Views/_ViewImports.cshtml"
using asvs_labs.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eb296b9bebc685e47f46615e4b3da8b1b47742a", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa581140530a068fbacca59590cb42e4257d5fe8", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<asvslabs.ViewModels.AccountRegisterViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sign-in"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "/Users/riccardptencate/Desktop/dotnet-training-mvc/asvs-labs/Views/Account/Index.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
            BeginContext(99, 31, true);
            WriteLiteral("\r\n\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(130, 902, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bc43b287dea469a93b7e9824ef0010c", async() => {
                BeginContext(136, 889, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <title>WorkWise</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta name=""description"" content="""" />
    <meta name=""keywords"" content="""" />
    <link rel=""stylesheet"" type=""text/css"" href=""css/animate.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""css/bootstrap.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""css/line-awesome.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""css/line-awesome-font-awesome.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""css/font-awesome.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""lib/slick/slick.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""lib/slick/slick-theme.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""css/style.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""css/responsive.css"">
");
                EndContext();
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
            EndContext();
            BeginContext(1032, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(1038, 9024, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0128353a5ff44eca85827cc6253cce0", async() => {
                BeginContext(1060, 1408, true);
                WriteLiteral(@"


    <div class=""wrapper"">


        <div class=""sign-in-page"">
            <div class=""signin-popup"">
                <div class=""signin-pop"">
                    <div class=""row"">
                        <div class=""col-lg-6"">
                            <div class=""cmp-info"">
                                <div class=""cm-logo"">
                                    <img src=""images/cm-logo.png"" style=""width: 30%; height: 30%;"" alt="""">
                                    <p>Workwise,  is a global freelancing platform and social networking where businesses and independent professionals connect and collaborate remotely</p>
                                </div><!--cm-logo end-->
                                <img src=""images/cm-main-img.png"" alt="""">
                            </div><!--cmp-info end-->
                        </div>
                        <div class=""col-lg-6"">
                            <div class=""login-sec"">
                                <ul class=""sign-control""");
                WriteLiteral(@">
                                    <li data-tab=""tab-1"" class=""current""><a href=""#"" title="""">Sign in</a></li>
                                    <li data-tab=""tab-2""><a href=""#"" title="""">Sign up</a></li>
                                </ul>
                                <div class=""sign_in_sec current"" id=""tab-1"">

                                    <h3>Sign in</h3>
");
                EndContext();
#line 58 "/Users/riccardptencate/Desktop/dotnet-training-mvc/asvs-labs/Views/Account/Index.cshtml"
                                     using (Html.BeginForm("Login", "Account", FormMethod.Post))
                                    {

#line default
#line hidden
                BeginContext(2605, 259, true);
                WriteLiteral(@"                                        <div class=""row"">
                                            <div class=""col-lg-12 no-pdd"">
                                                <div class=""sn-field"">
                                                    ");
                EndContext();
                BeginContext(2865, 179, false);
#line 63 "/Users/riccardptencate/Desktop/dotnet-training-mvc/asvs-labs/Views/Account/Index.cshtml"
                                               Write(Html.TextBoxFor(x => x.LoginViewModel.Email,
                                                    new { @class = "form-control", placeholder = "username", required = "required" }));

#line default
#line hidden
                EndContext();
                BeginContext(3044, 409, true);
                WriteLiteral(@"
                                                    <i class=""la la-user""></i>
                                                </div><!--sn-field end-->
                                            </div>
                                            <div class=""col-lg-12 no-pdd"">
                                                <div class=""sn-field"">
                                                    ");
                EndContext();
                BeginContext(3454, 184, false);
#line 70 "/Users/riccardptencate/Desktop/dotnet-training-mvc/asvs-labs/Views/Account/Index.cshtml"
                                               Write(Html.PasswordFor(x => x.LoginViewModel.Password,
                                                     new { @class = "form-control", placeholder = "password", required = "required" }));

#line default
#line hidden
                EndContext();
                BeginContext(3638, 1369, true);
                WriteLiteral(@"
                                                <i class=""la la-lock""></i>
                                                </div>
                                            </div>
                                            <div class=""col-lg-12 no-pdd"">
                                                <div class=""checky-sec"">
                                                    <div class=""fgt-sec"">
                                                        <input type=""checkbox"" name=""cc"" id=""c1"">
                                                        <label for=""c1"">
                                                            <span></span>
                                                        </label>
                                                        <small>Remember me</small>
                                                    </div><!--fgt-sec end-->
                                                    <a href=""#"" title="""">Forgot Password?</a>
                                          ");
                WriteLiteral(@"      </div>
                                            </div>
                                            <div class=""col-lg-12 no-pdd"">
                                                <button type=""submit"" value=""submit"">Sign in</button>
                                            </div>
                                        </div>
");
                EndContext();
#line 91 "/Users/riccardptencate/Desktop/dotnet-training-mvc/asvs-labs/Views/Account/Index.cshtml"
                                    }

#line default
#line hidden
                BeginContext(5046, 1046, true);
                WriteLiteral(@"                                    <div class=""login-resources"">
                                        <h4>Login Via Social Account</h4>
                                        <ul>
                                            <li><a href=""#"" title="""" class=""fb""><i class=""fa fa-facebook""></i>Login Via Facebook</a></li>
                                            <li><a href=""#"" title="""" class=""tw""><i class=""fa fa-twitter""></i>Login Via Twitter</a></li>
                                        </ul>
                                    </div><!--login-resources end-->
                                </div><!--sign_in_sec end-->
                                <div class=""sign_in_sec"" id=""tab-2"">
                                    <div class=""signup-tab"">
                                        <h2>Create a new accosdsdsunt!</h2>
                                        <ul></ul>
                                    </div><!--signup-tab end-->
                                    <div class=""dff-tab ");
                WriteLiteral("current\" id=\"tab-3\">\r\n");
                EndContext();
#line 106 "/Users/riccardptencate/Desktop/dotnet-training-mvc/asvs-labs/Views/Account/Index.cshtml"
                                         using (Html.BeginForm("Register", "Account", FormMethod.Post))
                                        {

#line default
#line hidden
                BeginContext(6240, 275, true);
                WriteLiteral(@"                                            <div class=""row"">
                                                <div class=""col-lg-12 no-pdd"">
                                                    <div class=""sn-field"">
                                                        ");
                EndContext();
                BeginContext(6516, 197, false);
#line 111 "/Users/riccardptencate/Desktop/dotnet-training-mvc/asvs-labs/Views/Account/Index.cshtml"
                                                   Write(Html.TextBoxFor(x => x.RegisterViewModel.Email,
                                                        new { @class = "form-control", placeholder = "example@example.com", required = "required" }));

#line default
#line hidden
                EndContext();
                BeginContext(6713, 414, true);
                WriteLiteral(@"
                                                        <i class=""la la-user""></i>
                                                    </div>
                                                </div>
                                                <div class=""col-lg-12 no-pdd"">
                                                    <div class=""sn-field"">
                                                        ");
                EndContext();
                BeginContext(7128, 190, false);
#line 118 "/Users/riccardptencate/Desktop/dotnet-training-mvc/asvs-labs/Views/Account/Index.cshtml"
                                                   Write(Html.PasswordFor(x => x.RegisterViewModel.Password,
                                                        new { @class = "form-control", placeholder = "password", required = "required" }));

#line default
#line hidden
                EndContext();
                BeginContext(7318, 410, true);
                WriteLiteral(@"
                                                    <i class=""la la-lock""></i>
                                                    </div>
                                                </div>
                                                <div class=""col-lg-12 no-pdd"">
                                                    <div class=""sn-field"">
                                                        ");
                EndContext();
                BeginContext(7729, 195, false);
#line 125 "/Users/riccardptencate/Desktop/dotnet-training-mvc/asvs-labs/Views/Account/Index.cshtml"
                                                   Write(Html.PasswordFor(x => x.RegisterViewModel.RePassword,
                                                        new { @class = "form-control", placeholder = "re-password", required = "required" }));

#line default
#line hidden
                EndContext();
                BeginContext(7924, 501, true);
                WriteLiteral(@"
                                                        <i class=""la la-lock""></i>
                                                    </div>
                                                </div>
                                                <div class=""col-lg-12 no-pdd"">
                                                    <button type=""submit"" value=""submit"">Get Started</button>
                                                </div>
                                            </div>
");
                EndContext();
#line 134 "/Users/riccardptencate/Desktop/dotnet-training-mvc/asvs-labs/Views/Account/Index.cshtml"
                                        }

#line default
#line hidden
                BeginContext(8468, 1587, true);
                WriteLiteral(@"                                    </div><!--dff-tab end-->
                                </div>
                            </div><!--login-sec end-->
                        </div>
                    </div>
                </div><!--signin-pop end-->
            </div><!--signin-popup end-->
            <div class=""footy-sec"">
                <div class=""container"">
                    <ul>
                        <li><a href=""#"" title="""">Help Center</a></li>
                        <li><a href=""#"" title="""">Privacy Policy</a></li>
                        <li><a href=""#"" title="""">Community Guidelines</a></li>
                        <li><a href=""#"" title="""">Cookies Policy</a></li>
                        <li><a href=""#"" title="""">Career</a></li>
                        <li><a href=""#"" title="""">Forum</a></li>
                        <li><a href=""#"" title="""">Language</a></li>
                        <li><a href=""#"" title="""">Copyright Policy</a></li>
                    </ul>
             ");
                WriteLiteral(@"       <p><img src=""images/copy-icon.png"" alt="""">Copyright 2018</p>
                </div>
            </div><!--footy-sec end-->
        </div><!--sign-in-page end-->


    </div><!--theme-layout end-->



    <script type=""text/javascript"" src=""js/jquery.min.js""></script>
    <script type=""text/javascript"" src=""js/popper.js""></script>
    <script type=""text/javascript"" src=""js/bootstrap.min.js""></script>
    <script type=""text/javascript"" src=""lib/slick/slick.min.js""></script>
    <script type=""text/javascript"" src=""js/script.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10062, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<asvslabs.ViewModels.AccountRegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
