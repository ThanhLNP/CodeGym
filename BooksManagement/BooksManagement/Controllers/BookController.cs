using BooksManagement.DAL;
using BooksManagement.Models;
using BooksManagement.Models.Book.Request;
using BooksManagement.Models.Category.Response;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace BooksManagement.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = new BookRepository();
        private readonly CategoryRepository _categoryRepository = new CategoryRepository();

        private IList<CategoryList> GetCategoryList()
        {
            return _categoryRepository.GetCategoryList();
        }

        private List<string> GetSearchList()
        {
            List<string> SearchList = new List<string>()
            {
                "All",
                "Name",
                "Categories",
                "Author",
                "Year of publication",
                "Amount"
            };
            return SearchList;
        }

        [HttpGet]
        public IActionResult BooksList()
        {
            ViewBag.SearchList = GetSearchList();
            return View(_bookRepository.GetBooksList());
        }

        [HttpGet]
        public IActionResult Book(GetBook model)
        {
            return View(_bookRepository.GetBook(model));
        }

        [HttpGet]
        public IActionResult AddBook()
        {
            ViewBag.Categories = GetCategoryList();
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(AddBook model)
        {
            var createResult = _bookRepository.AddBook(model);

            if (ModelState.IsValid)
            {
                if (createResult > 0)
                {
                    TempData["Success"] = "Book has been added success";
                }
                else
                {
                    TempData["Error"] = "Something went wrong, please try again later";
                }
            }
            ModelState.Clear();
            ViewBag.Categories = GetCategoryList();
            return View(new AddBook());
        }

        [HttpGet]
        public IActionResult DeleteBook(DeleteBook model)
        {
            _bookRepository.DeleteBook(model);
            return RedirectToAction("BooksList", "Book");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult BookSearch(BookSearch model)
        {
            ViewBag.SearchList = GetSearchList();
            return View(_bookRepository.BookSearch(model));
        }
    }
}
