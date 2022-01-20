using CodeFirstCrud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstCrud.Controllers
{
    public class StudentsController : Controller
    {
        private DatabaseContext Context;

        public StudentsController(DatabaseContext common)
        {
            Context = common;

        }
        public async Task<IActionResult> Index()
        {
            return View(await Context.tbl_Student.ToListAsync());
        }
        //Get Method code
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Student());
            else
                return View(Context.tbl_Student.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(Student student)
        {
            if (ModelState.IsValid)
            {
                if (student.Id ==0)                
                    Context.Add(student);              
                else                 
                    Context.Update(student);
                await Context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(student);
        }
        //Delete method
        public async Task<IActionResult> Delete(int? id)
        {
            var employee = await Context.tbl_Student.FindAsync(id);
            Context.tbl_Student.Remove(employee);
            await Context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



    }
}
