#pragma checksum "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Bron\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dde1c801010690be8427ad2c2461e3fba109826"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bron_Index), @"mvc.1.0.view", @"/Views/Bron/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bron/Index.cshtml", typeof(AspNetCore.Views_Bron_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dde1c801010690be8427ad2c2461e3fba109826", @"/Views/Bron/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b50c99fbef0e2a1d4ad52be2cb351b10343a99c", @"/Views/_ViewImports.cshtml")]
    public class Views_Bron_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Swp.Model.Bron>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Bron\Index.cshtml"
  
    ViewData["Title"] = "Uzbrojenie";
    IEnumerable<Swp.Model.Uzytkownik> logged = ViewData["Logged"] as IEnumerable<Swp.Model.Uzytkownik>;

#line default
#line hidden
            BeginContext(189, 33, true);
            WriteLiteral("\r\n<h2>Ewidencja uzbrojenia</h2>\r\n");
            EndContext();
#line 9 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Bron\Index.cshtml"
 if (logged.Where(z => z.Iduzytkownika.ToString() == User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier).Value).Select(a => a.IdroliNavigation.Nazwa).FirstOrDefault() == "Administrator")
{

#line default
#line hidden
            BeginContext(426, 17, true);
            WriteLiteral("    <p>\r\n        ");
            EndContext();
            BeginContext(443, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18572c8608f840278b21a8e872fe6521", async() => {
                BeginContext(466, 10, true);
                WriteLiteral("Dodaj broń");
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
            BeginContext(480, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
#line 14 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Bron\Index.cshtml"
}

#line default
#line hidden
            BeginContext(495, 451, true);
            WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Numer broni
                </th>
                <th>
                    Nazwa broni
                </th>
                <th>
                    Stan broni
                </th>
                <th>
                    Żołnierz
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 34 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Bron\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1003, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1076, 42, false);
#line 38 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Bron\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Idbroni));

#line default
#line hidden
            EndContext();
            BeginContext(1118, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1198, 45, false);
#line 41 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Bron\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nazwabroni));

#line default
#line hidden
            EndContext();
            BeginContext(1243, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1323, 44, false);
#line 44 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Bron\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.StanBroni));

#line default
#line hidden
            EndContext();
            BeginContext(1367, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1447, 70, false);
#line 47 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Bron\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IdzolnierzaNavigation.StopienString));

#line default
#line hidden
            EndContext();
            BeginContext(1517, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1519, 65, false);
#line 47 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Bron\Index.cshtml"
                                                                                           Write(Html.DisplayFor(modelItem => item.IdzolnierzaNavigation.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(1584, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
#line 49 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Bron\Index.cshtml"
                     if (logged.Where(z => z.Iduzytkownika.ToString() == User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier).Value).Select(a => a.IdroliNavigation.Nazwa).FirstOrDefault() == "Administrator")
                    {

#line default
#line hidden
            BeginContext(1857, 60, true);
            WriteLiteral("                        <td>\r\n\r\n                            ");
            EndContext();
            BeginContext(1917, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09afa2b852454c10b28ab965a4d388ec", async() => {
                BeginContext(1967, 6, true);
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
#line 53 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Bron\Index.cshtml"
                                                   WriteLiteral(item.Idbroni);

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
            BeginContext(1977, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(2009, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "874692e8d1694450bccadac335746b9a", async() => {
                BeginContext(2061, 6, true);
                WriteLiteral(" Usuń ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Bron\Index.cshtml"
                                                     WriteLiteral(item.Idbroni);

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
            BeginContext(2071, 35, true);
            WriteLiteral("\r\n\r\n                        </td>\r\n");
            EndContext();
#line 57 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Bron\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2129, 23, true);
            WriteLiteral("                </tr>\r\n");
            EndContext();
#line 59 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Bron\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2167, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Swp.Model.Bron>> Html { get; private set; }
    }
}
#pragma warning restore 1591
