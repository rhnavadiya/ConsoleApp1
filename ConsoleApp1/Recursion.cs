//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp10
//{
//    internal class Recursion
//    {
//        class Employee
//        {
//            public string EmployeeName;
//            public int EmployeeId;

//        }

//        static void Main(String[] args)
//        {



//            Console.Write("Enter factorial number: ");
//            int value = Convert.ToInt32(Console.ReadLine());


//            int result = Fact(value);

//            Console.WriteLine(result);




//            Console.WriteLine("factorial vlaue of enter number is: " + value);

//            //----------------------comandline argument--------------------------

//            for (int i = 0; i < args.Length; i++)
//            {
//                Console.WriteLine("command line argument is:" + args[i]);
//            }


//            //------------------------change name using call by reference--------------------------

//            Employee emp = new Employee();
//            emp.EmployeeName = "rutin";
//            emp.EmployeeId = 1;

//            update(emp);

//            Console.WriteLine("Employee name is :" + emp.EmployeeName);
//            Console.WriteLine("Employeeid is :" + emp.EmployeeId);


//            //------------------------replace and append method using stringbuilder---------------------------------


//            //*********APPEND MTHOD*****************
//            StringBuilder sb = new StringBuilder();

//            sb.Append("rutin");
//            sb.Append("navadiya");

//            Console.WriteLine("output using string builder append method: " + sb);

//            //***************REPLCE METHOD*************

//            string originalString = "The quick brown fox jumps over the lazy dog.";


//            StringBuilder sbReplace = new StringBuilder(originalString);

//            sbReplace.Replace("quick", "fast");

//            Console.WriteLine("output using string builder replace method: "+ sbReplace);

            




//        }

//        static int Fact(int value)
//        {
//            if (value == 0)
//            {
//                return 1;
//            }
//            else
//            {
//                return value * Fact(value - 1);
//            }
//        }



//        static void update(Employee empl)
//        {
//            empl.EmployeeName = "haresh";
//        }









//    }
//}
