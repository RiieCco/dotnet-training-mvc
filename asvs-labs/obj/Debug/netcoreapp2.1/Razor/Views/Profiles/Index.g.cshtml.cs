#pragma checksum "/Users/riccardptencate/Desktop/dotnet-training-mvc/asvs-labs/Views/Profiles/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1d046badeb09e3f3c826523bb71cd8c2b81c332"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profiles_Index), @"mvc.1.0.view", @"/Views/Profiles/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Profiles/Index.cshtml", typeof(AspNetCore.Views_Profiles_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1d046badeb09e3f3c826523bb71cd8c2b81c332", @"/Views/Profiles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa581140530a068fbacca59590cb42e4257d5fe8", @"/Views/_ViewImports.cshtml")]
    public class Views_Profiles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<asvslabs.ViewModels.ProfileViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/riccardptencate/Desktop/dotnet-training-mvc/asvs-labs/Views/Profiles/Index.cshtml"
  
  ViewData["Title"] = "Profiles";

#line default
#line hidden
            BeginContext(90, 227, true);
            WriteLiteral("\r\n\r\n\r\n<section class=\"companies-info\">\r\n  <div class=\"container\">\r\n    <div class=\"company-title\">\r\n      <h3>All specialists</h3>\r\n    </div><!--company-title end-->\r\n    <div class=\"companies-list\">\r\n      <div class=\"row\">\r\n");
            EndContext();
#line 16 "/Users/riccardptencate/Desktop/dotnet-training-mvc/asvs-labs/Views/Profiles/Index.cshtml"
         foreach (var users in Model.UserList)
        {


#line default
#line hidden
            BeginContext(378, 243, true);
            WriteLiteral("          <div class=\"col-lg-3 col-md-4 col-sm-6 col-12\">\r\n            <div class=\"company_profile_info\">\r\n              <div class=\"company-up-info\">\r\n\r\n                <img src=\"http://via.placeholder.com/91x91\" alt=\"\">\r\n                <h3>");
            EndContext();
            BeginContext(622, 36, false);
#line 24 "/Users/riccardptencate/Desktop/dotnet-training-mvc/asvs-labs/Views/Profiles/Index.cshtml"
               Write(Html.DisplayFor(x => users.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(658, 53, true);
            WriteLiteral("</h3>\r\n                <ul>\r\n                  <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 711, "\"", 774, 2);
            WriteAttributeValue("", 718, "/Messages/ShowChat/", 718, 19, true);
#line 26 "/Users/riccardptencate/Desktop/dotnet-training-mvc/asvs-labs/Views/Profiles/Index.cshtml"
WriteAttributeValue("", 737, Html.DisplayFor(x => users.UserName), 737, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(775, 186, true);
            WriteLiteral(" title=\"\" class=\"message-us\"><i class=\"fa fa-envelope\"></i></a></li>\r\n                </ul>\r\n              </div>\r\n            </div><!--company_profile_info end-->\r\n\r\n          </div>\r\n");
            EndContext();
#line 32 "/Users/riccardptencate/Desktop/dotnet-training-mvc/asvs-labs/Views/Profiles/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(972, 65, true);
            WriteLiteral("      </div>\r\n\r\n    </div>\r\n</section><!--companies-info end-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<asvslabs.ViewModels.ProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
