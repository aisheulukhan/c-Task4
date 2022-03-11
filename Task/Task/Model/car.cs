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
        public car(string color, int driveWay)
        {
            this.color = color;
        }
        public car(int passengerCount, int driveWay, string color)
        {
            this.passengerCount = passengerCount;
        }
        public car(int driveTime, int passengerCount, int driveWay)
        {
            this.driveTime = driveTime;
        }
        public car(int getSpeed, int driveTime, int passengerCount, int driveWay)
        {
            this.getSpeed = getSpeed;
        }
        public car(string model, int getSpeed, int driveTime, int passengerCount)
        {
            this.model = model;
        }
    }
}
