using coreApi1.Server.DTO;
using coreApi1.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreApi1.Server.IDataService
{
    public interface IDataServicecs
    {
        public List<Category> getCategories();
        public Category getCategoryById(int id);
        public List<Category> getCategoryByName(string name);
        public bool deleteCategory(int id);
        //public bool addCategory(Category category);
        public bool updateCategory(int id, Category category);


        public List<Product> getProducts();
        public Product getProductById(int id);
        public List<Product> getProductByName(string name);
        public bool deleteProduct(int id);
        public bool addProduct(Product product);
        public bool addCategory(AddCategoryRequest acr);
    }

   
}
