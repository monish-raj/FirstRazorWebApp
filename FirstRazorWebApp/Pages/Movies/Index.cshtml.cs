using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FirstRazorWebApp.Data;
using FirstRazorWebApp.Models;

namespace FirstRazorWebApp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly FirstRazorWebApp.Data.RazorPagesMovieContext _context;

        public IndexModel(FirstRazorWebApp.Data.RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
