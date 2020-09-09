using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{

    public class HomeController : Controller
    {

        private readonly pruebanetcoreContext context = new pruebanetcoreContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult CrearCliente() {

            return View();
        }

        [HttpPost]
        public IActionResult CrearCliente(Cliente cliente)
        {
            using (IDbContextTransaction   tn =  context.Database.BeginTransaction()) {
                if (ModelState.IsValid != false)
                {
                    context.Cliente.Add(cliente);
                    context.SaveChanges();
                    tn.Commit();
                    ModelState.Clear();
                    TempData["Mensaje"] = "Cliente creado con exito";
                }
                else {
                    tn.Rollback();
                    TempData["Mensaje_error"] = "Datos incorrectos";
                }

            }


            return View();
        }


        public IActionResult Clientes()
       {
            return View();
        }


        public JsonResult GetClientes() {

            var clientes = context.Cliente.ToList();

            var ListaClientes = clientes.Select(x => new {
                id = x.Id,
                documento = x.Documento != null ? x.Documento : "",
                Cliente = x.Nombre != null ? x.Nombre + " " + x.Apellidos : "",
                telefono = x.Telefono != null ? x.Telefono : "",
                direccion = x.Direccion != null ? x.Direccion : "",
                estado = x.Estado == true ? "Activo" : "Inactivo"
            }).ToList();

            return Json(ListaClientes);
        }

        public JsonResult EliminarCliente(int id) {

            Cliente cliente = context.Cliente.Where(x => x.Id == id).FirstOrDefault();
            if (cliente!=null) {
                context.Cliente.Remove(cliente);
                context.SaveChanges();
            }
            return Json(true);
        }

        public JsonResult Getcliente(int id) {

            var cliente = context.Cliente.Where(x => x.Id == id).Select(x=>new { 
            x.Apellidos,
            x.Direccion,
            x.Documento,
            x.Estado,
            x.Id,
            x.Nombre,
            x.Telefono
            
            }).FirstOrDefault();

            if (cliente != null)
            {


                return Json(cliente);
            }
            else {
                return Json(false);
            }
      
         }


    }
}
