#pragma checksum "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\PhongChieu\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b01c0d572892b76ffeed01a6e98261cc27b95892"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_PhongChieu_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/PhongChieu/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b01c0d572892b76ffeed01a6e98261cc27b95892", @"/Areas/Admin/Views/PhongChieu/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6acd418d1fcbb9053dd419167b49318627aec40", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_PhongChieu_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CinemaWeb.Areas.Admin.Models.PhongChieuModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\PhongChieu\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 10 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\PhongChieu\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaPhong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 13 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\PhongChieu\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaPhong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 16 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\PhongChieu\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SoGhe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 19 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\PhongChieu\Details.cshtml"
       Write(Html.DisplayFor(model => model.SoGhe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 22 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\PhongChieu\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TrangThai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 25 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\PhongChieu\Details.cshtml"
       Write(Html.DisplayFor(model => model.TrangThai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 796, "\"", 923, 6);
            WriteAttributeValue("", 806, "showModal(\'", 806, 11, true);
#nullable restore
#line 30 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\PhongChieu\Details.cshtml"
WriteAttributeValue("", 817, Url.Action("AddOrEdit","PhongChieu",new {id = Model.MaPhong},Context.Request.Scheme), 817, 85, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 902, "\',", 902, 2, true);
            WriteAttributeValue(" ", 904, "\'Sửa", 905, 5, true);
            WriteAttributeValue(" ", 909, "Phòng", 910, 6, true);
            WriteAttributeValue(" ", 915, "Chiếu\')", 916, 8, true);
            EndWriteAttribute();
            WriteLiteral("\r\n            class=\"btn btn-outline-warning\">Edit</button>\r\n    <button class=\"btn btn-outline-secondary\" data-dismiss=\"modal\">Back to List</button>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CinemaWeb.Areas.Admin.Models.PhongChieuModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
