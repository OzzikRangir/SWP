#pragma checksum "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Zolnierz\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91f138f7a12013caa9f203b4a2890b32130fd55e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Zolnierz_Delete), @"mvc.1.0.view", @"/Views/Zolnierz/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Zolnierz/Delete.cshtml", typeof(AspNetCore.Views_Zolnierz_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91f138f7a12013caa9f203b4a2890b32130fd55e", @"/Views/Zolnierz/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b50c99fbef0e2a1d4ad52be2cb351b10343a99c", @"/Views/_ViewImports.cshtml")]
    public class Views_Zolnierz_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Swp.Model.Zolnierz>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Zolnierz\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(71, 169, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Zolnierz</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(241, 43, false);
#line 15 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Zolnierz\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Stopien));

#line default
#line hidden
            EndContext();
            BeginContext(284, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(328, 39, false);
#line 18 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Zolnierz\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Stopien));

#line default
#line hidden
            EndContext();
            BeginContext(367, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(411, 40, false);
#line 21 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Zolnierz\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Imie));

#line default
#line hidden
            EndContext();
            BeginContext(451, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(495, 36, false);
#line 24 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Zolnierz\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Imie));

#line default
#line hidden
            EndContext();
            BeginContext(531, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(575, 44, false);
#line 27 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Zolnierz\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nazwisko));

#line default
#line hidden
            EndContext();
            BeginContext(619, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(663, 40, false);
#line 30 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Zolnierz\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nazwisko));

#line default
#line hidden
            EndContext();
            BeginContext(703, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(747, 41, false);
#line 33 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Zolnierz\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Adres));

#line default
#line hidden
            EndContext();
            BeginContext(788, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(832, 37, false);
#line 36 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Zolnierz\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Adres));

#line default
#line hidden
            EndContext();
            BeginContext(869, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(913, 44, false);
#line 39 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Zolnierz\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Imieojca));

#line default
#line hidden
            EndContext();
            BeginContext(957, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1001, 40, false);
#line 42 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Zolnierz\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Imieojca));

#line default
#line hidden
            EndContext();
            BeginContext(1041, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1085, 45, false);
#line 45 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Zolnierz\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Imiematki));

#line default
#line hidden
            EndContext();
            BeginContext(1130, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1174, 41, false);
#line 48 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Zolnierz\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Imiematki));

#line default
#line hidden
            EndContext();
            BeginContext(1215, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1259, 41, false);
#line 51 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Zolnierz\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pesel));

#line default
#line hidden
            EndContext();
            BeginContext(1300, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1344, 37, false);
#line 54 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Zolnierz\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pesel));

#line default
#line hidden
            EndContext();
            BeginContext(1381, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1425, 49, false);
#line 57 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Zolnierz\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Numertelefonu));

#line default
#line hidden
            EndContext();
            BeginContext(1474, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1518, 45, false);
#line 60 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Zolnierz\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Numertelefonu));

#line default
#line hidden
            EndContext();
            BeginContext(1563, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1607, 53, false);
#line 63 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Zolnierz\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IdgrupyNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1660, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1704, 57, false);
#line 66 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Zolnierz\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IdgrupyNavigation.Idgrupy));

#line default
#line hidden
            EndContext();
            BeginContext(1761, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1799, 216, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce141560fefa41289f1916818c20da33", async() => {
                BeginContext(1825, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1835, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "76b9d6fe1a734d609212e266c1852bb1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 71 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Zolnierz\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Idzolnierza);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1880, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1964, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19aae23aee744620b73bb11e9e451881", async() => {
                    BeginContext(1986, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2002, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2015, 10, true);
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
