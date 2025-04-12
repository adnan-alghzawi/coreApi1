using coreApi1.Server.IDataService;
using coreApi1.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace coreApi1.Server.DataService
{
    public class DataService : IDataServicecs
    {
        private readonly MyDbContext _context;
        public DataService(MyDbContext db)
        {
            _context = db;
        }

        public List<Category> getCategories()
        {
            return _context.Categories.ToList();
        }

        public Category getCategoryById(int id)
        {
            return _context.Categories.FirstOrDefault(c => c.CategoryId == id);
        }

        public List<Category> getCategoryByName(string name)
        {
            return _context.Categories
                .Where(c => c.CategoryName == name)
                .ToList();
        }

        public bool deleteCategory(int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.CategoryId == id);
            if (category == null)
                return false;

            _context.Categories.Remove(category);
            _context.SaveChanges();
            return true;
        }
        public List<Product> getProducts()
        {
            return _context.Products.ToList();
             
        }
        public Product getProductById(int id)
        {
            var product = _context.Products.FirstOrDefault(c => c.ProductId == id);
            if (product == null)
            {
                return null;
            }
            return product;
        }
        public List<Product> getProductByName(string name)
        {
            var products = _context.Products.Where(c => c.ProductName == name).ToList();
            if (products == null)
            {
                return null;
            }
            return products;
        }
        public bool deleteProduct(int id)
        {


            var product = _context.Products.FirstOrDefault(c => c.ProductId == id);
            if (product == null)
            {
                return false;
            }
            _context.Products.Remove(product);
            _context.SaveChanges();
            return true;
        }

    }
}
