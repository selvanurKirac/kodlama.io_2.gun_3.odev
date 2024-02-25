using Kodlama.DataAccess1.Abstract;
using Kodlama.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.DataAccess1.Concrete;

public class CategoryDal:ICategoryDal
{
    List<Category> categories;
    public CategoryDal()
    {
        categories = new List<Category>();
        Category category1 = new Category { Id = 1, Name = "Yazılım" };
        Category category2 = new Category { Id = 2, Name = "Network" };
        Category category3 = new Category { Id = 3, Name = "Siber Güvenlik" };
        categories.Add(category1);
        categories.Add(category2);
        categories.Add(category3);

    }

    public void Add(Category category)
    {
        categories.Add(category);
    }

    public void Delete(Category category)
    {
        Category categoryToDelete = categories.SingleOrDefault(c => c.Id == category.Id);
        categories.Remove(categoryToDelete);
    }

    public Category Get(int id)
    {
        return categories.SingleOrDefault(x => x.Id == id);
    }

    public List<Category> GetAll()
    {
        return categories;
    }

    public void Update(Category category)
    {
        Category categoryToUpdate = categories.SingleOrDefault(c => c.Id == category.Id);
        categoryToUpdate.Name = category.Name;
    }
}
