using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            var list = new List<int>();//инициализируем коллекцию list с форматом данных int
            while (list.Count < 15)//
                                   //list.Count подсчитывает количество элементов в списке,=>
                                   //=>соответственно цикл будет выполнятся, пока количество элементов меньше 15
            {
                //try 
                //{ 

                int i = Convert.ToInt32(Console.ReadLine());//int i -- создаем переменную i с типом int,=>
                //=>Convert.ToInt32(Console.ReadLine())конвертируем строку string, что пользователь ввел в консоль,=>
                //=> в тип Int и присваиваем это значение переменной i
                list.Add(i);//добавляем в список новый элемент, записывая значение из переменной i         
                
                /*}
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }*/
            }

            var sum = 0;
            for (var i = 0; i < list.Count; i++)
            {
                sum = list[i] + sum;
            }
            Console.Write("Сумма всех элементов = "); 
            Console.WriteLine(sum);
            Console.ReadLine();

            var diff = 0;
            var j = 0;
            while (list.Count > 15)
            {
                diff -= list[j];
                j++;
            }
            Console.Write("Разность всех элементов = ");
            Console.WriteLine(diff);
            Console.ReadLine();

            double multiplication = 1;
            j = 0;
            do
            {
                multiplication *= list[j];
                j++;
            }
            while (j < list.Count);
            Console.Write("Произведение всех элементов = ");
            Console.WriteLine(multiplication);
            Console.ReadLine();

            foreach (var item in list)
            {
                Console.WriteLine(item);
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
