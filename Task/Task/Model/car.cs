using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Model
{
    class car:Vehicle
    {
        public int motor;

        public car(int cycle)
        {
            this.cycle = cycle;
        }
        public car(int cycle, int driveWay) : this(cycle)
        {
            this.driveWay = driveWay;
        }
        public car(int cycle, int driveWay,string color):this (cycle,driveWay)
        {
            this.color = color;
        }
        public car(int cycle, int driveWay, string color, int passengerCount):this(cycle, driveWay, color)
        {
            this.passengerCount = passengerCount;
        }
        public car(int cycle, int driveWay, string color, int passengerCount, int driveTime):this(cycle, driveWay, color,passengerCount)
        {
            this.driveTime = driveTime;
        }
        public car(int cycle, int driveWay, string color, int passengerCount, int driveTime, int getSpeed):this(cycle, driveWay, color, passengerCount, driveTime)
        {
            this.getSpeed = getSpeed;
        }
        public car(int cycle, int driveWay, string color, int passengerCount, int driveTime, int getSpeed,string model):this(cycle, driveWay, color, passengerCount, driveTime,getSpeed)
        {
            this.model = model;
        }
    }
}
