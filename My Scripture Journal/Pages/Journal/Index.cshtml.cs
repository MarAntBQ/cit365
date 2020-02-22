using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using My_Scripture_Journal.Data;
using My_Scripture_Journal.Models;

namespace My_Scripture_Journal
{
    public class IndexModel : PageModel
    {
        private readonly My_Scripture_Journal.Data.My_Scripture_JournalContext _context;

        public IndexModel(My_Scripture_Journal.Data.My_Scripture_JournalContext context)
        {
            _context = context;
        }
        public string BookSort { get; set; }
        public string DateSort { get; set; }


        public IList<Scripture> Scripture { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Book { get; set; }
        [BindProperty(SupportsGet = true)]
        public string BookName { get; set; }
        [BindProperty(SupportsGet = true)]
        public string NoteSearch { get; set; }
        public async Task OnGetAsync(string sortOrder)
        {
            BookSort = sortOrder == "book_asc" ? "book_desc" : "book_asc";
            DateSort = sortOrder == "date_asc" ? "date_desc" : "date_asc";

            // Use LINQ 

            IQueryable<string> bookQuery = from m in _context.Scripture
                                           select m.Book;

            var scriptures = from m in _context.Scripture
                             select m;
            switch (sortOrder)
            {
                case "book_desc":
                    scriptures = scriptures.OrderByDescending(s => s.Book);
                    break;
                case "date_asc":
                    scriptures = scriptures.OrderBy(s => s.AddedDate);
                    break;
                case "date_desc":
                    scriptures = scriptures.OrderByDescending(s => s.AddedDate);
                    break;
                default:
                    scriptures = scriptures.OrderBy(s => s.Book);
                    break;
            }


            Scripture = await scriptures.AsNoTracking().ToListAsync();


            var note = from n in _context.Scripture select n;



            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.Book.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(NoteSearch))
            {
                scriptures = scriptures.Where(s => s.Note.Contains(NoteSearch));
            }
            //Scripture = await _context.Scripture.ToListAsync();

            if (!string.IsNullOrEmpty(BookName))
            {
                scriptures = scriptures.Where(x => x.Book == BookName);
            }
            Book = new SelectList(await bookQuery.Distinct().ToListAsync());

            Scripture = await scriptures.ToListAsync();
            /*
            public string BookSort { get; set; }
            public string DateSort { get; set; }
            public IList<Scripture> Scripture { get;set; }
            [BindProperty(SupportsGet = true)]
            public string SearchString { get; set; }

            public SelectList Book { get; set; }
            [BindProperty(SupportsGet = true)]
            public string BookName { get; set; }
            public async Task OnGetAsync()
            {

                IQueryable<string> bookQuery = from m in _context.Scripture
                                                orderby m.Book
                                                select m.Book;
                var notes = from m in _context.Scripture
                             select m;
                if (!string.IsNullOrEmpty(SearchString))
                {
                    notes = notes.Where(s => s.Note.Contains(SearchString));
                }
                if (!string.IsNullOrEmpty(BookName))
                {
                    notes = notes.Where(x => x.Book == BookName);
                }

                Book = new SelectList(await bookQuery.Distinct().ToListAsync());
                Scripture = await notes.ToListAsync();*/
        }
    }
}
