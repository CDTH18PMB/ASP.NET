#pragma checksum "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\LichChieu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e8b79860d31711ddd0217375f889832fceb2341"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_LichChieu_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/LichChieu/Index.cshtml")]
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
using CinemaWeb.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\_ViewImports.cshtml"
using CinemaWeb.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e8b79860d31711ddd0217375f889832fceb2341", @"/Areas/Admin/Views/LichChieu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34be26e1a44e7baae44a32827faa3b382622299f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_LichChieu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CinemaWeb.Areas.Admin.Models.LichChieuModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddOrEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "false", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "true", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\LichChieu\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--Tiêu đề-->\r\n<div class=\"card text-center\">\r\n    <div class=\"card-header\">\r\n        <h2>Quản lý lịch chiếu phim</h2>\r\n    </div>\r\n</div>\r\n<!--Hết tiêu đề-->\r\n<!--Thông báo-->\r\n");
#nullable restore
#line 14 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\LichChieu\Index.cshtml"
  
    if (TempData["Message"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"msg\" class=\"card text-center\">\r\n            <div class=\"card-header\">\r\n                <h4>");
#nullable restore
#line 19 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\LichChieu\Index.cshtml"
               Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 22 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\LichChieu\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--Hết thông báo-->\r\n<div class=\"card text-center\">\r\n    <div class=\"card-header\">\r\n        <!--Button thêm, form tìm kiếm-->\r\n        <div class=\'row\'>\r\n            <div class=\"col-md-4\">\r\n                <div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e8b79860d31711ddd0217375f889832fceb23418051", async() => {
                WriteLiteral("Tạo mới");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-8\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e8b79860d31711ddd0217375f889832fceb23419394", async() => {
                WriteLiteral("\r\n                    <div class=\"input-group\">\r\n                        <input type=\"text\" name=\"SearchString\"");
                BeginWriteAttribute("value", " value=\"", 1054, "\"", 1081, 1);
#nullable restore
#line 37 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\LichChieu\Index.cshtml"
WriteAttributeValue("", 1062, ViewData["Search"], 1062, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" placeholder=\'Nhập tên phim để tìm\' />\r\n                        <select class=\"form-select\" name=\"SearchStatus\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e8b79860d31711ddd0217375f889832fceb234110310", async() => {
                    WriteLiteral("Tất cả trạng thái");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e8b79860d31711ddd0217375f889832fceb234111896", async() => {
                    WriteLiteral("Kết thúc");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e8b79860d31711ddd0217375f889832fceb234113150", async() => {
                    WriteLiteral("Hoạt động");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </select>\r\n                        <input class=\"btn btn-outline-info\" type=\"submit\" value=\"Tìm kiếm\" />\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e8b79860d31711ddd0217375f889832fceb234114541", async() => {
                    WriteLiteral("X");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
        <!--Hết button thêm, form tìm kiếm-->
    </div>
    <div class=""card-body"">
        <!--Nội dung-->
        <table class=""table table-success table-striped"">
        <thead>
            <tr style='text-align:center'>
                <th>
                    Mã
                </th>
                <th>
                    Phim
                </th>
                <th>
                    Phòng
                </th>
                <th>
                    Ngày
                </th>
                <th>
                    Thời gian
                </th>
                <th>
                    Số ghế trống
                </th>
                <th>
                    Trạng thái
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 80 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\LichChieu\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr style=\'text-align:center\'>\r\n                    <td>\r\n                        ");
#nullable restore
#line 84 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\LichChieu\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MaLichChieu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 87 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\LichChieu\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.maphim.TenPhim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 90 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\LichChieu\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.maphong.MaPhong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 93 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\LichChieu\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NgayChieu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 96 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\LichChieu\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ThoiGian));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 99 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\LichChieu\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SoGheTrong));

#line default
#line hidden
#nullable disable
            WriteLiteral("/180\r\n                    </td>\r\n                    <td name=\"td_update_stt\" data-id=\"");
#nullable restore
#line 101 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\LichChieu\Index.cshtml"
                                                 Write(item.MaLichChieu);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n");
#nullable restore
#line 102 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\LichChieu\Index.cshtml"
                          
                            if (item.TrangThai == true)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            WriteLiteral("Hoạt động\r\n");
#nullable restore
#line 106 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\LichChieu\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            WriteLiteral("Kết thúc\r\n");
#nullable restore
#line 110 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\LichChieu\Index.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td style=\'text-align:left\'>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e8b79860d31711ddd0217375f889832fceb234121561", async() => {
                WriteLiteral("Chỉnh sửa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 114 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\LichChieu\Index.cshtml"
                                                    WriteLiteral(item.MaLichChieu);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <button class=\"btn btn-outline-warning\" name=\"btn_update_stt\" data-id=\"");
#nullable restore
#line 115 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\LichChieu\Index.cshtml"
                                                                                          Write(item.MaLichChieu);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-stt=\"");
#nullable restore
#line 115 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\LichChieu\Index.cshtml"
                                                                                                                        Write(item.TrangThai == true ?0:1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n");
#nullable restore
#line 116 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\LichChieu\Index.cshtml"
                              if (item.TrangThai == true)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            WriteLiteral("Huỷ\r\n");
#nullable restore
#line 119 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\LichChieu\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            WriteLiteral("Mở\r\n");
#nullable restore
#line 123 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\LichChieu\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </button>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 128 "D:\ASP.NET\CinemaWeb\Areas\Admin\Views\LichChieu\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <!--Hết nội dung-->\r\n</div>\r\n<div class=\"card-footer text-muted\">\r\n    Thiếu phân trang\r\n</div>\r\n</div>\r\n<!--Tập Lệnh-->\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $('button[name=btn_update_stt').click(function () {
            var id = $(this).attr('data-id');
            var soghe = $(this).attr('data-soghe');
            var stt = ($(this).attr('data-stt') == 0 ? false : true);
            $.ajax({
                method: ""POST"",
                url: ""../api/LichChieu_API/UpdateStatus/"",
                contentType: 'application/json; charset=UTF-8',
                data: JSON.stringify({ ""ma"": id, ""stt"": stt })
            })
                .done(function (msg) {
                    if (msg == '0') {
                        alert('Cập nhật thất bại');
                    }
                    else {
                        var r = JSON.parse(msg);
                        if (r.stt == 'True') {
                            $('button[name=btn_update_stt][data-id=' + r.id + ']').html('Huỷ');
                            $('button[name=btn_update_stt][data-id=' + r.id + ']').attr(""data-stt"", ""0"");
                            $('");
                WriteLiteral(@"td[name=td_update_stt][data-id=' + r.id + ']').html('Hoạt động');
                        }
                        else {
                            $('button[name=btn_update_stt][data-id=' + r.id + ']').html('Mở');
                            $('button[name=btn_update_stt][data-id=' + r.id + ']').attr(""data-stt"", ""1"");
                            $('td[name=td_update_stt][data-id=' + r.id + ']').html('Kết thúc');
                        }
                        alert('Cập nhật thành công');
                    }
                });
        })
    </script>
    <script>
        setTimeout(function () {
            $('#msg').fadeOut('slow');
        }, 3000);
    </script>
");
            }
            );
            WriteLiteral("<!--Hết tập Lệnh-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CinemaWeb.Areas.Admin.Models.LichChieuModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
