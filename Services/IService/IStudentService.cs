using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.IService
{
   public interface IStudentService
    {
        int totalStudent();
        IEnumerable<Test> GetEmployees();

    }
}
