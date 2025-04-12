using coreApi1.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace coreApi1.Server.IDataService
{
    public interface IdataService
    {
        List<Category> GetAll();
        Category GetById(int id);
        List<Category> GetByName(string name);
        bool Delete(int id);
    }

}
