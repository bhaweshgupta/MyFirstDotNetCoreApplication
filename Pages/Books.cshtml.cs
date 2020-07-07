using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyFirstDotNetCoreApplication.Models;

namespace MyFirstDotNetCoreApplication.Pages
{
    public class BooksModel : PageModel
    {
        private readonly ApplicationDBcontext _db;


        // dBcontext is coming using dependecy injection
        //if no depedncy injection then we need to create object and then dispose it
        public BooksModel(ApplicationDBcontext dBcontext)
        {
            _db = dBcontext;
        }

        public IEnumerable<Book> Books { get; set; }

        public async Task OnGet()
        {
            Books =  await _db.Book.ToListAsync();
        }

    }
}