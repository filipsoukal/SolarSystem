using System;
using System.Collections.Generic;
using System.Text;

namespace SolarSystem {
	public class Moon : SpaceObject  {
		public Moon(string name, double size, double velocity, double tempature,TypeOfObject objectType, MoonType moontype) : base(name,size,velocity,tempature, objectType) {
			TypeofMoon = moontype;
		}
		public enum MoonType {
			Small,
			Medium,
			Large
		}
		public MoonType TypeofMoon { get; set; }
	}
}
