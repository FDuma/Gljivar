#pragma checksum "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Biljeska\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e728bc07fbeb98217b89e8e0e94b36db569f7420"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Biljeska_Index), @"mvc.1.0.view", @"/Views/Biljeska/Index.cshtml")]
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
#line 1 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\_ViewImports.cshtml"
using Gljivar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\_ViewImports.cshtml"
using Gljivar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e728bc07fbeb98217b89e8e0e94b36db569f7420", @"/Views/Biljeska/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccec1446007ef9400b7f1deb65078f355b86550a", @"/Views/_ViewImports.cshtml")]
    public class Views_Biljeska_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Biljeska>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Biljeska\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Biljeska\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e728bc07fbeb98217b89e8e0e94b36db569f74203593", async() => {
                WriteLiteral("\r\n    <style>\r\n\r\n        a:hover, a.ex1:active {\r\n            color: red;\r\n            text-decoration: underline;\r\n        }\r\n    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e728bc07fbeb98217b89e8e0e94b36db569f74204720", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Biljeska\Index.cshtml"
     foreach (var o in Model)
    {


        

#line default
#line hidden
#nullable disable
                WriteLiteral("                <article>\r\n\r\n                    <h2>\r\n");
                WriteLiteral("                        <a");
                BeginWriteAttribute("href", " href=\"", 490, "\"", 563, 1);
#nullable restore
#line 30 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Biljeska\Index.cshtml"
WriteAttributeValue("", 497, Url.Action("NekaBiljeska", "Biljeska", new { id = o.IdBiljeski }), 497, 66, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 30 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Biljeska\Index.cshtml"
                                                                                                Write(o.Naziv);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                    </h2>\r\n\r\n\r\n                    <p>");
#nullable restore
#line 34 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Biljeska\Index.cshtml"
                  Write(o.Biljeska1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <br><hr><br>\r\n                </article>\r\n");
#nullable restore
#line 37 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Biljeska\Index.cshtml"
        

    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Biljeska>> Html { get; private set; }
    }
}
#pragma warning restore 1591
