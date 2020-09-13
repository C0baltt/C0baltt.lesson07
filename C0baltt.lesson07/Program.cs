using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*создать коллекцию целых чисел (15 элементов)
 заполнить данными от пользователя (с проверкой)
посчитать сумму всех элементов коллекции (for)
посчитать разность всех элементов (while)
посчитать произведение (do while)
вывести коллекцию(foreach)*/
namespace C0baltt.lesson07
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>();//инициализируем коллекцию list
            for (var i = 0; i < 15; i++)//добавляем 15 элементов в коллекцию
            {
                list.Add(i);//добавляем элементы в коллекцию
            }

            for (var i = 0; i < list.Count; i++)//вводим значения для 15-ти элементов коллекции list 
            {
                Console.WriteLine(list[i]);//считываем с консоли значение i-того элемента
            }    
                Console.ReadLine();
        }
    }
}
/*          МАТЕРИАЛЫ ПО УРОКУ
 var list = new List<string>();
            while (list.Count < 5)
            {
                list.Add(Console.ReadLine());
            }
            var i = 0;

            do
            {
                Console.WriteLine(list[i]);
                i++;
            }
            while (i < list.Count);

            Console.ReadLine();


    
    
    var list = new List<string>();
while (list.Count < 5)
{
    list.Add(Console.ReadLine());
}
var i = 0;
while(i < list.Count)
{
    Console.WriteLine(list[i]);
    i++;
}
Console.ReadLine();



 var list = new List<int>();
for (var i = 1;i< 10; i+=2 )//(итератор;условие;изменение)
{
    list.Add(i);
}
for(var i=0;i<list.Count; i++)
{
    Console.WriteLine(list[i]);
}
Console.ReadLine();*/
