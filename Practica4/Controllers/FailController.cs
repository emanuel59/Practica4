using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practica4.Models;
using Practica4.Data;

namespace Practica4.Controllers
{
    public class FailController : Controller
    {

        private readonly DatabaseContext _context;

        private readonly ILogger<HomeController> _logger;

        public FailController(ILogger<HomeController> logger,
            DatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        //Descendiente Mayor a Menor
        //Ascendiente Menor a Mayor
        /*public IActionResult Index()
        {
                                                 //Expresion   
            var listContactos=_context.Fail.OrderBy(s => s.Fecha).ToList();
            return View("List",listContactos);

        }*/

        public IActionResult Foto()
        {
            return View();
        }


        [HttpPost]
        public  IActionResult Foto(Fail objFail){

            if (ModelState.IsValid)
            {
                 objFail.Mensajes = "El Mensaje se ha registrado ";

                _context.Add(objFail);
                _context.SaveChanges();

                 return View(objFail);   
            }
            return View();
        }

        // GET: http://localhost:5000/Contacto/Edit/6 MUESTRA Contacto
        /*public IActionResult Edit(int? id)
        {
            if(id == null){
                return NotFound();
            }
            var contacto = _context.Contactos.Find(id);
            if(contacto == null){
                return NotFound();
            }
            return View(contacto);
        }

        //POST: http://localhost:5000/Contacto/Edit/ graba contacto
        [HttpPost]
        public IActionResult Edit(int id, Contacto contacto)
        {
            if (ModelState.IsValid)
            {
                _context.Update(contacto);
                _context.SaveChanges();
            }
            return View(contacto);
        }


        // GET: http://localhost:5000/Contacto/Delete/6 MUESTRA Contacto
        public IActionResult Delete(int? id)
        {
            var contacto = _context.Contactos.Find(id);
            _context.Contactos.Remove(contacto);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

         public IActionResult Buscar(string texto)
        {
            var textoABuscar = texto.ToUpper();

            var listCliente=_context.Contactos.Where(x => x.FirstName.ToUpper().IndexOf(textoABuscar)>=0);
            
            listCliente = listCliente.OrderBy(s => s.ID);
                  
            return View("ListaCLiente",listCliente);

        }*/
    }
}
