﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class Camera : IShootable
    {
        private string _brand;

        public Camera() { }

        public Camera(string brand)
        {
            _brand = brand;
        }

        public string Shoot()
        {
            return $"Shooting a {base.ToString()} - {_brand}";
        }

        public override string ToString()
        {
            return $"Shooting a {base.ToString()} - {_brand}";
        }
    }
}