using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Models;
using Repository.IRepository;

namespace Repository.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private TestingEntities _DBcontext;
        public StudentRepository(TestingEntities testingEntities)
        {
            _DBcontext = testingEntities;
        }
        public int AllStudents()
        {
            return 100;
        }

        public void DeleteEmployee(int EmployeeId)
        {
            Test user = _DBcontext.Tests.Find(EmployeeId);
            _DBcontext.Tests.Remove(user);
        }

        public Test GetEmployeeByID(int EmployeeId)
        {
            return _DBcontext.Tests.Find(EmployeeId);
        }

        public IEnumerable<Test> GetEmployees()
        {
            return _DBcontext.Tests.ToList();
        }

        public void InsertEmployee(Test Employee)
        {
            _DBcontext.Tests.Add(Employee);
            
        }

        public void Save()
        {
            _DBcontext.SaveChanges();
        }

        public void UpdateEmployee(Test Employee)
        {
            _DBcontext.Entry(Employee).State = EntityState.Modified;
        }
    }
}
