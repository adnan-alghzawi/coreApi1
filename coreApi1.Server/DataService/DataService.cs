using coreApi1.Server.DTO;
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

        //add category
        //public bool addCategory(Category category)
        //{
        //    if (category == null)
        //    {
        //        return false;
        //    }
        //    _context.Categories.Add(category);
        //    _context.SaveChanges();
        //    return true;
        //}

        //add product
        public bool addProduct(Product product)
        {
            if (product == null)
            {
                return false;
            }
            _context.Products.Add(product);
            _context.SaveChanges();
            return true;
        }

        // update category by id
        public bool updateCategory(int id, Category category)
        {
            var existingCategory = _context.Categories.FirstOrDefault(c => c.CategoryId == id);
            if (existingCategory == null)
            {
                return false;
            }
            existingCategory.CategoryName = category.CategoryName;
            existingCategory.CategoryDescription = category.CategoryDescription;
            _context.SaveChanges();
            return true;
        }

        public bool addCategory(AddCategoryRequest acr)
        {
            if (acr == null)
            {
                return false;
            }
            else
            {
                var category = new Category
                {
                    CategoryName=acr.CategoryName,
                    CategoryDescription=acr.CategoryDescription
                };
                _context.Categories.Add(category);
                _context.SaveChanges();
                return true;
            }

        }

        public bool Register(RegisterDTO registerDTO)
        {
            var user=_context.Users.FirstOrDefault(u => u.Email == registerDTO.Email);

            if (user != null)
            {
                return false;
            }
            else
            {
                var newUser = new User
                {
                    Name = registerDTO.Name,
                    
                    Email = registerDTO.Email,
                    Password = registerDTO.Password
                };
                _context.Users.Add(newUser);
                _context.SaveChanges();
                return true;
            }
        }

       
    }
}
