#pragma checksum "C:\Users\s217161227\Desktop\AmeliorateNew\AmeliorateAegis\Areas\Liason\Views\Error\PageNotFound.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a40682127ae3cfb3edfdacfa8d3be1e9260df656"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Liason_Views_Error_PageNotFound), @"mvc.1.0.view", @"/Areas/Liason/Views/Error/PageNotFound.cshtml")]
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
#line 1 "C:\Users\s217161227\Desktop\AmeliorateNew\AmeliorateAegis\Areas\Liason\Views\_ViewImports.cshtml"
using AmeliorateAegis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\s217161227\Desktop\AmeliorateNew\AmeliorateAegis\Areas\Liason\Views\_ViewImports.cshtml"
using AmeliorateAegis.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a40682127ae3cfb3edfdacfa8d3be1e9260df656", @"/Areas/Liason/Views/Error/PageNotFound.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55beccb9a00c1b368d959213ab0bacf2b3db22f4", @"/Areas/Liason/Views/_ViewImports.cshtml")]
    public class Areas_Liason_Views_Error_PageNotFound : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\s217161227\Desktop\AmeliorateNew\AmeliorateAegis\Areas\Liason\Views\Error\PageNotFound.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-danger\">Error.</h1>\r\n<h2> Ooooops Page Not Found, better check that URL!</h2>\r\n\r\n\r\nif (Model.ShowRequestId)\r\n            {\r\n<p><strong>Request ID: </strong><code>");
#nullable restore
#line 13 "C:\Users\s217161227\Desktop\AmeliorateNew\AmeliorateAegis\Areas\Liason\Views\Error\PageNotFound.cshtml"
                                 Write(Model.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code></p>\r\n            }\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
