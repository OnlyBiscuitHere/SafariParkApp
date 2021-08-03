using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class Vehicle
    {
        private int _capacity;
        private int _numPassengers;

        public int NumPassengers { get { return _numPassengers; } set { if (_numPassengers > _capacity) { throw new ArgumentException(); }_numPassengers= value; } }

        public int Position { get; private set; }

        public int Speed { get; init; }
        public Vehicle() 
        {
            
            Speed = 10;
        }

        public Vehicle(int capacity, int speed = 10)
        {
            if(capacity < 0)
            {
                throw new ArgumentException();
            }
            _capacity = capacity;
            Speed = speed;
        }

        public string Move(int times)
        {
            Position = Speed * times;
            return $"Moving along {times} times";
        }

        public string Move()
        {
            Position = Speed;
            return "Moving along";
        }
    }
}