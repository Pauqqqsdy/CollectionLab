using System.Collections;
using ClassLibrary;
using System.Linq;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CollectionLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1 часть
            //ArrayList list = new ArrayList();

            //list.AddRange(new object[] { new Truck(), new PassengerCar(), new OffroadCar(), new Transport() });
            //foreach (object obj in list)
            //{
            //    Console.WriteLine(obj);
            //}

            //Truck truck = new Truck();
            //truck.RandomCreate();
            //list.Add(truck);

            //PassengerCar car = new PassengerCar();
            //car.RandomCreate();
            //list.Add(car);

            //OffroadCar offroadNewCar = new OffroadCar();
            //offroadNewCar.RandomCreate();
            //list.Add(offroadNewCar);
            //foreach (object obj in list)
            //{
            //    Console.WriteLine(obj);
            //}

            //Console.WriteLine();

            //list.Remove(list[2]);
            //foreach (object obj in list)
            //{
            //    Console.WriteLine(obj);
            //}

            //Console.WriteLine();

            //OffroadCar offroadCar = new OffroadCar();
            //list.Insert(2, offroadCar);
            //foreach (object obj in list)
            //{
            //    Console.WriteLine(obj);
            //}

            //Console.WriteLine();

            //double maxCost = LinqRequests.FindMaxCostOfOffroadCars(list);
            //double avgSpeed = LinqRequests.FindAvgSpeedOfPassengerCars(list);
            //double relevantTrucks = LinqRequests.FindCountOfTrucksWithExceedingCapacity(list, 2000);
            //Console.WriteLine("Результаты запросов:");
            //Console.WriteLine($"Стоимость самого дорогого внедорожника: {maxCost}");
            //Console.WriteLine($"Средняя скорость всех легковых автомобилей: {avgSpeed}");
            //Console.WriteLine($"Количество грузовиков, грузоподъёмность которых больше 2000 кг: {relevantTrucks}");

            //Console.WriteLine();

            //ArrayList clonedList = (ArrayList)list.Clone();

            //list[2] = new Truck(3, "Lexus", 2015, "Белый", 5000000, 280, 5000);

            //Console.WriteLine("Оригинальный список:");
            //foreach (object obj in list)
            //{
            //    Console.WriteLine(obj);
            //}

            //Console.WriteLine();

            //Console.WriteLine("Клонированный список:");
            //foreach (object obj in clonedList)
            //{
            //    Console.WriteLine(obj);
            //}

            //Console.WriteLine();

            //Console.WriteLine("Отсортированный оригинальный список по годам выпуска:");
            //list.Sort(new SortByYearComparator());
            //foreach (object obj in list)
            //{
            //    Console.WriteLine(obj);
            //}

            //Console.WriteLine();

            //PassengerCar addCar = new PassengerCar(108, "Toyota", 2013, "Чёрный", 2500000, 220, 4, 250);
            //list.Add(addCar);

            //foreach (object obj in list)
            //{
            //    Console.WriteLine(obj);
            //}

            //Console.WriteLine();

            //Transport searchCar = new PassengerCar(108, "Toyota", 2013, "Чёрный", 2500000, 220, 4, 250);
            //int index = list.IndexOf(searchCar);
            //if (index != -1)
            //{
            //    Console.WriteLine($"Данный автомобиль есть в списке на позиции: {index + 1}");
            //}
            //else
            //{
            //    Console.WriteLine("Автомобиль не найден в предложенном списке.");
            //}

            #endregion Конец 1 части

            #region 2 часть
            //Stack<Transport> stack = new Stack<Transport>();
            //Truck truck = new Truck();
            //truck.RandomCreate();

            //PassengerCar car = new PassengerCar();
            //car.RandomCreate();

            //OffroadCar offroadNewCar = new OffroadCar();
            //offroadNewCar.RandomCreate();

            //Transport transport = new Transport();

            //foreach (var obj in new Transport[] { truck, car, offroadNewCar, transport })
            //{
            //    stack.Push(obj);
            //}

            //Console.WriteLine("Стек до удаления:");
            //foreach (object obj in stack)
            //{
            //    Console.WriteLine(obj);
            //}

            //Console.WriteLine();

            //Transport deleteObject = new Transport();
            //Console.WriteLine($"Попытка удалить объект {deleteObject}:");
            //Stack<Transport> tempStack = new Stack<Transport>();
            //bool isRemoved = false;
            //while (stack.Count > 0)
            //{
            //    var item = stack.Pop();
            //    if (!item.Equals(deleteObject))
            //    {
            //        tempStack.Push(item);
            //    }
            //    else
            //    {
            //        isRemoved = true;
            //    }
            //}

            //while (tempStack.Count > 0)
            //{
            //    stack.Push(tempStack.Pop());
            //}

            //if (isRemoved)
            //{
            //    Console.WriteLine($"\nОбъект {deleteObject} удалён из стека.\n");
            //    Console.WriteLine("Стек после удаления:");
            //    foreach (var obj in stack)
            //    {
            //        Console.WriteLine(obj);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"Объект {deleteObject} не был найден.");
            //}

            //Console.WriteLine();

            //double maxCost = LinqRequests.FindMaxCostOfOffroadCarsInStack(stack);
            //double avgSpeed = LinqRequests.FindAvgSpeedOfPassengerCarsInStack(stack);
            //double relevantTrucks = LinqRequests.FindCountOfTrucksWithExceedingCapacityInStack(stack, 2000);
            //Console.WriteLine("Результаты запросов:");
            //Console.WriteLine($"Стоимость самого дорогого внедорожника: {maxCost}");
            //Console.WriteLine($"Средняя скорость всех легковых автомобилей: {avgSpeed}");
            //Console.WriteLine($"Количество грузовиков, грузоподъёмность которых больше 2000 кг: {relevantTrucks}");

            //Console.WriteLine();

            //Stack<Transport> clonedStack = new Stack<Transport>(new Stack<Transport>(stack));
            //Console.WriteLine("Оригинальный стек:");
            //foreach (var obj in stack)
            //{
            //    Console.WriteLine(obj);
            //}

            //Console.WriteLine();

            //Console.WriteLine("Клонированный стек:");
            //foreach (var obj in clonedStack)
            //{
            //    Console.WriteLine(obj);
            //}

            //Console.WriteLine();

            //List<Transport> list = stack.ToList();
            //list.Sort();
            //list.Reverse();
            //stack.Clear();

            //foreach (var obj in list)
            //{
            //    stack.Push(obj);
            //}

            //Console.WriteLine("Отсортированный стек по годам выпуска:");
            //foreach (var obj in stack)
            //{
            //    Console.WriteLine(obj);
            //}

            //Console.WriteLine();

            //Transport searchCar = new PassengerCar(108, "Toyota", 2013, "Чёрный", 2500000, 220, 4, 250);
            //int index = FindObjectInStackTransport.FindInStack(stack, searchCar);

            //if (index != -1)
            //{
            //    Console.WriteLine($"Автомобиль {searchCar} найден в стеке на позиции {index + 1}.");
            //}
            //else
            //{
            //    Console.WriteLine($"Автомобиль {searchCar} не найден в стеке.");
            //}
            #endregion Конец 2 части

            #region 3 часть
            TestCollection testCollections = new TestCollection(10);
            testCollections.PrintFirstMiddleLast();
            testCollections.Print();

            Console.WriteLine();

            testCollections.FindTime();
            #endregion Конец 3 части
        }
    }
}