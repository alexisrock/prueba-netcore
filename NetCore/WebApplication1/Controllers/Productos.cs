using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class Productos : Controller
    {
        private readonly pruebanetcoreContext db = new pruebanetcoreContext();


        public IActionResult Index()
        {
            return View();
        }
        

        public IActionResult CrearProducto() {

            return View();
        }

        [HttpPost]
        public IActionResult CrearProducto(Producto producto)
        {

            if (ModelState.IsValid)
            {

                using ( IDbContextTransaction tn = db.Database.BeginTransaction()) {

                    try
                    {
                        Producto productover = db.Producto.Where(x => x.Codigo == producto.Codigo).FirstOrDefault();

                        if (productover == null)
                        {
                            var estado = Request.Form["estadoproduct"];
                            producto.Estado = estado == "on" ? true : false;
                            db.Producto.Add(producto);
                            db.SaveChanges();
                            tn.Commit();

                            TempData["Mensaje"] = "Producto creado con exito";
                            ModelState.Clear();
                        }
                        else {
                            TempData["Mensaje_error"] =  "El codigo del producto ya existe";
                            tn.Rollback();
                        }

                    }
                    catch (Exception ex)
                    {

                        TempData["Mensaje_error"] = "Error en la transaccion: " + ex.Message;
                        tn.Rollback();


                    }
                
                
                }

            }

            return View();
        }

        public JsonResult GetProductos() {

            var datos = db.Producto.Select(x => new
            {
                x.Codigo,
                x.Descripcion,
                estado = x.Estado == true ? "Activo" : "Inactivo"
            }).ToList();

            return Json(datos);
        }

        public JsonResult EliminarProducto(string codigo) {

            Producto producto = db.Producto.Where(x => x.Codigo == codigo).FirstOrDefault();
            db.Producto.Remove(producto);
            db.SaveChanges();

            return Json(true);
        }

        public JsonResult GetProducto(string codigo) {

            var datos = db.Producto.Where(x=>x.Codigo==codigo).Select(x => new
            {
                x.Codigo,
                x.Descripcion,
                estado = x.Estado == true
            }).FirstOrDefault();

            return Json(datos);
        }

        [HttpPost]
        public IActionResult Index(Producto producto)
        {
            using (IDbContextTransaction tn = db.Database.BeginTransaction()) {
                try
                {
                    Producto productoedit = db.Producto.Where(x => x.Codigo == producto.Codigo).FirstOrDefault();
                    productoedit.Descripcion = producto.Descripcion;
                    var estado = Request.Form["editestado"];
                    productoedit.Estado = estado == "on" ? true : false;

                    db.Entry(productoedit).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    tn.Commit();
                }
                catch (Exception ex)
                {
                    tn.Rollback();
                    throw;
                }            

            }

            return View();
        }

    }
}



