using Mobiilirakendus.Models;
namespace Services
{
    public interface IAsjadService
    {
        Task<List<Asjad>> GetStudentList();
        Task<int> AddStudent(Asjad studentModel);
        Task<int> DeleteStudent(Asjad studentModel);
        Task<int> UpdateStudent(Asjad studentModel);
    }
}
