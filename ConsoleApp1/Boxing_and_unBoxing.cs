using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Boxing_and_unBoxing
    {
      static void Main(string[] args)
        {
            //diffrence between first and firstordefault.
            List<string> list = new List<string>();

            list.Add("rutin");
            list.Add("hareshbahi");
            list.Add("navadiya");

            string getfirstchar = list.First();//can't get null value

            Console.WriteLine("first value in this list is: " + getfirstchar);

            string getfirstordefault = list.FirstOrDefault();//allow null value

            Console.WriteLine("first or default value in this list is: " + getfirstordefault);


            //convert nullable value to string

            int? value = null;

            Console.WriteLine("converted int value to string " + Convert.ToString(value));

            //write a program to perform boxing and unboxing

            int value1 = 15;

            object value2 = value1;

            int value3 = (int)value2;

            Console.WriteLine("unboxing : " + value2);

            const int pieValue = 3;

            Console.WriteLine("pievalue is " + pieValue);

            ConstValue(pieValue);

            readOnlyVlaueValue(pieValue);




        }

       //---------------------write a program to create a constant and use it in method---------------

         static void ConstValue(int value)
         {
            Console.WriteLine("constant value is:" + value);

         }

      //----------------write a program to create a read only and modify value and use it in method------------

         static void readOnlyVlaueValue(int value)
         {
            Console.WriteLine("constant value is:" + value);

         }
    }
}
