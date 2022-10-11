using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Posts.Any()) 
            {
                var Posts = new List<Post>
                {
                    new Post {
                        Title = "First Post",
                        Body = "",
                        Date = DateTime.Now.AddDays(-10)
                    },
                    new Post {
                        Title = "Second Post",
                        Body = "",
                        Date = DateTime.Now.AddDays(-7)
                    },
                    new Post {
                        Title = "Third Post",
                        Body = "",
                        Date = DateTime.Now.AddDays(-4)
                    }
                };

                context.Posts.AddRange(Posts);
                context.SaveChanges();
            }
        }
    }
}