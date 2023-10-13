// ClassWork template 1.2 // date: 29.09.2023

using IDA_C_sh_ClassWork_7;
using Service;
using System;
using System.Linq.Expressions;
using System.Text;



// ClassWork 07 : [C# Exceptions] 13.10.2023 --------------------------------

namespace IDA_C_sh_ClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
             //Task_1();
             Task_2();
            // Task_3();

             Console.ReadKey();
        }

        public static void Task_1() 
        {
            Console.Write("\n ***  House construct app\n" +
                "\nEnter workers quantity: ");
            Team team = new Team(ServiceFunction.Get_Int(2,10, "workers number out of range [2..10]"));

            House house_obj = new House();

            
                for (int i = 0; i < House.house_project.Length; i++)
                {
                    team.Construct(house_obj);
                    team.Team_list[0].Construct(house_obj);
                }
            
            
            Console.ReadKey();


            try
            {
                team.Construct(house_obj);
            }
            catch (Exception ex) 
            { Console.WriteLine(ex.Message); }

        }
        public static void Task_2() 
        {
            Money money_obj_1 = new("RUB", 1, 59);
            Console.WriteLine("money_obj_1: {0}\n", money_obj_1);

            Money money_obj_2 = new("USD", 3.79);
            Console.WriteLine("money_obj_2: {0}\n", money_obj_2);
            money_obj_2.name_ = "RUB";


            Console.WriteLine("{0} + {1} = {2}\n", money_obj_1, money_obj_2, (money_obj_1+ money_obj_2));

            Console.WriteLine("{1} - {0} = {2}\n", money_obj_1, money_obj_2, (money_obj_2 - money_obj_1));

            Console.WriteLine("{0} / {1} = {2}\n", money_obj_1, 3, (money_obj_1/3));

            Console.WriteLine("{0} * {1} = {2}\n", money_obj_1, 3, (money_obj_1 * 3));

            Console.WriteLine(money_obj_1 +"++ = {0}\n", (money_obj_1++));

            Console.WriteLine(money_obj_1 + "-- = {0}\n", (--money_obj_1));

            Console.WriteLine("{0} > {1} ? {2}\n", money_obj_1, money_obj_2, (money_obj_1 > money_obj_2));

            Console.WriteLine("{0} < {1} ? {2}\n", money_obj_1, money_obj_2, (money_obj_1 < money_obj_2));

            Console.WriteLine("{0} == {1} ? {2}\n", money_obj_1, money_obj_2, (money_obj_1 == money_obj_2));

            Console.WriteLine("{0} != {1} ? {2}\n", money_obj_1, money_obj_2, (money_obj_1 != money_obj_2));

            try 
            {
            while(true)
                {
                    money_obj_1--;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

        }
        public static void Task_3() { }

    } // class Programm
}// namespace

