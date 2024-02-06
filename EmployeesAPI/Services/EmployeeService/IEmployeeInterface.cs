using EmployeesAPI.Models;

namespace EmployeesAPI.Services.EmployeeService
{
    public interface IEmployeeInterface
    {
        Task<ServiceResponse<List<EmployeeModel>>> GetEmployees();
        Task<ServiceResponse<List<EmployeeModel>>> CreateEmployee(EmployeeModel employee);
        Task<EmployeeModel> GetEmployeeByID(int id);
        Task<ServiceResponse<List<EmployeeModel>>> UpdateEmployee(EmployeeModel updatedEmployee);
        Task<ServiceResponse<List<EmployeeModel>>> DeleteEmployee(int id);
        Task<ServiceResponse<List<EmployeeModel>>> InactiveEmployee(int id);
    }
}
