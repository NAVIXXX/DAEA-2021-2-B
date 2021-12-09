using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab12.Models;

namespace Lab12.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona
            {
                PersonaID = 1,
                Nombre = "Mortiz",
                Apellido = "Casas",
                Direccion = "Av. Grande 32133",
                FechaNacimiento = Convert.ToDateTime("1997-11-17"),
                Email = "casas@mail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 2,
                Nombre = "Carlos",
                Apellido = "Salas",
                Direccion = "Av. Proh 323",
                FechaNacimiento = Convert.ToDateTime("1998-11-21"),
                Email = "salas@mail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 3,
                Nombre = "Carlos",
                Apellido = "Martinelli",
                Direccion = "Av. NewEngland 111",
                FechaNacimiento = Convert.ToDateTime("1982-02-22"),
                Email = "martinelli@mail.com"
            });
            return View(personas);

        }
    }
}