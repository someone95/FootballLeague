using Common.Entities;
using DataAccess.Repositories;
using PhonebookNET.ViewModels.Footballers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhonebookNET.Controllers
{
    public class FootballersController : Controller
    {
        private FootballersRepository footballersRepository;
        private TeamsRepository teamsRepository;

        public FootballersController()
        {
            footballersRepository = new FootballersRepository();
            teamsRepository = new TeamsRepository();
        }
        // GET: Footballers
        [HttpGet]
        public ActionResult Index(FootballersIndexVM model)
        {
            model.Footballers = footballersRepository.GetAll();
            model.Teams = teamsRepository.GetAll();
            return View(model);
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            FootballersEditVM model = new FootballersEditVM();
            Footballer item = new Footballer();
            model.Teams = teamsRepository.GetAll();
            if (id != null)
            {
                item = footballersRepository.GetById(id.Value);
                model.Username = item.Username;
                model.Password = item.Password;
                model.FirstName = item.FirstName;
                model.LastName = item.LastName;
                model.TeamId = item.TeamId;
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(FootballersEditVM model)
        {
            Footballer item = new Footballer();
            if (model.Id > 0)
            {
                item = footballersRepository.GetById(model.Id);
            }
            item.FirstName = model.FirstName;
            item.LastName = model.LastName;
            item.Username = model.Username;
            item.Password = model.Password;
            item.Goals = model.Goals;
            item.Assists = model.Assists;
            item.TeamId = model.TeamId;
            item.IsReferee = model.IsReferee;
            footballersRepository.Save(item);
            return RedirectToAction("Index", "Footballers");
        }
        [HttpPost]
        public void Delete(int id)
        {
            if (id > 0)
            {
                Footballer footballer = footballersRepository.GetById(id);
                footballersRepository.Delete(footballer);
            }
        }
    }
}