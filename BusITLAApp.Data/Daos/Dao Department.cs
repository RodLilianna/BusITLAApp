using BusITLAApp.Data.Context;
using BusITLAApp.Data.Entities;
using BusITLAApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusITLAApp.Data.Daos
{
    public class Dao_Department : IDaoDepartment
    {
        private readonly BusITLAAppContext context;

        public Dao_Department(BusITLAAppContext context) 
        { 
            this.context = context;
        }
        public Department GetDepartment(int departmentId)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetDepartments()
        {
            throw new NotImplementedException();
        }

        public void RemoveDepartment(Department department)
        {
            throw new NotImplementedException();
        }

        public void SaveDepartment(Department department)
        {
            throw new NotImplementedException();
        }

        public void UpdateDepartment(Department department)
        {
            throw new NotImplementedException();
        }
    }
}
