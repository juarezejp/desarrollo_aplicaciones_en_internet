#pragma checksum "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "754fa5ade9269b983acb1c144d696f4ebf7c1839"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Details), @"mvc.1.0.view", @"/Views/Booking/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Booking/Details.cshtml", typeof(AspNetCore.Views_Booking_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"754fa5ade9269b983acb1c144d696f4ebf7c1839", @"/Views/Booking/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2c1c136844b518ec2391dad0a3e50f0a27db134", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResHotel.Models.Booking>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(72, 122, true);
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>Booking</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(195, 51, false);
#line 14 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateBookingMade));

#line default
#line hidden
            EndContext();
            BeginContext(246, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(307, 47, false);
#line 17 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateBookingMade));

#line default
#line hidden
            EndContext();
            BeginContext(354, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(414, 51, false);
#line 20 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TimeBookingMade));

#line default
#line hidden
            EndContext();
            BeginContext(465, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(526, 47, false);
#line 23 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Details.cshtml"
       Write(Html.DisplayFor(model => model.TimeBookingMade));

#line default
#line hidden
            EndContext();
            BeginContext(573, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(633, 51, false);
#line 26 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BookedStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(684, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(745, 47, false);
#line 29 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Details.cshtml"
       Write(Html.DisplayFor(model => model.BookedStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(792, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(852, 49, false);
#line 32 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BookedEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(901, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(962, 45, false);
#line 35 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Details.cshtml"
       Write(Html.DisplayFor(model => model.BookedEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(1007, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1067, 55, false);
#line 38 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalPaymentDueDate));

#line default
#line hidden
            EndContext();
            BeginContext(1122, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1183, 51, false);
#line 41 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalPaymentDueDate));

#line default
#line hidden
            EndContext();
            BeginContext(1234, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1294, 57, false);
#line 44 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalPaymentDueAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1351, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1412, 53, false);
#line 47 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalPaymentDueAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1465, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1525, 54, false);
#line 50 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalPaymentMadeOn));

#line default
#line hidden
            EndContext();
            BeginContext(1579, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1640, 50, false);
#line 53 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalPaymentMadeOn));

#line default
#line hidden
            EndContext();
            BeginContext(1690, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1750, 51, false);
#line 56 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BookingComments));

#line default
#line hidden
            EndContext();
            BeginContext(1801, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1862, 47, false);
#line 59 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Details.cshtml"
       Write(Html.DisplayFor(model => model.BookingComments));

#line default
#line hidden
            EndContext();
            BeginContext(1909, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1951, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "754fa5ade9269b983acb1c144d696f4ebf7c183911275", async() => {
                BeginContext(2004, 4, true);
                WriteLiteral("Edit");
                EndContext();
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
#line 64 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Booking\Details.cshtml"
                           WriteLiteral(Model.BookingID);

#line default
#line hidden
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
            EndContext();
            BeginContext(2012, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(2019, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "754fa5ade9269b983acb1c144d696f4ebf7c183913616", async() => {
                BeginContext(2041, 12, true);
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
            BeginContext(2057, 8, true);
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
