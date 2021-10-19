#pragma checksum "/Users/lundimapundu/Downloads/AmeliorateAegis/AmeliorateAegis/Areas/Public/Views/Contact/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d936c553a520ae0f5490220140f1ad19bb590e2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Public_Views_Contact_Index), @"mvc.1.0.view", @"/Areas/Public/Views/Contact/Index.cshtml")]
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
#line 1 "/Users/lundimapundu/Downloads/AmeliorateAegis/AmeliorateAegis/Areas/Public/Views/_ViewImports.cshtml"
using AmeliorateAegis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/lundimapundu/Downloads/AmeliorateAegis/AmeliorateAegis/Areas/Public/Views/_ViewImports.cshtml"
using AmeliorateAegis.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d936c553a520ae0f5490220140f1ad19bb590e2f", @"/Areas/Public/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55beccb9a00c1b368d959213ab0bacf2b3db22f4", @"/Areas/Public/Views/_ViewImports.cshtml")]
    public class Areas_Public_Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("forms/contact.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("php-email-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/lundimapundu/Downloads/AmeliorateAegis/AmeliorateAegis/Areas/Public/Views/Contact/Index.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main id=""main"">

    <!-- ======= Intro Single ======= -->
    <section class=""intro-single"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12 col-lg-8"">
                    <div class=""title-single-box"">
                        <h1 class=""title-single"">Contact us</h1>
                        <span class=""color-text-a"">Handling and improving tasks through feedback. </div>
                </div>
            </div>
        </div>
    </section><!-- End Intro Single-->
    <!-- ======= Contact Single ======= -->
    <section class=""contact"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-sm-12"">
                    <div class=""contact-map box"">
");
            WriteLiteral("                    </div>\r\n                </div>\r\n                <div class=\"col-sm-12 section-t8\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-7\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d936c553a520ae0f5490220140f1ad19bb590e2f5925", async() => {
                WriteLiteral(@"
                                <div class=""row"">
                                    <div class=""col-md-6 mb-3"">
                                        <div class=""form-group"">
                                            <input type=""text"" name=""name"" class=""form-control form-control-lg form-control-a"" placeholder=""Your Name"" data-rule=""minlen:4"" data-msg=""Please enter at least 4 chars"">
                                            <div class=""validate""></div>
                                        </div>
                                    </div>
                                    <div class=""col-md-6 mb-3"">
                                        <div class=""form-group"">
                                            <input name=""email"" type=""email"" class=""form-control form-control-lg form-control-a"" placeholder=""Your Email"" data-rule=""email"" data-msg=""Please enter a valid email"">
                                            <div class=""validate""></div>
                                        </");
                WriteLiteral(@"div>
                                    </div>
                                    <div class=""col-md-12 mb-3"">
                                        <div class=""form-group"">
                                            <input type=""text"" name=""subject"" class=""form-control form-control-lg form-control-a"" placeholder=""Subject"" data-rule=""minlen:4"" data-msg=""Please enter at least 8 chars of subject"">
                                            <div class=""validate""></div>
                                        </div>
                                    </div>
                                    <div class=""col-md-12"">
                                        <div class=""form-group"">
                                            <textarea name=""message"" class=""form-control"" name=""message"" cols=""45"" rows=""8"" data-rule=""required"" data-msg=""Please write something for us"" placeholder=""Message""></textarea>
                                            <div class=""validate""></div>
                           ");
                WriteLiteral(@"             </div>
                                    </div>
                                    <div class=""col-md-12 mb-3"">
                                        <div class=""mb-3"">
                                            <div class=""loading"">Loading</div>
                                            <div class=""error-message""></div>
                                            <div class=""sent-message"">Your message has been sent. Thank you!</div>
                                        </div>
                                    </div>

                                    <div class=""col-md-12 text-center"">
                                        <button type=""submit"" class=""btn btn-a"">Send Message</button>
                                    </div>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""col-md-5 section-md-t3"">
                            <div class=""icon-box section-b2"">
                                <div class=""icon-box-icon"">
                                    <span class=""ion-ios-paper-plane""></span>
                                </div>
                                <div class=""icon-box-content table-cell"">
                                    <div class=""icon-box-title"">
                                        <h4 class=""icon-title"">Say Hello</h4>
                                    </div>
                                    <div class=""icon-box-content"">
                                        <p class=""mb-1"">
                                            Email.
                                            <span class=""color-a"">contact@ameliorateaegis.com</span>
                                        </p>
                                        <p class=""mb-1"">
                                     ");
            WriteLiteral(@"       Phone.
                                            <span class=""color-a"">+54 356 945234</span>
                                        </p>
                                    </div>
                                </div>
                            </div>
                            <div class=""icon-box section-b2"">
                                <div class=""icon-box-icon"">
                                    <span class=""ion-ios-pin""></span>
                                </div>
                                <div class=""icon-box-content table-cell"">
                                    <div class=""icon-box-title"">
                                        <h4 class=""icon-title"">Find us in</h4>
                                    </div>
                                    <div class=""icon-box-content"">
                                        <p class=""mb-1"">
                                            123 Some Sreet,
                                            <br> Port Elizabeth. EC");
            WriteLiteral(@".
                                        </p>
                                    </div>
                                </div>
                            </div>
                            <div class=""icon-box"">
                                <div class=""icon-box-icon"">
                                    <span class=""ion-ios-redo""></span>
                                </div>
                                <div class=""icon-box-content table-cell"">
                                    <div class=""icon-box-title"">
                                        <h4 class=""icon-title"">Social networks</h4>
                                    </div>
                                    <div class=""icon-box-content"">
                                        <div class=""socials-footer"">
                                            <ul class=""list-inline"">
                                                <li class=""list-inline-item"">
                                                    <a href=""#"" class=""li");
            WriteLiteral(@"nk-one"">
                                                        <i class=""fa fa-facebook"" aria-hidden=""true""></i>
                                                    </a>
                                                </li>
                                                <li class=""list-inline-item"">
                                                    <a href=""#"" class=""link-one"">
                                                        <i class=""fa fa-twitter"" aria-hidden=""true""></i>
                                                    </a>
                                                </li>
                                                <li class=""list-inline-item"">
                                                    <a href=""#"" class=""link-one"">
                                                        <i class=""fa fa-instagram"" aria-hidden=""true""></i>
                                                    </a>
                                                </li>
                              ");
            WriteLiteral(@"                  <li class=""list-inline-item"">
                                                    <a href=""#"" class=""link-one"">
                                                        <i class=""fa fa-pinterest-p"" aria-hidden=""true""></i>
                                                    </a>
                                                </li>
                                                <li class=""list-inline-item"">
                                                    <a href=""#"" class=""link-one"">
                                                        <i class=""fa fa-dribbble"" aria-hidden=""true""></i>
                                                    </a>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
        ");
            WriteLiteral("        </div>\r\n            </div>\r\n        </div>\r\n    </section><!-- End Contact Single-->\r\n\r\n</main><!-- End #main -->\r\n");
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
