#pragma checksum "C:\Users\kerle\Google Drive\notebook kerley\documentos\CURSOS\Curso C#\hamburgueriaCamila\WebApplication1\WebApplication1\Views\MateriaPrima_Produtos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b8fa35e16674810f635d565d8d40388de50f48b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MateriaPrima_Produtos_Index), @"mvc.1.0.view", @"/Views/MateriaPrima_Produtos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MateriaPrima_Produtos/Index.cshtml", typeof(AspNetCore.Views_MateriaPrima_Produtos_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b8fa35e16674810f635d565d8d40388de50f48b", @"/Views/MateriaPrima_Produtos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1ff06a39e58d6f48f90f932fe8e24983c58b74d", @"/Views/_ViewImports.cshtml")]
    public class Views_MateriaPrima_Produtos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication1.Models.MateriaPrima_Produto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Salvar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(65, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\kerle\Google Drive\notebook kerley\documentos\CURSOS\Curso C#\hamburgueriaCamila\WebApplication1\WebApplication1\Views\MateriaPrima_Produtos\Index.cshtml"
  
    ViewData["Title"] = "Construindo Produtos";

#line default
#line hidden
            BeginContext(125, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(132, 17, false);
#line 8 "C:\Users\kerle\Google Drive\notebook kerley\documentos\CURSOS\Curso C#\hamburgueriaCamila\WebApplication1\WebApplication1\Views\MateriaPrima_Produtos\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(149, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
            BeginContext(156, 1488, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f966c8759d14a7abc0552d6d264e433", async() => {
                BeginContext(182, 148, true);
                WriteLiteral("\r\n    <table class=\"table table-striped table-hover table-condensed\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(331, 53, false);
#line 14 "C:\Users\kerle\Google Drive\notebook kerley\documentos\CURSOS\Curso C#\hamburgueriaCamila\WebApplication1\WebApplication1\Views\MateriaPrima_Produtos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.MateriaPrima.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(384, 206, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    <label>Valor Unitario</label>\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n\r\n        <tbody>\r\n\r\n");
                EndContext();
#line 25 "C:\Users\kerle\Google Drive\notebook kerley\documentos\CURSOS\Curso C#\hamburgueriaCamila\WebApplication1\WebApplication1\Views\MateriaPrima_Produtos\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(647, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(720, 52, false);
#line 29 "C:\Users\kerle\Google Drive\notebook kerley\documentos\CURSOS\Curso C#\hamburgueriaCamila\WebApplication1\WebApplication1\Views\MateriaPrima_Produtos\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MateriaPrima.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(772, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(852, 59, false);
#line 32 "C:\Users\kerle\Google Drive\notebook kerley\documentos\CURSOS\Curso C#\hamburgueriaCamila\WebApplication1\WebApplication1\Views\MateriaPrima_Produtos\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MateriaPrima.VlrUnitario));

#line default
#line hidden
                EndContext();
                BeginContext(911, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(991, 51, false);
#line 35 "C:\Users\kerle\Google Drive\notebook kerley\documentos\CURSOS\Curso C#\hamburgueriaCamila\WebApplication1\WebApplication1\Views\MateriaPrima_Produtos\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MateriaPrima.uni));

#line default
#line hidden
                EndContext();
                BeginContext(1042, 274, true);
                WriteLiteral(@"
                    </td>
                    <td>
                        <label class=""control-label""></label>
                        <input  class=""form-control"" />
                    </td>
                    <td>
                        <input type=""checkbox""");
                EndContext();
                BeginWriteAttribute("id", " id=", 1316, "", 1371, 1);
#line 42 "C:\Users\kerle\Google Drive\notebook kerley\documentos\CURSOS\Curso C#\hamburgueriaCamila\WebApplication1\WebApplication1\Views\MateriaPrima_Produtos\Index.cshtml"
WriteAttributeValue("", 1320, Html.DisplayFor(modelItem => item.MateriaPrima.Id), 1320, 51, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1371, 22, true);
                WriteLiteral(" name=\"ListaMateriais\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1393, "\"", 1452, 1);
#line 42 "C:\Users\kerle\Google Drive\notebook kerley\documentos\CURSOS\Curso C#\hamburgueriaCamila\WebApplication1\WebApplication1\Views\MateriaPrima_Produtos\Index.cshtml"
WriteAttributeValue("", 1401, Html.DisplayFor(modelItem => item.MateriaPrima.Id), 1401, 51, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1453, 63, true);
                WriteLiteral(">          \r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 45 "C:\Users\kerle\Google Drive\notebook kerley\documentos\CURSOS\Curso C#\hamburgueriaCamila\WebApplication1\WebApplication1\Views\MateriaPrima_Produtos\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(1531, 106, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n    <input type=\"submit\" value=\"UpdateChecks\" class=\"btn btn-default\" />\r\n");
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
            BeginContext(1644, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication1.Models.MateriaPrima_Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
