#pragma checksum "C:\Users\LENOVO TINY\source\repos\pruebanetcore\NetCore\WebApplication1\Views\Inventario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc281e7de292c58c2eccf55356e2a607eb345e37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventario_Index), @"mvc.1.0.view", @"/Views/Inventario/Index.cshtml")]
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
#line 1 "C:\Users\LENOVO TINY\source\repos\pruebanetcore\NetCore\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO TINY\source\repos\pruebanetcore\NetCore\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc281e7de292c58c2eccf55356e2a607eb345e37", @"/Views/Inventario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\LENOVO TINY\source\repos\pruebanetcore\NetCore\WebApplication1\Views\Inventario\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Inventario</h1>\r\n\r\n\r\n<div class=\"container\">\r\n\r\n\r\n\t<div class=\"d-flex flex-wrap flex-row\">\r\n\t\t<div class=\"flex-column\">\r\n\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 222, "\"", 263, 1);
#nullable restore
#line 15 "C:\Users\LENOVO TINY\source\repos\pruebanetcore\NetCore\WebApplication1\Views\Inventario\Index.cshtml"
WriteAttributeValue("", 229, Url.Action("CrearCliente","Home"), 229, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-outline-primary"">Cliente</a>
		</div>
	</div>
	<br />

	<div class=""d-flex flex-wrap flex-row"">

		<div class=""table-responsive"">

			<table class=""table table-bordered table-striped"" id=""tblinventario"">
				<thead>
					<tr>
						<th>codigo</th>
						<th>Descripcion</th>
						<th>Cant. Inicial</th>
						<th>Cant. Salida</th>
						<th>Stock</th>
						<th>Precio Venta</th>
						<th>Accion</th>
					</tr>

				</thead>
				<tbody></tbody>

			</table>

		</div>

	</div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
