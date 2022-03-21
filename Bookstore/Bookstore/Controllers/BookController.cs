using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore.Models;
using Bookstore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository= null;
          public BookController()
        {
            _bookRepository = new BookRepository();

        }
        
        public List<BookModel> getAllBooks()
        {
            return _bookRepository.getAllBooks();

        }

        public BookModel getBooks(int id)
        {
            return _bookRepository.getBooksByID(id);


        }

        public List<BookModel> searchBooks(string bookName, string author )
        {
            return _bookRepository.searchBooks(bookName, author);


        }
        public IActionResult Index()
        {
            return View();
        }
    }
}