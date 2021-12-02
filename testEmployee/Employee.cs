using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollConsoleApp
{
    public abstract class Employee
    {
        private int empId;
        private string name;
        private Vehicle vehicle;

        public Employee(int pEmpId, string pName, Vehicle pV)
        {
            empId = pEmpId;
            name = pName;
            this.vehicle = pV;
        }

        /**
         * @return the empId
         */
        public int getEmpId()
        {
            return empId;
        }

        /**
         * @param empId the empId to set
         */
        public void setEmpId(int empId)
        {
            this.empId = empId;
        }

        public abstract double calculatePay();
        /**
         * @return the name
         */
        public string getName()
        {
            return name;
        }

        /**
         * @param name the name to set
         */
        public void setName(string name)
        {
            this.name = name;
        }

        /**
         * @return the vehicle
         */
        public Vehicle getVehicle()
        {
            return vehicle;
        }

        /**
         * @param vehicle the vehicle to set
         */
        public void setVehicle(Vehicle vehicle)
        {
            this.vehicle = vehicle;
        }
    }
}
