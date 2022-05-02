using System;
using System.Collections.Generic;
using System.Text;

namespace SolarSystem {
	class Asteroid : SpaceObject{
		public Asteroid(string name, double size, double velocity, double tempature, Composition compositon) : base(name,size,velocity,tempature) {
			Ore = compositon;
		}
		public enum Composition {
			Lead,
			Iron,
			Platinum,
			Iridium
		}
		public Composition Ore { get; set; }
	}
}
