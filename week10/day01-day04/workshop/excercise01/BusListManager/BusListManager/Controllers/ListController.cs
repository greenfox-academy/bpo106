﻿using Microsoft.AspNetCore.Mvc;
using BusListManager.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BusListManager.Controllers
{
    public class ListController : Controller
    {
        ListRepository listRepository;

        public ListController(ListRepository listRepository)
        {
            this.listRepository = listRepository;
        }

        [Route("/")]
        [Route("/list")]
        public IActionResult List()
        {
            return View();
        }
    }
}