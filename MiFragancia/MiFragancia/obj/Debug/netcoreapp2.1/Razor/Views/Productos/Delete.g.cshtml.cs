#pragma checksum "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\Productos\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c925dc75da04053cf88cdfca1d5516cbbd6eb38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productos_Delete), @"mvc.1.0.view", @"/Views/Productos/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Productos/Delete.cshtml", typeof(AspNetCore.Views_Productos_Delete))]
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
#line 1 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\_ViewImports.cshtml"
using MiFragancia;

#line default
#line hidden
#line 2 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\_ViewImports.cshtml"
using MiFragancia.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c925dc75da04053cf88cdfca1d5516cbbd6eb38", @"/Views/Productos/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"306b91b02534dfeba902bd102262fb1c730c55fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Productos_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MiFragancia.Models.Producto>
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
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\Productos\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\Productos\Delete.cshtml"
 if (Log.isSingin)
{


#line default
#line hidden
            BeginContext(107, 21, true);
            WriteLiteral("    <h2>Delete</h2>\r\n");
            EndContext();
            BeginContext(130, 176, true);
            WriteLiteral("    <h3>Are you sure you want to delete this?</h3>\r\n    <div>\r\n        <h4>Producto</h4>\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(307, 42, false);
#line 18 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\Productos\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(349, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(405, 38, false);
#line 21 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\Productos\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(443, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(499, 47, false);
#line 24 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\Productos\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(546, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(602, 43, false);
#line 27 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\Productos\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(645, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(701, 44, false);
#line 30 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\Productos\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(745, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(801, 40, false);
#line 33 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\Productos\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(841, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(897, 42, false);
#line 36 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\Productos\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
            EndContext();
            BeginContext(939, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(995, 38, false);
#line 39 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\Productos\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Precio));

#line default
#line hidden
            EndContext();
            BeginContext(1033, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1089, 42, false);
#line 42 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\Productos\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Activo));

#line default
#line hidden
            EndContext();
            BeginContext(1131, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1187, 38, false);
#line 45 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\Productos\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Activo));

#line default
#line hidden
            EndContext();
            BeginContext(1225, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1281, 40, false);
#line 48 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\Productos\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(1321, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1377, 39, false);
#line 51 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\Productos\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Tipo.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1416, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1472, 42, false);
#line 54 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\Productos\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Imagen));

#line default
#line hidden
            EndContext();
            BeginContext(1514, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1570, 41, false);
#line 57 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\Productos\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Imagen.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1611, 46, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n\r\n        ");
            EndContext();
            BeginContext(1657, 223, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61afde8b107242fc8218b86d95749ed4", async() => {
                BeginContext(1683, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1697, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d0e22960f5804ee9b421444ce0fc85bb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 62 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\Productos\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

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
                BeginContext(1733, 92, true);
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n            ");
                EndContext();
                BeginContext(1825, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1466b0015369416fba0f002d0d8ee1ac", async() => {
                    BeginContext(1847, 12, true);
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
                BeginContext(1863, 10, true);
                WriteLiteral("\r\n        ");
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
            BeginContext(1880, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 67 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\Productos\Delete.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1906, 53, true);
            WriteLiteral("    <h1>Ooops! parece que tienes que logearte!</h1>\r\n");
            EndContext();
#line 71 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\Productos\Delete.cshtml"
}

#line default
#line hidden
            BeginContext(1962, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MiFragancia.Models.Producto> Html { get; private set; }
    }
}
#pragma warning restore 1591
