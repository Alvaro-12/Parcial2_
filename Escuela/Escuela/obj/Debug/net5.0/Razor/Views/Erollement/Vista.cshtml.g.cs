#pragma checksum "E:\UNIVERSIDAD\Ciclo 04\Programacion 2\Parcial2\Parcial2_\Escuela\Escuela\Views\Erollement\Vista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce1757d42a8c8408b68f3780789ea4876fe4847d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Erollement_Vista), @"mvc.1.0.view", @"/Views/Erollement/Vista.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce1757d42a8c8408b68f3780789ea4876fe4847d", @"/Views/Erollement/Vista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ad1daf75ad34d7efa7ede8e232fbd89a93ea7bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Erollement_Vista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Escuela.Dominio.Erollement>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\UNIVERSIDAD\Ciclo 04\Programacion 2\Parcial2\Parcial2_\Escuela\Escuela\Views\Erollement\Vista.cshtml"
  
    ViewData["Title"] = "Erollement";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Inscripcion</h1>\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce1757d42a8c8408b68f3780789ea4876fe4847d3639", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>ComboBox</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce1757d42a8c8408b68f3780789ea4876fe4847d4701", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 16 "E:\UNIVERSIDAD\Ciclo 04\Programacion 2\Parcial2\Parcial2_\Escuela\Escuela\Views\Erollement\Vista.cshtml"
     using (Html.BeginForm("Registrar", "Erollement", FormMethod.Post))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\UNIVERSIDAD\Ciclo 04\Programacion 2\Parcial2\Parcial2_\Escuela\Escuela\Views\Erollement\Vista.cshtml"
   Write(Html.DropDownListFor(a => a.CourseID, new SelectList(ViewBag.estadolistcourse, "Value", "Text"), "Selecciona un curso", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br />\r\n");
#nullable restore
#line 20 "E:\UNIVERSIDAD\Ciclo 04\Programacion 2\Parcial2\Parcial2_\Escuela\Escuela\Views\Erollement\Vista.cshtml"
   Write(Html.DropDownListFor(a => a.StudentID, new SelectList(ViewBag.estadolsitestudents, "Value", "Text"), "Selecciona un Estudiante", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br />\r\n        <label for=\"Grade\">Escriba un grado:( A, B, C, D)</label>\r\n        <br />\r\n        <input type=\"text\" name=\"Grade\" />\r\n        <br />\r\n        <br />\r\n        <input type=\"submit\" />\r\n        <br />\r\n        <br />\r\n");
#nullable restore
#line 30 "E:\UNIVERSIDAD\Ciclo 04\Programacion 2\Parcial2\Parcial2_\Escuela\Escuela\Views\Erollement\Vista.cshtml"
   Write(Html.ActionLink("Menu Principal", "Index", "EscuelaController1", new { }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br />\r\n        <br />\r\n");
#nullable restore
#line 33 "E:\UNIVERSIDAD\Ciclo 04\Programacion 2\Parcial2\Parcial2_\Escuela\Escuela\Views\Erollement\Vista.cshtml"
   Write(Html.ActionLink("Ver tabla de inscritos", "Students", "Home", new { }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "E:\UNIVERSIDAD\Ciclo 04\Programacion 2\Parcial2\Parcial2_\Escuela\Escuela\Views\Erollement\Vista.cshtml"
                                                                                                                   

    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Escuela.Dominio.Erollement> Html { get; private set; }
    }
}
#pragma warning restore 1591
