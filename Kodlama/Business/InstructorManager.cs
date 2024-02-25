using Kodlama.DataAccess1.Abstract;
using Kodlama.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.Business;

public class InstructorManager
{
    public readonly IInstructorDal _instructorDal;

    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }
    public List<Instructor> GetAll()
    {
        return _instructorDal.GetAll();
    }
}
