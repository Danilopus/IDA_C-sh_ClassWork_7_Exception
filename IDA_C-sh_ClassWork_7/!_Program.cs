// ClassWork template 1.2 // date: 29.09.2023

using IDA_C_sh_ClassWork_7;
using Service;
using System;
using System.Linq.Expressions;
using System.Text;



// ClassWork 07 : [C# Exceptions, Operators overload] 13.10.2023 --------------------------------

// HomeWork 07 : в ДЗ перекочевала задача №2 - Money.

namespace IDA_C_sh_ClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_1(); // Задача из работы в классе
            Task_2(); // Задача для ДЗ

            //Console.ReadKey();
        }

        // программа “Строительство дома”
        /* Задание 1. Реализовать программу “Строительство дома”
        Реализовать:
        Классы
        ■ House (Дом), Basement (Фундамент), Walls (Стены),
        Door (Дверь), Window (Окно), Roof (Крыша);
        ■ Team (Бригада строителей), Worker (Строитель),
        TeamLeader (Бригадир).
        Интерфейсы
        ■ IWorker, IPart.
        Все части дома должны реализовать интерфейс IPart
        (Часть дома), для рабочих и бригадира предоставляется
        базовый интерфейс IWorker (Рабочий).
        Бригада строителей (Team) строит дом (House). Дом
        состоит из фундамента (Basement), стен (Wall), окон
        (Window), дверей (Door), крыши (Part).
        Согласно проекту, в доме должно быть 1 фундамент,
        Бригада начинает работу, и строители последовательно
        “строят” дом, начиная с фундамента. Каждый строитель
        не знает заранее, на чём завершился предыдущий этап
        строительства, поэтому он “проверяет”, что уже постро-
        ено и продолжает работу. Если в игру вступает бригадир
        (TeamLeader), он не строит, а формирует отчёт, что уже
        построено и какая часть работы выполнена.
        В конечном итоге на консоль выводится сообщение, что
        строительство дома завершено и отображается “рисунок
        дома” (вариант отображения выбрать самостоятельно).*/
        public static void Task_1() 
        {
            Console.Write("\n ***  House construct app\n" + "\nEnter workers quantity: ");
            Team team = new Team(ServiceFunction.Get_Int(2,10, "workers number out of range [2..10]"));
            House house_obj = new House();            
                for (int i = 0; i < House.house_project.Length; i++)
                {
                    team.Construct(house_obj);
                    team.Team_list[0].Construct(house_obj);
                }    
            Console.ReadKey();
            // Пытаемся построить уже достроенный дом
            try
            {
                team.Construct(house_obj);
            }
            catch (Exception ex) 
            { Console.WriteLine(ex.Message); }
        }
        // Money
        /* Написать класс Money, предназначенный для хранения денежной суммы (в рублях и копейках). Для класса
        реализовать перегрузку операторов + (сложение денежных сумм), – (вычитание сумм), / (деление суммы на целое
        число), * (умножение суммы на целое число), ++ (сумма
        увеличивается на 1 копейку), -- (сумма уменьшается на
        1 копейку), <, >, ==, !=.
        Класс не может содержать отрицательную сумму.
        В случае если при исполнении какой-либо операции получается отрицательная сумма денег, то класс генерирует
        исключительную ситуацию «Банкрот».

        Программа должна с помощью меню продемонстрировать все возможности класса Money. 
        Обработка исключительных ситуаций производится в программе.*/
        public static void Task_2() 
        {
            Money money_obj_1 = new("RUB", 1, 59);
            Money money_obj_2 = new("RUB", 3.79);

            do 
            {
                Console.Clear();
                Console.Write("\n*** Money app demo\n" +
                    "1. Show money objects\n" +
                    "2. Show me overloaded binary operations\n" +
                    "3. Show me overloaded unary operations\n" +
                    "4. Show me overloaded compare operations\n" +
                    "5. Show me BankroteException in work\n" +
                    "6. Show me DifferentCurrencyTypesException in work\n" +
                    "0. Exit\n" +
                    "\nchoice: ");
                switch(ServiceFunction.Get_Int(0,6, "such menu item doesn't exist"))
                {
                    case 0: return;
                    case 1: block1(); break;
                    case 2: block2(); break;
                    case 3: block3(); break;
                    case 4: block4(); break;
                    case 5: block5(); break;
                    case 6: block6(); break;
                }
                Console.ReadKey();
            } while (true);


            void block1()
            {
                Console.WriteLine("\nmoney_obj_1: {0}", money_obj_1);
                Console.WriteLine("money_obj_2: {0}\n", money_obj_2);
            }
            void block2()
            {
                Console.WriteLine("\n{0} + {1} = {2}\n", money_obj_1, money_obj_2, (money_obj_1 + money_obj_2));
                Console.WriteLine("{1} - {0} = {2}\n", money_obj_1, money_obj_2, (money_obj_2 - money_obj_1));
                Console.WriteLine("{0} / {1} = {2}\n", money_obj_1, 3, (money_obj_1 / 3));
                Console.WriteLine("{0} * {1} = {2}\n", money_obj_1, 3, (money_obj_1 * 3));
            }
            void block3()
            {
                Console.WriteLine("\n" + money_obj_1 + "++ = {0}\n", (money_obj_1++));
                Console.WriteLine(money_obj_1 + "-- = {0}\n", (--money_obj_1));
            }
            void block4()
            {
                Console.WriteLine("\n{0} > {1} ? {2}\n", money_obj_1, money_obj_2, (money_obj_1 > money_obj_2));
                Console.WriteLine("{0} < {1} ? {2}\n", money_obj_1, money_obj_2, (money_obj_1 < money_obj_2));
                Console.WriteLine("{0} == {1} ? {2}\n", money_obj_1, money_obj_2, (money_obj_1 == money_obj_2));
                Console.WriteLine("{0} != {1} ? {2}\n", money_obj_1, money_obj_2, (money_obj_1 != money_obj_2));
            }
            void block5()
            {
                Console.WriteLine("\nTrying to decrement {money_obj_1} in infinity loop");
                try
                {
                    while (true)
                    {
                        Console.Write("{0} | ",money_obj_1--);
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
            void block6()
            {
                Money money_obj_3 = new("EUR", 115, 115);
                Console.WriteLine("\nMoney money_obj_3 = new(\"EUR\", 115, 115)\nmoney_obj_3: {0}", money_obj_3);
                Console.WriteLine("\nTrying {0} - {1}", money_obj_3, money_obj_2);
                try
                {
                    _ = money_obj_3 - money_obj_1;
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }

        }

    } // class Programm
}// namespace

