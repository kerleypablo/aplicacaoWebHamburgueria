#pragma checksum "C:\Users\kerle\Google Drive\notebook kerley\documentos\CURSOS\Curso C#\hamburgueriaCamila\WebApplication1\WebApplication1\Views\Produtos\Construct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ccaeabe5cd7987774f4dc114999e5acbcc191e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produtos_Construct), @"mvc.1.0.view", @"/Views/Produtos/Construct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produtos/Construct.cshtml", typeof(AspNetCore.Views_Produtos_Construct))]
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
#line 1 "C:\Users\kerle\Google Drive\notebook kerley\documentos\CURSOS\Curso C#\hamburgueriaCamila\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\kerle\Google Drive\notebook kerley\documentos\CURSOS\Curso C#\hamburgueriaCamila\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ccaeabe5cd7987774f4dc114999e5acbcc191e4", @"/Views/Produtos/Construct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1ff06a39e58d6f48f90f932fe8e24983c58b74d", @"/Views/_ViewImports.cshtml")]
    public class Views_Produtos_Construct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.ViewModels.MateriaPrima_ProdutoFormViwModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateChecks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(75, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\kerle\Google Drive\notebook kerley\documentos\CURSOS\Curso C#\hamburgueriaCamila\WebApplication1\WebApplication1\Views\Produtos\Construct.cshtml"
  
    ViewData["Title"] = "Construindo Produtos";

#line default
#line hidden
            BeginContext(135, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(142, 17, false);
#line 8 "C:\Users\kerle\Google Drive\notebook kerley\documentos\CURSOS\Curso C#\hamburgueriaCamila\WebApplication1\WebApplication1\Views\Produtos\Construct.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(159, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
            BeginContext(166, 1107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c82940bd9c8e402388cd0abd4db55769", async() => {
                BeginContext(198, 379, true);
                WriteLiteral(@"
    
    <table class=""table table-striped table-hover table-condensed"">
        <thead>
            <tr>
                <th>
                    <label>Nome</label>
                </th>
                <th>
                    <label>Valor Unitario</label>
                </th>
                <th></th>
            </tr>
        </thead>

        <tbody>

");
                EndContext();
#line 26 "C:\Users\kerle\Google Drive\notebook kerley\documentos\CURSOS\Curso C#\hamburgueriaCamila\WebApplication1\WebApplication1\Views\Produtos\Construct.cshtml"
             foreach (var item in Model.MateriaPrimas)
            {

#line default
#line hidden
                BeginContext(648, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(721, 39, false);
#line 30 "C:\Users\kerle\Google Drive\notebook kerley\documentos\CURSOS\Curso C#\hamburgueriaCamila\WebApplication1\WebApplication1\Views\Produtos\Construct.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(760, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(840, 46, false);
#line 33 "C:\Users\kerle\Google Drive\notebook kerley\documentos\CURSOS\Curso C#\hamburgueriaCamila\WebApplication1\WebApplication1\Views\Produtos\Construct.cshtml"
                   Write(Html.DisplayFor(modelItem => item.VlrUnitario));

#line default
#line hidden
                EndContext();
                BeginContext(886, 101, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <input type=\"checkbox\"");
                EndContext();
                BeginWriteAttribute("id", " id=", 987, "", 1029, 1);
#line 36 "C:\Users\kerle\Google Drive\notebook kerley\documentos\CURSOS\Curso C#\hamburgueriaCamila\WebApplication1\WebApplication1\Views\Produtos\Construct.cshtml"
WriteAttributeValue("", 991, Html.DisplayFor(modelItem => item.Id), 991, 38, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1029, 22, true);
                WriteLiteral(" name=\"ListaMateriais\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1051, "\"", 1097, 1);
#line 36 "C:\Users\kerle\Google Drive\notebook kerley\documentos\CURSOS\Curso C#\hamburgueriaCamila\WebApplication1\WebApplication1\Views\Produtos\Construct.cshtml"
WriteAttributeValue("", 1059, Html.DisplayFor(modelItem => item.Id), 1059, 38, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1098, 53, true);
                WriteLiteral(">\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 39 "C:\Users\kerle\Google Drive\notebook kerley\documentos\CURSOS\Curso C#\hamburgueriaCamila\WebApplication1\WebApplication1\Views\Produtos\Construct.cshtml"
            }

#line default
#line hidden
                BeginContext(1166, 100, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n    <input type=\"submit\" value=\"Slavar\" class=\"btn btn-default\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1273, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.ViewModels.MateriaPrima_ProdutoFormViwModel> Html { get; private set; }
    }
}
#pragma warning restore 1591