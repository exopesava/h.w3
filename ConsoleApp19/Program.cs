﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Vehicle
    {
        public string brand;
        class MotorVehicle : Vehicle
        {
            public string modelName;
        }
        class Car : MotorVehicle
        {
        }
        class truck : MotorVehicle
        {
        }
        static void Main(string[] args)
        {
            Car MyCar = new Car();
            MyCar.brand = "BMW";
            MyCar.modelName = "C300";
            truck MyTruck = new truck();
            MyTruck.brand = "Mercedes";
            MyTruck.modelName = "V12";
            Console.WriteLine("My Car  is: " +
            MyCar.brand + " and " + MyCar.modelName);
            Console.WriteLine("My Truck  is : " +
            MyTruck.brand + " and " + MyTruck.modelName);
            Console.ReadKey();
        }
    }
}