#pragma checksum "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Korisnik\NoviKorisnik.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ade4695990d8e61197195c2d9042f1163401701"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Korisnik_NoviKorisnik), @"mvc.1.0.view", @"/Views/Korisnik/NoviKorisnik.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ade4695990d8e61197195c2d9042f1163401701", @"/Views/Korisnik/NoviKorisnik.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccec1446007ef9400b7f1deb65078f355b86550a", @"/Views/_ViewImports.cshtml")]
    public class Views_Korisnik_NoviKorisnik : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Mjesto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "-1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Korisnik\NoviKorisnik.cshtml"
  
    ViewData["Title"] = "NoviProizvod";
    List<GljivarDrustvo> gljivarDrustvo = ViewBag.gljivarDrustvo;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h5>Podaci o korisniku:</h5>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ade4695990d8e61197195c2d9042f11634017014265", async() => {
                WriteLiteral(@"
    <table>
        
        <tr>
            <td>
                <span>
                    <label for=""korisnickoIme"">Korisničko ime:</label>     
                    <input type=""text"" name=""korisnickoIme"" placeholder=""Unesite korisnicko ime"" required>
                </span>
                <br />
            </td>
        </tr>
        <tr>
            <td>
                <span>
                    <label for=""pass"">Lozinka:</label>
                    <input type=""password"" name=""pass"" placeholder=""Unesite lozinku"" required>
                </span>
            </td>
        </tr>
        <tr>
            <td>
                <span>
                    <label for=""ime"">Vaše ime:</label>
                    <input type=""text"" name=""ime"" placeholder=""Unesite vaše ime"" required>
                </span>
            </td>
        </tr>
        <tr>
            <td>
                <span>
                    <label for=""prezime"">Vaše prezime:</label>
                    <inpu");
                WriteLiteral(@"t type=""text"" name=""prezime"" placeholder=""Unesite vaše prezime"" required>
                </span>
            </td>
         </tr>
        <tr>
            <td>
                <span>
                    <label for=""idMjesta"">Županija: </label>
                    <select name=""idMjesta"">
");
#nullable restore
#line 50 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Korisnik\NoviKorisnik.cshtml"
                         foreach (var p in Model)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ade4695990d8e61197195c2d9042f11634017016216", async() => {
#nullable restore
#line 52 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Korisnik\NoviKorisnik.cshtml"
                                                   Write(p.Naziv);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Korisnik\NoviKorisnik.cshtml"
                               WriteLiteral(p.IdMjesta);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Korisnik\NoviKorisnik.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                </span>
            </td>
        </tr>
        <tr>
            <td>
                <span>
                    <label for=""idGljivarDrustvo"">Član: </label>
                    <select name=""idGljivarDrustvo"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ade4695990d8e61197195c2d9042f11634017018606", async() => {
                    WriteLiteral(" - ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 64 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Korisnik\NoviKorisnik.cshtml"
                         foreach (var g in gljivarDrustvo)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ade4695990d8e61197195c2d9042f116340170110136", async() => {
#nullable restore
#line 66 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Korisnik\NoviKorisnik.cshtml"
                                                           Write(g.Naziv);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Korisnik\NoviKorisnik.cshtml"
                               WriteLiteral(g.IdGljivarDrustvo);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 67 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Korisnik\NoviKorisnik.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                </span>
            </td>
        </tr>
        <tr>
            <td>
                <span>
                    <label for=""kontaktBroj"">Kontakt broj: </label>
                    <input type=""number"" name=""kontaktBroj"" placeholder=""Unesite broj kontakta"">
                </span>
            </td>
        </tr>
        <tr>
            <td>
                <span>
                    <label for=""email"">eMail: </label>
                    <input type=""text"" name=""email"" placeholder=""Unesite svoju elektroničku poštu"">
                </span>
            </td>
        </tr>
        <tr>
            <td>
                <span>
                    <label for=""isAdmin"">Administrator: </label>
                    <input type=""checkbox"" name=""isAdmin"" value=false>
                </span>
            </td>
            <button id=""submitbtn"" type=""submit"" style=""min-width:100px;"">Unesi</button>
        </tr>


       
    </table>
    
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 9 "C:\Users\Filip\source\repos\Gljivar\Gljivar\Views\Korisnik\NoviKorisnik.cshtml"
AddHtmlAttributeValue("", 188, Url.Action("NoviKorisnik", "Korisnik"), 188, 39, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Mjesto>> Html { get; private set; }
    }
}
#pragma warning restore 1591