#pragma checksum "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\Admin\Views\Roles\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d529ac3687d7dd40585bb2083be1c72a198232c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Roles_Add), @"mvc.1.0.view", @"/Areas/Admin/Views/Roles/Add.cshtml")]
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
#line 1 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\Admin\Views\_ViewImports.cshtml"
using EndPoint.Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\Admin\Views\_ViewImports.cshtml"
using EndPoint.Site.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d529ac3687d7dd40585bb2083be1c72a198232c9", @"/Areas/Admin/Views/Roles/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87685c89e84078b3e134b89a928accf3d0f04a39", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Roles_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelAbshar.Domain.Entities.User.Role>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("roleTitle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("نام نقش"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Username"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-describedby", new global::Microsoft.AspNetCore.Html.HtmlString("basic-addon1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formAddRole"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\Admin\Views\Roles\Add.cshtml"
  
    ViewData["Title"] = "Add";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    List<HotelAbshar.Domain.Entities.Permission.Permission> permissions = ViewBag.permissions;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""basic-input-group"">
    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""card"">
                <div class=""card-header"">
                    <div class=""card-title-wrap bar-success"">
                        <h4 class=""card-title"">اضافه کردن نقش</h4>
                    </div>
                </div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d529ac3687d7dd40585bb2083be1c72a198232c97139", async() => {
                WriteLiteral(@"
                    <div class=""card-body"">
                        <div class=""card-block"">
                            <div class=""input-group"">
                                <div class=""input-group-prepend"">
                                    <span class=""input-group-text"" id=""basic-addon1""></span>
                                </div>
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d529ac3687d7dd40585bb2083be1c72a198232c97791", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 24 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\Admin\Views\Roles\Add.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RoleTitle);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                            </div>\r\n                            <br>");
#nullable restore
#line 27 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\Admin\Views\Roles\Add.cshtml"
                                    if (ViewBag.ExistRoleTitle == true)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <p class=\"text text-danger\">نام نقش تکراری می باشد</p>\r\n");
#nullable restore
#line 30 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\Admin\Views\Roles\Add.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\Admin\Views\Roles\Add.cshtml"
                              if (ViewBag.NoIsValid == true)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"alert alert-danger\">اطلاعات صحیح یا کامل نیست</div>\r\n");
#nullable restore
#line 33 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\Admin\Views\Roles\Add.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <input type=\"submit\" value=\"اضافه کن\" class=\"btn btn-success\" />\r\n                        </div>\r\n                    </div>\r\n                    <h3>دسترسی ها</h3>\r\n                    <ul>\r\n");
#nullable restore
#line 39 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\Admin\Views\Roles\Add.cshtml"
                         foreach (var item in permissions.Where(p => p.ParentID == null))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li>\r\n                                <input type=\"checkbox\" name=\"selectedPermissions\"");
                BeginWriteAttribute("value", " value=\"", 2107, "\"", 2133, 1);
#nullable restore
#line 42 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\Admin\Views\Roles\Add.cshtml"
WriteAttributeValue("", 2115, item.PermissionID, 2115, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> ");
#nullable restore
#line 42 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\Admin\Views\Roles\Add.cshtml"
                                                                                                           Write(item.PermissionTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                <ul>\r\n");
#nullable restore
#line 45 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\Admin\Views\Roles\Add.cshtml"
                                     foreach (var sub in permissions.Where(p => p.ParentID == item.PermissionID))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <li>\r\n                                            <input type=\"checkbox\" name=\"selectedPermissions\"");
                BeginWriteAttribute("value", " value=\"", 2494, "\"", 2519, 1);
#nullable restore
#line 48 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\Admin\Views\Roles\Add.cshtml"
WriteAttributeValue("", 2502, sub.PermissionID, 2502, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> ");
#nullable restore
#line 48 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\Admin\Views\Roles\Add.cshtml"
                                                                                                                      Write(sub.PermissionTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            <ul>\r\n");
#nullable restore
#line 50 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\Admin\Views\Roles\Add.cshtml"
                                                 foreach (var sub2 in permissions.Where(p => p.ParentID == sub.PermissionID))
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <li>\r\n                                                        <input type=\"checkbox\" name=\"selectedPermissions\"");
                BeginWriteAttribute("value", " value=\"", 2937, "\"", 2963, 1);
#nullable restore
#line 53 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\Admin\Views\Roles\Add.cshtml"
WriteAttributeValue("", 2945, sub2.PermissionID, 2945, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />");
#nullable restore
#line 53 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\Admin\Views\Roles\Add.cshtml"
                                                                                                                                  Write(sub2.PermissionTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                    </li>\r\n");
#nullable restore
#line 55 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\Admin\Views\Roles\Add.cshtml"
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </ul>\r\n                                        </li>\r\n");
#nullable restore
#line 59 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\Admin\Views\Roles\Add.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </ul>\r\n\r\n                            </li>\r\n");
#nullable restore
#line 63 "D:\Abshar\HotelAbshar\EndPoint.Site\Areas\Admin\Views\Roles\Add.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </ul>\r\n\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
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
    </div>

</section>
<script>
    const formAddRole = document.querySelector('#formAddRole');
    formAddRole.addEventListener('submit', event => {
        let roleTitle = document.getElementById('roleTitle').value;



        if (roleTitle == """") {
            alert(""لطفا تمامی موارد را وارد کنید"");
            event.preventDefault();
        }

        // actual logic, e.g. validate the form
        console.log('Form submission cancelled.');
    });

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HotelAbshar.Domain.Entities.User.Role> Html { get; private set; }
    }
}
#pragma warning restore 1591