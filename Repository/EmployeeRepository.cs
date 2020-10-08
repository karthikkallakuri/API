using API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public class EmployeeRepository : IEmployeeDataRepository
    {
        public string GetNameById(int id)
        {
            string name;
            if (id == 1)
            {
                name = "Karthik1";
            }
            else if (id == 2)
            {
                name = "Karthik2";
            }
            else
            {
                name = "Not Found";
            }
            return name;
        }
    }
}