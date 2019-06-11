using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Sedc.Todo.WebApp.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            var todos = new List<string>
            {
                "Todo1",
                "Todo2",
                "Todo3",
                "Todo4",
                "Todo5"
            };

            return View(todos);
        }
    }
}