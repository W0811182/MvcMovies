using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovies.Data;
using System;
using System.Linq;

namespace MvcMovies.Models;

public static class seedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMoviesContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMoviesContext>>()))
        {
            if (context.Movie.Any())
            {
                return;
            }
            context.Movie.AddRange(
                new Movie
                {
                    Id = "1",
                    Title = "Everything Everywhere All At Once",
                    ReleaseDate = DateTime.Parse("2022-03-11"),
                    Genre = "Comedy",
                    Price = 9.99M
                },
                new Movie
                {
                    Id = "2",
                    Title = "The Father",
                    ReleaseDate = DateTime.Parse("2021-01-27"),
                    Genre = "Psychological Drama",
                    Price = 9.99M
                },
                new Movie
                {
                    Id = "3",
                    Title = "There Will Be Blood",
                    ReleaseDate = DateTime.Parse("2007-09-27"),
                    Genre = "Period Drama",
                    Price = 9.99M
                },
                new Movie
                {
                    Id = "4",
                    Title = "Whiplash",
                    ReleaseDate = DateTime.Parse("2014-01-16"),
                    Genre = "Music Drama",
                    Price = 9.99M
                },
                new Movie
                {
                    Id = "5",
                    Title = "La La Land",
                    ReleaseDate = DateTime.Parse("2016-08-31"),
                    Genre = "Romantic Comedy",
                    Price = 9.99M
                }
            );
            context.SaveChanges();
        }
    }
}
