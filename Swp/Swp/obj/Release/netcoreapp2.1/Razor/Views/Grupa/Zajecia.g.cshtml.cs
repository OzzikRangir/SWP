#pragma checksum "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Grupa\Zajecia.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "119244c3123bd60b926793d2cdbb103b73edd5aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grupa_Zajecia), @"mvc.1.0.view", @"/Views/Grupa/Zajecia.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Grupa/Zajecia.cshtml", typeof(AspNetCore.Views_Grupa_Zajecia))]
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
#line 3 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\_ViewImports.cshtml"
using Swp.TagHelpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"119244c3123bd60b926793d2cdbb103b73edd5aa", @"/Views/Grupa/Zajecia.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb2b80837ff6c0e038ad6b02718e265b887074a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Grupa_Zajecia : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Swp.Model.Grupa>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(24, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Grupa\Zajecia.cshtml"
  
    ViewData["Title"] = "Plan zajęć";

#line default
#line hidden
            BeginContext(72, 40, true);
            WriteLiteral("\r\n<h2>Plan zajęć</h2>\r\n\r\n<div>\r\n    <h4>");
            EndContext();
            BeginContext(113, 39, false);
#line 10 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Grupa\Zajecia.cshtml"
   Write(Html.DisplayFor(model => model.Idgrupy));

#line default
#line hidden
            EndContext();
            BeginContext(152, 133, true);
            WriteLiteral("</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n\r\n        <dt>\r\n            Specjalność\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(286, 42, false);
#line 18 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Grupa\Zajecia.cshtml"
       Write(Html.DisplayFor(model => model.Nazwagrupy));

#line default
#line hidden
            EndContext();
            BeginContext(328, 363, true);
            WriteLiteral(@"
        </dd>
    </dl>

    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Data
                </th>
                <th>
                    Nazwa
                </th>
                <th>
                    Miejsce
                </th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 37 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Grupa\Zajecia.cshtml"
             foreach (var item in Model.Zajecie.OrderBy(c => c.Datazajecia))
            {

#line default
#line hidden
            BeginContext(784, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(845, 46, false);
#line 41 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Grupa\Zajecia.cshtml"
               Write(Html.DisplayFor(modelItem => item.Datazajecia));

#line default
#line hidden
            EndContext();
            BeginContext(891, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(959, 47, false);
#line 44 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Grupa\Zajecia.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nazwazajecia));

#line default
#line hidden
            EndContext();
            BeginContext(1006, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1074, 42, false);
#line 47 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Grupa\Zajecia.cshtml"
               Write(Html.DisplayFor(modelItem => item.Miejsce));

#line default
#line hidden
            EndContext();
            BeginContext(1116, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 50 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Grupa\Zajecia.cshtml"
            }

#line default
#line hidden
            BeginContext(1175, 51, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(1226, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ed84db42eda4fe599ba22a022b57c90", async() => {
                BeginContext(1248, 6, true);
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
            BeginContext(1258, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Swp.Model.Grupa> Html { get; private set; }
    }
}
#pragma warning restore 1591
