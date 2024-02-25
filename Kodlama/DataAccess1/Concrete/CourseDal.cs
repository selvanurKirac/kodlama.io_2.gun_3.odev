

using Kodlama.DataAccess.Abstract;
using Kodlama.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.DataAccess.Concrete;

public class CourseDal:ICourseDal
{
    List<Course> courses;
    public CourseDal()
    {
        Course course1 = new Course { Id = 1, Name = "C# + Angular", Description = "Yazılım Geliştirici Yetiştirici Kampı (C# + Angular)", CategoryId = 1, InstructorId = 1 };
        Course course2 = new Course { Id = 2, Name = "Javascript", Description = "Yazılım Geliştirici Yetiştirici Kampı (Javascript)", CategoryId = 1, InstructorId = 1 };
        Course course3 = new Course { Id = 3, Name = "Java + React", Description = "Yazılım Geliştirici Yetiştirici Kampı (Java + React)", CategoryId = 1, InstructorId = 1 };
        Course course4 = new Course { Id = 4, Name = ".Net", Description = "Senior Yazılım Geliştirici Kampı (.Net)", CategoryId = 1, InstructorId = 1 };

        courses = new List<Course>()
        {
            course1, course2, course3, course4
        };
        



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
