using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Q20240408.EntidadesDeNegocio;
using Q20240408.LogicaDeNegocio;

namespace Q20240408.UI.AppWebMVC.Controllers
{
    public class PersonaController : Controller
    {

        readonly PersonaQBL _personaQBL;
        public PersonaController(PersonaQBL personaQBL)
        {
            _personaQBL = personaQBL;
        }

        // GET: PersonaController
        public async Task<ActionResult> Index(PersonaQ personaQ)
        {
            var persona = await _personaQBL.Buscar(personaQ);
            return View(persona);
        }

        // GET: PersonaController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var clientes = await _personaQBL.ObtenerPoId(new PersonaQ { Id = id });
            return View(clientes);
        }

        // GET: PersonaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PersonaQ personaQ)
        {
            try
            {
                await _personaQBL.Crear(personaQ);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var persona = await _personaQBL.ObtenerPoId(new PersonaQ { Id = id });
            return View(persona);
        }

        // POST: PersonaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(PersonaQ personaQ)
        {
            try
            {
                await _personaQBL.Modificar(personaQ);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // GET: PersonaController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var clientes = await _personaQBL.ObtenerPoId(new PersonaQ { Id = id });
            return View(clientes);
        }

        // POST: PersonaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, PersonaQ personaQ)
        {
            try
            {
                await _personaQBL.Eliminar(personaQ);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

