using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Model
{
    class bicycle:Vehicle
    {
        public bicycle(int cycle)
        {
            this.cycle = cycle;
        }
        public bicycle(int cycle, int driveWay) : this(cycle)
        {
            this.driveWay = driveWay;
        }
        public bicycle(int cycle, int driveWay, string color) : this(cycle, driveWay)
        {
            this.color = color;
        }
        public bicycle(int cycle, int driveWay, string color, int passengerCount) : this(cycle, driveWay, color)
        {
            this.passengerCount = passengerCount;
        }
        public bicycle(int cycle, int driveWay, string color, int passengerCount, int driveTime) : this(cycle, driveWay, color, passengerCount)
        {
            this.driveTime = driveTime;
        }
        public bicycle(int cycle, int driveWay, string color, int passengerCount, int driveTime, int getSpeed) : this(cycle, driveWay, color, passengerCount, driveTime)
        {
            this.getSpeed = getSpeed;
        }
        public bicycle(int cycle, int driveWay, string color, int passengerCount, int driveTime, int getSpeed, string model) : this(cycle, driveWay, color, passengerCount, driveTime, getSpeed)
        {
            this.model = model;
        }
    }
}
