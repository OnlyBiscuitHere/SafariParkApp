using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class Aeroplane : Vehicle
    {
        private string _airline;

        public Aeroplane(int capacity): base(capacity)
        {
            ToString();
        }

        public Aeroplane(int capacity, int speed, string airline) : base(capacity, speed)
        {
            _airline = airline;
            ToString();
        }

        public int Altitude { get; private set; }

        public void Ascend(int distance)
        {
            Altitude += distance;
        }

        public void Descend(int distance)
        {
            Altitude -= distance;
        }

        public override string Move()
        {
            Position += Speed;
            return $"Moving along at an altitude {Altitude} meters";
        }

        public override string Move(int times)
        {
            Position += Speed * times;
            return $"Moving along {times} times at an altitude of {Altitude} meters";
        }

        public override string ToString()
        {
            return $"Thank you for flying {_airline}: {base.ToString()} Altitude {Altitude}"; 
        }
    }
}