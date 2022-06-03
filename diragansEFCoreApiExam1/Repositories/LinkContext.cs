using Microsoft.EntityFrameworkCore;
using diragansEFCoreApiExam1.Models;


namespace diragansEFCoreApiExam1.Repository
{
    public class LinkContext : DbContext
    {

        public LinkContext(DbContextOptions<LinkContext> options) 
            : base(options)
        {
        }

        //Setting Entity Set
        public DbSet<Product> Products { get; set; }
 
       
 
 
    }
}
