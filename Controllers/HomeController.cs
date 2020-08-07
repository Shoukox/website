using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication2.Data.Models;
using WebApplication2.Data.ViewModels;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public List<person> persons;
        public List<personcats> personscats;

        public HomeController()
        {
            personscats = new List<personcats>()
            {
                    new personcats
                    {
                        ezName = "Overwatch", desc = "ну пиздец", id=1,
                    },
                    new personcats
                    {
                        ezName = "CS", desc = "как быда", id = 2
                    },
                    new personcats
                    {
                        ezName = "Dota", desc = "god", id = 3
                    },
                    new personcats
                    {
                        ezName = "osu!", desc = "ну пиздец", id = 4
                    },
                    new personcats
                    {
                        ezName = "Paladins", desc = "как быда", id = 5
                    },
                    new personcats
                    {
                        ezName = "Apex", desc = "god", id = 6
                    }
            };
            persons = new List<person>()
            {
                new person { name = "Артём", desc = "гегедроп",  cats = getCatsPerson("CS, Dota, osu!"), img = "/img/b.jpg" },
                new person { name = "Никита", desc = "ахуеть 2 дня = 100пп", cats = getCatsPerson("CS, Dota, osu!"), img = "/img/a.jpg" },
                new person { name = "Эдгар", desc = "авирватчир", cats = getCatsPerson("Overwatch, Apex"), img = "/img/d.jpg" },
                new person { name = "Санжар", desc = "ez 300pp", cats = getCatsPerson("Paladins, Dota, osu!"), img = "/img/c.jpg" },
                new person { name = "Максим", desc = "утиный король", cats = getCatsPerson("Overwatch, Dota, Paladins"), img = "/img/f.jpg" },
                new person { name = "Шерзод", desc = "крысапьес", cats = getCatsPerson("Paladins, Dota"), img = "/img/g.jpg"},
                new person { name = "Шахзод", desc = "опа опа", cats = getCatsPerson("CS, Dota, osu!"), img = "/img/e.jpg" }
            };
        }
        public Info getCatsPerson(string text)
        {
            var info = new Info();
            if (text.Contains("Dota")) { info.dota = true; info.catString += "Dota, "; }
            if (text.Contains("CS")) {info.cs = true; info.catString += "CS, "; }
            if (text.Contains("osu!")) {info.osu = true; info.catString += "osu!, "; }
            if (text.Contains("Overwatch")) {info.overwatch = true; info.catString += "Overwatch, "; }
            if (text.Contains("Paladins")) {info.paladins = true; info.catString += "Paladins, ";}
            if (text.Contains("Apex")) {info.apex = true; info.catString += "Apex, ";
        }
            return info;
        }
        public ViewResult Index(string? catString)
        {
            ViewModel info;
            info = new ViewModel() { persons = persons, personCats = personscats, curCategory = new WebApplication2.Data.Models.personcats() { ezName = "Все" } };
            if (catString != null && catString != "Все")
            {
                info.curCategory = personscats.First(m => m.ezName.Contains(catString));
                switch (catString)
                {
                    case "Dota":
                        info.persons = persons.Where(m => m.cats.dota == true);
                        break;
                    case "Overwatch":
                        info.persons = persons.Where(m => m.cats.overwatch == true);
                        break;
                    case "osu!":
                        info.persons = persons.Where(m => m.cats.osu == true);
                        break;
                    case "Paladins":
                        info.persons = persons.Where(m => m.cats.paladins == true);
                        break;
                    case "CS":
                        info.persons = persons.Where(m => m.cats.cs == true);
                        break;
                    case "Apex":
                        info.persons = persons.Where(m => m.cats.apex == true);
                        break;
                }
                for (int i = 1; i <= info.personCats.Count() - 1; i++)
                {
                    if (info.personCats.ElementAt(i).ezName == catString)
                    {
                        var list = info.personCats.ToList();
                        var first = list[0];
                        list[0] = list[i];
                        list[i] = first;
                        info.personCats = list;
                        break;
                    }
                }
            }
            ViewBag.Title = "Главный сайт";
            return View(info);
        }
        public ViewResult About()
        {
            return View();
        }
    }

}
