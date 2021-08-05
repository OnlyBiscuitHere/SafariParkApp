using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class Hunter : Person, IShootable
    {
        private string _camera;
        private IShootable _brand;
        public IShootable Shooter { get { return _brand; } set { _brand = value; }}

        public Hunter(string fName, string lName, string camera = "") : base(fName, lName)
        {
            this._camera = camera;
        }
        public Hunter(string fName, string lName, IShootable brand) : base(fName, lName)
        {
            this._brand =  brand;
        }
        
        public virtual string Shoot()
        {
            return $"{GetFullName()}: {Shooter.Shoot()}";
        }
        public override string ToString()
        {
            return $"{base.ToString()} Camera: {_camera}";
        }
    }
}