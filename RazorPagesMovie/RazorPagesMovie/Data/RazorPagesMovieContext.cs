using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Data;

public class RazorPagesMovieContext : DbContext
{
    public RazorPagesMovieContext(DbContextOptions<RazorPagesMovieContext> options)
        : base(options)
    {
    }

    public DbSet<Movie> Movie => Set<Movie>();
}