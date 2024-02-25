
using Kodlama.DataAccess.Abstract;
using Kodlama.DataAccess.Concrete;
using Kodlama.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.Business;

public class CourseManager
    
{
    // dependency injection
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {
        
        return _courseDal.GetAll();

        
    }
}
