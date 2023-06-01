using System;
using System.Linq;

public class ProductRepository
{
    private readonly EcommerceDbContext _dbContext;

    public ProductRepository(EcommerceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Create(Product product)

    {
        _dbContext.Products.Add(product);
        _dbContext.SaveChanges();
    }

    public Product GetById(int productId)

    {
        return _dbContext.Products.FirstOrDefault(p => p.Id == productId);
    }

    public void Update(Product product)
    {
        _dbContext.Products.Update(product);
        _dbContext.SaveChanges();
    }

    public void Delete(Product product)
    {
        _dbContext.Products.Remove(product);
        _dbContext.SaveChanges();
    }
}
