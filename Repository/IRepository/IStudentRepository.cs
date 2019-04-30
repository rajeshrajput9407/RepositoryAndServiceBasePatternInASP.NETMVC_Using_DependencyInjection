using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repository.IRepository
{
   public interface IStudentRepository 
    {
        int AllStudents();

        void InsertEmployee(Test Employee); // C

        IEnumerable<Test> GetEmployees(); // R

        Test GetEmployeeByID(int EmployeeId); // R

        void UpdateEmployee(Test Employee); //U

        void DeleteEmployee(int EmployeeId); //D

        void Save();
    }
}
