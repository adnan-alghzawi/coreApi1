using coreApi1.Server.Models;
using coreApi1.Server.IDataService;


namespace coreApi1.Server.DataService
{
    
    public class DataService : IdataService
    {
        private readonly MyDbContext _context;

        public DataService(MyDbContext context)
        {
            _context = context;
        }

        public List<Category> GetAll() => _context.Categories.ToList();

        public Category GetById(int id) => _context.Categories.Find(id);

        public List<Category> GetByName(string name) =>
            _context.Categories.Where(c => c.CategoryName == name).ToList();

        public bool Delete(int id)
        {
            var category = _context.Categories.Find(id);
            if (category == null) return false;

            _context.Categories.Remove(category);
            _context.SaveChanges();
            return true;
        }
    }

}
