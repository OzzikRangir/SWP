#pragma checksum "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Pliki\Read.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6eaa1cd9e0d63af3b3ab0494858e22c5379d9699"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pliki_Read), @"mvc.1.0.view", @"/Views/Pliki/Read.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pliki/Read.cshtml", typeof(AspNetCore.Views_Pliki_Read))]
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
#line 1 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\_ViewImports.cshtml"
using Swp;

#line default
#line hidden
#line 2 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\_ViewImports.cshtml"
using Swp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6eaa1cd9e0d63af3b3ab0494858e22c5379d9699", @"/Views/Pliki/Read.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b50c99fbef0e2a1d4ad52be2cb351b10343a99c", @"/Views/_ViewImports.cshtml")]
    public class Views_Pliki_Read : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Pliki\Read.cshtml"
  
    ViewData["Title"] = @Model;

#line default
#line hidden
            BeginContext(55, 167, true);
            WriteLiteral("\r\n<iframe style=\"position:fixed; top:0px; left:0px; bottom:0px; right:0px; width:100%; height:100%; border:none; margin:0; padding:0; overflow:hidden; z-index:999999;\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 222, "\"", 284, 2);
            WriteAttributeValue("", 228, "https://view.officeapps.live.com/op/view.aspx?src=", 228, 50, true);
#line 6 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Pliki\Read.cshtml"
WriteAttributeValue("", 278, Model, 278, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(285, 10, true);
            WriteLiteral("></iframe>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
