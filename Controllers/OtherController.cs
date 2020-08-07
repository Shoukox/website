using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class OtherController : Controller
    {
        public IActionResult Calc(double? first, string? chr, double? second)
        {
            string answer = "";
            if(first != null && chr != null && second != null)
            {
                switch (chr)
                {
                    case "Сложение":
                        answer = $"{first} + {second} = {Convert.ToDouble(first) + Convert.ToDouble(second)}";
                        break;
                    case "Вычитание":
                        answer = $"{first} - {second} = {Convert.ToDouble(first) - Convert.ToDouble(second)}";
                        break;
                    case "Деление":
                        answer = $"{first} / {second} = {Convert.ToDouble(first) / Convert.ToDouble(second)}";
                        break;
                    case "Умножение":
                        answer = $"{first} * {second} = {Convert.ToDouble(first) * Convert.ToDouble(second)}";
                        break;
                    case "Степень":
                        answer = $"Число {first} в степени {second} равняется {Math.Pow(Convert.ToDouble(first), Convert.ToDouble(second))}";
                        break;
                    case "Корень":
                        answer = $"Число {first} в корне равняется: {Math.Sqrt(Convert.ToDouble(first))}";
                        break;
                }
                ViewBag.Answer = answer;
            }
            return View();
        }
    }
}
