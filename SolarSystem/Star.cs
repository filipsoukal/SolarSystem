using System;
using System.Collections.Generic;
using System.Text;

namespace SolarSystem {
	class Star : SpaceObject{
		public Star(string name, double size, double velocity, double tempature, StarType starType) : base(name,size,velocity,tempature) {
			TypeofStar = starType;
		}
		public enum StarType {
			Blue,
			RedDwarf,
			RedGiant,
			Neutron
		}
		public StarType TypeofStar { get; set; }
	}
}
