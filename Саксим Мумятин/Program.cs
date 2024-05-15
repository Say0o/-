using System;

namespace Саксим_Мумятин
{
    // Абстрактный класс Транспортное средство
    public abstract class Vehicle
    {
        // Координаты транспортного средства
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        // Параметры средства передвижения
        public decimal Price { get; set; }
        public double Speed { get; set; }
        public int Year { get; set; }

        // Конструктор для инициализации параметров
        public Vehicle(double latitude, double longitude, decimal price, double speed, int year)
        {
            Latitude = latitude;
            Longitude = longitude;
            Price = price;
            Speed = speed;
            Year = year;
        }

        // Абстрактный метод для задания динамических характеристик
        public abstract void SetDynamicCharacteristic();
    }

    // Класс Самолет
    public class Plane : Vehicle
    {
        // Высота полета самолета
        public double Altitude { get; set; }

        // Количество пассажиров
        public int Passengers { get; set; }

        // Конструктор для инициализации параметров
        public Plane(double latitude, double longitude, decimal price, double speed, int year, double altitude)
            : base(latitude, longitude, price, speed, year)
        {
            Altitude = altitude;
        }

        // Реализация метода для задания динамических характеристик самолета
        public override void SetDynamicCharacteristic()
        {
            Console.WriteLine("Введите количество пассажиров: ");
            Passengers = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите высоту полета: ");
            Altitude = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Координаты: {Latitude}, {Longitude}");
            Console.WriteLine($"Цена: {Price}");
            Console.WriteLine($"Скорость: {Speed}");
            Console.WriteLine($"Год: {Year}");
            Console.WriteLine($"Количество пассажиров: {Passengers}");
            Console.WriteLine($"Высота полета: {Altitude}");
        }
    }

    // Класс Автомобиль
    public class Car : Vehicle
    {
        // Количество пассажиров
        public int Passengers { get; set; }

        // Конструктор для инициализации параметров
        public Car(double latitude, double longitude, decimal price, double speed, int year)
            : base(latitude, longitude, price, speed, year)
        {
        }

        // Реализация метода для задания динамических характеристик автомобиля
        public override void SetDynamicCharacteristic()
        {
            Console.WriteLine("Введите количество пассажиров в автомобиле: ");
            Passengers = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Координаты: {Latitude}, {Longitude}");
            Console.WriteLine($"Цена: {Price}");
            Console.WriteLine($"Скорость: {Speed}");
            Console.WriteLine($"Год: {Year}");
            Console.WriteLine($"Количество пассажиров: {Passengers}");
        }
    }

    // Класс Корабль
    public class Ship : Vehicle
    {
        // Количество пассажиров
        public int Passengers { get; set; }

        // Порт приписки
        public string HomePort { get; set; }

        // Конструктор для инициализации параметров
        public Ship(double latitude, double longitude, decimal price, double speed, int year, string homePort)
            : base(latitude, longitude, price, speed, year)
        {
            HomePort = homePort;
        }

        // Реализация метода для задания динамических характеристик корабля
        public override void SetDynamicCharacteristic()
        {
            Console.WriteLine("Введите количество пассажиров на корабле: ");
            Passengers = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите порт приписки корабля: ");
            HomePort = Console.ReadLine();

            Console.WriteLine($"Координаты: {Latitude}, {Longitude}");
            Console.WriteLine($"Цена: {Price}");
            Console.WriteLine($"Скорость: {Speed}");
            Console.WriteLine($"Год: {Year}");
            Console.WriteLine($"Количество пассажиров: {Passengers}");
            Console.WriteLine($"Порт приписки: {HomePort}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта самолета и вывод информации о нем
            Console.WriteLine("Введите данные для самолета:");
            Plane plane = new Plane(0, 0, 1000000, 900, 2024, 0);
            plane.SetDynamicCharacteristic();

            // Создание объекта автомобиля и вывод информации о нем
            Console.WriteLine("\nВведите данные для автомобиля:");
            Car car = new Car(0, 0, 50000, 120, 2022);
            car.SetDynamicCharacteristic();

            // Создание объекта корабля и вывод информации о нем
            Console.WriteLine("\nВведите данные для корабля:");
            Ship ship = new Ship(0, 0, 5000000, 50, 2020, "");
            ship.SetDynamicCharacteristic();
        }
    }
}