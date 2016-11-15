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
    public class UsersController : Controller
    {
        private UserRepository _userRepository;
        private RoleRepository _roleRepository;
        private KoperasiDbContext _entities;
        public UsersController()
        {
            _entities = new KoperasiDbContext();
            _userRepository = new UserRepository(_entities);
            _roleRepository = new RoleRepository(_entities);
        }
        // GET: Users
        public ActionResult Index()
        {
           var query =  _userRepository.GetAllWithRoles();
            return View(query);
        }

        public ActionResult Create()
        {

            ViewBag.RoleId = new SelectList(_roleRepository.GetAll(), "Id", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Create(User u)
        {
            try { 
                _userRepository.Add(u);
                _userRepository.Save();

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ViewBag.RoleId = new SelectList(_roleRepository.GetAll(), "Id", "Name", u.RoleId);
                return View(u);
            }
        }
    }
}