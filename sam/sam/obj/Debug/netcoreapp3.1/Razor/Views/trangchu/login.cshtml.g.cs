#pragma checksum "D:\Skyfolder\Desktop\c4\sam\sam\Views\trangchu\login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5991effda320482a47022857b621e3d3c7537833"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_trangchu_login), @"mvc.1.0.view", @"/Views/trangchu/login.cshtml")]
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
#line 1 "D:\Skyfolder\Desktop\c4\sam\sam\Views\_ViewImports.cshtml"
using sam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Skyfolder\Desktop\c4\sam\sam\Views\_ViewImports.cshtml"
using sam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5991effda320482a47022857b621e3d3c7537833", @"/Views/trangchu/login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4f2b5e3da760ebb8e8d685cfc8feaf4a57c20ea", @"/Views/_ViewImports.cshtml")]
    public class Views_trangchu_login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!--<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
</head>
<style>
    form {
        box-shadow: 0 0 2px gray;
        border-radius: 20px;
        width: 300px;
        min-width: 500px;
        padding: 15px;
        margin: 0 auto;
        transition: 0.6s ease-in-out;
        line-height: 30px;
    }

    input[type=""text""]:focus {
        width: 180px;
        background-color: lightpink;
    }

    input[type=""submit""]:hover {
        background-color: rgb(187, 54, 54);
        color: white;
    }

    .dangnhap {
        text-align: left;
    }

    .dangki {
        text-align: right;
    }
</style>
<body>
    <form asp-action=""login"">
        <div class=""dangnhap"">
            <h1><b>Đăng nhập tài khoản</b></h1>
            <div class=""formgroup"">
                <div>Email</div>
                <input type=""text"" class=""from_control"" p");
            WriteLiteral(@"laceholder=""Email"">
            </div>
            <div class=""formgroup"">
                <div>Mật khẩu</div>
                <input type=""text"" class=""from_control"" placeholder=""Mật khẩu""><br>
            </div>
            <div></div>
        </div>
        <div class=""formgroup"">
            <input type=""submit"" value=""Đăng nhập""><div>Quên mật khẩu?</div>
        </div>
        </div>
        <div class=""dangki"">
            <div class=""formgroup"">
                <input type=""submit"" value=""Đăng kí"">

            </div>
            </form>-->
");
            WriteLiteral("\r\n<!--</body>\r\n</html>-->");
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