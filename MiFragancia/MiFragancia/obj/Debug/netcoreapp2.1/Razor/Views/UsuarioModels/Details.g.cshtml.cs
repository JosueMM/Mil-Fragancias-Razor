#pragma checksum "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb39f833ae8362ee0923284d432405510bdc8c0e"
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
#line 1 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\_ViewImports.cshtml"
using MiFragancia;

#line default
#line hidden
#line 2 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\_ViewImports.cshtml"
using MiFragancia.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb39f833ae8362ee0923284d432405510bdc8c0e", @"/Views/UsuarioModels/Details.cshtml")]
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
#line 3 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(85, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
 if (Log.isAdmin && Log.isSingin)
{

#line default
#line hidden
            BeginContext(125, 22, true);
            WriteLiteral("    <h2>Details</h2>\r\n");
            EndContext();
            BeginContext(149, 128, true);
            WriteLiteral("    <div>\r\n        <h4>UsuarioModel</h4>\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(278, 42, false);
#line 16 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(320, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(376, 38, false);
#line 19 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
           Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(414, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(470, 43, false);
#line 22 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Usuario));

#line default
#line hidden
            EndContext();
            BeginContext(513, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(569, 39, false);
#line 25 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
           Write(Html.DisplayFor(model => model.Usuario));

#line default
#line hidden
            EndContext();
            BeginContext(608, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(664, 42, false);
#line 28 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Correo));

#line default
#line hidden
            EndContext();
            BeginContext(706, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(762, 38, false);
#line 31 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
           Write(Html.DisplayFor(model => model.Correo));

#line default
#line hidden
            EndContext();
            BeginContext(800, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(856, 47, false);
#line 34 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Contrasenna));

#line default
#line hidden
            EndContext();
            BeginContext(903, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(959, 43, false);
#line 37 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
           Write(Html.DisplayFor(model => model.Contrasenna));

#line default
#line hidden
            EndContext();
            BeginContext(1002, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1058, 42, false);
#line 40 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Activo));

#line default
#line hidden
            EndContext();
            BeginContext(1100, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1156, 38, false);
#line 43 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
           Write(Html.DisplayFor(model => model.Activo));

#line default
#line hidden
            EndContext();
            BeginContext(1194, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1250, 41, false);
#line 46 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Admin));

#line default
#line hidden
            EndContext();
            BeginContext(1291, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1347, 37, false);
#line 49 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
           Write(Html.DisplayFor(model => model.Admin));

#line default
#line hidden
            EndContext();
            BeginContext(1384, 67, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(1451, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77a9d55704724ff093fe68cc60e8fba3", async() => {
                BeginContext(1497, 4, true);
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
#line 54 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
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
            BeginContext(1505, 12, true);
            WriteLiteral(" |\r\n        ");
            EndContext();
            BeginContext(1517, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b771dad4673e404d84f87619af8973e8", async() => {
                BeginContext(1539, 12, true);
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
            BeginContext(1555, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 57 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"

}
else
{

#line default
#line hidden
            BeginContext(1583, 76, true);
            WriteLiteral("    <h1>Ooops parece que tienes que logearte o no eres administrador </h1>\r\n");
            EndContext();
#line 62 "C:\Users\Usuario\Desktop\Razor\Mil-Fragancias-Razor\MiFragancia\MiFragancia\Views\UsuarioModels\Details.cshtml"
}

#line default
#line hidden
            BeginContext(1662, 2, true);
            WriteLiteral("\r\n");
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
