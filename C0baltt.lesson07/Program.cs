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
            int[,] i = new int[10, 10];
            var rnd = new Random();
            for (var i = 0; i < 10; i++)
            {
                list.Add(rnd.Next(0, 100).ToString());
                break;
                continue;
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
