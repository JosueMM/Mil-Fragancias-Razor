#pragma checksum "C:\Users\Usuario\Desktop\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6c17625887d513fb86e179cea4cad2da1f0209a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UsuarioModels_Details), @"mvc.1.0.view", @"/Views/UsuarioModels/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UsuarioModels/Details.cshtml", typeof(AspNetCore.Views_UsuarioModels_Details))]
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
#line 1 "C:\Users\Usuario\Desktop\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\_ViewImports.cshtml"
using MiFragancia;

#line default
#line hidden
#line 2 "C:\Users\Usuario\Desktop\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\_ViewImports.cshtml"
using MiFragancia.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6c17625887d513fb86e179cea4cad2da1f0209a", @"/Views/UsuarioModels/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"306b91b02534dfeba902bd102262fb1c730c55fc", @"/Views/_ViewImports.cshtml")]
    public class Views_UsuarioModels_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MiFragancia.Models.UsuarioModel>
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
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Usuario\Desktop\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(85, 126, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>UsuarioModel</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(212, 42, false);
#line 14 "C:\Users\Usuario\Desktop\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(254, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(298, 38, false);
#line 17 "C:\Users\Usuario\Desktop\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(336, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(380, 43, false);
#line 20 "C:\Users\Usuario\Desktop\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Usuario));

#line default
#line hidden
            EndContext();
            BeginContext(423, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(467, 39, false);
#line 23 "C:\Users\Usuario\Desktop\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.Usuario));

#line default
#line hidden
            EndContext();
            BeginContext(506, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(550, 42, false);
#line 26 "C:\Users\Usuario\Desktop\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Correo));

#line default
#line hidden
            EndContext();
            BeginContext(592, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(636, 38, false);
#line 29 "C:\Users\Usuario\Desktop\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.Correo));

#line default
#line hidden
            EndContext();
            BeginContext(674, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(718, 47, false);
#line 32 "C:\Users\Usuario\Desktop\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Contrasenna));

#line default
#line hidden
            EndContext();
            BeginContext(765, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(809, 43, false);
#line 35 "C:\Users\Usuario\Desktop\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.Contrasenna));

#line default
#line hidden
            EndContext();
            BeginContext(852, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(896, 42, false);
#line 38 "C:\Users\Usuario\Desktop\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Activo));

#line default
#line hidden
            EndContext();
            BeginContext(938, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(982, 38, false);
#line 41 "C:\Users\Usuario\Desktop\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.Activo));

#line default
#line hidden
            EndContext();
            BeginContext(1020, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1064, 41, false);
#line 44 "C:\Users\Usuario\Desktop\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Admin));

#line default
#line hidden
            EndContext();
            BeginContext(1105, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1149, 37, false);
#line 47 "C:\Users\Usuario\Desktop\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.Admin));

#line default
#line hidden
            EndContext();
            BeginContext(1186, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1233, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cee57e0e4be04fa1af0a6bc95a2a9e48", async() => {
                BeginContext(1279, 4, true);
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
#line 52 "C:\Users\Usuario\Desktop\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
                           WriteLiteral(Model.ID);

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
            BeginContext(1287, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1295, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cd389c8245d487b96ce523a65ceefd7", async() => {
                BeginContext(1317, 12, true);
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
            BeginContext(1333, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MiFragancia.Models.UsuarioModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
