#pragma checksum "C:\Users\LENOVO TINY\source\repos\pruebanetcore\NetCore\WebApplication1\Views\Facturacion\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1212cfc5d0b73a96df221f2d680c4eb45958e31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Facturacion_Index), @"mvc.1.0.view", @"/Views/Facturacion/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1212cfc5d0b73a96df221f2d680c4eb45958e31", @"/Views/Facturacion/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Facturacion_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\LENOVO TINY\source\repos\pruebanetcore\NetCore\WebApplication1\Views\Facturacion\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n\r\n<div class=\"row\">\r\n\r\n\t<div class=\"col-md-4\">\r\n\t\t<a");
            BeginWriteAttribute("href", " href=\"", 162, "\"", 210, 1);
#nullable restore
#line 13 "C:\Users\LENOVO TINY\source\repos\pruebanetcore\NetCore\WebApplication1\Views\Facturacion\Index.cshtml"
WriteAttributeValue("", 169, Url.Action("CrearFactura","Facturacion"), 169, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-outline-primary"">Facturar</a>
	</div>

</div>

<div class=""container"">
	<table class=""table table-responsive table-bordered table-striped"" >
		<thead>
			<tr>
				<td>Num. Factura</td>
				<td>Clilente</td>
				<td>Valor Total</td>
				<td>Accion</td>
			</tr>
		</thead>
		<tbody>	</tbody>
	</table>


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
