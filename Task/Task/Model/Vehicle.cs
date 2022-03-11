using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Model
{
    class Vehicle
    {
        public int cycle;
        public int driveWay;
        public string color;
        public int passengerCount;
        public int driveTime;
        public int getSpeed;
        public string model;

        public void About()
        {
            Console.WriteLine($"{cycle} {driveWay} {color} {passengerCount} {driveTime} {getSpeed} {model}");


        }
        public void Getspeed()
        {
            int driveWay = 4000;
            int driveTime = 60;
            Console.WriteLine("getspeed:" + (driveWay / driveTime));
        }
    }
}
