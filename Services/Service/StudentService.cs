using Models;
using Repository.IRepository;
using Services.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Service
{
    public class StudentService : IStudentService
    {
        private IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IEnumerable<Test> GetEmployees()
        {
            return _studentRepository.GetEmployees();
        }

        public int totalStudent()
        {
            return _studentRepository.AllStudents();
        }
    }
}
