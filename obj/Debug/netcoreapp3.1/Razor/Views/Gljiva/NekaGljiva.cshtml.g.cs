#pragma checksum "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Gljiva\NekaGljiva.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee2124ff229ddbd1649ac25791c8c741cc701928"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gljiva_NekaGljiva), @"mvc.1.0.view", @"/Views/Gljiva/NekaGljiva.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee2124ff229ddbd1649ac25791c8c741cc701928", @"/Views/Gljiva/NekaGljiva.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccec1446007ef9400b7f1deb65078f355b86550a", @"/Views/_ViewImports.cshtml")]
    public class Views_Gljiva_NekaGljiva : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gljiva>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Gljiva\NekaGljiva.cshtml"
  
    ViewData["Title"] = "NekaGljiva";
    List<String> mjesta = ViewBag.gljivaUMjestu;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee2124ff229ddbd1649ac25791c8c741cc7019283319", async() => {
                WriteLiteral("\r\n        <article>\r\n\r\n            <h2>");
#nullable restore
#line 10 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Gljiva\NekaGljiva.cshtml"
           Write(Model.Naziv);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n            <p><b>Kategorija: </b>");
#nullable restore
#line 11 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Gljiva\NekaGljiva.cshtml"
                             Write(Model.Kategorija);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></p>\r\n            <p><b>Opis: </b>");
#nullable restore
#line 12 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Gljiva\NekaGljiva.cshtml"
                       Write(Model.Opis);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></p>\r\n            <p>\r\n                <b>\r\n                    Otrovno:\r\n");
#nullable restore
#line 16 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Gljiva\NekaGljiva.cshtml"
                     if (Model.Otrovnica != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Gljiva\NekaGljiva.cshtml"
                         if (Model.Otrovnica.Value)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <b>Da</b>\r\n");
#nullable restore
#line 21 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Gljiva\NekaGljiva.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <b>Ne</b>\r\n");
#nullable restore
#line 25 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Gljiva\NekaGljiva.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Gljiva\NekaGljiva.cshtml"
                         
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <b> - </b>\r\n");
#nullable restore
#line 30 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Gljiva\NekaGljiva.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </p>\r\n            <p>Zupanije:</p>\r\n");
#nullable restore
#line 33 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Gljiva\NekaGljiva.cshtml"
             foreach (var m in mjesta)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <b>");
#nullable restore
#line 35 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Gljiva\NekaGljiva.cshtml"
              Write(m);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b>\r\n");
#nullable restore
#line 36 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Gljiva\NekaGljiva.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n        </article>\r\n    ");
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
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gljiva> Html { get; private set; }
    }
}
#pragma warning restore 1591
