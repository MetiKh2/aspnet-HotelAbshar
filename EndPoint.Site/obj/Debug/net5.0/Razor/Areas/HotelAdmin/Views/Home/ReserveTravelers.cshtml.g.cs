#pragma checksum "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\HotelAdmin\Views\Home\ReserveTravelers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0d1884b4b1a9b863b53c71e563f45fb8a721931"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HotelAdmin_Views_Home_ReserveTravelers), @"mvc.1.0.view", @"/Areas/HotelAdmin/Views/Home/ReserveTravelers.cshtml")]
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
#line 1 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\HotelAdmin\Views\_ViewImports.cshtml"
using EndPoint.Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\HotelAdmin\Views\_ViewImports.cshtml"
using EndPoint.Site.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\HotelAdmin\Views\Home\ReserveTravelers.cshtml"
using HotelAbshar.Common.Convertors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d1884b4b1a9b863b53c71e563f45fb8a721931", @"/Areas/HotelAdmin/Views/Home/ReserveTravelers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87685c89e84078b3e134b89a928accf3d0f04a39", @"/Areas/HotelAdmin/Views/_ViewImports.cshtml")]
    public class Areas_HotelAdmin_Views_Home_ReserveTravelers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List< HotelAbshar.Domain.Entities.Reservation.travelerReservation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\HotelAdmin\Views\Home\ReserveTravelers.cshtml"
  
    ViewData["Title"] = "ReserveTravelers";
    Layout = "~/Areas/HotelAdmin/Views/Shared/_AdminHotelLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<h1>مسافران</h1>
<section id=""extended"">
    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""card"">
                <div class=""card-header"">
                    <div class=""card-title-wrap bar-success"">
                        <h4 class=""card-title"">  رزرو ها</h4>
                        <a class=""btn btn-primary""");
            BeginWriteAttribute("href", " href=\"", 593, "\"", 639, 2);
            WriteAttributeValue("", 600, "/HotelAdmin/Home/Index/", 600, 23, true);
#nullable restore
#line 17 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\HotelAdmin\Views\Home\ReserveTravelers.cshtml"
WriteAttributeValue("", 623, ViewBag.HotelID, 623, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">صفحه اصلی</a>\r\n                        <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 706, "\"", 779, 2);
            WriteAttributeValue("", 713, "/HotelAdmin/Home/AddTraveler/", 713, 29, true);
#nullable restore
#line 18 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\HotelAdmin\Views\Home\ReserveTravelers.cshtml"
WriteAttributeValue("", 742, Model.FirstOrDefault().ReservationID, 742, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">افزودن مسافر </a>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""card-block"">
                        <table class=""table table-responsive-md text-center"">
                            <thead>
                                <tr>


                                    <th>نام مسافر </th>
                                    <th>نام خانوادگی مسافر </th>
                                    <th>جنسیت  </th>
                                    <th>شماره ملی</th>
                              
                                    <th>اقدامات </th>
                                </tr>
                            </thead>
                            <tbody>

");
#nullable restore
#line 38 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\HotelAdmin\Views\Home\ReserveTravelers.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n\r\n                                        <td>");
#nullable restore
#line 42 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\HotelAdmin\Views\Home\ReserveTravelers.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 43 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\HotelAdmin\Views\Home\ReserveTravelers.cshtml"
                                       Write(item.Family);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 44 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\HotelAdmin\Views\Home\ReserveTravelers.cshtml"
                                       Write(item.Sex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 45 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\HotelAdmin\Views\Home\ReserveTravelers.cshtml"
                                       Write(item.NationalID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                   \r\n                                  \r\n                                        <td>\r\n                                            <a class=\"success p-0\" data-original-title=\"\"");
            BeginWriteAttribute("title", " title=\"", 2133, "\"", 2141, 0);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 2142, "\"", 2232, 4);
            WriteAttributeValue("", 2149, "/HotelAdmin/Home/EditTraveler/", 2149, 30, true);
#nullable restore
#line 49 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\HotelAdmin\Views\Home\ReserveTravelers.cshtml"
WriteAttributeValue("", 2179, item.UserReservationID, 2179, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2202, "?ReserveID=", 2202, 11, true);
#nullable restore
#line 49 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\HotelAdmin\Views\Home\ReserveTravelers.cshtml"
WriteAttributeValue("", 2213, item.ReservationID, 2213, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <i class=\"fa fa-pencil font-medium-3 mr-2\"></i>\r\n                                            </a>\r\n");
            WriteLiteral("                                            <a class=\"danger p-0\" data-original-title=\"\"");
            BeginWriteAttribute("title", " title=\"", 2787, "\"", 2795, 0);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2796, "\"", 2845, 3);
            WriteAttributeValue("", 2806, "DeleteTraveler(", 2806, 15, true);
#nullable restore
#line 55 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\HotelAdmin\Views\Home\ReserveTravelers.cshtml"
WriteAttributeValue("", 2821, item.UserReservationID, 2821, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2844, ")", 2844, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <i class=\"fa fa-trash-o font-medium-3 mr-2\"></i>\r\n                                            </a>\r\n\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 61 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\HotelAdmin\Views\Home\ReserveTravelers.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<script type=""text/javascript"">
    function DeleteTraveler (id) {


        $.ajax({
            type: ""POST"",
            url: """);
#nullable restore
#line 78 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\HotelAdmin\Views\Home\ReserveTravelers.cshtml"
             Write(Url.Action("DeleteTraveler"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            data: { TravelerID: id },
            dataType: ""text"",
            success: function (msg) {
                console.log(msg);

            },
            error: function (req, status, error) {
                console.log(msg);
            }
        }).then(function (isConfirm) {
            location.reload();
        });
    };
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List< HotelAbshar.Domain.Entities.Reservation.travelerReservation>> Html { get; private set; }
    }
}
#pragma warning restore 1591