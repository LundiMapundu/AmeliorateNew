#pragma checksum "C:\Users\s217161227\Desktop\AmeliorateNew\AmeliorateAegis\Areas\Teacher\Views\Attendance\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ffe85138d04145852770ca71abba0bd58d9aac5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Teacher_Views_Attendance_Index), @"mvc.1.0.view", @"/Areas/Teacher/Views/Attendance/Index.cshtml")]
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
#line 1 "C:\Users\s217161227\Desktop\AmeliorateNew\AmeliorateAegis\Areas\Teacher\Views\_ViewImports.cshtml"
using AmeliorateAegis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\s217161227\Desktop\AmeliorateNew\AmeliorateAegis\Areas\Teacher\Views\_ViewImports.cshtml"
using AmeliorateAegis.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ffe85138d04145852770ca71abba0bd58d9aac5", @"/Areas/Teacher/Views/Attendance/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55beccb9a00c1b368d959213ab0bacf2b3db22f4", @"/Areas/Teacher/Views/_ViewImports.cshtml")]
    public class Areas_Teacher_Views_Attendance_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AmeliorateAegis.Models.ViewModels.PupilAttendanceViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\s217161227\Desktop\AmeliorateNew\AmeliorateAegis\Areas\Teacher\Views\Attendance\Index.cshtml"
  
    ViewData["Title"] = "Attendance";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card card-plain"">
                <div class=""card-header card-header-primary"">
                    <h4 class=""card-title mt-0""> Student Attendance</h4>
                    <p class=""card-category""> Attendance for ");
#nullable restore
#line 13 "C:\Users\s217161227\Desktop\AmeliorateNew\AmeliorateAegis\Areas\Teacher\Views\Attendance\Index.cshtml"
                                                        Write(DateTime.Today.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <div class=\"table-responsive\">\r\n                        <table class=\"table table-hover\">\r\n                            <tr");
            BeginWriteAttribute("class", " class=\"", 705, "\"", 713, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <th>
                                    ID
                                </th>
                                <th>
                                    First Name
                                </th>
                                <th>
                                    Last Surname
                                </th>
                                <th class=""text-center"">
                                    Check if Attended
                                </th>
                            </tr>
                            <tbody>
");
#nullable restore
#line 33 "C:\Users\s217161227\Desktop\AmeliorateNew\AmeliorateAegis\Areas\Teacher\Views\Attendance\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 37 "C:\Users\s217161227\Desktop\AmeliorateNew\AmeliorateAegis\Areas\Teacher\Views\Attendance\Index.cshtml"
                                       Write(Html.DisplayFor(model => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 40 "C:\Users\s217161227\Desktop\AmeliorateNew\AmeliorateAegis\Areas\Teacher\Views\Attendance\Index.cshtml"
                                       Write(Html.DisplayFor(model => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 43 "C:\Users\s217161227\Desktop\AmeliorateNew\AmeliorateAegis\Areas\Teacher\Views\Attendance\Index.cshtml"
                                       Write(Html.DisplayFor(model => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </td>
                                        <td class=""text-center"">
                                            <div class=""form-check"">
                                                <label class=""form-check-label"">
                                                    ");
#nullable restore
#line 48 "C:\Users\s217161227\Desktop\AmeliorateNew\AmeliorateAegis\Areas\Teacher\Views\Attendance\Index.cshtml"
                                               Write(Html.CheckBoxFor(m => item.IsAttended, new { onclick = "UpdateAttendance(this)", data_pupil = item.Id, @class = "form-check-input" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                    <span class=""form-check-sign"">
                                                        <span class=""check""></span>
                                                    </span>
                                                </label>
                                            </div>
                                        </td>
                                    </tr>
");
#nullable restore
#line 56 "C:\Users\s217161227\Desktop\AmeliorateNew\AmeliorateAegis\Areas\Teacher\Views\Attendance\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script type=""text/javascript"">
    function UpdateAttendance(elem) {
    var attended = $(elem).is(':checked');
    var data = $(elem).data('pupil');
        console.log(attended)
    $.ajax({
        type: 'POST',
        url: '");
#nullable restore
#line 73 "C:\Users\s217161227\Desktop\AmeliorateNew\AmeliorateAegis\Areas\Teacher\Views\Attendance\Index.cshtml"
         Write(Url.Action("UpdateAttendance", "Attendance", new { Area = "Teacher" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n        data: { isChecked: attended, pupilId:data },\r\n        success: function(res) {\r\n            //console.log(res);\r\n        }\r\n    });\r\n}\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AmeliorateAegis.Models.ViewModels.PupilAttendanceViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
