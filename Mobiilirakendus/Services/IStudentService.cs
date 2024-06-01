using Mobiilirakendus1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiilirakendus1.Services
{
    public interface IStudentService
    {
        Task<List<StudentModel>> GetStudentList();
        Task<int> AddStudent(StudentModel studentModel);
        Task<int> DeleteStudent(StudentModel studentModel);
        Task<int> UpdateStudent(StudentModel studentModel);
    }
}
