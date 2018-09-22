using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region удаление элемента и добавление точки к строкам
            Set<string> set1 = new Set<string>
            {
                "123.",
                "qq",
                "string",
                "another string"
            };

            Console.WriteLine("Множество set1:");
            set1.Print();


            string str;
            Console.WriteLine("Введите элемент для удаления");
            str = Console.ReadLine();
            Set<string> set2 = new Set<string>(set1 - str);

            Console.WriteLine("Множество без элемента " + '"' + str + "\" :");
            set2.Print();

            Console.WriteLine("Добавление точки строкам:");
            Set<string> pointSet = new Set<string>(set2.AddPoint());
            pointSet.Print();
            #endregion

            Set<int> set3 = new Set<int>() { 8, 9};
            Set<int> set4 = new Set<int>() { 8, 9, 0, 11, 0 };
            Set<int> resultSet = new Set<int>();


            Console.WriteLine("Первое множество:");
            set3.Print();
            Console.WriteLine("Второе множество");
            set4.Print();


            Console.WriteLine("Пересечение множеств(*):");            
            resultSet = set3 * set4;
            resultSet.Print();


            if (set4 > set3)
            {
                Console.WriteLine("Первое множество является подмножеством второго множества");
            }
            else
            {
                Console.WriteLine("Первое множество не является подмножеством второго множества");
            }


            if(set3 < set4)
            {
                Console.WriteLine("Множества равны");
            }
            else
            {
                Console.WriteLine("Множества не равны");
            }


            Console.WriteLine("Объединение множеств:");
            resultSet = set3 & set4;
            resultSet.Print();
            

            Console.WriteLine("Удаление нулей из второго множества:");
            resultSet = set4.DeleteZeroElements();
            resultSet.Print();

            //Console.WriteLine("Текущее время:");
            Set<int>.Date  date = new Set<int>.Date();
            Set<int>.Owner owner = new Set<int>.Owner();

            Console.WriteLine(owner.OwnerName);
            Console.WriteLine(owner.OwnerCompany);
            Console.WriteLine(owner.Id);

            //метоы расширение String
            Console.WriteLine(str.AddPoint());

        }
    }
}
