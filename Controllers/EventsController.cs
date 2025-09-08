using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models.EventEntity;

namespace WebApplication1.Controllers
{
    public class EventsController : Controller
    {
        private readonly StudentContext _context;

        public EventsController(StudentContext context)
        {
            _context = context;
        }

        // List all events
        public async Task<IActionResult> List()
        {
            var eventsList = await _context.Events.ToListAsync();
            return View(eventsList);
        }

        // Create event
        [HttpGet]
        public IActionResult Add() => View();

        [HttpPost]
        public async Task<IActionResult> Add(Event newEvent)
        {
            if (ModelState.IsValid)
            {
                _context.Events.Add(newEvent);
                await _context.SaveChangesAsync();
                return RedirectToAction("List");
            }
            return View(newEvent);
        }

        // Edit event
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var ev = await _context.Events.FindAsync(id);
            return ev == null ? NotFound() : View(ev);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Event ev)
        {
            _context.Events.Update(ev);
            await _context.SaveChangesAsync();
            return RedirectToAction("List");
        }

        // Delete event
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ev = await _context.Events.FindAsync(id);
            if (ev != null)
            {
                _context.Events.Remove(ev);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("List");
        }

        // Calendar view
        public async Task<IActionResult> Calendar()
        {
            var eventsList = await _context.Events.ToListAsync();
            return View(eventsList);
        }
    }
}
