#pragma checksum "C:\Users\m_cel\Source\Repos\jeroen107\NGTI\NGTI\Views\Admin\Reservations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edd5bba76450dae8e79fcec7cb9dcdf29181ad40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Reservations), @"mvc.1.0.view", @"/Views/Admin/Reservations.cshtml")]
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
#line 1 "C:\Users\m_cel\Source\Repos\jeroen107\NGTI\NGTI\Views\_ViewImports.cshtml"
using NGTI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\m_cel\Source\Repos\jeroen107\NGTI\NGTI\Views\_ViewImports.cshtml"
using NGTI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edd5bba76450dae8e79fcec7cb9dcdf29181ad40", @"/Views/Admin/Reservations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7513e97e5fa2eb22e9aaec927e9e92d8f23c0bf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Reservations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NGTI.Models.ReservationsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/table.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditSolo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditGroup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\m_cel\Source\Repos\jeroen107\NGTI\NGTI\Views\Admin\Reservations.cshtml"
  
    ViewData["Title"] = "All Reservations";


#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edd5bba76450dae8e79fcec7cb9dcdf29181ad405115", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "edd5bba76450dae8e79fcec7cb9dcdf29181ad405377", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edd5bba76450dae8e79fcec7cb9dcdf29181ad407259", async() => {
                WriteLiteral(@"
    <div class=""up"">
    <table class=""content-table"">
        <thead>
            <tr>
                <th>Name</th>
                <th>Date</th>
                <th>Timeslot</th>
                <th>Table Nr.</th>
                <th>Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 25 "C:\Users\m_cel\Source\Repos\jeroen107\NGTI\NGTI\Views\Admin\Reservations.cshtml"
             foreach (var item in Model.soloList)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 29 "C:\Users\m_cel\Source\Repos\jeroen107\NGTI\NGTI\Views\Admin\Reservations.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 32 "C:\Users\m_cel\Source\Repos\jeroen107\NGTI\NGTI\Views\Admin\Reservations.cshtml"
                   Write(Convert.ToString(string.Format("{0:dd/MM/yyyy}", item.Date)));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 35 "C:\Users\m_cel\Source\Repos\jeroen107\NGTI\NGTI\Views\Admin\Reservations.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TimeSlot));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td class=\"tableid\">\r\n                        ");
#nullable restore
#line 38 "C:\Users\m_cel\Source\Repos\jeroen107\NGTI\NGTI\Views\Admin\Reservations.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TableId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edd5bba76450dae8e79fcec7cb9dcdf29181ad409613", async() => {
                    WriteLiteral("Edit");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\m_cel\Source\Repos\jeroen107\NGTI\NGTI\Views\Admin\Reservations.cshtml"
                                                   WriteLiteral(item.IdSoloReservation);

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
                WriteLiteral(" | |\r\n                        ");
#nullable restore
#line 42 "C:\Users\m_cel\Source\Repos\jeroen107\NGTI\NGTI\Views\Admin\Reservations.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { id = item.IdSoloReservation, type = "Solo" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                        ");
#nullable restore
#line 43 "C:\Users\m_cel\Source\Repos\jeroen107\NGTI\NGTI\Views\Admin\Reservations.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { id = item.IdSoloReservation, type = "Solo" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 46 "C:\Users\m_cel\Source\Repos\jeroen107\NGTI\NGTI\Views\Admin\Reservations.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </tbody>
    </table>
        </div>

    <div class=""down"">
    <table class=""content-table"">
        <thead>
            <tr>

                <th>Name</th>
                <th>Team Name</th>
                <th>Date</th>
                <th>TimeSlot</th>
                <th>Table Nr</th>
                <th>Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 65 "C:\Users\m_cel\Source\Repos\jeroen107\NGTI\NGTI\Views\Admin\Reservations.cshtml"
             foreach (var item in Model.groupList)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "C:\Users\m_cel\Source\Repos\jeroen107\NGTI\NGTI\Views\Admin\Reservations.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 72 "C:\Users\m_cel\Source\Repos\jeroen107\NGTI\NGTI\Views\Admin\Reservations.cshtml"
               Write(Html.DisplayFor(modelItem => item.Teamname));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 75 "C:\Users\m_cel\Source\Repos\jeroen107\NGTI\NGTI\Views\Admin\Reservations.cshtml"
               Write(Convert.ToString(string.Format("{0:dd/MM/yyyy}", item.Date)));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 78 "C:\Users\m_cel\Source\Repos\jeroen107\NGTI\NGTI\Views\Admin\Reservations.cshtml"
               Write(Html.DisplayFor(modelItem => item.TimeSlot));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td class=\"tableid\">\r\n                    ");
#nullable restore
#line 81 "C:\Users\m_cel\Source\Repos\jeroen107\NGTI\NGTI\Views\Admin\Reservations.cshtml"
               Write(Html.DisplayFor(modelItem => item.TableId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edd5bba76450dae8e79fcec7cb9dcdf29181ad4015285", async() => {
                    WriteLiteral("Edit");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\m_cel\Source\Repos\jeroen107\NGTI\NGTI\Views\Admin\Reservations.cshtml"
                                                WriteLiteral(item.IdGroupReservation);

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
                WriteLiteral(" |\r\n                    ");
#nullable restore
#line 85 "C:\Users\m_cel\Source\Repos\jeroen107\NGTI\NGTI\Views\Admin\Reservations.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.IdGroupReservation, type = "Group" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                    ");
#nullable restore
#line 86 "C:\Users\m_cel\Source\Repos\jeroen107\NGTI\NGTI\Views\Admin\Reservations.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.IdGroupReservation, type = "Group" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 89 "C:\Users\m_cel\Source\Repos\jeroen107\NGTI\NGTI\Views\Admin\Reservations.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n    </div>\r\n    \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NGTI.Models.ReservationsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
