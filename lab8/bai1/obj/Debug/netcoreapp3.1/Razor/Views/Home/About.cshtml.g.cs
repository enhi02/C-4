#pragma checksum "D:\Skyfolder\Desktop\c4\lab8\bai1\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da27060decd9cdd984ac8c880a69875a3247f665"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
#line 1 "D:\Skyfolder\Desktop\c4\lab8\bai1\Views\_ViewImports.cshtml"
using bai1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Skyfolder\Desktop\c4\lab8\bai1\Views\_ViewImports.cshtml"
using bai1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da27060decd9cdd984ac8c880a69875a3247f665", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54ca149602d5efa54ff870604ebd94b07f5bc3f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Skyfolder\Desktop\c4\lab8\bai1\Views\Home\About.cshtml"
  
    var Message = ViewData["Message"];
    var name = ViewBag.name;
    var email = ViewBag.email;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>Use this page to detail your about</p>\r\n<h5>Title:");
#nullable restore
#line 8 "D:\Skyfolder\Desktop\c4\lab8\bai1\Views\Home\About.cshtml"
     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n<h5>Message:");
#nullable restore
#line 9 "D:\Skyfolder\Desktop\c4\lab8\bai1\Views\Home\About.cshtml"
       Write(Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n<h5>name:");
#nullable restore
#line 10 "D:\Skyfolder\Desktop\c4\lab8\bai1\Views\Home\About.cshtml"
    Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n<h5>email:");
#nullable restore
#line 11 "D:\Skyfolder\Desktop\c4\lab8\bai1\Views\Home\About.cshtml"
     Write(email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>");
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
