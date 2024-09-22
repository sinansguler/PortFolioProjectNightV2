using PortFolioProjectNightV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortFolioProjectNightV2.Controllers
{
    public class SkillController : Controller
    {
        DbNyPortfolioNightEntities context = new DbNyPortfolioNightEntities();
        public ActionResult SkillList()
        {
            var values = context.Skill.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSkill(Skill skill)
        {
            context.Skill.Add(skill);
            context.SaveChanges();
            return RedirectToAction("Skilllist");
        }

        public ActionResult DeleteSkill(int id)
        {
            var value = context.Skill.Find(id);
            context.Skill.Remove(value);
            context.SaveChanges();
            return RedirectToAction("SkillList");


        }



        public ActionResult UpdateSkill(int id)
        {
            var value = context.Skill.Find(id);
            return View(value);
        }
    }
}