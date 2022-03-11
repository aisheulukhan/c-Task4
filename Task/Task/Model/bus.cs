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
        public bus(int cycle, int driveWay) : this(cycle)
        {
            this.driveWay = driveWay;
        }
        public bus(int cycle, int driveWay, string color) : this(cycle, driveWay)
        {
            this.color = color;
        }
        public bus(int cycle, int driveWay, string color, int passengerCount) : this(cycle, driveWay, color)
        {
            this.passengerCount = passengerCount;
        }
        public bus(int cycle, int driveWay, string color, int passengerCount, int driveTime) : this(cycle, driveWay, color, passengerCount)
        {
            this.driveTime = driveTime;
        }
        public bus(int cycle, int driveWay, string color, int passengerCount, int driveTime, int getSpeed) : this(cycle, driveWay, color, passengerCount, driveTime)
        {
            this.getSpeed = getSpeed;
        }
        public bus(int cycle, int driveWay, string color, int passengerCount, int driveTime, int getSpeed, string model) : this(cycle, driveWay, color, passengerCount, driveTime, getSpeed)
        {
            this.model = model;
        }
    }
}
