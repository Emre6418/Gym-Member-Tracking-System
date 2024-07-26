using Gym_Member_Tracking_System.Data;
using Gym_Member_Tracking_System.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Gym_Member_Tracking_System.Controllers
{
    public class AdminPanelController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminPanelController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var data = _context.Member.ToList();
            return View(data);
        }

        //GET CREATE
        public IActionResult Create() 
        { 
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Members member)
        {
            if (member != null)
            {
                _context.Member.Add(member);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(member);
        }

        public async Task<IActionResult> Edit(int id) 
        {
            var data = await _context.Member.FindAsync(id); 
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Members member) 
        {
            if (member != null)
            {
                _context.Member.Update(member);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(member);
        }


        public async Task<IActionResult> Delete(int id) 
        {
            var data = await _context.Member.FindAsync(id);
            return View(data);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var data = await _context.Member.FindAsync(id);
            if (data != null)
            {
                _context.Member.Remove(data);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }



    }
}
