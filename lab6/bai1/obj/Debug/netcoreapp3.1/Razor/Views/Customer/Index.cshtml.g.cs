#pragma checksum "D:\Skyfolder\Desktop\c4\lab6\bai1\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "740d32248cb82d771683a2e00e25d88a5d6ae1c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
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
#line 1 "D:\Skyfolder\Desktop\c4\lab6\bai1\Views\_ViewImports.cshtml"
using bai1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Skyfolder\Desktop\c4\lab6\bai1\Views\_ViewImports.cshtml"
using bai1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"740d32248cb82d771683a2e00e25d88a5d6ae1c5", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54ca149602d5efa54ff870604ebd94b07f5bc3f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bai1.Models.TestCustomer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"<!--<html>
    <head>
        <title> Customer Details</title>
        <style>
            img {
                width :20%;
                margin-left :30px
            }
            td{
                padding : 45px;
            }
        </style>
    </head>
    <body>-->
");
            WriteLiteral("        <!--<table>\r\n            <tr>\r\n                <td>");
#nullable restore
#line 21 "D:\Skyfolder\Desktop\c4\lab6\bai1\Views\Customer\Index.cshtml"
               Write(Model.Test[0].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td id=\"b\">");
#nullable restore
#line 23 "D:\Skyfolder\Desktop\c4\lab6\bai1\Views\Customer\Index.cshtml"
                      Write(Model.Test[1].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"c\">");
#nullable restore
#line 24 "D:\Skyfolder\Desktop\c4\lab6\bai1\Views\Customer\Index.cshtml"
                         Write(Model.Test[2].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td class=\"d\">");
#nullable restore
#line 26 "D:\Skyfolder\Desktop\c4\lab6\bai1\Views\Customer\Index.cshtml"
                         Write(Model.Test[3].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n            <tr>\r\n                <br />\r\n                <img src=\"");
#nullable restore
#line 31 "D:\Skyfolder\Desktop\c4\lab6\bai1\Views\Customer\Index.cshtml"
                     Write(Model.Test[0].img);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n                <img src=\"");
#nullable restore
#line 32 "D:\Skyfolder\Desktop\c4\lab6\bai1\Views\Customer\Index.cshtml"
                     Write(Model.Test[1].img);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n                <img src=\"");
#nullable restore
#line 33 "D:\Skyfolder\Desktop\c4\lab6\bai1\Views\Customer\Index.cshtml"
                     Write(Model.Test[2].img);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n                <img src=\"");
#nullable restore
#line 34 "D:\Skyfolder\Desktop\c4\lab6\bai1\Views\Customer\Index.cshtml"
                     Write(Model.Test[3].img);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n            </tr>-->\r\n\r\n");
            WriteLiteral("        <!--</table>\r\n    </body>\r\n</html>-->\r\n\r\n<h1>CÁC NGÀNH ĐÀO TẠO</h1>\r\n");
#nullable restore
#line 54 "D:\Skyfolder\Desktop\c4\lab6\bai1\Views\Customer\Index.cshtml"
     foreach (var i in @Model.Test)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table style=\"float:left;\">\r\n        <tr>\r\n            <td><img");
            BeginWriteAttribute("src", " src=\"", 1481, "\"", 1494, 2);
#nullable restore
#line 58 "D:\Skyfolder\Desktop\c4\lab6\bai1\Views\Customer\Index.cshtml"
WriteAttributeValue("", 1487, i.img, 1487, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1493, "", 1494, 1, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 300px; height: 300px;\" />\r\n            <td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 62 "D:\Skyfolder\Desktop\c4\lab6\bai1\Views\Customer\Index.cshtml"
           Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 65 "D:\Skyfolder\Desktop\c4\lab6\bai1\Views\Customer\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bai1.Models.TestCustomer> Html { get; private set; }
    }
}
#pragma warning restore 1591