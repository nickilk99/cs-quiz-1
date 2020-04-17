using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz1_NickIlkic
{
    class Employee
    {
        public int empId { get; set; }
        public String empName { get; set; }
        public double empSal { get; set; }

        public Employee(int id, string name, double sal)
        {
            empId = id;
            empName = name;
            empSal = sal;
        }
    }
}
