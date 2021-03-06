#pragma checksum "E:\UNIVERSIDAD\Ciclo 04\Programacion 2\Parcial2\Parcial2_\Escuela\Escuela\Views\Home\Students.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e455dad5beecf40a779fddb1a60236b1ba04c0de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Students), @"mvc.1.0.view", @"/Views/Home/Students.cshtml")]
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
#line 1 "E:\UNIVERSIDAD\Ciclo 04\Programacion 2\Parcial2\Parcial2_\Escuela\Escuela\Views\_ViewImports.cshtml"
using Escuela;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\UNIVERSIDAD\Ciclo 04\Programacion 2\Parcial2\Parcial2_\Escuela\Escuela\Views\_ViewImports.cshtml"
using Escuela.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e455dad5beecf40a779fddb1a60236b1ba04c0de", @"/Views/Home/Students.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ad1daf75ad34d7efa7ede8e232fbd89a93ea7bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Students : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Escuela.Dominio.Erollement>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\UNIVERSIDAD\Ciclo 04\Programacion 2\Parcial2\Parcial2_\Escuela\Escuela\Views\Home\Students.cshtml"
  
    ViewData["Title"] = "Students";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Students</h1>

<table id=""mitabla"" class=""table table-striped table-hover"">
    <thead>
        <tr>
            <th>
                LastName
            </th>
            <th>
                FirstMidName
            </th>
            <th>
                Curso perteneciente
            </th>
            <th>
                Grade
            </th>
        </tr>

    </thead>

    <tbody>

");
#nullable restore
#line 29 "E:\UNIVERSIDAD\Ciclo 04\Programacion 2\Parcial2\Parcial2_\Escuela\Escuela\Views\Home\Students.cshtml"
         foreach (var iteracion in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 32 "E:\UNIVERSIDAD\Ciclo 04\Programacion 2\Parcial2\Parcial2_\Escuela\Escuela\Views\Home\Students.cshtml"
               Write(iteracion.Student.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "E:\UNIVERSIDAD\Ciclo 04\Programacion 2\Parcial2\Parcial2_\Escuela\Escuela\Views\Home\Students.cshtml"
               Write(iteracion.Student.FirstMidName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "E:\UNIVERSIDAD\Ciclo 04\Programacion 2\Parcial2\Parcial2_\Escuela\Escuela\Views\Home\Students.cshtml"
               Write(iteracion.Course.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "E:\UNIVERSIDAD\Ciclo 04\Programacion 2\Parcial2\Parcial2_\Escuela\Escuela\Views\Home\Students.cshtml"
               Write(iteracion.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 37 "E:\UNIVERSIDAD\Ciclo 04\Programacion 2\Parcial2\Parcial2_\Escuela\Escuela\Views\Home\Students.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
#nullable restore
#line 41 "E:\UNIVERSIDAD\Ciclo 04\Programacion 2\Parcial2\Parcial2_\Escuela\Escuela\Views\Home\Students.cshtml"
Write(Html.ActionLink("Menu Principal", "Index", "EscuelaController1", new { }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 42 "E:\UNIVERSIDAD\Ciclo 04\Programacion 2\Parcial2\Parcial2_\Escuela\Escuela\Views\Home\Students.cshtml"
Write(Html.ActionLink("Registrar alumno en un curso", "Vista", "Erollement", new { }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://cdn.datatables.net/1.11.3/js/jquery.dataTables.min.js\"></script>\r\n    <script>\r\n        $(document).ready(function () {\r\n\r\n            var tabla = $(\'#mitabla\').DataTable()\r\n        });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Escuela.Dominio.Erollement>> Html { get; private set; }
    }
}
#pragma warning restore 1591
