#pragma checksum "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da493aadedc4fffd9c2e698cb779c16181906fcc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Delete), @"mvc.1.0.view", @"/Views/Booking/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Booking/Delete.cshtml", typeof(AspNetCore.Views_Booking_Delete))]
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
#line 1 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\_ViewImports.cshtml"
using ResHotel;

#line default
#line hidden
#line 2 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\_ViewImports.cshtml"
using ResHotel.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da493aadedc4fffd9c2e698cb779c16181906fcc", @"/Views/Booking/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2c1c136844b518ec2391dad0a3e50f0a27db134", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResHotel.Models.Booking>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(71, 168, true);
            WriteLiteral("\n<h1>Delete</h1>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <h4>Booking</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(240, 51, false);
#line 15 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DateBookingMade));

#line default
#line hidden
            EndContext();
            BeginContext(291, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(352, 47, false);
#line 18 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DateBookingMade));

#line default
#line hidden
            EndContext();
            BeginContext(399, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(459, 51, false);
#line 21 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TimeBookingMade));

#line default
#line hidden
            EndContext();
            BeginContext(510, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(571, 47, false);
#line 24 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TimeBookingMade));

#line default
#line hidden
            EndContext();
            BeginContext(618, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(678, 51, false);
#line 27 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BookedStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(729, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(790, 47, false);
#line 30 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BookedStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(837, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(897, 49, false);
#line 33 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BookedEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(946, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1007, 45, false);
#line 36 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BookedEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(1052, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1112, 55, false);
#line 39 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalPaymentDueDate));

#line default
#line hidden
            EndContext();
            BeginContext(1167, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1228, 51, false);
#line 42 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TotalPaymentDueDate));

#line default
#line hidden
            EndContext();
            BeginContext(1279, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1339, 57, false);
#line 45 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalPaymentDueAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1396, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1457, 53, false);
#line 48 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TotalPaymentDueAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1510, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1570, 54, false);
#line 51 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalPaymentMadeOn));

#line default
#line hidden
            EndContext();
            BeginContext(1624, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1685, 50, false);
#line 54 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TotalPaymentMadeOn));

#line default
#line hidden
            EndContext();
            BeginContext(1735, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1795, 51, false);
#line 57 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BookingComments));

#line default
#line hidden
            EndContext();
            BeginContext(1846, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1907, 47, false);
#line 60 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BookingComments));

#line default
#line hidden
            EndContext();
            BeginContext(1954, 34, true);
            WriteLiteral("\n        </dd>\n    </dl>\n    \n    ");
            EndContext();
            BeginContext(1988, 209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da493aadedc4fffd9c2e698cb779c16181906fcc11999", async() => {
                BeginContext(2014, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(2023, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "da493aadedc4fffd9c2e698cb779c16181906fcc12389", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 65 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.BookingID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2066, 81, true);
                WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\n        ");
                EndContext();
                BeginContext(2147, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da493aadedc4fffd9c2e698cb779c16181906fcc14311", async() => {
                    BeginContext(2169, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2185, 5, true);
                WriteLiteral("\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2197, 8, true);
            WriteLiteral("\n</div>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResHotel.Models.Booking> Html { get; private set; }
    }
}
#pragma warning restore 1591
