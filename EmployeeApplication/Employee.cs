using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    public class Employee
    {
        private long EmployeeID;
        private string firstName;
        private string lastName;
        private string position;


        public long EmployeeNumber
        {
            get { return EmployeeID; }
            set { EmployeeID = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public Employee()
        {
            this.EmployeeID = 0;
            this.firstName = string.Empty;
            this.lastName = string.Empty;
            this.position = string.Empty;
        }
        public Employee(long employeeNumber, string firstName, string lastName, string position)
        {
            this.EmployeeID = employeeNumber;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
        }


    }

}
