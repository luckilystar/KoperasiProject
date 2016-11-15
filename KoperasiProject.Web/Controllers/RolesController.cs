using KoperasiProject.Domain.Users;
using KoperasiProject.EntityFramework;
using KoperasiProject.Repository.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KoperasiProject.Web.Controllers
{
    public class RolesController : Controller
    {
        private RoleRepository _roleRepository;

        public RolesController()
        {
            _roleRepository = new RoleRepository(new KoperasiDbContext());
        }
        // GET: Roles
        public ActionResult Index()
        {
            var query = _roleRepository.GetAll();
            return View(query);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Role r)
        {
            try
            {
                _roleRepository.Add(r);
                _roleRepository.Save();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(r);
            }

        }
    }

}