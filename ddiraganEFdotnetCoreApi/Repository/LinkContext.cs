using Microsoft.EntityFrameworkCore;
using ddiraganEFdotnetCoreApi.Models;

namespace ddiraganEFdotnetCoreApi.Repository
{
    public class LinkContext :DbContext
    {

        public DbSet<Product>? Products { get; set; }

        public LinkContext(DbContextOptions<LinkContext> options)
         : base(options)
        {
        }



    }
}
