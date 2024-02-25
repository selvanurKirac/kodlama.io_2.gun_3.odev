using Kodlama.DataAccess1.Abstract;
using Kodlama.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.DataAccess1.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> instructors;
        public InstructorDal()
        {
            instructors = new List<Instructor>();
            Instructor instructor1 = new Instructor { Id = 1, FirstName = "Engin", LastName = "Demiroğ" };
            Instructor instructor2 = new Instructor { Id = 2, FirstName = "Halit Enes", LastName = "Kalaycı" };

            instructors.Add(instructor1);   
            instructors.Add(instructor2);
        }
        public void Add(Instructor instructor)
        {
            instructors.Add(instructor);
            
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }
       

        public void Delete(Instructor instructor)
        {
            Instructor instructorToDelete = instructors.SingleOrDefault(i => i.Id == instructor.Id);
            instructors.Remove(instructorToDelete);
        }

        public Instructor Get(int id)
        {
            return instructors.SingleOrDefault(x => x.Id == id);
        }

    
        public void Update(Instructor instructor)
        {
            Instructor instructorToUpdate = instructors.SingleOrDefault(i => i.Id == instructor.Id);
            instructorToUpdate.FirstName = instructor.FirstName;
            instructorToUpdate.LastName = instructor.LastName;
        }

    }
}
