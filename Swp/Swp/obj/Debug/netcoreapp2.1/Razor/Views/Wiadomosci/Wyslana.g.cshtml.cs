#pragma checksum "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Wiadomosci\Wyslana.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "888a4a55df68b584a89a521ae775ca10f6541304"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wiadomosci_Wyslana), @"mvc.1.0.view", @"/Views/Wiadomosci/Wyslana.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Wiadomosci/Wyslana.cshtml", typeof(AspNetCore.Views_Wiadomosci_Wyslana))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"888a4a55df68b584a89a521ae775ca10f6541304", @"/Views/Wiadomosci/Wyslana.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b50c99fbef0e2a1d4ad52be2cb351b10343a99c", @"/Views/_ViewImports.cshtml")]
    public class Views_Wiadomosci_Wyslana : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Swp.Model.Wiadomosc>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Wyslane", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Wiadomosci\Wyslana.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(73, 13, true);
            WriteLiteral("\r\n<h2>Tytuł: ");
            EndContext();
            BeginContext(87, 37, false);
#line 7 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Wiadomosci\Wyslana.cshtml"
      Write(Html.DisplayFor(model => model.Tytul));

#line default
#line hidden
            EndContext();
            BeginContext(124, 154, true);
            WriteLiteral("</h2>\r\n\r\n<div>\r\n    <h4></h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            Otrzymano:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(279, 63, false);
#line 17 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Wiadomosci\Wyslana.cshtml"
       Write(Html.DisplayFor(model => model.Detalewiadomosci.Dataotrzymania));

#line default
#line hidden
            EndContext();
            BeginContext(342, 94, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Nadawca:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(437, 62, false);
#line 23 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Wiadomosci\Wyslana.cshtml"
       Write(Html.DisplayFor(model => model.IdzolnierzaNavigation.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(499, 95, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Odbiorca:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(595, 79, false);
#line 29 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Wiadomosci\Wyslana.cshtml"
       Write(Html.DisplayFor(model => model.Detalewiadomosci.IdzolnierzaNavigation.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(674, 121, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n\r\n        <hr />\r\n        <dt>\r\n            Treść:\r\n        </dt>\r\n       \r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(796, 37, false);
#line 39 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Wiadomosci\Wyslana.cshtml"
       Write(Html.DisplayFor(model => model.Tresc));

#line default
#line hidden
            EndContext();
            BeginContext(833, 49, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(882, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48a6b48bf3db470696d6688946bf470f", async() => {
                BeginContext(906, 19, true);
                WriteLiteral("Powrót do wysłanych");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(929, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Swp.Model.Wiadomosc> Html { get; private set; }
    }
}
#pragma warning restore 1591
