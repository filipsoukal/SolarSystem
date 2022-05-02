using System;
using System.Collections.Generic;
using System.Text;

namespace SolarSystem {
	class Star : SpaceObject{
		public Star(string name, double size, double velocity, double tempature ) : base(name,size,velocity,tempature) {
		}
	}
}
