#pragma checksum "C:\Users\timop\source\repos\Projekti\Sovitushuone\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38faa6b731b1d0888955c6209666634dd496d2ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\timop\source\repos\Projekti\Sovitushuone\Views\_ViewImports.cshtml"
using Sovitushuone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\timop\source\repos\Projekti\Sovitushuone\Views\_ViewImports.cshtml"
using Sovitushuone.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38faa6b731b1d0888955c6209666634dd496d2ad", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c052bb11dc6e49331bb7b14280bef14b8eb6fa8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\timop\source\repos\Projekti\Sovitushuone\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""/css/app.css"" type=""text/css"" />

<div class=""text-center"">
    <header>
        <h1>Sovitushuone</h1>
    </header>
    <input type=""text"" placeholder=""Syötä käyttäjänimesi"" name=""username"" required>
</div>
<div class=""text-center"">
    <input type=""password"" placeholder=""Syötä salasanasi"" name=""password"" required>
</div>
<div class=""text-center"">
    <button type=""submit"" name=""login"">Kirjaudu sisään</button>
</div>
<div class=""text-center"">
    <button type=""submit"" name=""register"">Rekisteröidy</button>
    <br>
    <a");
            BeginWriteAttribute("href", " href=\"", 620, "\"", 707, 1);
#nullable restore
#line 22 "C:\Users\timop\source\repos\Projekti\Sovitushuone\Views\Home\Index.cshtml"
WriteAttributeValue("", 627, Url.Action("Index", null, new { area = string.Empty, controller = "vaatteet" }), 627, 80, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <span>Vaatehuone</span>\r\n    </a>\r\n</div>\r\n");
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
