using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Model
{
    class bus:Vehicle
    {
        public int motor;
        public bus(int cycle)
        {
            this.cycle = cycle;
        }
        public bus(int cycle, int driveWay)
        {
            this.driveWay = driveWay;
        }
        public bus(string color, int driveWay)
        {
            this.color = color;
        }
        public bus(int passengerCount, int driveWay, string color)
        {
            this.passengerCount = passengerCount;
        }
        public bus(int driveTime, int passengerCount, int driveWay)
        {
            this.driveTime = driveTime;
        }
        public bus(int getSpeed, int driveTime, int passengerCount, int driveWay)
        {
            this.getSpeed = getSpeed;
        }
        public bus(string model, int getSpeed, int driveTime, int passengerCount)
        {
            this.model = model;
        }
    }
}
