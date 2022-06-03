using diragansEFCoreApiExam1.Models;

namespace diragansEFCoreApiExam1.Repository
{
    public class ProductRepository : IProductRepository
    {
        public LinkContext _linkContext;
        public ProductRepository(LinkContext linkContext)
        {

            _linkContext = linkContext;

        }

        public Product GetProductByID(int ID)
        {
            return _linkContext.Products.FirstOrDefault(x => x.ProductID == ID);
        }

        public List<Product> GetAllProduct()
        {

            return _linkContext.Products.ToList();
        }


        public Product AddProduct(Product p)
        {
            _linkContext.Products.Add(p);
            _linkContext.SaveChanges();
            return p;
            
        }
    

        public Product UpdateProduct(Product p)
        {
            _linkContext.Products.Update(p);
            _linkContext.SaveChanges();
            return p;

        }

        public void DeleteProduct(int ID)
        {
            var product = _linkContext.Products.FirstOrDefault(x => x.ProductID == ID);
            if (product != null)
            {
                _linkContext.Remove(product);
                _linkContext.SaveChanges();
            }
        }
 
    }
}
