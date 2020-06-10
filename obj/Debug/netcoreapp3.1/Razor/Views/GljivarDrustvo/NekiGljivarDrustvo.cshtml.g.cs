#pragma checksum "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\GljivarDrustvo\NekiGljivarDrustvo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68c6d677ffd2de18f065388ea29e9fa40cf0c295"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GljivarDrustvo_NekiGljivarDrustvo), @"mvc.1.0.view", @"/Views/GljivarDrustvo/NekiGljivarDrustvo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68c6d677ffd2de18f065388ea29e9fa40cf0c295", @"/Views/GljivarDrustvo/NekiGljivarDrustvo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccec1446007ef9400b7f1deb65078f355b86550a", @"/Views/_ViewImports.cshtml")]
    public class Views_GljivarDrustvo_NekiGljivarDrustvo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GljivarDrustvo>
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
#line 2 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\GljivarDrustvo\NekiGljivarDrustvo.cshtml"
  
    ViewData["Title"] = "GljivarDrustvo";
    List<Korisnik> korisnici = ViewBag.korisnici;
    List<Objava> objave = ViewBag.objave;
    List<Dogadaj> dogadaji = ViewBag.dogadaji;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\GljivarDrustvo\NekiGljivarDrustvo.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68c6d677ffd2de18f065388ea29e9fa40cf0c2953781", async() => {
                WriteLiteral("\r\n    <article>\r\n\r\n        <h2>");
#nullable restore
#line 18 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\GljivarDrustvo\NekiGljivarDrustvo.cshtml"
       Write(Model.Naziv);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n        <p><b>Županija: </b>");
#nullable restore
#line 19 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\GljivarDrustvo\NekiGljivarDrustvo.cshtml"
                       Write(Model.IdMjestoNavigation.Naziv);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></p>\r\n\r\n        <p>\r\n            <b>Članovi: </b>\r\n\r\n");
#nullable restore
#line 24 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\GljivarDrustvo\NekiGljivarDrustvo.cshtml"
             foreach (var k in korisnici)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\GljivarDrustvo\NekiGljivarDrustvo.cshtml"
                 if (k.IdGljivarskoDrustvo == Model.IdGljivarDrustvo)

                {


#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a");
                BeginWriteAttribute("href", " href=\"", 623, "\"", 696, 1);
#nullable restore
#line 30 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\GljivarDrustvo\NekiGljivarDrustvo.cshtml"
WriteAttributeValue("", 630, Url.Action("NekiKorisnik", "Korisnik", new { id = k.IdKorisnik }), 630, 66, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        ");
#nullable restore
#line 31 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\GljivarDrustvo\NekiGljivarDrustvo.cshtml"
                   Write(k.KorisnickoIme);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </a>\r\n");
#nullable restore
#line 33 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\GljivarDrustvo\NekiGljivarDrustvo.cshtml"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\GljivarDrustvo\NekiGljivarDrustvo.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p><b>Objave: </b></p>\r\n");
#nullable restore
#line 37 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\GljivarDrustvo\NekiGljivarDrustvo.cshtml"
         foreach (var o in objave)
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\GljivarDrustvo\NekiGljivarDrustvo.cshtml"
             if (o.IdGljivarDrustvo != null && o.IdGljivarDrustvo == Model.IdGljivarDrustvo)

            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 1039, "\"", 1106, 1);
#nullable restore
#line 44 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\GljivarDrustvo\NekiGljivarDrustvo.cshtml"
WriteAttributeValue("", 1046, Url.Action("NekaObjava", "Objava", new { id = o.IdObjava }), 1046, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        ");
#nullable restore
#line 45 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\GljivarDrustvo\NekiGljivarDrustvo.cshtml"
                   Write(o.Naziv);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </a>\r\n                </p>\r\n");
#nullable restore
#line 48 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\GljivarDrustvo\NekiGljivarDrustvo.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\GljivarDrustvo\NekiGljivarDrustvo.cshtml"
             
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </p>\r\n\r\n        <p><b>Događaji: </b></p>\r\n");
#nullable restore
#line 54 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\GljivarDrustvo\NekiGljivarDrustvo.cshtml"
         foreach (var d in dogadaji)
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\GljivarDrustvo\NekiGljivarDrustvo.cshtml"
             if (d.IdGljivarDrustvo != null && d.IdGljivarDrustvo == Model.IdGljivarDrustvo)

            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 1475, "\"", 1545, 1);
#nullable restore
#line 61 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\GljivarDrustvo\NekiGljivarDrustvo.cshtml"
WriteAttributeValue("", 1482, Url.Action("NekiDogadaj", "Dogadaj", new { id = d.IdDogadaj }), 1482, 63, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        ");
#nullable restore
#line 62 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\GljivarDrustvo\NekiGljivarDrustvo.cshtml"
                   Write(d.Naziv);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </a>\r\n                </p>\r\n");
#nullable restore
#line 65 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\GljivarDrustvo\NekiGljivarDrustvo.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\GljivarDrustvo\NekiGljivarDrustvo.cshtml"
             
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </p>\r\n\r\n\r\n\r\n    </article>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GljivarDrustvo> Html { get; private set; }
    }
}
#pragma warning restore 1591
