using Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Repository
{
    public class BookRepository
    {
        public List<BookModel> getAllBooks()
        {
            return DataSource();

        }
        public BookModel getBooksByID(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();


        }

        public List<BookModel> searchBooks(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains( title) && x.Author.Contains(authorName)).ToList();


        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1, Title="MVC",Author="Akshat"},
                new BookModel(){Id=2, Title="Java",Author="Suman"},
                new BookModel(){ Id = 3, Title = ".NET", Author = "Sushil" },
                new BookModel(){ Id =4 , Title = "Web services", Author = "Rakesh" }

            };  
        }
    }

}
