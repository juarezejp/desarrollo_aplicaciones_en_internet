#pragma checksum "c:\Users\ELADIO\Documents\uni\AplicacionesInternet\proyecto\Views\Pasajero\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5518be7d73e3c7fce66040f5609c5a6a585dc255"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pasajero_Delete), @"mvc.1.0.view", @"/Views/Pasajero/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pasajero/Delete.cshtml", typeof(AspNetCore.Views_Pasajero_Delete))]
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
#line 1 "c:\Users\ELADIO\Documents\uni\AplicacionesInternet\proyecto\Views\_ViewImports.cshtml"
using proyecto;

#line default
#line hidden
#line 2 "c:\Users\ELADIO\Documents\uni\AplicacionesInternet\proyecto\Views\_ViewImports.cshtml"
using proyecto.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5518be7d73e3c7fce66040f5609c5a6a585dc255", @"/Views/Pasajero/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c408a981cda364cb3b7366a3e1aa09923cb88b9e", @"/Views/_ViewImports.cshtml")]
    public class Views_Pasajero_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<proyecto.Models.Pasajero>
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
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "c:\Users\ELADIO\Documents\uni\AplicacionesInternet\proyecto\Views\Pasajero\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(77, 178, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Pasajero</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(256, 42, false);
#line 15 "c:\Users\ELADIO\Documents\uni\AplicacionesInternet\proyecto\Views\Pasajero\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.nombre));

#line default
#line hidden
            EndContext();
            BeginContext(298, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(362, 38, false);
#line 18 "c:\Users\ELADIO\Documents\uni\AplicacionesInternet\proyecto\Views\Pasajero\Delete.cshtml"
       Write(Html.DisplayFor(model => model.nombre));

#line default
#line hidden
            EndContext();
            BeginContext(400, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(463, 44, false);
#line 21 "c:\Users\ELADIO\Documents\uni\AplicacionesInternet\proyecto\Views\Pasajero\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.apaterno));

#line default
#line hidden
            EndContext();
            BeginContext(507, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(571, 40, false);
#line 24 "c:\Users\ELADIO\Documents\uni\AplicacionesInternet\proyecto\Views\Pasajero\Delete.cshtml"
       Write(Html.DisplayFor(model => model.apaterno));

#line default
#line hidden
            EndContext();
            BeginContext(611, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(674, 44, false);
#line 27 "c:\Users\ELADIO\Documents\uni\AplicacionesInternet\proyecto\Views\Pasajero\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.amaterno));

#line default
#line hidden
            EndContext();
            BeginContext(718, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(782, 40, false);
#line 30 "c:\Users\ELADIO\Documents\uni\AplicacionesInternet\proyecto\Views\Pasajero\Delete.cshtml"
       Write(Html.DisplayFor(model => model.amaterno));

#line default
#line hidden
            EndContext();
            BeginContext(822, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(885, 50, false);
#line 33 "c:\Users\ELADIO\Documents\uni\AplicacionesInternet\proyecto\Views\Pasajero\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.tipo_documento));

#line default
#line hidden
            EndContext();
            BeginContext(935, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(999, 46, false);
#line 36 "c:\Users\ELADIO\Documents\uni\AplicacionesInternet\proyecto\Views\Pasajero\Delete.cshtml"
       Write(Html.DisplayFor(model => model.tipo_documento));

#line default
#line hidden
            EndContext();
            BeginContext(1045, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1108, 49, false);
#line 39 "c:\Users\ELADIO\Documents\uni\AplicacionesInternet\proyecto\Views\Pasajero\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.num_documento));

#line default
#line hidden
            EndContext();
            BeginContext(1157, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1221, 45, false);
#line 42 "c:\Users\ELADIO\Documents\uni\AplicacionesInternet\proyecto\Views\Pasajero\Delete.cshtml"
       Write(Html.DisplayFor(model => model.num_documento));

#line default
#line hidden
            EndContext();
            BeginContext(1266, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1329, 52, false);
#line 45 "c:\Users\ELADIO\Documents\uni\AplicacionesInternet\proyecto\Views\Pasajero\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.fecha_nacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(1381, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1445, 48, false);
#line 48 "c:\Users\ELADIO\Documents\uni\AplicacionesInternet\proyecto\Views\Pasajero\Delete.cshtml"
       Write(Html.DisplayFor(model => model.fecha_nacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(1493, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1556, 40, false);
#line 51 "c:\Users\ELADIO\Documents\uni\AplicacionesInternet\proyecto\Views\Pasajero\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pais));

#line default
#line hidden
            EndContext();
            BeginContext(1596, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1660, 43, false);
#line 54 "c:\Users\ELADIO\Documents\uni\AplicacionesInternet\proyecto\Views\Pasajero\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pais.nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1703, 68, true);
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1772, 44, false);
#line 57 "c:\Users\ELADIO\Documents\uni\AplicacionesInternet\proyecto\Views\Pasajero\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.telefono));

#line default
#line hidden
            EndContext();
            BeginContext(1816, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1880, 40, false);
#line 60 "c:\Users\ELADIO\Documents\uni\AplicacionesInternet\proyecto\Views\Pasajero\Delete.cshtml"
       Write(Html.DisplayFor(model => model.telefono));

#line default
#line hidden
            EndContext();
            BeginContext(1920, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1983, 41, false);
#line 63 "c:\Users\ELADIO\Documents\uni\AplicacionesInternet\proyecto\Views\Pasajero\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(2024, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2088, 37, false);
#line 66 "c:\Users\ELADIO\Documents\uni\AplicacionesInternet\proyecto\Views\Pasajero\Delete.cshtml"
       Write(Html.DisplayFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(2125, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2188, 41, false);
#line 69 "c:\Users\ELADIO\Documents\uni\AplicacionesInternet\proyecto\Views\Pasajero\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.clave));

#line default
#line hidden
            EndContext();
            BeginContext(2229, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2293, 37, false);
#line 72 "c:\Users\ELADIO\Documents\uni\AplicacionesInternet\proyecto\Views\Pasajero\Delete.cshtml"
       Write(Html.DisplayFor(model => model.clave));

#line default
#line hidden
            EndContext();
            BeginContext(2330, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2368, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5518be7d73e3c7fce66040f5609c5a6a585dc25513671", async() => {
                BeginContext(2394, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2404, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5518be7d73e3c7fce66040f5609c5a6a585dc25514064", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 77 "c:\Users\ELADIO\Documents\uni\AplicacionesInternet\proyecto\Views\Pasajero\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IDPasajero);

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
                BeginContext(2448, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2531, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5518be7d73e3c7fce66040f5609c5a6a585dc25515987", async() => {
                    BeginContext(2553, 12, true);
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
                BeginContext(2569, 6, true);
                WriteLiteral("\r\n    ");
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
            BeginContext(2582, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<proyecto.Models.Pasajero> Html { get; private set; }
    }
}
#pragma warning restore 1591
