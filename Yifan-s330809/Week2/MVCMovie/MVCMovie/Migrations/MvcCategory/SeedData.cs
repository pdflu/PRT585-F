﻿using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MVCMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Name = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Director = "Romantic Comedy",
                        Email = "7.99M"
                    },

                    new Movie
                    {
                        Name = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Director = "Comedy",
                        Email = "8.99M"
                    },

                    new Movie
                    {
                        Name = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Director = "Comedy",
                        Email = "9.99M"
                    },

                    new Movie
                    {
                        Name = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Director = "Western",
                        Email = "3.99M"
                    }
                );
                context.SaveChanges();
            }


            using (var context = new MvcCategoryContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcCategoryContext>>()))
            {
                // Look for any movies.
                if (context.Category.Any())
                {
                    return;   // DB has been seeded
                }

                context.Category.AddRange(
                    new Category
                    {
                        Name = "Comedy",
                        Code = "C01"

                    },

                    new Category
                    {
                        Name = "Action",
                        Code = "A01"

                    },

                    new Category
                    {
                        Name = "Drama",
                        Code = "D01"

                    },

                    new Category
                    {
                        Name = "Horror",
                        Code = "H01"

                    }

                );
                context.SaveChanges();
            }
        }
    }


}
