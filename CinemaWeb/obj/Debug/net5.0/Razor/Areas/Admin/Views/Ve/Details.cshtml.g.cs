#pragma checksum "E:\ASP.NET\CinemaWeb\Areas\Admin\Views\Ve\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10464aff6e9698fe4870c2df63a14d2167586cd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Ve_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Ve/Details.cshtml")]
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
#line 1 "E:\ASP.NET\CinemaWeb\Areas\Admin\Views\_ViewImports.cshtml"
using CinemaWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ASP.NET\CinemaWeb\Areas\Admin\Views\_ViewImports.cshtml"
using CinemaWeb.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ASP.NET\CinemaWeb\Areas\Admin\Views\_ViewImports.cshtml"
using CinemaWeb.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10464aff6e9698fe4870c2df63a14d2167586cd1", @"/Areas/Admin/Views/Ve/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34be26e1a44e7baae44a32827faa3b382622299f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Ve_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CinemaWeb.Areas.Admin.Models.VeModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\ASP.NET\CinemaWeb\Areas\Admin\Views\Ve\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-4\">\r\n            Mã\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 13 "E:\ASP.NET\CinemaWeb\Areas\Admin\Views\Ve\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaVe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            Phim\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 19 "E:\ASP.NET\CinemaWeb\Areas\Admin\Views\Ve\Details.cshtml"
       Write(Html.DisplayFor(model => model.maphim.TenPhim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            Phòng\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 25 "E:\ASP.NET\CinemaWeb\Areas\Admin\Views\Ve\Details.cshtml"
       Write(Html.DisplayFor(model => model.Phong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            Ghế\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 31 "E:\ASP.NET\CinemaWeb\Areas\Admin\Views\Ve\Details.cshtml"
       Write(Html.DisplayFor(model => model.maghe.TenGhe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            Thời gian\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 37 "E:\ASP.NET\CinemaWeb\Areas\Admin\Views\Ve\Details.cshtml"
       Write(Html.DisplayFor(model => model.suatchieu.ThoiGian));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n            ");
#nullable restore
#line 38 "E:\ASP.NET\CinemaWeb\Areas\Admin\Views\Ve\Details.cshtml"
       Write(Html.DisplayFor(model => model.suatchieu.NgayChieu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            Người mua\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 44 "E:\ASP.NET\CinemaWeb\Areas\Admin\Views\Ve\Details.cshtml"
       Write(Html.DisplayFor(model => model.nguoimua.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            Ngày mua\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 50 "E:\ASP.NET\CinemaWeb\Areas\Admin\Views\Ve\Details.cshtml"
       Write(Html.DisplayFor(model => model.NgayMua));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            Giá\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 56 "E:\ASP.NET\CinemaWeb\Areas\Admin\Views\Ve\Details.cshtml"
       Write(Html.DisplayFor(model => model.GiaVe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CinemaWeb.Areas.Admin.Models.VeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
