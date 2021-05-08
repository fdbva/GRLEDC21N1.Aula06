using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Aula06.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aula06.Controllers
{
    public class StringController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Concat(StringInputModel stringInputModel)
        {
            var result = stringInputModel.Left + stringInputModel.Right;
            stringInputModel.Result = result;

            return View("Index", stringInputModel);
        }

        [HttpPost]
        public IActionResult Compare(StringInputModel stringInputModel)
        {
            var result = string.Equals(stringInputModel.Left, stringInputModel.Right, StringComparison.OrdinalIgnoreCase);

            stringInputModel.Result = result.ToString();

            return View("Index", stringInputModel);
        }
    }
}
