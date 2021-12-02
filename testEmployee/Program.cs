using System;

namespace PayrollConsoleApp
{ //come back and put methods in place
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] group = new Employee[0]; 
            
            int count = 0;
           
            
            int menuOption = 0;
            do
            {
                menuOption = ShowMenu();
                
                switch (menuOption)
                {
                    case 1:

                        Array.Resize(ref group, group.Length + 1); //add space for new employee
                        FullTime ft;
                        ft = ReadNewFullTime();
                        group[count] = ft;// add full time employee
                        count++;
                        break;

                    case 2:
                        Array.Resize(ref group, group.Length + 1); //add space for new employee
                        PartTime pt;
                        pt = ReadNewPartTime();
                        group[count] = pt; // add part time employee
                        count++;
                        break;

                    case 3:
                        foreach (var employee in group)
                        {
                            CalcPayroll(employee); 
                        }
                        break;

                    default:
                        break;

                }

            } while (menuOption != 4);
        }

        public static FullTime ReadNewFullTime()
        {

            /*************************************************/
            /*This method creats and populates employee objects.*/
            /*Parameters None*/
            /*Return vaules: New FullTime*/
            /*************************************************/
            int id;
            string name;
            double sal;
            double timeAndHour; // overtime

                Console.WriteLine("Enter Id: ");
                id = Int32.Parse(Console.ReadLine());
           
                Console.WriteLine("\nEnter Name: ");
                name = Console.ReadLine();

                Console.WriteLine("\nEnter Salary: ");
                sal = Double.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter Bonus: ");
                timeAndHour = Double.Parse(Console.ReadLine());

                FullTime ft1 = new(id, name, sal, timeAndHour, GetVehicle());
            
            return ft1;
        }

        public static PartTime ReadNewPartTime()
        {

            /*************************************************/
            /*This method creats and populates employee objects.*/
            /*Parameters None*/
            /*Return vaules: New PartTime*/
            /*************************************************/
            int id;
            string name;
            double rate;
            double hoursWorked; // overtime

                Console.WriteLine("Enter Id: ");
                id = Int32.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter Name: ");
                name = Console.ReadLine();

                Console.WriteLine("\nEnter Hourly Rate: ");
                rate = Double.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter Number of Hours Worked: ");
                hoursWorked = Double.Parse(Console.ReadLine());

                Vehicle v1 = GetVehicle();
                PartTime pt1 = new (id, name, rate, hoursWorked, v1);
          
            return pt1;
        }
        public static int ShowMenu() 
        {
            int menuOption;


            Console.WriteLine(""
                    + "/*************************************************************/"
                    + "\n/*  1. Add Full Time                                       */"
                    + "\n/*  2. Add Part Time                                       */"
                    + "\n/*  3. Calculate Payroll                                   */"
                    + "\n/*  4. Exit                                                */"
                    + "\n/***********************************************************/");
            Console.WriteLine("Input:  ");
            menuOption = Int32.Parse(Console.ReadLine());

            return menuOption;
        }

        public static Vehicle GetVehicle()
        {
            /* creat and return a vehicle object if "Y" and if not return null*/

            string hasVehicle;

            Console.WriteLine("Does employee has a vehicle?  Y/N");
            hasVehicle = Console.ReadLine().ToUpper();

            if (hasVehicle.Equals("Y"))
            {
                //create and populate objects
                Console.WriteLine("\nEnter Plate Number: ");
                string auxPlate = Console.ReadLine();

                Console.WriteLine("\nEnter Vehicle Color: ");
                string auxColor = Console.ReadLine();

                return (new Vehicle(auxPlate, auxColor));
            }
            else
            { //employee does not have a vehicle
                return (null);
            }
        }  

        public static void addEmployee(Employee[] pArrEmp, Employee pEmp, int count = 0)
        {    
            /*adds employee to the employee array pArrEmp*/
            pArrEmp[count] = pEmp;

        }//end of add Employee


        static double totalCompanyPay;

        public static void CalcPayroll(Employee employee) 
        {
            
            double individualPay;

            // calculates salary

            Console.WriteLine("\n*************************\n");

            individualPay = employee.calculatePay();
           

            //check to see of employee has a vehicle
             string hasVehicle = employee.getVehicle() == null ? "No" : "Yes";

            Console.WriteLine($"Emlpoyees Name: {employee.getName()}");
            Console.WriteLine($"Has Vehicle: {(hasVehicle)}");

            if (employee.getVehicle() != null)
                { 
                    Console.WriteLine($"Plate Number: {employee.getVehicle().getPlateNumber()}");
                    Console.WriteLine($"Color: {employee.getVehicle().getColor()}");

                }

              Console.WriteLine($"Take Home Pay: {individualPay}");

            //end of calc salary */

            totalCompanyPay += individualPay;
      
            Console.WriteLine($"Total Pay Roll of the Company {totalCompanyPay}");

        }
    }
    
}
