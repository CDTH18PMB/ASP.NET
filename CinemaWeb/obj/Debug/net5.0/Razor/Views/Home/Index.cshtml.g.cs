#pragma checksum "E:\ASP.NET\CinemaWeb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26f350a4f55b0ca27b87807e92b9c7040539d14f"
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
#line 1 "E:\ASP.NET\CinemaWeb\Views\_ViewImports.cshtml"
using CinemaWeb.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ASP.NET\CinemaWeb\Views\_ViewImports.cshtml"
using CinemaWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ASP.NET\CinemaWeb\Views\_ViewImports.cshtml"
using CinemaWeb.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26f350a4f55b0ca27b87807e92b9c7040539d14f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51e646528bc322c2b10fbb346d6a88b244cbf390", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CinemaWeb.Areas.Admin.Models.PhimModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:220px;height:300px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Poster"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("title-gd"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn watch-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""w3l-main-slider position-relative"" id=""home"">
    <div class=""companies20-content"">
        <div class=""owl-one owl-carousel owl-theme"">
            <div class=""item"">
                <li>
                    <div class=""slider-info banner-view bg bg2"">
                        <div class=""banner-info"">
                            <h3>Latest Movie Trailers</h3>
                            <p>
                                Lorem ipsum dolor sit amet consectetur adipisicing elit.<span class=""over-para"">
                                    Consequuntur hic odio
                                    voluptatem tenetur consequatur.
                                </span>
                            </p>
                            <a href=""#small-dialog1"" class=""popup-with-zoom-anim play-view1"">
                                <span class=""video-play-icon"">
                                    <span class=""fa fa-play""></span>
                                </span>
               ");
            WriteLiteral(@"                 <h6>Watch Trailer</h6>
                            </a>
                            <!-- dialog itself, mfp-hide class is required to make dialog hidden -->
                            <div id=""small-dialog1"" class=""zoom-anim-dialog mfp-hide"">
                                <iframe src=""https://player.vimeo.com/video/358205676"" allow=""autoplay; fullscreen""");
            BeginWriteAttribute("allowfullscreen", "\r\n                                        allowfullscreen=\"", 1464, "\"", 1523, 0);
            EndWriteAttribute();
            WriteLiteral(@"></iframe>
                            </div>
                        </div>
                    </div>
                </li>
            </div>
            <div class=""item"">
                <li>
                    <div class=""slider-info  banner-view banner-top1 bg bg2"">
                        <div class=""banner-info"">
                            <h3>Latest Online Movies</h3>
                            <p>
                                Lorem ipsum dolor sit amet consectetur adipisicing elit.<span class=""over-para"">
                                    Consequuntur hic odio
                                    voluptatem tenetur consequatur.
                                </span>
                            </p>
                            <a href=""#small-dialog2"" class=""popup-with-zoom-anim play-view1"">
                                <span class=""video-play-icon"">
                                    <span class=""fa fa-play""></span>
                                </span>
          ");
            WriteLiteral(@"                      <h6>Watch Trailer</h6>
                            </a>
                            <!-- dialog itself, mfp-hide class is required to make dialog hidden -->
                            <div id=""small-dialog2"" class=""zoom-anim-dialog mfp-hide"">
                                <iframe src=""https://player.vimeo.com/video/395376850"" allow=""autoplay; fullscreen""");
            BeginWriteAttribute("allowfullscreen", "\r\n                                        allowfullscreen=\"", 2933, "\"", 2992, 0);
            EndWriteAttribute();
            WriteLiteral(@"></iframe>
                            </div>
                        </div>
                    </div>
                </li>
            </div>
            <div class=""item"">
                <li>
                    <div class=""slider-info banner-view banner-top2 bg bg2"">
                        <div class=""banner-info"">
                            <h3>Latest Movie Trailers</h3>
                            <p>
                                Lorem ipsum dolor sit amet consectetur adipisicing elit.<span class=""over-para"">
                                    Consequuntur hic odio
                                    voluptatem tenetur consequatur.
                                </span>
                            </p>
                            <a href=""#small-dialog3"" class=""popup-with-zoom-anim play-view1"">
                                <span class=""video-play-icon"">
                                    <span class=""fa fa-play""></span>
                                </span>
          ");
            WriteLiteral(@"                      <h6>Watch Trailer</h6>
                            </a>
                            <!-- dialog itself, mfp-hide class is required to make dialog hidden -->
                            <div id=""small-dialog3"" class=""zoom-anim-dialog mfp-hide"">
                                <iframe src=""https://player.vimeo.com/video/389969665"" allow=""autoplay; fullscreen""");
            BeginWriteAttribute("allowfullscreen", "\r\n                                        allowfullscreen=\"", 4402, "\"", 4461, 0);
            EndWriteAttribute();
            WriteLiteral(@"></iframe>
                            </div>
                        </div>
                    </div>
                </li>
            </div>
            <div class=""item"">
                <li>
                    <div class=""slider-info banner-view banner-top3 bg bg2"">
                        <div class=""banner-info"">
                            <h3>Latest Online Movies</h3>
                            <p>
                                Lorem ipsum dolor sit amet consectetur adipisicing elit.<span class=""over-para"">
                                    Consequuntur hic odio
                                    voluptatem tenetur consequatur.
                                </span>
                            </p>
                            <a href=""#small-dialog4"" class=""popup-with-zoom-anim play-view1"">
                                <span class=""video-play-icon"">
                                    <span class=""fa fa-play""></span>
                                </span>
           ");
            WriteLiteral(@"                     <h6>Watch Trailer</h6>
                            </a>
                            <!-- dialog itself, mfp-hide class is required to make dialog hidden -->
                            <div id=""small-dialog4"" class=""zoom-anim-dialog mfp-hide"">
                                <iframe src=""https://player.vimeo.com/video/323491174"" allow=""autoplay; fullscreen""");
            BeginWriteAttribute("allowfullscreen", "\r\n                                        allowfullscreen=\"", 5870, "\"", 5929, 0);
            EndWriteAttribute();
            WriteLiteral(@"></iframe>
                            </div>
                        </div>
                    </div>
                </li>
            </div>
        </div>
    </div>
</section>

<!-- Tất cả phim -->
<section class=""w3l-grids"">
    <div class=""grids-main py-5"">
        <div class=""container py-lg-3"">
            <div class=""headerhny-title"">
                <div class=""w3l-title-grids"">
                    <div class=""headerhny-left"">
                        <h3 class=""hny-title"">New Releases</h3>
                    </div>
                </div>
            </div>
            <div class=""owl-three owl-carousel owl-theme"">
");
#nullable restore
#line 126 "E:\ASP.NET\CinemaWeb\Views\Home\Index.cshtml"
                  
                    foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"item vhny-grid\">\r\n                            <div class=\"box16 mb-0\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 6821, "\"", 6841, 1);
#nullable restore
#line 131 "E:\ASP.NET\CinemaWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 6828, item.Trailer, 6828, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">\r\n                                    <figure>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "26f350a4f55b0ca27b87807e92b9c7040539d14f13590", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7008, "~/user/images/poster/", 7008, 21, true);
#nullable restore
#line 133 "E:\ASP.NET\CinemaWeb\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 7029, item.Poster, 7029, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </figure>
                                    <div class=""box-content"">
                                        <h4>
                                            <span class=""post"">
                                                <span class=""fa fa-clock-o""> </span>");
#nullable restore
#line 138 "E:\ASP.NET\CinemaWeb\Views\Home\Index.cshtml"
                                                                               Write(item.ThoiLuong);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </span>

                                            <span class=""post fa fa-heart text-right""></span>
                                        </h4>
                                    </div>
                                    <span class=""fa fa-play video-icon"" aria-hidden=""true""></span>
                                </a>
                            </div>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26f350a4f55b0ca27b87807e92b9c7040539d14f16323", async() => {
#nullable restore
#line 147 "E:\ASP.NET\CinemaWeb\Views\Home\Index.cshtml"
                                                                                           Write(item.TenPhim);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 147 "E:\ASP.NET\CinemaWeb\Views\Home\Index.cshtml"
                                                                      WriteLiteral(item.MaPhim);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <div class=\"button-center text-center mt-4\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26f350a4f55b0ca27b87807e92b9c7040539d14f18866", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 149 "E:\ASP.NET\CinemaWeb\Views\Home\Index.cshtml"
                                                         WriteLiteral(item.MaPhim);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n\r\n                        </div>\r\n");
#nullable restore
#line 153 "E:\ASP.NET\CinemaWeb\Views\Home\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>

    </div>
</section>


<!--<section class=""w3l-albums py-5"" id=""projects"">
    <div class=""container py-lg-4"">
        <div class=""row"">
            <div class=""col-lg-12 mx-auto"">-->
<!--Horizontal Tab-->
<!--<div id=""parentHorizontalTab"">
    <ul class=""resp-tabs-list hor_1"">
        <li>Recent Movies</li>
        <li>Popular Movies</li>
        <div class=""clear""></div>
    </ul>
    <div class=""resp-tabs-container hor_1"">
        <div class=""albums-content"">
            <div class=""row"">-->
<!--/set1-->
<!--<div class=""col-lg-4 new-relise-gd mt-lg-0 mt-0"">
    <div class=""slider-info"">
        <div class=""img-circle"">
            <a href=""https://www.youtube.com/embed/XRm1P7oGpMQ"">

                <img style=""width:160px;height:230px"" src=""~/user/images/Rom.jpg"" class=""img-fluid""
                     alt=""author image"">
                <div class=""overlay-icon"">

                    <span class=""fa fa-play video-icon"" aria-hidden=""true""><");
            WriteLiteral(@"/span>
                </div>
            </a>
        </div>
        <div class=""message"">
            <a class=""author-book-title"" asp-action=""Detail"">Ròm</a>
            <p>Trần Thanh Huy</p>
            <h4>
                <span class=""post"">
                    <span class=""fa fa-clock-o""> </span> 1 Hr 19min

                </span>

                <span class=""post fa fa-heart text-right""></span>
            </h4>
        </div>
    </div>

</div>
<div class=""col-lg-4 new-relise-gd mt-lg-0 mt-0"">
    <div class=""slider-info"">
        <div class=""img-circle"">
            <a href=""https://www.youtube.com/embed/PqNGHKLyPD0"">

                <img style=""width:160px;height:230px"" src=""~/user/images/TiecTrangMau.jpg"" class=""img-fluid""
                     alt=""author image"">
                <div class=""overlay-icon"">

                    <span class=""fa fa-play video-icon"" aria-hidden=""true""></span>
                </div>
            </a>
        </div>
        <div class=""m");
            WriteLiteral(@"essage"">
            <a class=""author-book-title"" asp-action=""Detail"">Tiệc trăng máu</a>
            <p>Nguyễn Quang Dũng</p>
            <h4>
                <span class=""post"">
                    <span class=""fa fa-clock-o""> </span> 1 Hr 32min

                </span>

                <span class=""post fa fa-heart text-right""></span>
            </h4>
        </div>
    </div>

</div>
<div class=""col-lg-4 new-relise-gd mt-lg-0 mt-0"">
    <div class=""slider-info"">
        <div class=""img-circle"">
            <a href=""https://www.youtube.com/embed/WvOgvFtcIAw"">

                <img style=""width:160px;height:230px"" src=""~/user/images/TheCroods2.jpg"" class=""img-fluid""
                     alt=""author image"">
                <div class=""overlay-icon"">

                    <span class=""fa fa-play video-icon"" aria-hidden=""true""></span>
                </div>
            </a>
        </div>
        <div class=""message"">
            <a class=""author-book-title"" asp-action=""Detail"">THE ");
            WriteLiteral(@"CROODS 2</a>
            <p>Joel Crawford</p>
            <h4>
                <span class=""post"">
                    <span class=""fa fa-clock-o""> </span> 1 Hr 36min

                </span>

                <span class=""post fa fa-heart text-right""></span>
            </h4>
        </div>
    </div>

</div>-->
<!--//set1-->
<!--/set1-->
<!--<div class=""col-lg-4 new-relise-gd mt-lg-0 mt-0"">
    <div class=""slider-info"">
        <div class=""img-circle"">
            <a href=""https://www.youtube.com/embed/XRm1P7oGpMQ"">

                <img style=""width:160px;height:230px"" src=""~/user/images/BanDaoPeninsula.jpg"" class=""img-fluid""
                     alt=""author image"">
                <div class=""overlay-icon"">

                    <span class=""fa fa-play video-icon"" aria-hidden=""true""></span>
                </div>
            </a>
        </div>
        <div class=""message"">
            <a class=""author-book-title"" asp-action=""Detail"">Bán đảo Peninsula</a>
            <p>Yeon S");
            WriteLiteral(@"ang Ho</p>
            <h4>
                <span class=""post"">
                    <span class=""fa fa-clock-o""> </span> 1 Hr 56min

                </span>

                <span class=""post fa fa-heart text-right""></span>
            </h4>
        </div>
    </div>

</div>
<div class=""col-lg-4 new-relise-gd mt-lg-0 mt-0"">
    <div class=""slider-info"">
        <div class=""img-circle"">
            <a href=""https://www.youtube.com/embed/o1LlKT1fNPA"">

                <img style=""width:160px;height:230px"" src=""~/user/images/BiMatCuaGio.jpg"" class=""img-fluid""
                     alt=""author image"">
                <div class=""overlay-icon"">

                    <span class=""fa fa-play video-icon"" aria-hidden=""true""></span>
                </div>
            </a>
        </div>
        <div class=""message"">
            <a class=""author-book-title"" asp-action=""Detail"">Bí Mật Của Gió</a>
            <p>Nguyễn Phan Quang Bình</p>
            <h4>
                <span class=""post"">
  ");
            WriteLiteral(@"                  <span class=""fa fa-clock-o""> </span> 1 Hr 54min

                </span>

                <span class=""post fa fa-heart text-right""></span>
            </h4>
        </div>
    </div>

</div>
<div class=""col-lg-4 new-relise-gd mt-lg-0 mt-0"">
    <div class=""slider-info"">
        <div class=""img-circle"">
            <a href=""https://www.youtube.com/embed/Ny5X2qtIyTw"">

                <img style=""width:160px;height:230px"" src=""~/user/images/MaiBenEm-Endless.jpg"" class=""img-fluid""
                     alt=""author image"">
                <div class=""overlay-icon"">

                    <span class=""fa fa-play video-icon"" aria-hidden=""true""></span>
                </div>
            </a>
        </div>
        <div class=""message"">
            <a class=""author-book-title"" asp-action=""Detail"">Mãi Bên Em -  Endless</a>
            <p>Scott Speer</p>
            <h4>
                <span class=""post"">
                    <span class=""fa fa-clock-o""> </span> 1 Hr 19min
");
            WriteLiteral(@"
                </span>

                <span class=""post fa fa-heart text-right""></span>
            </h4>
        </div>
    </div>

</div>-->
<!--//set1-->
<!--/set1-->
<!--<div class=""col-lg-4 new-relise-gd mt-lg-0 mt-0"">
    <div class=""slider-info"">
        <div class=""img-circle"">
            <a href=""https://www.youtube.com/embed/jiHzd87NpNM"">

                <img style=""width:160px;height:230px"" src=""~/user/images/DiepVienSieuLay.jpg"" class=""img-fluid""
                     alt=""author image"">
                <div class=""overlay-icon"">

                    <span class=""fa fa-play video-icon"" aria-hidden=""true""></span>
                </div>
            </a>
        </div>
        <div class=""message"">
            <a class=""author-book-title"" asp-action=""Detail"">Điệp Viên Siêu Lầy</a>
            <p>Peter Segal</p>
            <h4>
                <span class=""post"">
                    <span class=""fa fa-clock-o""> </span> 1 Hr 19min

                </span>

        ");
            WriteLiteral(@"        <span class=""post fa fa-heart text-right""></span>
            </h4>
        </div>
    </div>

</div>
<div class=""col-lg-4 new-relise-gd mt-lg-0 mt-0"">
    <div class=""slider-info"">
        <div class=""img-circle"">
            <a href=""https://www.youtube.com/embed/XRm1P7oGpMQ"">

                <img style=""width:160px;height:230px"" src=""~/user/images/TraiTimQuaiVat.jpg"" class=""img-fluid""
                     alt=""author image"">
                <div class=""overlay-icon"">

                    <span class=""fa fa-play video-icon"" aria-hidden=""true""></span>
                </div>
            </a>
        </div>
        <div class=""message"">
            <a class=""author-book-title"" asp-action=""Detail"">Trái Tim Quái Vật</a>
            <p>Tạ Nguyên Hiệp</p>
            <h4>
                <span class=""post"">
                    <span class=""fa fa-clock-o""> </span> 1 Hr 29min

                </span>

                <span class=""post fa fa-heart text-right""></span>
            ");
            WriteLiteral(@"</h4>
        </div>
    </div>

</div>
<div class=""col-lg-4 new-relise-gd mt-lg-0 mt-0"">
    <div class=""slider-info"">
        <div class=""img-circle"">
            <a href=""https://www.youtube.com/embed/XRm1P7oGpMQ"">

                <img style=""width:160px;height:230px"" src=""~/user/images/VioletVergarden.jpg"" class=""img-fluid""
                     alt=""author image"">
                <div class=""overlay-icon"">

                    <span class=""fa fa-play video-icon"" aria-hidden=""true""></span>
                </div>
            </a>
        </div>
        <div class=""message"">
            <a class=""author-book-title"" asp-action=""Detail"">Violet Evergarden</a>
            <p>Fujita Haruka</p>
            <h4>
                <span class=""post"">
                    <span class=""fa fa-clock-o""> </span> 2 Hr

                </span>

                <span class=""post fa fa-heart text-right""></span>
            </h4>
        </div>
    </div>

</div>-->
<!--//set1-->
<!--</div>
</");
            WriteLiteral(@"div>
<div class=""albums-content"">
    <div class=""row"">-->
<!--/set1-->
<!--<div class=""col-lg-4 new-relise-gd mt-lg-0 mt-0"">
    <div class=""slider-info"">
        <div class=""img-circle"">
            <a href=""https://www.youtube.com/embed/XRm1P7oGpMQ"">

                <img style=""width:160px;height:230px"" src=""~/user/images/Rom.jpg"" class=""img-fluid""
                     alt=""author image"">
                <div class=""overlay-icon"">

                    <span class=""fa fa-play video-icon"" aria-hidden=""true""></span>
                </div>
            </a>
        </div>
        <div class=""message"">
            <a class=""author-book-title"" asp-action=""Detail"">Ròm</a>
            <p>Trần Thanh Huy</p>
            <h4>
                <span class=""post"">
                    <span class=""fa fa-clock-o""> </span> 1 Hr 19min

                </span>

                <span class=""post fa fa-heart text-right""></span>
            </h4>
        </div>
    </div>

</div>
<div class=""col-");
            WriteLiteral(@"lg-4 new-relise-gd mt-lg-0 mt-0"">
    <div class=""slider-info"">
        <div class=""img-circle"">
            <a href=""https://www.youtube.com/embed/PqNGHKLyPD0"">

                <img style=""width:160px;height:230px"" src=""~/user/images/TiecTrangMau.jpg"" class=""img-fluid""
                     alt=""author image"">
                <div class=""overlay-icon"">

                    <span class=""fa fa-play video-icon"" aria-hidden=""true""></span>
                </div>
            </a>
        </div>
        <div class=""message"">
            <a class=""author-book-title"" asp-action=""Detail"">Tiệc trăng máu</a>
            <p>Nguyễn Quang Dũng</p>
            <h4>
                <span class=""post"">
                    <span class=""fa fa-clock-o""> </span> 1 Hr 32min

                </span>

                <span class=""post fa fa-heart text-right""></span>
            </h4>
        </div>
    </div>

</div>-->
<!--//set1-->
<!--/set1-->
<!--<div class=""col-lg-4 new-relise-gd mt-lg-0 mt-0"">
  ");
            WriteLiteral(@"  <div class=""slider-info"">
        <div class=""img-circle"">
            <a href=""https://www.youtube.com/embed/XRm1P7oGpMQ"">

                <img style=""width:160px;height:230px"" src=""~/user/images/BanDaoPeninsula.jpg"" class=""img-fluid""
                     alt=""author image"">
                <div class=""overlay-icon"">

                    <span class=""fa fa-play video-icon"" aria-hidden=""true""></span>
                </div>
            </a>
        </div>
        <div class=""message"">
            <a class=""author-book-title"" asp-action=""Detail"">Bán đảo Peninsula</a>
            <p>Yeon Sang Ho</p>
            <h4>
                <span class=""post"">
                    <span class=""fa fa-clock-o""> </span> 1 Hr 56min

                </span>

                <span class=""post fa fa-heart text-right""></span>
            </h4>
        </div>
    </div>

</div>
<div class=""col-lg-4 new-relise-gd mt-lg-0 mt-0"">
    <div class=""slider-info"">
        <div class=""img-circle"">
         ");
            WriteLiteral(@"   <a href=""https://www.youtube.com/embed/o1LlKT1fNPA"">

                <img style=""width:160px;height:230px"" src=""~/user/images/BiMatCuaGio.jpg"" class=""img-fluid""
                     alt=""author image"">
                <div class=""overlay-icon"">

                    <span class=""fa fa-play video-icon"" aria-hidden=""true""></span>
                </div>
            </a>
        </div>
        <div class=""message"">
            <a class=""author-book-title"" asp-action=""Detail"">Bí Mật Của Gió</a>
            <p>Nguyễn Phan Quang Bình</p>
            <h4>
                <span class=""post"">
                    <span class=""fa fa-clock-o""> </span> 1 Hr 54min

                </span>

                <span class=""post fa fa-heart text-right""></span>
            </h4>
        </div>
    </div>

</div>-->
<!--//set1-->
<!--/set1-->
<!--<div class=""col-lg-4 new-relise-gd mt-lg-0 mt-0"">
            <div class=""slider-info"">
                <div class=""img-circle"">
                    <a hre");
            WriteLiteral(@"f=""https://www.youtube.com/embed/jiHzd87NpNM"">

                        <img style=""width:160px;height:230px"" src=""~/user/images/DiepVienSieuLay.jpg"" class=""img-fluid""
                             alt=""author image"">
                        <div class=""overlay-icon"">

                            <span class=""fa fa-play video-icon"" aria-hidden=""true""></span>
                        </div>
                    </a>
                </div>
                <div class=""message"">
                    <a class=""author-book-title"" asp-action=""Detail"">Điệp Viên Siêu Lầy</a>
                    <p>Peter Segal</p>
                    <h4>
                        <span class=""post"">
                            <span class=""fa fa-clock-o""> </span> 1 Hr 19min

                        </span>

                        <span class=""post fa fa-heart text-right""></span>
                    </h4>
                </div>
            </div>

        </div>
        <div class=""col-lg-4 new-relise-gd mt-lg-0 mt-");
            WriteLiteral(@"0"">
            <div class=""slider-info"">
                <div class=""img-circle"">
                    <a href=""https://www.youtube.com/embed/XRm1P7oGpMQ"">

                        <img style=""width:160px;height:230px"" src=""~/user/images/TraiTimQuaiVat.jpg"" class=""img-fluid""
                             alt=""author image"">
                        <div class=""overlay-icon"">

                            <span class=""fa fa-play video-icon"" aria-hidden=""true""></span>
                        </div>
                    </a>
                </div>
                <div class=""message"">
                    <a class=""author-book-title"" asp-action=""Detail"">Trái Tim Quái Vật</a>
                    <p>Tạ Nguyên Hiệp</p>
                    <h4>
                        <span class=""post"">
                            <span class=""fa fa-clock-o""> </span> 1 Hr 29min

                        </span>

                        <span class=""post fa fa-heart text-right""></span>
                    </h4>
   ");
            WriteLiteral("             </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>-->\r\n<!--//set3-->\r\n<!--</div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    </div>\r\n    </div>\r\n</section>-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CinemaWeb.Areas.Admin.Models.PhimModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
