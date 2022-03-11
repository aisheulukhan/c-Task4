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
        public bicycle(string color, int driveWay)
        {
            this.color = color;
        }
        public bicycle(int passengerCount, int driveWay, string color)
        {
            this.passengerCount = passengerCount;
        }
        public bicycle(int driveTime, int passengerCount, int driveWay)
        {
            this.driveTime = driveTime;
        }
        public bicycle(int getSpeed, int driveTime, int passengerCount, int driveWay)
        {
            this.getSpeed = getSpeed;
        }
        public bicycle(string model, int getSpeed, int driveTime, int passengerCount)
        {
            this.model = model;
        }
    }
}
