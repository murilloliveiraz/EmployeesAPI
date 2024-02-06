using EmployeesAPI.DataContext;
using EmployeesAPI.Models;

namespace EmployeesAPI.Services.EmployeeService
{
    public class EmployeeService : IEmployeeInterface
    {
        private ApplicationDbContext _context;
        public EmployeeService(ApplicationDbContext context) 
        {
            _context = context;
        }
        public Task<ServiceResponse<List<EmployeeModel>>> CreateEmployee(EmployeeModel employee)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<EmployeeModel>>> DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeModel> GetEmployeeByID(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<EmployeeModel>>> GetEmployees()
        {
            ServiceResponse<List<EmployeeModel>> serviceResponse = new ServiceResponse<List<EmployeeModel>>();

            try
            {
                serviceResponse.Data = _context.Employees.ToList();
            }
            catch(Exception ex) 
            {
                serviceResponse.Message = ex.Message;
                serviceResponse.Sucess = false;
            } 
        }

        public Task<ServiceResponse<List<EmployeeModel>>> InactiveEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<EmployeeModel>>> UpdateEmployee(EmployeeModel updatedEmployee)
        {
            throw new NotImplementedException();
        }
    }
}
