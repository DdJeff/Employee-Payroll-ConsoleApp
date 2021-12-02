using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollConsoleApp
{
    public class Vehicle
    {
        private string plateNumber;
        private string color;

        public Vehicle(string plateNumber, string color)
        {
            this.plateNumber = plateNumber;
            this.color = color;

        }

        /**
         * @return the plateNumber
         */
        public string getPlateNumber()
        {
            return plateNumber;
        }

        /**
         * @param plateNumber the plateNumber to set
         */
        public void setPlateNumber(string plateNumber)
        {
            this.plateNumber = plateNumber;
        }

        /**
         * @return the color
         */
        public string getColor()
        {
            return color;
        }

        /**
         * @param color the color to set
         */
        public void setColor(string color)
        {
            this.color = color;
        }
    }
}
