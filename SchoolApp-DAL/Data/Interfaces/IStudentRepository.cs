using SchoolApp_DAL.Models;

namespace SchoolApp_DAL.Data.Interfaces;

public interface IStudentRepository
{
    Task<IReadOnlyList<Student>> GetAllAsync();
    Task<Student?> GetByIdAsync(int id);
    Task<Student?> GetByNameAsync(string studentName);
    Task<int> CreateAsync(Student student);
}
