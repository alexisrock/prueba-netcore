#pragma checksum "C:\Users\LENOVO TINY\source\repos\pruebanetcore\NetCore\WebApplication1\Views\Home\Clientes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "498f90f54c59110ba1c16e535aac5983572ad9b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Clientes), @"mvc.1.0.view", @"/Views/Home/Clientes.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"498f90f54c59110ba1c16e535aac5983572ad9b5", @"/Views/Home/Clientes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Clientes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/DataTables-1.10.21/js/jquery.dataTables.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/DataTables-1.10.21/js/dataTables.bootstrap4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Clientesjs.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\LENOVO TINY\source\repos\pruebanetcore\NetCore\WebApplication1\Views\Home\Clientes.cshtml"
  
	ViewData["Title"] = "Clientes";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Clientes</h1>\r\n\r\n<div class=\"container\">\r\n\r\n\t<br />\r\n\r\n\t<div class=\"d-flex flex-wrap flex-row\">\r\n\t\t<div class=\"flex-column\">\r\n\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 224, "\"", 265, 1);
#nullable restore
#line 15 "C:\Users\LENOVO TINY\source\repos\pruebanetcore\NetCore\WebApplication1\Views\Home\Clientes.cshtml"
WriteAttributeValue("", 231, Url.Action("CrearCliente","Home"), 231, 34, false);

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

			<table class=""table table-bordered table-striped"" id=""tblCliente"">
				<thead>
					<tr>
						<th>Documento</th>
						<th>Nombres</th>
						<th>Telefono</th>
						<th>Direccion</th>
						<th>Estado</th>
						<th>Accion</th>
					</tr>

				</thead>
				<tbody></tbody>

			</table>

		</div>

	</div>

</div>
");
#nullable restore
#line 45 "C:\Users\LENOVO TINY\source\repos\pruebanetcore\NetCore\WebApplication1\Views\Home\Clientes.cshtml"
 using (Html.BeginForm(null, null, FormMethod.Post, new { id = "formclienteedit" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"	<div class=""modal fade"" id=""ModalEditCliente"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
		<div class=""modal-dialog"">
			<div class=""modal-content"">
				<div class=""modal-header"">
					<h5 class=""modal-title"" id=""exampleModalLabel"">Editar Cliente</h5>
					<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
						<span aria-hidden=""true"">&times;</span>
					</button>
				</div>
				<div class=""modal-body"">


					<div class=""form-row"">

						<input id=""editid"" type=""hidden"" />

						<div class=""form-group col-sm-6"">
							<label for=""editDocumento"">Cedula</label>
							<input id=""editDocumento"" type=""text"" class=""form-control"" />
						</div>
						<div class=""form-group col-sm-6"">
							<label for=""editNombre"">Nombre</label>
							<input id=""editNombre"" type=""text"" class=""form-control"" />

						</div>


					</div>
					<div class=""form-row"">

						<div class=""form-group col-sm-6"">
							<label for=""editApellidos"">Ap");
            WriteLiteral(@"ellidos</label>
							<input id=""editApellidos"" type=""text"" class=""form-control"" />
						</div>
						<div class=""form-group col-sm-6"">
							<label for=""editTelefono"">Telefono</label>
							<input id=""editTelefono"" type=""number"" class=""form-control"" />
						</div>


					</div>
					<div class=""form-row"">

						<div class=""form-group col-sm-6"">
							<label for=""editDirecion"">Direccion</label>
							<input id=""editDirecion"" type=""text"" class=""form-control"" />
						</div>

					</div>
					<div class=""form-group "">
						<div class=""form-check"">
							<label for=""editestado"" class=""form-check-label"">Estado</label>
							<input id=""editestado"" type=""checkbox"" class=""form-check-input"" />

						</div>

					</div>


				</div>
				<div class=""modal-footer"">
					<button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cerrar</button>					
					<button class=""btn btn-primary"" onclick=""GuardarCliente()"">Guardar</button>
				</div>
			</div>
		</div>
	</div");
            WriteLiteral(">\r\n");
#nullable restore
#line 114 "C:\Users\LENOVO TINY\source\repos\pruebanetcore\NetCore\WebApplication1\Views\Home\Clientes.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "498f90f54c59110ba1c16e535aac5983572ad9b58787", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "498f90f54c59110ba1c16e535aac5983572ad9b59826", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "498f90f54c59110ba1c16e535aac5983572ad9b510865", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "498f90f54c59110ba1c16e535aac5983572ad9b511905", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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