﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryFinal
{
    public abstract class MotorVehicle : IShippingVehicle
    {
        protected string name;
        public string Name { get => name; }
        public uint TopSpeed { get; set; }
        public uint MaxDistancePerRefuel { get; set; }
        public uint MaxWeight { get; set; }
    }

    
}