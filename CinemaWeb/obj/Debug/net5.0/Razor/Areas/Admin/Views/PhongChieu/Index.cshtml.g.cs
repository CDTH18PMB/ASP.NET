#pragma checksum "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\PhongChieu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f73b6b33ba6f90b04747aa139f3e34e6f1636a4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_PhongChieu_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/PhongChieu/Index.cshtml")]
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
#line 1 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\_ViewImports.cshtml"
using CinemaWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\_ViewImports.cshtml"
using CinemaWeb.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f73b6b33ba6f90b04747aa139f3e34e6f1636a4b", @"/Areas/Admin/Views/PhongChieu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6acd418d1fcbb9053dd419167b49318627aec40", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_PhongChieu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CinemaWeb.Areas.Admin.Models.PhongChieuModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\PhongChieu\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Phòng Chiếu</h1>\r\n\r\n<p>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <button");
            BeginWriteAttribute("onclick", " onclick=\"", 214, "\"", 321, 5);
            WriteAttributeValue("", 224, "showModal(\'", 224, 11, true);
#nullable restore
#line 12 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\PhongChieu\Index.cshtml"
WriteAttributeValue("", 235, Url.Action("AddOrEdit","PhongChieu",null,Context.Request.Scheme), 235, 65, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 300, "\',\'Thêm", 300, 7, true);
            WriteAttributeValue(" ", 307, "Phòng", 308, 6, true);
            WriteAttributeValue(" ", 313, "Chiếu\')", 314, 8, true);
            EndWriteAttribute();
            WriteLiteral(@" 
                    class=""btn btn-outline-primary"">Create New</button>
        </div>
        <div class=""col-md-8"">
            <input type=""search"" class=""form-control""  placeholder=""Nhập để tìm""/>
        </div>
    </div>
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 24 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\PhongChieu\Index.cshtml"
           Write(Html.DisplayNameFor(Model => Model.MaPhong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\PhongChieu\Index.cshtml"
           Write(Html.DisplayNameFor(Model => Model.SoGhe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\PhongChieu\Index.cshtml"
           Write(Html.DisplayNameFor(Model => Model.TrangThai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 36 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\PhongChieu\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\PhongChieu\Index.cshtml"
           Write(Html.DisplayFor(Model => item.MaPhong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\PhongChieu\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SoGhe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\PhongChieu\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TrangThai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1353, "\"", 1485, 7);
            WriteAttributeValue("", 1363, "showModal(\'", 1363, 11, true);
#nullable restore
#line 48 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\PhongChieu\Index.cshtml"
WriteAttributeValue("", 1374, Url.Action("Details", "PhongChieu", new {id = item.MaPhong },Context.Request.Scheme), 1374, 85, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1459, "\',", 1459, 2, true);
            WriteAttributeValue(" ", 1461, "\'Chi", 1462, 5, true);
            WriteAttributeValue(" ", 1466, "tiết", 1467, 5, true);
            WriteAttributeValue(" ", 1471, "phòng", 1472, 6, true);
            WriteAttributeValue(" ", 1477, "chiếu\')", 1478, 8, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                   class=\"btn btn-outline-info\">Details</button>\r\n                <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1577, "\"", 1703, 6);
            WriteAttributeValue("", 1587, "showModal(\'", 1587, 11, true);
#nullable restore
#line 50 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\PhongChieu\Index.cshtml"
WriteAttributeValue("", 1598, Url.Action("AddOrEdit","PhongChieu",new {id = item.MaPhong},Context.Request.Scheme), 1598, 84, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1682, "\',", 1682, 2, true);
            WriteAttributeValue(" ", 1684, "\'Sửa", 1685, 5, true);
            WriteAttributeValue(" ", 1689, "Phòng", 1690, 6, true);
            WriteAttributeValue(" ", 1695, "Chiếu\')", 1696, 8, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                        class=\"btn btn-outline-warning\">Edit</button>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f73b6b33ba6f90b04747aa139f3e34e6f1636a4b9628", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f73b6b33ba6f90b04747aa139f3e34e6f1636a4b9906", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 53 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\PhongChieu\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.MaPhong);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn-outline-danger\">Delete</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\PhongChieu\Index.cshtml"
                                            WriteLiteral(item.MaPhong);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 58 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\PhongChieu\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<div class=""modal"" tabindex=""-1"" id=""form-modal"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title""></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>
            <div class=""modal-body"">

            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CinemaWeb.Areas.Admin.Models.PhongChieuModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
