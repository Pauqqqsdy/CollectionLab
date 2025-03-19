using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ClassLibrary
{
    public class LinqRequests
    {
        /// <summary>
        /// Функция для нахождения внедорожника с максимальной стоимостью
        /// </summary>
        /// <param name="transports">массив, в котором находится все введённые виды транспорта</param>
        public static double FindMaxCostOfOffroadCars(ArrayList transports)
        {
            return transports
                .OfType<OffroadCar>()
                .Max(t => t.Cost);
        }

        /// <summary>
        /// Функция для нахождения средней скорости всех легковых автомобилей
        /// </summary>
        /// <param name="transports">массив, в котором находится все введённые виды транспорта</param>
        public static double FindAvgSpeedOfPassengerCars(ArrayList transports)
        {
            IEnumerable<PassengerCar> passengerCars = transports.OfType<PassengerCar>();
            return passengerCars.Any() ? passengerCars.Average(t => t.MaxSpeed) : 0;
        }

        /// <summary>
        /// Функция для нахождения количества грузовых автомобилей, грузоподъёмность которых больше, чем заданная
        /// </summary>
        /// <param name="transports">массив, в котором находится все введённые виды транспорта</param>
        /// <param name="capacity">заданная грузоподъёмность, с которой нужно сравнить грузоподъёмность каждого грузовика</param>
        public static double FindCountOfTrucksWithExceedingCapacity(ArrayList transports, double capacity)
        {
            return transports.OfType<Truck>().Count(t => t.LoadCapacity > capacity);
        }

        public static double FindMaxCostOfOffroadCarsInStack(Stack<Transport> transports)
        {
            return transports
                .OfType<OffroadCar>()
                .Max(t => t.Cost);
        }

        public static double FindAvgSpeedOfPassengerCarsInStack(Stack<Transport> transports)
        {
            IEnumerable<PassengerCar> passengerCars = transports.OfType<PassengerCar>();
            return passengerCars.Any() ? passengerCars.Average(t => t.MaxSpeed) : 0;
        }

        public static double FindCountOfTrucksWithExceedingCapacityInStack(Stack<Transport> transports, double capacity)
        {
            return transports.OfType<Truck>().Count(t => t.LoadCapacity > capacity);
        }
    }
}