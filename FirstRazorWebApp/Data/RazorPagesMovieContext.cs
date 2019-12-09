using System;
using Microsoft.EntityFrameworkCore;

namespace FirstRazorWebApp.Data
{
    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext(DbContextOptions<RazorPagesMovieContext> options) : base(options)
        {
        }

        public DbSet<FirstRazorWebApp.Models.Movie> Movie { get; set; }
    }
}
