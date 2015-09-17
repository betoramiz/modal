using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjemploModal.Models;

namespace EjemploModal.Controllers
{
    public class EmpleadoController : Controller
    {
        private List<Empleado> empleados;
        public EmpleadoController()
        {
            empleados = new List<Empleado>();
            empleados.Add(new Empleado() { Id = 1, Nombre="Hugo", Edad=10 });
            empleados.Add(new Empleado() { Id = 2, Nombre = "paco", Edad = 10 });
            empleados.Add(new Empleado() { Id = 3, Nombre = "Luis", Edad = 10 });
            empleados.Add(new Empleado() { Id = 4, Nombre = "Pepito", Edad = 10 });
        }

        public ActionResult Index()
        {
            return View(empleados);
        }

        [HttpGet]
        public JsonResult Eliminar(int id = 0)
        {
            Empleado empleado = empleados.Where(x => x.Id == id).FirstOrDefault();
            empleados.Remove(empleado);
            return Json(empleados, JsonRequestBehavior.AllowGet);
        }
    }
}