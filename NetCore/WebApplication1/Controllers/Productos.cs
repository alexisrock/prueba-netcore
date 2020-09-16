using System;
using System.Collections.Generic;
using System.Linq;
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

    }
}
