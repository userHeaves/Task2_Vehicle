using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2_Vehicle
{
    class Vehicle
    {
        private double Speed;
        private string Direction;
        private string _ownerName;
        private static int vehicleIDCounter = 0;
        private int _vehicleID;
        public const double maxSpeed = 200;
        public double currentSpeed
        {
            get { return Speed; }
            set { Speed = value; }
         
        }
        public string currentDirection
        {
            get { return Direction; }
        }
        public string ownerName
        {
            get { return _ownerName; }
        }
        public int vehicleID
        {
            get { return vehicleIDCounter; }
        }
        public Vehicle()
        {
            _vehicleID = ++vehicleIDCounter;
        }
    }
}
