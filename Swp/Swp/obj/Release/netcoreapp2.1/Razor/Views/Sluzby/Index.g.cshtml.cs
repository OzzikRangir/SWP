#pragma checksum "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Sluzby\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25dbd577e4d7e6e7569d331e5728271f4b5e8252"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sluzby_Index), @"mvc.1.0.view", @"/Views/Sluzby/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sluzby/Index.cshtml", typeof(AspNetCore.Views_Sluzby_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25dbd577e4d7e6e7569d331e5728271f4b5e8252", @"/Views/Sluzby/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb2b80837ff6c0e038ad6b02718e265b887074a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Sluzby_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Swp.Model.Sluzba>>
    {
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
        private global::Swp.TagHelpers.SluzbyTagHelper __Swp_TagHelpers_SluzbyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(33, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("calendar", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "36f5a1396bda4b6688b2b81c37a1e8bd", async() => {
            }
            );
            __Swp_TagHelpers_SluzbyTagHelper = CreateTagHelper<global::Swp.TagHelpers.SluzbyTagHelper>();
            __tagHelperExecutionContext.Add(__Swp_TagHelpers_SluzbyTagHelper);
#line 3 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Sluzby\Index.cshtml"
__Swp_TagHelpers_SluzbyTagHelper.Month = DateTime.Now.Month;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("month", __Swp_TagHelpers_SluzbyTagHelper.Month, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 3 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Sluzby\Index.cshtml"
__Swp_TagHelpers_SluzbyTagHelper.Year = DateTime.Now.Year;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("year", __Swp_TagHelpers_SluzbyTagHelper.Year, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 3 "C:\Users\Student\Source\Repos\SWP\Swp\Swp\Views\Sluzby\Index.cshtml"
__Swp_TagHelpers_SluzbyTagHelper.Events = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("events", __Swp_TagHelpers_SluzbyTagHelper.Events, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Swp.Model.Sluzba>> Html { get; private set; }
    }
}
#pragma warning restore 1591
