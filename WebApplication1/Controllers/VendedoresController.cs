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
    public class  VendedoresController : Controller
    {
        private readonly pruebanetcoreContext context = new pruebanetcoreContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CrearVendedor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CrearVendedor(Vendedor vendedor)
        {

            using (IDbContextTransaction tn = context.Database.BeginTransaction())
            {
                if (ModelState.IsValid != false)
                {
                    context.Vendedor.Add(vendedor);
                    context.SaveChanges();
                    tn.Commit();
                    ModelState.Clear();
                    TempData["Mensaje"] = "Vendedor creado con exito";
                }
                else
                {
                    tn.Rollback();
                    TempData["Mensaje_error"] = "Datos incorrectos";
                }

            }
            return View();
        }


        public JsonResult GetVendedores(){

            var vendedores = context.Vendedor.Select(x => new
            {
                cargo = x.Cargo != null ? x.Cargo : "",
                vendedores = x.Nombres != null ? x.Nombres : "",
                estado = x.Estado == true ? "Activo" : "Inactivo",
                x.Id
            }).ToList();



            return Json(vendedores);
        }


        public JsonResult EliminarVendedor(int id)
        {

            Vendedor vendedor = context.Vendedor.Where(x => x.Id == id).FirstOrDefault();
            if (vendedor != null)
            {
                context.Vendedor.Remove(vendedor);
                context.SaveChanges();
            }
            return Json(true);
        }

        public JsonResult GetVendedor(int id) {

            var vendedores = context.Vendedor.Where(x=>x.Id==id).Select(x => new
            {
                cargo = x.Cargo != null ? x.Cargo : "",
                vendedores = x.Nombres != null ? x.Nombres : "",
                x.Estado ,
                x.Id
            }).FirstOrDefault();



            return Json(vendedores);
        }


        public JsonResult GuardarInfoVendedor(int id, string nombre, string cargo, bool estado) {


            Vendedor vendedor = context.Vendedor.Where(x => x.Id == id).FirstOrDefault();
            if (vendedor!= null)
            {
                vendedor.Nombres = nombre;
                vendedor.Cargo = cargo;
                vendedor.Estado = estado;
                context.Entry(vendedor).State = EntityState.Modified;
                context.SaveChanges();

            }
            return Json(true);
        }




    }
}
