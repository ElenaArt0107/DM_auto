#pragma checksum "C:\Users\User\source\repos\SyntraWestCSharpEindwerkOlenaArtiushenko\Presentation.DMAutoservice\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63d7b370a66b1e4b52662c01c2f0cebfcddadcef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\User\source\repos\SyntraWestCSharpEindwerkOlenaArtiushenko\Presentation.DMAutoservice\Views\_ViewImports.cshtml"
using Presentation.DMAutoservice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\SyntraWestCSharpEindwerkOlenaArtiushenko\Presentation.DMAutoservice\Views\_ViewImports.cshtml"
using Presentation.DMAutoservice.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\SyntraWestCSharpEindwerkOlenaArtiushenko\Presentation.DMAutoservice\Views\_ViewImports.cshtml"
using DMAutoservice.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\SyntraWestCSharpEindwerkOlenaArtiushenko\Presentation.DMAutoservice\Views\_ViewImports.cshtml"
using Presentation.Website;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\SyntraWestCSharpEindwerkOlenaArtiushenko\Presentation.DMAutoservice\Views\_ViewImports.cshtml"
using DMAutoservice.Domain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\User\source\repos\SyntraWestCSharpEindwerkOlenaArtiushenko\Presentation.DMAutoservice\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63d7b370a66b1e4b52662c01c2f0cebfcddadcef", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8b42d0b02735645217f4897dcd0784b47815d2b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\source\repos\SyntraWestCSharpEindwerkOlenaArtiushenko\Presentation.DMAutoservice\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63d7b370a66b1e4b52662c01c2f0cebfcddadcef5483", async() => {
                WriteLiteral("\r\n    <!-- main container -->\r\n    <div class=\"wrapper\">\r\n        <aside class=\"sidebar\">\r\n            <img class=\"img_main_logo\"");
                BeginWriteAttribute("src", " src=\"", 263, "\"", 317, 1);
#nullable restore
#line 11 "C:\Users\User\source\repos\SyntraWestCSharpEindwerkOlenaArtiushenko\Presentation.DMAutoservice\Views\Home\Index.cshtml"
WriteAttributeValue("", 269, Url.Content("~/images/DMAutoService_adapt.jpg"), 269, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" alt=""DMAutoService"">
            <div class=""all_containers"">
                <!-- contacts container -->
                <div class=""contacts_cont"">
                    <h3 class=""contacts_title"">Contactgegevens</h3>
                    <div>
                        <div>
                            <span class=""contacts_type"">C:</span>
                            <a class=""contacts_content"" href=""+3250270283"">+3250270283</a>
                        </div>
                        <div>
                            <span class=""contacts_type"">A:</span>
                            <a class=""contacts_content"">Monnikenwerve 187, 8000 Brugge</a>
                        </div>
                        <div>
                            <span class=""contacts_type"">E:</span>
                            <a class=""contacts_content"" href=""mailto:brugge.dmautoservice@gmail.com"">brugge.dmautoservice@gmail.com</a>
                        </div>
                        <div>
                            <sp");
                WriteLiteral(@"an class=""contacts_type_btw"">BTW:</span>
                            <span class=""contacts_content"">BE0694562065</span>
                        </div>
                    </div>
                </div>
                <!-- car brands container-->
                <div class=""brands_cont"">
                    <h3 class=""brands_name"">Merken</h3>
                    <ul>
                        <li class=""bullet"">
                            <span class=""brand_content"">Alfa Fiat</span>
                        </li>
                        <li class=""bullet"">
                            <span class=""brand_content"">Mercedes</span>
                        </li>
                        <li class=""bullet"">
                            <span class=""brand_content"">BMW</span>
                        </li>
                        <li class=""bullet"">
                            <span class=""brand_content"">VAG</span>
                        </li>
                        <li class=""bullet"">
              ");
                WriteLiteral(@"              <span class=""brand_content"">etc...</span>
                        </li>
                    </ul>
                </div>

                <!-- our honoured customers container -->
                <div class=""brands_cont"">
                    <h3 class=""brands_name"">Services</h3>
                    <ul>
                        <li class=""bullet"">
                            <span class=""brand_content"">Diagnose</span>
                        </li>
                        <li class=""bullet"">
                            <span class=""brand_content"">Chiptuning</span>
                        </li>
                        <li class=""bullet"">
                            <span class=""brand_content"">Onderhoud</span>
                        </li>
                        <li class=""bullet"">
                            <span class=""brand_content"">Airco</span>
                        </li>
                        <li class=""bullet"">
                            <span class=""brand_content""");
                WriteLiteral(@">Remmen service</span>
                        </li>
                        <li class=""bullet"">
                            <span class=""brand_content"">Vervangwagen</span>
                        </li>
                        <li class=""bullet"">
                            <span class=""brand_content"">Alle elektronische herstellingen</span>
                        </li>
                        <li class=""bullet"">
                            <span class=""brand_content"">Monteren van opties</span>
                        </li>
                        <li class=""bullet"">
                            <span class=""brand_content"">Alle reparaties</span>
                        </li>
                        <li class=""bullet"">
                            <span class=""brand_content"">Nazicht keuring & Aanbieden keuring</span>
                        </li>
                    </ul>
                </div>
            </div>
        </aside>
        <!-- about me container -->
        <div class=""about");
                WriteLiteral(@"_me_container"">
            <!-- about ne main info -->
            <div class=""main_info_container"">
                <h2 class=""main_info_h2"">Garage van Brugge</h2>
                <h1 class=""main_info_h1"">DM AutoService</h1>
                <p class=""description"">
                    De best mogelijke prestaties, duurzaam, betrouwbaar en vooral veilig.
                    Find the best decision for your car!
                </p>
            </div>
            <!-- project container -->
            <div class=""other_main_containers"">
                <h3 class=""main_info_h3"">Zie ook</h3>
                <ol>
                    <li class=""numb_link"">
                        <a class=""link"" href=""https://www.facebook.com/search/top?q=dm%20autoservice"">https://www.facebook.com/search/top?q=dm%20autoservice</a>
                        <span class=""dots"">..................................</span>

                        <span><b>[</b><span class=""link"">Facebook</span><b>]</b></span>
           ");
                WriteLiteral(@"         </li>
                    <li class=""numb_link"">
                        <a class=""link"">
                            https://www.google.com/maps/place/DM+AutoService/
                        </a>
                        <span class=""dots"">............................................</span>

                        <span><b>[</b><span class=""link"">GoogleMaps</span><b>]</b></span>
                    </li>
                </ol>
            </div>
            <!-- work experience -->
            <div class=""other_main_containers"">
                <!-- #1 -->
                <h3 class=""main_info_h3"">Wat wij aanbieden</h3>
                <h4 class=""main_info_h4"">Chiptuning op maat <span class=""main_info_h4_highlighted"">Alle merken</span></h4>
                <span class=""main_info_span"">Nieuw sinds 2018 <span class=""delimiter"">|</span> Belgie</span>
                <ul class=""main_list_non"">
                    <li>
                        Wereldwijd vestigingen technologie
         ");
                WriteLiteral(@"           </li>
                    <li>
                        Software op maat
                    </li>
                    <li>
                        Dyno tested
                    </li>
                </ul>
                <!-- #2 -->
                <h4 class=""main_info_h4"">Onderhoud en herstellingen <span class=""main_info_h4_highlighted"">Alle merken</span></h4>
                <span class=""main_info_span"">Sinds 2018 <span class=""delimiter"">|</span> Belgie</span>
                <ul class=""main_list_non"">
                    <li>
                        Kwaliteits service
                    </li>
                    <li>
                        Mobil olie
                    </li>
                    <li>
                        Toegang tot Mercedes portaal: Om digitale service boek in te vullen en historiek van uw wagen te zien
                    </li>
                    <li>
                        Alle mechanische herstellingen: Koppelingen vervangen, distributie, ophan");
                WriteLiteral(@"ging
                    </li>
                    <li>
                        Revisie van motoren
                    </li>
                </ul>
                <!-- #3 -->
                <h4 class=""main_info_h4"">Diagnose + coderen <span class=""main_info_h4_highlighted"">Elektronische en mechanische problemen</span></h4>
                <span class=""main_info_span"">Sinds 2018 <span class=""delimiter"">|</span> Belgie</span>
                <ul class=""main_list_non"">
                    <li>
                        Diagnose door gebruik van originele software
                    </li>
                    <li>
                        Coderen en aanpassen van software
                    </li>
                    <li>
                        Update van navigatie
                    </li>
                </ul>
            </div>
            <!-- Sertificates -->
            <div>
                <!-- #1 -->
                <h3 class=""main_info_h3"">Onze Certificeringen </h3>
             ");
                WriteLiteral(@"   <h4 class=""main_info_h4_highlighted"">WinOLS Master</h4>
                <span class=""main_info_span"">Sinds 2018 <span class=""delimiter"">|</span> Belgie</span>
                <ul class=""main_list_non"">
                    <li>Bewerken van ECU kaarten</li>
                    <li>Eigen database</li>
                </ul>
                <h4 class=""main_info_h4_highlighted"">Mercedes onderhoudstechniekers</h4>
                <span class=""main_info_span"">Sinds 2018 <span class=""delimiter"">|</span> Belgie</span>
                <ul class=""main_list_non"">
                    <li>Veel jaren Mercedes ervaring</li>
                    <li>Diagnose</li>
                </ul>
                <h4 class=""main_info_h4_highlighted"">Werken aan hybride voertuigen</h4>
                <span class=""main_info_span"">Sinds 2018 <span class=""delimiter"">|</span> Belgie</span>
                <ul class=""main_list_non"">
                    <li>Veilig werken aan hybride voertuigen</li>
                    <li>Veilig");
                WriteLiteral("e service</li>\r\n                </ul>\r\n            </div>\r\n");
                WriteLiteral("        <div>\r\n");
#nullable restore
#line 203 "C:\Users\User\source\repos\SyntraWestCSharpEindwerkOlenaArtiushenko\Presentation.DMAutoservice\Views\Home\Index.cshtml"
             if (AccountSessionHelper.IsLoggedIn)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <h1>User is logged in</h1>\r\n                <ul>\r\n                    <li><b>Username: </b>");
#nullable restore
#line 207 "C:\Users\User\source\repos\SyntraWestCSharpEindwerkOlenaArtiushenko\Presentation.DMAutoservice\Views\Home\Index.cshtml"
                                    Write(AccountSessionHelper.Account.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                    <li><b>UserId: </b>");
#nullable restore
#line 208 "C:\Users\User\source\repos\SyntraWestCSharpEindwerkOlenaArtiushenko\Presentation.DMAutoservice\Views\Home\Index.cshtml"
                                  Write(AccountSessionHelper.Account.UserId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                    <li>\r\n                        <b>Rights: </b>\r\n                        <ul>\r\n");
#nullable restore
#line 212 "C:\Users\User\source\repos\SyntraWestCSharpEindwerkOlenaArtiushenko\Presentation.DMAutoservice\Views\Home\Index.cshtml"
                             foreach (var right in AccountSessionHelper.Account.Rights)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li>");
#nullable restore
#line 214 "C:\Users\User\source\repos\SyntraWestCSharpEindwerkOlenaArtiushenko\Presentation.DMAutoservice\Views\Home\Index.cshtml"
                               Write(right);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 215 "C:\Users\User\source\repos\SyntraWestCSharpEindwerkOlenaArtiushenko\Presentation.DMAutoservice\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </ul>\r\n                    </li>\r\n                </ul>\r\n");
#nullable restore
#line 219 "C:\Users\User\source\repos\SyntraWestCSharpEindwerkOlenaArtiushenko\Presentation.DMAutoservice\Views\Home\Index.cshtml"

            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p class=\"alert_customized\">For more actions, please ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63d7b370a66b1e4b52662c01c2f0cebfcddadcef18770", async() => {
                    WriteLiteral("log in");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" \r\n            or ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63d7b370a66b1e4b52662c01c2f0cebfcddadcef20220", async() => {
                    WriteLiteral("register");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" first</p>\r\n");
#nullable restore
#line 225 "C:\Users\User\source\repos\SyntraWestCSharpEindwerkOlenaArtiushenko\Presentation.DMAutoservice\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n        </div>\r\n\r\n    </div>\r\n");
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
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
