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


        public List<Product> getProducts();
        public Product getProductById(int id);
        public List<Product> getProductByName(string name);
        public bool deleteProduct(int id);
    }
}
