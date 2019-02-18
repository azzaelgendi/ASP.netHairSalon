using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hair.Models;
using Microsoft.AspNetCore.Http;

namespace Hair.Controllers
{
    public class AppointmentDetailController : Controller
    {
        private readonly HairContext _context;

        public AppointmentDetailController(HairContext context)
        {
            _context = context;
        }

        // GET: AppointmentDetail
        public async Task<IActionResult> Index(string AppointmentId)
        {
            if (AppointmentId!=null)
            {
                HttpContext.Session.SetString(nameof(AppointmentId), AppointmentId.ToString());
            }
            else if (HttpContext.Session.GetString("AppointmentId")!=null)
            {
                AppointmentId = HttpContext.Session.GetString("AppointmentId");
            }
            else
            {
                TempData["message"] = "Please select appointement first to show the details";
                return RedirectToAction("Index", "Appointment");
            }

            var totalMinutes = _context.AppointmentDetail.Sum(a => a.ProcedureMinutes);
            ViewData["totalMinutes"] = totalMinutes.ToString();

            var hairContext = _context.AppointmentDetail.Include(a => a.Appointment)
                .Include(a => a.Product).Where(a=>a.AppointmentId==int.Parse(AppointmentId));
            return View(await hairContext.ToListAsync());
        }

        // GET: AppointmentDetail/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointmentDetail = await _context.AppointmentDetail
                .Include(a => a.Appointment)
                .Include(a => a.Product)
                .FirstOrDefaultAsync(m => m.AppointmentDetailId == id);
            if (appointmentDetail == null)
            {
                return NotFound();
            }

            return View(appointmentDetail);
        }

        // GET: AppointmentDetail/Create
        public IActionResult Create()
        {
            ViewData["AppointmentId"] = new SelectList(_context.Appointment, "AppointmentId", "AppointmentId");
            ViewData["ProductId"] = new SelectList(_context.Product, "ProductId", "Name");
            return View();
        }

        // POST: AppointmentDetail/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AppointmentDetailId,AppointmentId,ProductId,ProcedureMinutes,RetailPrice,Quantity,Discount,Total,Comments")] AppointmentDetail appointmentDetail)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(appointmentDetail);
                    await _context.SaveChangesAsync();
                    TempData["message"] = "Appointment Created";
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {

                TempData["message"] = "Create Failed" + ex.GetBaseException().Message;
            }
            ViewData["AppointmentId"] = new SelectList(_context.Appointment, "AppointmentId", "AppointmentId", appointmentDetail.AppointmentId);
            ViewData["ProductId"] = new SelectList(_context.Product, "ProductId", "Name", appointmentDetail.ProductId);
            return View(appointmentDetail);
        }

        // GET: AppointmentDetail/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointmentDetail = await _context.AppointmentDetail.FindAsync(id);
            if (appointmentDetail == null)
            {
                return NotFound();
            }
            ViewData["AppointmentId"] = new SelectList(_context.Appointment, "AppointmentId", "AppointmentId", appointmentDetail.AppointmentId);
            ViewData["ProductId"] = new SelectList(_context.Product, "ProductId", "Name", appointmentDetail.ProductId);
            return View(appointmentDetail);
        }

        // POST: AppointmentDetail/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AppointmentDetailId,AppointmentId,ProductId,ProcedureMinutes,RetailPrice,Quantity,Discount,Total,Comments")] AppointmentDetail appointmentDetail)
        {
            if (id != appointmentDetail.AppointmentDetailId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appointmentDetail);
                    await _context.SaveChangesAsync();
                    TempData["message"] = "Record Edited" ;
                }
                //catch (DbUpdateConcurrencyException)
                //{
                catch(Exception ex)
                { 
                    if (!AppointmentDetailExists(appointmentDetail.AppointmentDetailId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        TempData["message"] = "Edit Failed" + ex.GetBaseException().Message;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AppointmentId"] = new SelectList(_context.Appointment, "AppointmentId", "AppointmentId", appointmentDetail.AppointmentId);
            ViewData["ProductId"] = new SelectList(_context.Product, "ProductId", "Name", appointmentDetail.ProductId);
            return View(appointmentDetail);
        }

        // GET: AppointmentDetail/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointmentDetail = await _context.AppointmentDetail
                .Include(a => a.Appointment)
                .Include(a => a.Product)
                .FirstOrDefaultAsync(m => m.AppointmentDetailId == id);
            if (appointmentDetail == null)
            {
                return NotFound();
            }

            return View(appointmentDetail);
        }

        // POST: AppointmentDetail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var appointmentDetail = await _context.AppointmentDetail.FindAsync(id);
                _context.AppointmentDetail.Remove(appointmentDetail);
                await _context.SaveChangesAsync();
                TempData["message"] = "Deleted";
                
               
            }
            catch (Exception ex)
            {

                TempData["message"] = "Delete Failed" + ex.GetBaseException().Message;
            }
            return RedirectToAction(nameof(Index));
        }

        private bool AppointmentDetailExists(int id)
        {
            return _context.AppointmentDetail.Any(e => e.AppointmentDetailId == id);
        }
    }
}
