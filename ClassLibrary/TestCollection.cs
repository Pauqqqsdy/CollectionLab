using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Linq.Expressions;

namespace ClassLibrary
{
    public class TestCollection
    {
        public LinkedList<Truck> list1 = new LinkedList<Truck>();
        public LinkedList<string> list2 = new LinkedList<string>();
        public Dictionary<Transport, Truck> list3 = new Dictionary<Transport, Truck>();
        public Dictionary<string, Truck> list4 = new Dictionary<string, Truck>();

        private Truck first, middle, last, noexist;

        public TestCollection(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Truck truck = new Truck();
                truck.RandomCreate();

                while (list3.ContainsKey(truck.GetBase) || list4.ContainsKey(truck.GetBase.ToString()))
                {
                    truck.RandomCreate();
                }

                list3.Add(truck.GetBase, truck);
                list4.Add(truck.GetBase.ToString(), truck);
                list1.AddLast(truck);
                list2.AddLast(truck.ToString());

                if (i == 0) first = truck.Clone();
                if (i == size / 2) middle = truck.Clone();
                if (i == size - 1) last = truck.Clone();
            }
            noexist = new Truck();

            while (list3.ContainsKey(noexist.GetBase))
            {
                noexist.RandomCreate();
            }
        }

        public void PrintFirstMiddleLast()
        {
            Console.WriteLine("Первый элемент:");
            Console.WriteLine(first);
            Console.WriteLine();

            Console.WriteLine("Средний элемент:");
            Console.WriteLine(middle);
            Console.WriteLine();

            Console.WriteLine("Последний элемент:");
            Console.WriteLine(last);
            Console.WriteLine();
        }

        private void TimeDetection(Func<bool> action, string message)
        {
            int iterations = 10;
            double totalTime = 0;
            bool isFound = false;

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < iterations; i++)
            {
                sw.Restart();
                isFound = action.Invoke();
                sw.Stop();
                totalTime += sw.ElapsedTicks;
                sw.Reset();
            }

            double avgTime = totalTime / iterations;
            string result = isFound ? "Элемент найден" : "Элемент не найден";
            Console.WriteLine($"{message}: {result} за {avgTime} тиков");
        }

        public void FindTime()
        {
            var elementsToFind = new[]
            {
            (Element: first, Name: "первого элемента"),
            (Element: middle, Name: "среднего элемента"),
            (Element: last, Name: "последнего элемента"),
            (Element: noexist, Name: "несуществующего элемента")
            };

            foreach (var element in elementsToFind)
            {
                Console.WriteLine($"Поиск элемента {element.Name}");

                TimeDetection(() => list1.Contains(element.Element), $"Поиск в list1");

                TimeDetection(() => list2.Contains(element.Element.ToString()), $"Поиск в list2");

                TimeDetection(() => list3.ContainsKey(element.Element.GetBase), $"Поиск в list3 по ключу");
                TimeDetection(() => list3.ContainsValue(element.Element), $"Поиск в list3 по значению");

                TimeDetection(() => list4.ContainsKey(element.Element.GetBase.ToString()), $"Поиск в list4 по ключу");
                TimeDetection(() => list4.ContainsValue(element.Element), $"Поиск в list4 по значению");

                Console.WriteLine();
            }
        }

        public void Print()
        {
            Console.WriteLine("Все элементы:");
            int index = 1;
            LinkedListNode<Truck> currentNode = list1.First;

            while (currentNode != null)
            {
                Console.WriteLine($"{index}: {currentNode.Value}");
                currentNode = currentNode.Next;
                index++;
            }
        }
    }
}
