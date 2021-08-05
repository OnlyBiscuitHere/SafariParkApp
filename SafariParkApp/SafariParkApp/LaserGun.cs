using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class LaserGun : Weapon
    {
        private string _brand;
        public LaserGun(string brand) : base(brand)
        {
            _brand = brand;
        }

        public override string Shoot()
        {
            return $"Zing!! Shooting a {base.ToString()} - {_brand}";
        }
    }
}