#pragma checksum "C:\Users\Student\Desktop\SWP\SWP\SWP\Swp\Swp\Views\Zolnierz\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18445394160c1298eade84dd66ffa58de06087fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Zolnierz_Details), @"mvc.1.0.view", @"/Views/Zolnierz/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Zolnierz/Details.cshtml", typeof(AspNetCore.Views_Zolnierz_Details))]
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
#line 1 "C:\Users\Student\Desktop\SWP\SWP\SWP\Swp\Swp\Views\_ViewImports.cshtml"
using Swp;

#line default
#line hidden
#line 2 "C:\Users\Student\Desktop\SWP\SWP\SWP\Swp\Swp\Views\_ViewImports.cshtml"
using Swp.Models;

#line default
#line hidden
#line 3 "C:\Users\Student\Desktop\SWP\SWP\SWP\Swp\Swp\Views\_ViewImports.cshtml"
using Swp.TagHelpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18445394160c1298eade84dd66ffa58de06087fd", @"/Views/Zolnierz/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb2b80837ff6c0e038ad6b02718e265b887074a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Zolnierz_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Swp.Model.Zolnierz>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Student\Desktop\SWP\SWP\SWP\Swp\Swp\Views\Zolnierz\Details.cshtml"
  
    ViewData["Title"] = "Dane osobowe";
    IEnumerable<Swp.Model.Uzytkownik> logged = ViewData["Logged"] as IEnumerable<Swp.Model.Uzytkownik>;

#line default
#line hidden
            BeginContext(182, 42, true);
            WriteLiteral("\r\n<h2>Dane osobowe</h2>\r\n\r\n<div>\r\n    <h4>");
            EndContext();
            BeginContext(225, 45, false);
#line 11 "C:\Users\Student\Desktop\SWP\SWP\SWP\Swp\Swp\Views\Zolnierz\Details.cshtml"
   Write(Html.DisplayFor(model => model.StopienString));

#line default
#line hidden
            EndContext();
            BeginContext(270, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(272, 36, false);
#line 11 "C:\Users\Student\Desktop\SWP\SWP\SWP\Swp\Swp\Views\Zolnierz\Details.cshtml"
                                                  Write(Html.DisplayFor(model => model.Imie));

#line default
#line hidden
            EndContext();
            BeginContext(308, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(310, 40, false);
#line 11 "C:\Users\Student\Desktop\SWP\SWP\SWP\Swp\Swp\Views\Zolnierz\Details.cshtml"
                                                                                        Write(Html.DisplayFor(model => model.Nazwisko));

#line default
#line hidden
            EndContext();
            BeginContext(350, 140, true);
            WriteLiteral("</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n\r\n        <dt>\r\n            Adres zameldowania\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(491, 37, false);
#line 19 "C:\Users\Student\Desktop\SWP\SWP\SWP\Swp\Swp\Views\Zolnierz\Details.cshtml"
       Write(Html.DisplayFor(model => model.Adres));

#line default
#line hidden
            EndContext();
            BeginContext(528, 17, true);
            WriteLiteral("\r\n        </dd>\r\n");
            EndContext();
#line 21 "C:\Users\Student\Desktop\SWP\SWP\SWP\Swp\Swp\Views\Zolnierz\Details.cshtml"
         if (logged.Where(z => z.Iduzytkownika.ToString() == User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier).Value).Select(a => a.IdroliNavigation.Nazwa).FirstOrDefault() == "Administrator")
        {

#line default
#line hidden
            BeginContext(765, 98, true);
            WriteLiteral("            <dt>\r\n                Imię ojca\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(864, 40, false);
#line 27 "C:\Users\Student\Desktop\SWP\SWP\SWP\Swp\Swp\Views\Zolnierz\Details.cshtml"
           Write(Html.DisplayFor(model => model.Imieojca));

#line default
#line hidden
            EndContext();
            BeginContext(904, 120, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                Imię matki\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1025, 41, false);
#line 33 "C:\Users\Student\Desktop\SWP\SWP\SWP\Swp\Swp\Views\Zolnierz\Details.cshtml"
           Write(Html.DisplayFor(model => model.Imiematki));

#line default
#line hidden
            EndContext();
            BeginContext(1066, 115, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                PESEL\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1182, 37, false);
#line 39 "C:\Users\Student\Desktop\SWP\SWP\SWP\Swp\Swp\Views\Zolnierz\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pesel));

#line default
#line hidden
            EndContext();
            BeginContext(1219, 21, true);
            WriteLiteral("\r\n            </dd>\r\n");
            EndContext();
#line 41 "C:\Users\Student\Desktop\SWP\SWP\SWP\Swp\Swp\Views\Zolnierz\Details.cshtml"

        }

#line default
#line hidden
            BeginContext(1253, 80, true);
            WriteLiteral("        <dt>\r\n            Nr telefonu\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1334, 45, false);
#line 47 "C:\Users\Student\Desktop\SWP\SWP\SWP\Swp\Swp\Views\Zolnierz\Details.cshtml"
       Write(Html.DisplayFor(model => model.Numertelefonu));

#line default
#line hidden
            EndContext();
            BeginContext(1379, 91, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Grupa\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1471, 57, false);
#line 53 "C:\Users\Student\Desktop\SWP\SWP\SWP\Swp\Swp\Views\Zolnierz\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdgrupyNavigation.Idgrupy));

#line default
#line hidden
            EndContext();
            BeginContext(1528, 57, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n        \r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1585, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f6a8d0589dd446a9dd0de2a92646461", async() => {
                BeginContext(1607, 6, true);
                WriteLiteral("Powrót");
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
            BeginContext(1617, 4, true);
            WriteLiteral(" |\r\n");
            EndContext();
#line 60 "C:\Users\Student\Desktop\SWP\SWP\SWP\Swp\Swp\Views\Zolnierz\Details.cshtml"
     if (logged.Where(z => z.Iduzytkownika.ToString() == User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier).Value).Select(a => a.IdroliNavigation.Nazwa).FirstOrDefault() == "Administrator")
    {

#line default
#line hidden
            BeginContext(1833, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1841, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e28753f059c4216aecad93905a0d3b3", async() => {
                BeginContext(1896, 6, true);
                WriteLiteral("Edytuj");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "C:\Users\Student\Desktop\SWP\SWP\SWP\Swp\Swp\Views\Zolnierz\Details.cshtml"
                               WriteLiteral(Model.Idzolnierza);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1906, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 63 "C:\Users\Student\Desktop\SWP\SWP\SWP\Swp\Swp\Views\Zolnierz\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(1915, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Swp.Model.Zolnierz> Html { get; private set; }
    }
}
#pragma warning restore 1591
