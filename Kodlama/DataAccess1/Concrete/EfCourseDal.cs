
using Kodlama.DataAccess.Abstract;
using Kodlama.Entities;

namespace Kodlama.DataAccess.Concrete;

public class EfCourseDal: ICourseDal
{
    List<Course> courses;
    public EfCourseDal()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "JavaScript";
        course1.Description = ".Net 8 vs...";
        
        Console.WriteLine("Kod bitti");

        Course course2 = new Course();
        course1.Id = 2;
        course1.Name = "Java";
        course1.Description = "Java 17";
        

        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = "Python";
        course3.Description = "Python 3.12...";
        
        courses = new List<Course>() { course1, course2, course3 };
    }
    public List<Course> GetAll()
    {
        //sql öğren
        // burada db işlemleri yapılır
        return courses;
    }
    public void Add(Course entity)
    {
        courses.Add(entity);
    }

    public void Delete(Course course)
    {
        Course productToDelete = courses.SingleOrDefault(c => c.Id == course.Id);
        courses.Remove(productToDelete);
    }

    public Course Get(int id)
    {
        return courses.FirstOrDefault(x => x.Id == id);
    }


    public void Update(Course course)
    {
        Course courseToUpdate = courses.SingleOrDefault(c => c.Id == course.Id);
        courseToUpdate.Name = course.Name;
        courseToUpdate.Description = course.Description;
        courseToUpdate.CategoryId = course.CategoryId;
        courseToUpdate.InstructorId = course.InstructorId;
    }
}
