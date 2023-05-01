using E_G_FinalProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_G_FinalProject.Controllers
{
    public class PokemonController : Controller
    {
        private readonly PokeApiService _pokeApiService;

        public PokemonController(PokeApiService pokeApiService)
        {
            _pokeApiService = pokeApiService;
        }


        // GET: PokemonController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PokemonController/Details/5
        public async Task<ActionResult> DetailsAsync(int id)
        {
            var pokemon = await _pokeApiService.GetPokemon(id);
            return View(pokemon);
        }

        // GET: PokemonController/Create
        public async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: PokemonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PokemonController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            return View();
        }

        // POST: PokemonController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PokemonController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            return View();
        }

        // POST: PokemonController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
