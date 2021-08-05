using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class Vehicle : IMoveable
    {
        private int _capacity;
        private int _numPassengers;

        public int NumPassengers { get { return _numPassengers; } 
            set { if (_numPassengers < 0)
                { throw new ArgumentException(); }
                else if (value > _capacity) 
                { throw new ArgumentException(); }
                _numPassengers= value; } }

        public int Position { get; set; }

        public int Speed { get; init; }
        public Vehicle() 
        {
            Speed = 10;
        }

        public Vehicle(int capacity, int speed = 10)
        {
            _capacity = capacity;
            Speed = speed;
            if (capacity < 0)
            {
                throw new ArgumentException();
            }
        }

        public virtual string Move(int times)
        {
            Position = Speed * times;
            return $"Moving along {times} times";
        }

        public virtual string Move()
        {
            Position += Speed;
            return "Moving along";
        }
        public override string ToString()
        {
            return base.ToString() + $"capacity: {_capacity} passengers: {NumPassengers} speed: {Speed} position: {Position}";
        }
    }
}