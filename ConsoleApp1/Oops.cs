using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Oops
    {

        class A
        {
            public void MethodA(int i) 
            {
                Console.WriteLine("This is A method");
            }
        }

        class B : A
        {
            public void MethodB(int i)
            {
                Console.WriteLine("This is B method");
            }
        }

        class C : B
        {
            public void MethodC(int i)
            {
                Console.WriteLine("This is c method");
            }
        }

        class D : A
        {
            public void MethodC(int i)
            {
                Console.WriteLine("This is c method");
            }
        }


        //---------------------------Implicit and Explicit interface----------------------------------

        interface ICar
        {
            void getCar();

        }

        interface IMobile
        {
            void getMobile();
        }

        public class Car2 : ICar, IMobile
        {
            //---------------------implicit interface------------------
            //public void getCar()
            //{
            //    Console.WriteLine("Implicit Interface Implementation");
            //}
            //public void getMobile()
            //{
            //    Console.WriteLine("Implicit Interface Implementation");
            //}

            //-----------------explicit interface------------------
            void ICar.getCar()
            {
                Console.WriteLine("This is get car method");
            }

            void IMobile.getMobile()
            {
                Console.WriteLine("This is get mobile method");
            }

        }

        static void Main(String[] args)
        {
            //instance of A class
            //A a = new A();
            //a.MethodA(15);
            //a.MethodB(10);------------------we can't use the parent class property or method-----------------

            //instance of class B

            //B b = new B();
            //b.MethodA(15);
            //b.MethodB(10);

            A aa = new B();

            //instance of class c

            //C c = new C();
            //b.MethodA(15);
            //b.MethodB(10);
            //c.MethodC(5);


            //implicit interface
            Car2 car = new Car2();
            //car.getCar();
            //car.getMobile();

            //explicit interface
            ICar control = car;
            IMobile surface = car;


            control.getCar();
            surface.getMobile();






        }
    }
}
