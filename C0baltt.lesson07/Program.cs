using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0baltt.lesson07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 10];
            for (var i = 0; i < 10; i++)
            {
                for (var j = 0; j< 10; j++)
                {
                    array[i, j] = 8;
                }
            }
            foreach(var item in list)//(элемент in коллекция)
            {
                Console.WriteLine(item);
            }

           

            Console.ReadLine();
        }
    }
}
/*
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
