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
        public List<debils> debils;
        public List<debilscats> debilscat;

        public HomeController()
        {
            debilscat = new List<debilscats>()
            {
                    new debilscats
                    {
                        ezName = "Отбитые", desc = "ну пиздец", id = 1
                    },
                    new debilscats
                    {
                        ezName = "Вроде норм", desc = "как быда", id = 2
                    },
                    new debilscats
                    {
                        ezName = "абсолютный боженькоыы", desc = "god", id = 3
                    }
            };
            debils = new List<debils>()
            {
                new debils { name = "Артём", desc = "гегедроп", isCockold = true, cat = debilscat.First(m=>m.ezName == "Отбитые"), img = "/img/b.jpg" },
                new debils { name = "Никита", desc = "ахуеть 2 дня = 100пп", isCockold = true, cat = debilscat.First(m=>m.ezName == "Отбитые"), img = "/img/a.jpg" },
                new debils { name = "Эдгар", desc = "авирватчир", isCockold = false, cat = debilscat.First(m=>m.ezName == "Вроде норм"), img = "/img/d.jpg" },
                new debils { name = "Санжар", desc = "ez 300pp", isCockold = false, cat = debilscat.First(m=>m.ezName == "Вроде норм"), img = "/img/c.jpg" },
                new debils { name = "Shoukko", desc = "опа опа", isCockold = false, cat = debilscat.First(m=>m.ezName == "абсолютный боженькоыы"), img = "/img/e.jpg" }
            };
        }
        public ViewResult Index(int? catId)
        {
            ViewModel info;
            info = new ViewModel() { debils = debils, debilsCategories = debilscat, curCategory = new WebApplication2.Data.Models.debilscats() {ezName = "Все"} };
            if (catId != 0 && catId != null)
            {
                info.curCategory = debilscat.First(m => m.id == catId);
                info.debils = debils.Where(m => m.cat.id == catId);
                for(int i = 1; i <= info.debilsCategories.Count() - 1; i++)
                {
                    if(info.debilsCategories.ElementAt(i).id == catId)
                    {
                        var list = info.debilsCategories.ToList();
                        var first = list[0];
                        list[0] = list[i];
                        list[i] = first;
                        info.debilsCategories = list;
                        break;
                    }
                }
            }
            ViewBag.Title = "Главный сайт";
            return View(info);
        }
    }

}
