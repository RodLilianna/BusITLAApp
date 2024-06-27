using BusITLAApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusITLAApp.Data.Interfaces
{
    public interface IDaoDepartment
    {
        List<Department> GetDepartments();
        Department GetDepartment(int departmentId);
        void SaveDepartment(Department department);
        void UpdateDepartment(Department department);
        void RemoveDepartment(Department department);
    }
}
