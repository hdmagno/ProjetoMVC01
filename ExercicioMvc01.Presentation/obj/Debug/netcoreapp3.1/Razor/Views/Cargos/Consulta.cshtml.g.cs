#pragma checksum "D:\Projetos\VisualStudio\Coti-Csharp\Sabado\ExercicioMvc01\ExercicioMvc01.Presentation\Views\Cargos\Consulta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01ed859c1be98637fbc95b9904ad8ef46dcf4f26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cargos_Consulta), @"mvc.1.0.view", @"/Views/Cargos/Consulta.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01ed859c1be98637fbc95b9904ad8ef46dcf4f26", @"/Views/Cargos/Consulta.cshtml")]
    public class Views_Cargos_Consulta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExercicioMvc01.Presentation.Models.CargoConsultaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projetos\VisualStudio\Coti-Csharp\Sabado\ExercicioMvc01\ExercicioMvc01.Presentation\Views\Cargos\Consulta.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h5>Consulta de Cargos</h5>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n");
#nullable restore
#line 11 "D:\Projetos\VisualStudio\Coti-Csharp\Sabado\ExercicioMvc01\ExercicioMvc01.Presentation\Views\Cargos\Consulta.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <label>Nome do Usuário</label>\r\n");
#nullable restore
#line 14 "D:\Projetos\VisualStudio\Coti-Csharp\Sabado\ExercicioMvc01\ExercicioMvc01.Presentation\Views\Cargos\Consulta.cshtml"
       Write(Html.TextBoxFor(model => model.Nome,
           new
           {
               @class = "form-control",
               @placeholder = "Ex: Desenvolvedor"
           }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"text-danger\">\r\n                ");
#nullable restore
#line 21 "D:\Projetos\VisualStudio\Coti-Csharp\Sabado\ExercicioMvc01\ExercicioMvc01.Presentation\Views\Cargos\Consulta.cshtml"
           Write(Html.ValidationMessageFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </span>\r\n            <br />\r\n");
            WriteLiteral("            <input type=\"submit\" class=\"btn btn-success\" value=\"Pesquisar\" />\r\n");
#nullable restore
#line 26 "D:\Projetos\VisualStudio\Coti-Csharp\Sabado\ExercicioMvc01\ExercicioMvc01.Presentation\Views\Cargos\Consulta.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<br />\r\n\r\n");
#nullable restore
#line 32 "D:\Projetos\VisualStudio\Coti-Csharp\Sabado\ExercicioMvc01\ExercicioMvc01.Presentation\Views\Cargos\Consulta.cshtml"
 if (Model != null && Model.Cargos != null && Model.Cargos.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-bordered table-striped table-hover\">\r\n        <thead>\r\n            <tr>\r\n                <th>Cargo</th>\r\n                <th>Descrição</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 42 "D:\Projetos\VisualStudio\Coti-Csharp\Sabado\ExercicioMvc01\ExercicioMvc01.Presentation\Views\Cargos\Consulta.cshtml"
             foreach (var item in Model.Cargos)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 45 "D:\Projetos\VisualStudio\Coti-Csharp\Sabado\ExercicioMvc01\ExercicioMvc01.Presentation\Views\Cargos\Consulta.cshtml"
                   Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 46 "D:\Projetos\VisualStudio\Coti-Csharp\Sabado\ExercicioMvc01\ExercicioMvc01.Presentation\Views\Cargos\Consulta.cshtml"
                   Write(item.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 48 "D:\Projetos\VisualStudio\Coti-Csharp\Sabado\ExercicioMvc01\ExercicioMvc01.Presentation\Views\Cargos\Consulta.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td colspan=\"2\">Cargos: ");
#nullable restore
#line 52 "D:\Projetos\VisualStudio\Coti-Csharp\Sabado\ExercicioMvc01\ExercicioMvc01.Presentation\Views\Cargos\Consulta.cshtml"
                                   Write(Model.Cargos.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n");
#nullable restore
#line 56 "D:\Projetos\VisualStudio\Coti-Csharp\Sabado\ExercicioMvc01\ExercicioMvc01.Presentation\Views\Cargos\Consulta.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExercicioMvc01.Presentation.Models.CargoConsultaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
