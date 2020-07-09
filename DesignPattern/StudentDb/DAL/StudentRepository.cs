using StudentDb.Data;
using StudentDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace StudentDb.DAL
{
    public class StudentRepository : IStudentRepository, IDisposable
    {
        private StudentDbContext _context;
        public StudentRepository(StudentDbContext context)
        {
            this._context = context;
        }
        public void DeleteStudent(int studentId)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetStudentById(int? studentId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Student>> GetStudents()
        {
            throw new NotImplementedException();
        }

        public void InsertStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }

    }
}