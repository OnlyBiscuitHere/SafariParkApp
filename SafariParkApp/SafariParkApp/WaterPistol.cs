using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class WaterPistol : Weapon
    {
        private string _brand;
        public WaterPistol(string brand) : base(brand)
        {
            _brand = brand;
        }
        
        public override string Shoot()
        {
            return $"Splash!! Shooting a {base.ToString()} - {_brand}";
        }
    }
}