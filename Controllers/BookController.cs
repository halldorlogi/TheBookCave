using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheBookCave.Models;
using TheBookCave.Services;

namespace TheBookCave.Controllers
{
    public class BookController : Controller
    {
        private BookService _bookService;
        public IActionResult Index()
        {
            var books = _bookService.GetAllBooks();

            return View(books);
        }
        public BookController()
        {
            _bookService = new BookService();
        }
    }
}