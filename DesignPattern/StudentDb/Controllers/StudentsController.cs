using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StudentDb.Data;
using StudentDb.Models;
using StudentDb.DAL;
using Microsoft.Ajax.Utilities;

namespace StudentDb.Controllers
{
    public class StudentsController : Controller
    {
        //private StudentDbContext db = new StudentDbContext();
        private UnitOfWork _unitOfWork = new UnitOfWork();

        // GET: Students
        public ActionResult Index()
        {          
            var _student = _unitOfWork.GetRepositoryInstance<Student>().Get();
            //return View(await db.Students.ToListAsync());
            return View(_student);
        }

        // GET: Students/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var _student = _unitOfWork.GetRepositoryInstance<Student>().GetById(id);
            return View(_student);
        }

        // GET: Students/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for         
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentId,Name,Year")] Student student)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.GetRepositoryInstance<Student>().Insert(student);
                _unitOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: Students/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var _student = _unitOfWork.GetRepositoryInstance<Student>().GetById(id);
            if (_student == null)
            {
                return HttpNotFound();
            }
            return View(_student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for         
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentId,Name,Year")] Student student)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.GetRepositoryInstance<Student>().Update(student);
                _unitOfWork.SaveChanges();                
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: Students/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            _unitOfWork.GetRepositoryInstance<Student>().Delete(id);
            _unitOfWork.SaveChanges();
            return RedirectToAction("Index");
        }
                
    }
}
