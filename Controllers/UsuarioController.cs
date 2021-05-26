using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Data;
using ProyectoFinal.Models;

namespace ProyectoFinal.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly SpContext _context;

        public UsuarioController(SpContext context)
        {
            _context = context;
        }
         public async Task<IActionResult> Create([Bind("IdUsuario,Tipo,Nombre,Apellido,Correo,Password,Direccion,Telefono")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }
    }
}